using System;
using System.Diagnostics;
using static Halo3VisualRandomizer.RandomizedItems.RandomizedItems;
using Bungie;
using Bungie.Tags;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Halo3VisualRandomizer
{
    public partial class Randomizer
    {
        private partial class LevelRandomizer
        {

            private class SquadRandomizer
            {
                TagElement Squad;
                Random Rand;
                RandomizerSettings Settings;

                RandomizedObjectDetails old_vehicle;
                bool HasVehicle = false;
                bool MakeHunter = false;
                TagFieldEnum TeamField;

                SquadSpecialCase specialCase;

                public SquadRandomizer(TagElement squad, Random rand, RandomizerSettings settings)
                {
                    Squad = squad;
                    Rand = rand;
                    Settings = settings;
                    TeamField = (TagFieldEnum)GetField(Squad, "team");

                    specialCase = SquadSpecialCases.Where(x => x.SquadNames.Contains(Squad.ElementHeaderText)).FirstOrDefault();
                    if (specialCase != null)
                    {
                        Debug.WriteLine("special case identified, Skip: " + specialCase.Skip + " Character: " + specialCase.RandomizeCharacters + " Vehicle: " + specialCase.RandomizeVehicles);
                    }

                    if (rand.NextDouble() < settings.MakeHunterChance)
                    {
                        MakeHunter = true;
                    }
                }

                public void Randomize()
                {

                    if (specialCase != null && specialCase.Skip)
                    {
                        Debug.WriteLine("Skipping squad: " + Squad.ElementHeaderText);
                        return;
                    }
                    Debug.WriteLine("randomizing " + Squad.ElementHeaderText);
                    var team_element = GetField(Squad, "team");
                    var fireteams_block = GetField(Squad, "fire-teams");
                    foreach (TagFieldBlockElement fireteam in ((TagFieldBlock)fireteams_block).Elements)
                    {
                        var normal_diff_count_field = GetField(fireteam, "normal diff count");
                        ((TagFieldElementInteger)normal_diff_count_field).Data = (int)(((TagFieldElementInteger)normal_diff_count_field).Data * Settings.SquadSizeMultiplier);
                        RandomizeTypes(fireteam);
                        var starting_locations_block = GetField(fireteam, "starting locations");
                        foreach (TagFieldBlockElement starting_location in ((TagFieldBlock)starting_locations_block).Elements)
                        {
                            RandomizeTypes(starting_location);
                        }
                    }
                }

                // Randomizes the types for a fireteam or starting location
                private void RandomizeTypes(TagFieldBlockElement element)
                {
                    var character_field = GetField(element, "character type");
                    var weapon_field = GetField(element, "initial weapon");
                    var vehicle_field = GetField(element, "vehicle type");
                    TagField vehicle_variant_field;
                    TagField normal_diff_count;
                    // these have different names in fireteams and starting locations
                    if (FieldExists(element, "vehicle variant"))
                    {
                        vehicle_variant_field = GetField(element, "vehicle variant");
                    }
                    else
                    {
                        vehicle_variant_field = GetField(element, "vehicle variant name");
                    }
                    if (FieldExists(element, "normal diff count"))
                    {
                        normal_diff_count = GetField(element, "normal diff count");
                    }
                    else
                    {
                        normal_diff_count = null;
                    }
                    var old_character = characters.List.Where(x => x.PaletteIndex == ((TagFieldBlockIndex)character_field).Value && ((TagFieldBlockIndex)character_field).Value != -1).FirstOrDefault();
                    if (old_character != null && (specialCase == null || specialCase.RandomizeCharacters))
                    {
                        var old_character_faction = old_character.Faction;
                        ((TagFieldEnum)TeamField).Value = (int)old_character_faction;
                        var new_character_factions = Settings.FactionCompatabilities.Where(x => x.Faction == old_character_faction).FirstOrDefault().CompatibleFactions;
                        if (new_character_factions.Contains(Faction.Covenant) && MakeHunter)
                        {
                            var new_character = characters.GetRandomObjectWeighted(Rand, require_palette_index: true, name_starts_with: new List<string> { "hunter" });
                            if (new_character != null)
                            {
                                ((TagFieldBlockIndex)character_field).Value = new_character.PaletteIndex;
                                ((TagFieldBlockIndex)weapon_field).Value = -1;
                            }

                        }
                        else
                        {
                            RandomizedObjectDetails new_character;
                            if (specialCase != null && specialCase.AllowedCharacters.Any())
                            {
                                new_character = characters.GetRandomObjectWeighted(Rand, require_palette_index: true, factions: new_character_factions, name_starts_with: specialCase.AllowedCharacters);
                                if (new_character is null)
                                {
                                    new_character = characters.GetRandomObjectWeighted(Rand, require_palette_index: true, name_starts_with: specialCase.AllowedCharacters);
                                }
                            }
                            else
                            {
                                new_character = characters.GetRandomObjectWeighted(Rand, require_palette_index: true, factions: new_character_factions);
                            }
                            ((TagFieldBlockIndex)character_field).Value = new_character.PaletteIndex;
                        }
                    }
                    if (((TagFieldBlockIndex)weapon_field).Value != -1)
                    {
                        ((TagFieldBlockIndex)weapon_field).Value = weapons.GetRandomObjectWeighted(Rand, require_palette_index: true).PaletteIndex;
                    }
                    if (((TagFieldBlockIndex)vehicle_field).Value != -1 && (specialCase == null || specialCase.RandomizeVehicles))
                    {
                        HasVehicle = true;
                        var old_vehicle = vehicles.List.Where(x => x.PaletteIndex == ((TagFieldBlockIndex)vehicle_field).Value && ((TagFieldBlockIndex)vehicle_field).Value != -1).FirstOrDefault();
                        if (old_vehicle != null)
                        {
                            RandomizedObjectDetails new_vehicle;
                            new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true);
                            if (specialCase != null && specialCase.AllowedVehicles.Any())
                            {
                                new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true, name_starts_with: specialCase.AllowedVehicles);
                            }
                            else if (old_vehicle.SubCategory == SubCategory.Air)
                            {
                                new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true, subcategories: new List<SubCategory>() { SubCategory.Air });
                            }
                            if (new_vehicle != null)
                            {
                                ((TagFieldBlockIndex)vehicle_field).Value = new_vehicle.PaletteIndex;
                                if (normal_diff_count != null && old_character != null)
                                {
                                    //((TagFieldElementInteger)normal_diff_count).Data = (int)(new_vehicle.Seats * Settings.SquadSizeMultiplier);
                                }
                                var new_variant = new_vehicle.Variants.GetRandomObjectWeighted(Rand);
                                if (specialCase != null && specialCase.AllowedVehicleVariants.Any())
                                {
                                    new_variant = new_vehicle.Variants.GetRandomObjectWeighted(Rand, name_starts_with: specialCase.AllowedVehicleVariants);
                                }
                                if (new_variant != null)
                                {
                                    ((TagFieldElementStringID)vehicle_variant_field).Data = new_variant.Name;
                                }
                                else
                                {
                                    ((TagFieldElementStringID)vehicle_variant_field).Data = "";
                                }

                                if (FieldExists(element, "seat type"))
                                {
                                    var seat_field = GetField(element, "seat type");
                                    //((TagFieldEnum)seat_field).Value = 0;
                                }
                            }
                        }
                    }
                    else if (Rand.NextDouble() < Settings.GiveVehicleChance && (specialCase == null || specialCase.RandomizeVehicles) && old_character != null && old_vehicle == null)
                    {
                        var new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true);
                        ((TagFieldBlockIndex)vehicle_field).Value = new_vehicle.PaletteIndex;
                        if (normal_diff_count != null && old_character != null)
                        {
                            ((TagFieldElementInteger)normal_diff_count).Data = (int)(new_vehicle.Seats * Settings.SquadSizeMultiplier);
                            if (FieldExists(element, "seat type"))
                            {
                                var seat_field = GetField(element, "seat type");
                                ((TagFieldEnum)seat_field).Value = 0;
                            }
                        }
                        if (normal_diff_count != null && old_character != null)
                        {
                            ((TagFieldElementInteger)normal_diff_count).Data = (int)(new_vehicle.Seats * Settings.SquadSizeMultiplier);
                        }
                        var new_variant = new_vehicle.Variants.GetRandomObjectWeighted(Rand);
                        if (new_variant != null)
                        {
                            HasVehicle = true;
                            ((TagFieldBlockIndex)vehicle_field).Value = new_vehicle.PaletteIndex;
                            ((TagFieldElementStringID)vehicle_variant_field).Data = new_variant.Name;
                        }
                        else
                        {
                            ((TagFieldElementStringID)vehicle_variant_field).Data = "";
                        }
                    }
                }




                private void ClearSpawnPointsOverrides()
                {
                    var spawn_point_block = GetField(Squad, "spawn points");
                    foreach (TagFieldBlockElement spawn_point in ((TagFieldBlock)spawn_point_block).Elements)
                    {
                        var character_field = GetField(spawn_point, "character type");
                        ((TagFieldBlockIndex)character_field).Value = -1;
                        var weapon_field = GetField(spawn_point, "initial weapon");
                        ((TagFieldBlockIndex)weapon_field).Value = -1;
                        if (specialCase != null && specialCase.RandomizeVehicles)
                        {
                            var vehicle_field = GetField(spawn_point, "vehicle type");
                            if (vehicles.List.Any(x => x.PaletteIndex == ((TagFieldBlockIndex)vehicle_field).Value && ((TagFieldBlockIndex)vehicle_field).Value != -1))
                            {
                                old_vehicle = vehicles.List.Where(x => x.PaletteIndex == ((TagFieldBlockIndex)vehicle_field).Value).FirstOrDefault();
                                ((TagFieldBlockIndex)vehicle_field).Value = -1;
                            }
                            var seat_field = GetField(spawn_point, "seat type");
                            ((TagFieldEnum)seat_field).Value = 0;
                        }
                    }
                }
            }
        }
    }

}
