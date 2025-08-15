using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;


namespace Halo3VisualRandomizer.RandomizedItems
{

    public static partial class RandomizedItems
    {

        

        public class RandomizedObjectList
        {
            public string Name { get; set; } = "";
            public List<RandomizedObjectDetails> List { get; set; } = new List<RandomizedObjectDetails>();
            public string Type { get; set; } = "";
            public string ResourceFileType { get; set; } = "";
            public string ResourceFileExtension { get; set; } = "";
            public string ResourcesFolder { get; set; } = "resources";
            public string PaletteName { get; set; } = "";
            public string PaletteNameAiResources { get; set; } = "";

            public RandomizedObjectList FilterName(string name)
            {
                RandomizedObjectList new_list = (RandomizedObjectList)this.MemberwiseClone();
                new_list.List = this.List.Where(o => o.Name.Contains(name)).ToList();
                return new_list;
            }


            public RandomizedObjectList DeepCopy()
            {
                RandomizedObjectList new_list = (RandomizedObjectList)this.MemberwiseClone();
                new_list.List = new List<RandomizedObjectDetails>();
                foreach (RandomizedObjectDetails item in List)
                {
                    new_list.List.Add(item.ShallowCopy());
                }
                return new_list;
            }

            public void ResetIndexes()
            {
                foreach (var object_type in List)
                {
                    object_type.PaletteIndex = -1;
                }
            }

            public RandomizedObjectDetails GetRandomObjectWeighted(Random rand, List<SubCategory> subcategories = null, List<Faction> factions = null, List<string> name_starts_with = null, List<string> CompatibleCharacters = null, bool require_palette_index = false)
            {
                var filtered_list = List.ToList();
                if (subcategories != null)
                {
                    filtered_list = filtered_list.Where(o => subcategories.Contains(o.SubCategory)).ToList();
                }
                if (factions != null)
                {
                    filtered_list = filtered_list.Where(o => factions.Contains(o.Faction)).ToList();
                }
                if (name_starts_with != null)
                {
                    filtered_list = filtered_list.Where(o => name_starts_with.Any(o2 => o2.StartsWith(o.Name))).ToList();
                }
                if (CompatibleCharacters != null)
                {
                    filtered_list = filtered_list.Where(weapon => CompatibleCharacters.All(character_name => weapon.CompatibleEnemies.List.Any(character => character_name == character.Name))).ToList();
                }
                if (require_palette_index)
                {
                    filtered_list = filtered_list.Where(o => o.PaletteIndex != -1).ToList();
                }



                int total_weight = 0;
                foreach (RandomizedObjectDetails item in filtered_list)
                {
                    total_weight += item.Weight;
                }
                int random_number = rand.Next(0, total_weight);
                foreach (RandomizedObjectDetails item in filtered_list)
                {
                    if (random_number <= item.Weight)
                    {
                        return item;
                    }
                    random_number -= item.Weight;
                }
                return null;
            }
        }

        public enum SubCategory
        {
            None,
            Air,
            Land,
            Space,
            Turret,
            Civilian,
            WeaponStash,
            Weak,
            Medium,
            Strong,
            Creature,
            Specialist,
            Grenade,
            ArmorAbility,
            Obstacle,
        }

        public enum Faction
        {
            None,
            Human = 2,
            Covenant = 7,
            Elite = 3,
            Forerunner = 5,
            Flood = 4,
            Promethean,
            Mule,
        }

        public class RandomizedObjectDetails
        {
            public string FancyName { get; set; } = "";
            public bool Editable { get; set; } = true;
            public string Name { get; set; } = "";
            public string Path { get; set; } = @"";
            public int AmmoMag { get; set; } = 0;
            public int AmmoTotal { get; set; } = 0;
            public int Seats { get; set; } = 1;
            public string Subtitle { get; set; } = "";

            public int PaletteIndex { get; set; } = -1;
            public int Weight { get; set; } = 10;
            public SubCategory SubCategory { get; set; }
            public Faction Faction { get; set; }
            public string CopyPropertiesFrom { get; set; } = "";

            public RandomizedObjectList CompatibleEnemies { get; set; } = new RandomizedObjectList();
            public RandomizedObjectList Variants { get; set; } = new RandomizedObjectList();

            public RandomizedObjectDetails ShallowCopy()
            {
                return (RandomizedObjectDetails)this.MemberwiseClone();
            }

        }



        public static List<string> skipSpecialObjects = new List<string>()
        {
        };

        


        
        
    }
    
}