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
            Level Level;
            string LevelPath;
            string LevelFolderPath;
            TagFile TagFile;
            Random Rand;

            RandomizerSettings Settings;

            public LevelRandomizer(Level level, RandomizerSettings settings)
            {
                Level = level;
                Settings = settings;
                int seed = settings.Seed;
                foreach (char c in level.Name)
                    seed += c % 500;
                Rand = new Random(seed);
                LevelPath = @"levels\solo\" + level.Name + @"\" + level.Name;
                LevelFolderPath = @"levels\solo\" + level.Name;
                var test_path = Bungie.Tags.TagPath.FromPathAndType(LevelPath, "scnr*");
                TagFile = new Bungie.Tags.TagFile(test_path);
            }

            public void Randomize()
            {
                if (!Level.CutsceneOnly)
                {
                    AddToPalettes();
                    ClearDesignerZones();
                    if (Settings.RandomizeStartingProfiles)
                    {
                        RandomizeProfiles();
                    }
                    RandomizeVariousWorldObjects();
                    if (Settings.RandomizeSquads)
                    {
                        //RemoveAiResources();
                        RandomizeSquads();
                        if (Level.HasAiResources)
                        {
                            AddToAiResourcePalettes();
                            RandomizeAiResourcesSquads();

                        }
                    }

                }

                Debug.WriteLine("saving scenario");
                TagFile.Save();
                // bad code. ideally disposing the tag file should happen elsewhere
                TagFile.Dispose();
            }

            public void BuildCacheFile()
            {
                Debug.WriteLine("Building cache file: " + LevelPath);

                string tool_path = Settings.EkPath + @"\tool.exe";
                try
                {
                    ProcessStartInfo process = new ProcessStartInfo();
                    process.WindowStyle = ProcessWindowStyle.Hidden;
                    process.FileName = tool_path;
                    process.Arguments = string.Format("build-cache-file " + LevelPath);
                    process.WorkingDirectory = Settings.EkPath;
                    Process x = Process.Start(process);
                    x.WaitForExit();
                }
                catch (System.Exception e)
                {
                    throw new Exception("Building cache file failed\n" + e);
                }

            }

            public void CopyFileToMCC()
            {
                string fileToCopy = Settings.EkPath + @"\maps\" + Level.Name + @".map";
                string destinationDirectory = Settings.MCCPath + @"\halo3\maps\";
                var start_time = DateTime.Now;
                while (!File.Exists(fileToCopy))
                {
                    System.Threading.Thread.Sleep(1000);
                    if (DateTime.Now - start_time > TimeSpan.FromMinutes(5))
                    {
                        throw new Exception("File not found: " + fileToCopy);
                    }
                }
                File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy), true);
            }

            public void MoveFileToMCC()
            {
                string fileToMove = Settings.EkPath + @"\maps\" + Level.Name + @".map";
                string destinationDirectory = Settings.MCCPath + @"\halo3\maps\";
                var start_time = DateTime.Now;
                while (!File.Exists(fileToMove))
                {
                    System.Threading.Thread.Sleep(1000);
                    if (DateTime.Now - start_time > TimeSpan.FromMinutes(5))
                    {
                        throw new Exception("File not found: " + fileToMove);
                    }
                }
                File.Move(fileToMove, destinationDirectory + Path.GetFileName(fileToMove));
            }

            public void DeleteFromEk()
            {
                string fileToDelete = Settings.EkPath + @"\maps\" + Level.Name + @".map";
                File.Delete(fileToDelete);
            }

            private static void AddObjectsToPalette(TagField palette, RandomizedObjectList randomized_object_list)
            {
                TagFieldBlock palette_block = (TagFieldBlock)palette;
                foreach (var object_type in randomized_object_list.List)
                {
                    if (object_type.Weight != 0)
                    {
                        bool found = false;
                        foreach (var element in palette_block.Elements)
                        {
                            if (element.ElementHeaderText.ToLower().Contains(object_type.Name.ToLower()))
                            {
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            int count = palette_block.Elements.Count;
                            palette_block.AddElement();

                            var tag = ((TagFieldBlockElement)palette_block.Elements[count]);
                            var tgb = (TagFieldReference)tag.Fields[0];

                            tgb.Path = TagPath.FromPathAndType(object_type.Path, randomized_object_list.Type);
                            //tgb.Path = TagPath.FromPathAndExtension(object_type.Path, randomized_object_list.Type);


                        }
                    }
                }
                foreach (var element in palette_block.Elements)
                {
                    foreach (var object_type in randomized_object_list.List)
                    {
                        if (element.ElementHeaderText.ToLower() == object_type.Name.ToLower())
                        {
                            object_type.PaletteIndex = element.ElementIndex;
                            //break;
                            continue;
                        }
                    }
                }
                foreach (var object_type in randomized_object_list.List)
                {
                    if (object_type.PaletteIndex == -1 && object_type.Weight != 0)
                    {
                        Debug.WriteLine(object_type.Name + " was not successfully added to the palette");
                    }
                }
            }

            private static void AddObjectsToTag(TagFile tag_file, RandomizedObjectList randomized_object_list, bool ai_resources = false)
            {
                string palette_name = randomized_object_list.PaletteName;
                if (ai_resources)
                {
                    palette_name = randomized_object_list.PaletteNameAiResources;
                }
                var new_palette = tag_file.Fields.Where(x => x.DisplayName.Contains(palette_name)).FirstOrDefault();
                if (new_palette != null)
                {
                    {
                        AddObjectsToPalette(new_palette, randomized_object_list);
                    }
                }
            }

            private void AddToResourcePalette(RandomizedObjectList randomized_object_list)
            {
                Debug.WriteLine("adding to resource palette: " + randomized_object_list.Name);
                //TagPath tag_path = TagPath.FromPathAndType(LevelResourcesPath, randomized_object_list.ResourceFileType);
                var resources_path = LevelFolderPath + @"\resources\" + Level.Name;
                TagPath tag_path = TagPath.FromPathAndExtension(resources_path, randomized_object_list.ResourceFileExtension);
                //Debug.WriteLine(tag_path.Type);
                using (TagFile resource_file = new TagFile(tag_path))
                {
                    //Debug.WriteLine(resource_file.Path);
                    AddObjectsToTag(resource_file, randomized_object_list);
                    resource_file.Save();
                }
            }

            private void AddToAiResourcePalette(RandomizedObjectList randomized_object_list)
            {
                Debug.WriteLine("adding to ai resource palette: " + randomized_object_list.Name);
                var resources_path = LevelFolderPath + @"\ai_resources\" + Level.Name + @"_master";
                TagPath tag_path = TagPath.FromPathAndExtension(resources_path, "scenario_ai_resource");
                using (TagFile resource_file = new TagFile(tag_path))
                {
                    AddObjectsToTag(resource_file, randomized_object_list, true);
                    resource_file.Save();
                }
            }

            private void AddToScenarioPalette(RandomizedObjectList randomized_object_list)
            {
                Debug.WriteLine("adding to scenario palette: " + randomized_object_list.Name);
                AddObjectsToTag(TagFile, randomized_object_list);
            }

            private void AddToPalettes()
            {
                Debug.WriteLine("Adding to Palettes");
                vehicles.ResetIndexes();
                weapons.ResetIndexes();
                equipments.ResetIndexes();
                scenerys.ResetIndexes();
                crates.ResetIndexes();
                //machines.ResetIndexes();
                characters.ResetIndexes();
                AddToResourcePalette(vehicles);
                AddToResourcePalette(weapons);
                AddToResourcePalette(equipments);
                AddToResourcePalette(scenerys);
                AddToResourcePalette(crates);
                AddToScenarioPalette(characters);
                //AddToResourcePalette(machines);
                AddToScenarioPalette(vehicles);
                AddToScenarioPalette(characters);
                AddToScenarioPalette(weapons);
                //AddToScenarioPalette(equipments);
            }

            private void AddToAiResourcePalettes()
            {
                Debug.WriteLine("Adding to ai resource palette");
                vehicles.ResetIndexes();
                weapons.ResetIndexes();
                //equipments.ResetIndexes();
                characters.ResetIndexes();
                AddToAiResourcePalette(vehicles);
                AddToAiResourcePalette(weapons);
                //AddToAiResourcePalette(equipments);
                AddToAiResourcePalette(characters);
            }

            private void RandomizeWorldObjects(RandomizedObjectList randomized_object_list)
            {
                Debug.WriteLine("randomizing world objects: " + randomized_object_list.Name);
                var resources_path = LevelFolderPath + @"\" + randomized_object_list.ResourcesFolder + @"\" + Level.Name;
                var tag_path = TagPath.FromPathAndExtension(resources_path, randomized_object_list.ResourceFileExtension);
                using (var resource_file = new TagFile(tag_path))
                {
                    var tag_field_block = GetField(resource_file, randomized_object_list.Name);
                    foreach (var element in ((TagFieldBlock)tag_field_block).Elements)
                    {
                        var name_field = ((TagElement)element).Fields.Where(x => x.DisplayName == "name").FirstOrDefault();
                        if (name_field != null)
                        {
                            //TagFieldBlock names_block = ((TagFieldBlockIndex)name_field).GetReferencedBlock();
                            TagFieldBlock names_block = (TagFieldBlock)GetField(resource_file, "names");

                            var index = ((TagFieldBlockIndex)name_field).Value;
                            if (index >= 0)
                            {
                                var name_element = ((TagFieldBlock)names_block).Elements[((TagFieldBlockIndex)name_field).Value];
                                var name_string_field = name_element.Fields.Where(x => x.DisplayName == "name").FirstOrDefault();
                                if (name_string_field != null)
                                {
                                    var name = ((TagFieldElementString)name_string_field).Data;
                                    if (skipSpecialObjects.Contains(name.ToLower()))
                                    {
                                        Debug.WriteLine("Skipping randomizing object: " + name);
                                        continue;
                                    }
                                }
                            }

                        }
                        var type_field = ((TagElement)element).Fields.Where(x => x.DisplayName == "type").FirstOrDefault();
                        if (type_field != null)
                        {
                            int index = ((TagFieldBlockIndex)type_field).Value;
                            var object_type = randomized_object_list.List.Where(x => x.PaletteIndex == index).FirstOrDefault();
                            //if (randomized_object_list.List.Any(x => x.PaletteIndex == index))
                            if (object_type != null && (object_type.SubCategory != SubCategory.WeaponStash || Settings.RandomizeWeaponStashTypes))
                            {
                                var randomized_object = randomized_object_list.GetRandomObjectWeighted(Rand, require_palette_index: true);
                                if (randomized_object != null && randomized_object.PaletteIndex != -1)
                                {
                                    ((TagFieldBlockIndex)type_field).Value = randomized_object.PaletteIndex;
                                    TagFieldStruct weapon_data = (TagFieldStruct)((TagElement)element).Fields.Where(x => x.DisplayName == "weapon data").FirstOrDefault();
                                    if (weapon_data != null)
                                    {
                                        var roundsLeft = ((TagElement)weapon_data.Elements.First()).Fields.Where(x => x.DisplayName == "rounds left").FirstOrDefault();
                                        if (roundsLeft != null)
                                        {
                                            ((TagFieldElementInteger)roundsLeft).Data = 0;
                                        }
                                        var roundsLoaded = ((TagElement)weapon_data.Elements.First()).Fields.Where(x => x.DisplayName == "rounds loaded").FirstOrDefault();
                                        if (roundsLoaded != null)
                                        {
                                            ((TagFieldElementInteger)roundsLoaded).Data = 0;
                                        }
                                    }
                                    TagFieldStruct object_data = (TagFieldStruct)((TagElement)element).Fields.Where(x => x.DisplayName == "object data").FirstOrDefault();
                                    if (object_data != null && randomized_object.SubCategory == SubCategory.Obstacle)
                                    {
                                        var rotation = ((TagElement)object_data.Elements.First()).Fields.Where(x => x.DisplayName == "rotation").FirstOrDefault();
                                        if (rotation != null)
                                        {
                                            float[] floatArray = { 0.0f, 0.0f, 0.0f };
                                            ((TagFieldElementArraySingle)rotation).Data = floatArray;


                                        }
                                    }
                                }
                            }
                            index = ((TagFieldBlockIndex)type_field).Value;
                            object_type = randomized_object_list.List.Where(x => x.PaletteIndex == index).FirstOrDefault();
                            if (object_type != null)
                            {

                                TagFieldStruct permutationData;
                                permutationData = (TagFieldStruct)((TagElement)element).Fields.Where(x => x.DisplayName == "permutation data").FirstOrDefault();
                                if (permutationData != null)
                                {
                                    var variant_name_field = ((TagElement)permutationData.Elements.First()).Fields.Where(x => x.DisplayName == "variant name").FirstOrDefault();
                                    if (variant_name_field != null)
                                    {
                                        var variant = object_type.Variants.GetRandomObjectWeighted(Rand);
                                        if (variant != null)
                                        {
                                            ((TagFieldElementStringID)variant_name_field).Data = variant.Name;
                                        }
                                        else
                                        {
                                            ((TagFieldElementStringID)variant_name_field).Data = "";
                                        }
                                    }
                                }
                            }
                        }

                    }
                    resource_file.Save();
                }
            }

            private void RandomizeVariousWorldObjects()
            {
                if (Settings.RandomizeVehicles)
                {
                    RandomizeWorldObjects(vehicles);
                }
                if (Settings.RandomizeWeapons)
                {
                    RandomizeWorldObjects(weapons);
                }
                if (Settings.RandomizeEquipments)
                {
                    RandomizeWorldObjects(equipments);
                }
                if (Settings.RandomizeEnvironmentalObjects)
                {
                    RandomizeWorldObjects(scenerys);
                    RandomizeWorldObjects(crates);
                    //RandomizeWorldObjects(machines);
                }

            }

            private void ClearDesignerZones()
            {
                TagField designer_zones = GetField(TagFile, "designer zones");
                if (designer_zones != null)
                {
                    foreach (TagElement designer_zone in ((TagFieldBlock)designer_zones).Elements)
                    {
                        foreach (string block_type in new List<string> { "character", "vehicle", "equipment", "weapon", "scenery", "crate" })
                        {
                            var tag_field_block = designer_zone.Fields.Where(x => x.FieldPathWithoutIndexes.Contains("Block:" + block_type)).FirstOrDefault();
                            //var tag_field_block = GetField(designer_zone, block_type);
                            if (tag_field_block != null)
                            {
                                ((TagFieldBlock)tag_field_block).RemoveAllElements();
                            }
                            else
                            {
                                throw new Exception("tag field block not found" + block_type);
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception("designer zones not found");
                }
            }

            private void RandomizeProfiles()
            {
                var profiles_field = GetField(TagFile, "player starting profile");
                foreach (var profile in ((TagFieldBlock)profiles_field).Elements)
                {
                    var primary_type = weapons.GetRandomObjectWeighted(Rand, require_palette_index: true);
                    var secondary_type = weapons.GetRandomObjectWeighted(Rand, require_palette_index: true);
                    var equipment_type = equipments.GetRandomObjectWeighted(Rand, require_palette_index: true, subcategories: new List<SubCategory> { SubCategory.ArmorAbility });
                    foreach (var field in profile.Fields)
                    {
                        if (field.FieldName == "primary weapon" && primary_type != null)
                        {
                            ((TagFieldReference)field).Path = TagPath.FromPathAndType(primary_type.Path, "weap");
                        }
                        else if (field.FieldName == "secondary weapon" && secondary_type != null)
                        {
                            ((TagFieldReference)field).Path = TagPath.FromPathAndType(secondary_type.Path, "weap");
                        }
                        else if (field.FieldName == "starting equipment" && equipment_type != null)
                        {
                            ((TagFieldReference)field).Path = TagPath.FromPathAndType(equipment_type.Path, "eqip");
                        }
                        else if (field.FieldName == "primaryrounds loaded" && primary_type != null)
                        {
                            ((TagFieldElementInteger)field).Data = primary_type.AmmoMag;
                        }
                        else if (field.FieldName == "secondaryrounds loaded" && secondary_type != null)
                        {
                            ((TagFieldElementInteger)field).Data = secondary_type.AmmoMag;
                        }
                        else if (field.FieldName == "primaryrounds total" && primary_type != null)
                        {
                            ((TagFieldElementInteger)field).Data = primary_type.AmmoTotal;
                        }
                        else if (field.FieldName == "secondaryrounds total" && secondary_type != null)
                        {
                            ((TagFieldElementInteger)field).Data = secondary_type.AmmoTotal;
                        }
                        var grenadeValues = new List<string> { "starting fragmentation grenade count", "starting plasma grenade count", "starting claymore grenade count", "starting firebomb grenade count" };
                        if (grenadeValues.Contains(field.FieldName, StringComparer.OrdinalIgnoreCase))
                        {
                            ((TagFieldElementInteger)field).Data = Rand.Next(0, 3);
                        }
                    }
                }
            }

            private void RemoveAiResources()
            {
                var resources_block = GetField(TagFile, "scenario resources");
                foreach (TagElement resources in ((TagFieldBlock)resources_block).Elements)
                {
                    var ai_resources_block = GetField(resources, "ai resources");
                    ((TagFieldBlock)ai_resources_block).RemoveAllElements();
                }
            }

            private void RandomizeSquads()
            {
                TagField squads = GetField(TagFile, "squads");
                if (squads != null)
                {
                    foreach (TagElement squad in ((TagFieldBlock)squads).Elements)
                    {
                        SquadRandomizer squad_randomizer = new SquadRandomizer(squad, Rand, Settings);
                        squad_randomizer.Randomize();
                    }
                }
            }

            private void RandomizeAiResourcesSquads()
            {
                Debug.WriteLine("Randomizing Ai resource squads");
                var resources_path = LevelFolderPath + @"\ai_resources\" + Level.Name + @"_master";
                TagPath tag_path = TagPath.FromPathAndExtension(resources_path, "scenario_ai_resource");
                using (TagFile resource_file = new TagFile(tag_path))
                {
                    TagField squads = GetField(resource_file, "squads");
                    if (squads != null)
                    {
                        foreach (TagElement squad in ((TagFieldBlock)squads).Elements)
                        {
                            SquadRandomizer squad_randomizer = new SquadRandomizer(squad, Rand, Settings);
                            squad_randomizer.Randomize();
                        }
                    }

                    resource_file.Save();
                }
            }

        }
    }


}
