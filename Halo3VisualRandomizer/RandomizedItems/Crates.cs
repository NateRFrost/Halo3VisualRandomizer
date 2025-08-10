using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo3VisualRandomizer.RandomizedItems
{
    public partial class RandomizedItems
    {
        public static RandomizedObjectList crates = new RandomizedObjectList()
        {
            Name = "crates",
            ResourceFileType = "*cen",
            ResourceFileExtension = "scenario_scenery_resource",
            PaletteName = "crate palette",
            Type = "bloc",
            List = new List<RandomizedObjectDetails>()
            {
                new RandomizedObjectDetails
                {
                    Name = "crate_h_gun_rack_1",
                    Path = @"objects\gear\human\military\crate_h_gun_rack_1\crate_h_gun_rack_1",
                    Faction = Faction.Human,
                    SubCategory = SubCategory.WeaponStash,
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "default" },
                            new RandomizedObjectDetails{Name = "example" },
                            new RandomizedObjectDetails{Name = "shot_rock01" },
                            new RandomizedObjectDetails{Name = "br_rock01" },
                            new RandomizedObjectDetails{Name = "ar_shot" },
                            new RandomizedObjectDetails{Name = "br_shot" },
                            new RandomizedObjectDetails{Name = "ar_10" },
                            new RandomizedObjectDetails{Name = "br_5" },
                        }
                    }
                },
                new RandomizedObjectDetails
                {
                    Name = "crate_h_gun_rack_2",
                    Path = @"objects\gear\human\military\crate_h_gun_rack_2\crate_h_gun_rack_2",
                    Faction = Faction.Human,
                    SubCategory = SubCategory.WeaponStash,
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "example" },
                            new RandomizedObjectDetails{Name = "ar_10" },
                            new RandomizedObjectDetails{Name = "empty" },
                            new RandomizedObjectDetails{Name = "shot_10" },
                            new RandomizedObjectDetails{Name = "shot_9" },
                            new RandomizedObjectDetails{Name = "smg_10" },
                            new RandomizedObjectDetails{Name = "br_10" },
                            new RandomizedObjectDetails{Name = "standard" },
                            new RandomizedObjectDetails{Name = "stand_rock" },
                        }
                    }
                },
                new RandomizedObjectDetails
                {
                    Name = "h_grenade_crate",
                    Path = @"objects\gear\human\military\h_grenade_crate\h_grenade_crate",
                    Faction = Faction.Human,
                    SubCategory = SubCategory.WeaponStash,
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "one" },
                            new RandomizedObjectDetails{Name = "two" },
                            new RandomizedObjectDetails{Name = "three" },
                            new RandomizedObjectDetails{Name = "four" },
                        }
                    }
                },
                new RandomizedObjectDetails
                {
                    Name = "resupply_capsule_fired",
                    Path = @"objects\gear\human\military\resupply_capsule_fired\resupply_capsule_fired",
                    Faction = Faction.Human,
                    SubCategory = SubCategory.WeaponStash,
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            //some variants appear to not work
                            //new RandomizedObjectDetails{Name = "ar" },
                            new RandomizedObjectDetails{Name = "br" },
                            //new RandomizedObjectDetails{Name = "laser" },
                            //new RandomizedObjectDetails{Name = "pistols" },
                            new RandomizedObjectDetails{Name = "default" },
                            new RandomizedObjectDetails{Name = "rocket" },
                            //new RandomizedObjectDetails{Name = "shotgun" },
                            //new RandomizedObjectDetails{Name = "smg" },
                            new RandomizedObjectDetails{Name = "sniper" },
                            //new RandomizedObjectDetails{Name = "turret" },
                        }
                    }
                },
                new RandomizedObjectDetails
                {
                    Name = "resupply_capsule_unfired",
                    Path = @"objects\gear\human\military\resupply_capsule_unfired\resupply_capsule_unfired",
                    Faction = Faction.Human,
                    SubCategory = SubCategory.WeaponStash,
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            //some variants appear to not work
                            new RandomizedObjectDetails{Name = "ar" },
                            new RandomizedObjectDetails{Name = "br" },
                            new RandomizedObjectDetails{Name = "laser" },
                            new RandomizedObjectDetails{Name = "pistols" },
                            new RandomizedObjectDetails{Name = "default" },
                            //new RandomizedObjectDetails{Name = "rocket" },
                            new RandomizedObjectDetails{Name = "shotgun" },
                            //new RandomizedObjectDetails{Name = "smg" },
                            //new RandomizedObjectDetails{Name = "sniper" },
                            //new RandomizedObjectDetails{Name = "turret" },
                        }
                    }
                },
                new RandomizedObjectDetails
                {
                    Name = "crate_space_a",
                    Path = @"objects\props\covenant\crate_space_a\crate_space_a",
                    Faction = Faction.Covenant,
                    SubCategory = SubCategory.WeaponStash,
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "default"},
                            new RandomizedObjectDetails{Name = "plasma_rifles0" },
                            new RandomizedObjectDetails{Name = "plasma_rifles1" },
                            new RandomizedObjectDetails{Name = "mixed0" },
                            new RandomizedObjectDetails{Name = "carbines0" },
                            new RandomizedObjectDetails{Name = "beam_rifles0" },
                            new RandomizedObjectDetails{Name = "brute_shot0" },
                            new RandomizedObjectDetails{Name = "energy_blades0" },
                            new RandomizedObjectDetails{Name = "spike_rifle0" },
                            new RandomizedObjectDetails{Name = "spike_rifle1" },
                            new RandomizedObjectDetails{Name = "excavator0" },
                            new RandomizedObjectDetails{Name = "excavator1" },
                            new RandomizedObjectDetails{Name = "plasma_pistols0" },
                            new RandomizedObjectDetails{Name = "plasma_pistols1" },
                            new RandomizedObjectDetails{Name = "flak_cannons0" },
                        }
                    }
                },
                new RandomizedObjectDetails
                {
                    Name = "crate_space_b",
                    Path = @"objects\gear\human\military\crate_space_b\crate_space_b",
                    Faction = Faction.Covenant,
                    SubCategory = SubCategory.WeaponStash,
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "default" },
                            new RandomizedObjectDetails{Name = "plasma_rifles0" },
                            new RandomizedObjectDetails{Name = "spike_rifle0" },
                        }
                    }
                },
            }
        };
    }
}
