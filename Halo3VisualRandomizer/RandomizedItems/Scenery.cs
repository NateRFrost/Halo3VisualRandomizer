using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo3VisualRandomizer.RandomizedItems
{
    public partial class RandomizedItems
    {
        public static RandomizedObjectList scenerys = new RandomizedObjectList()
        {
            Name = "scenerys",
            ResourceFileType = "*cen",
            ResourceFileExtension = "scenario_scenery_resource",
            PaletteName = "scenery palette",
            Type = "scen",
            List = new List<RandomizedObjectDetails>()
            {
                new RandomizedObjectDetails
                {
                    Name = "armory_shelf",
                    Path = @"objects\levels\solo\020_base\armory_shelf\armory_shelf",
                    Faction = Faction.Human,
                    SubCategory = SubCategory.WeaponStash,
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "empty"},
                            new RandomizedObjectDetails{Name = "ar" },
                            new RandomizedObjectDetails{Name = "ar01" },
                            new RandomizedObjectDetails{Name = "ar02" },
                            new RandomizedObjectDetails{Name = "br" },
                            new RandomizedObjectDetails{Name = "br01" },
                            new RandomizedObjectDetails{Name = "br02" },
                            new RandomizedObjectDetails{Name = "shot" },
                            new RandomizedObjectDetails{Name = "shot01" },
                            new RandomizedObjectDetails{Name = "shot02" },
                            new RandomizedObjectDetails{Name = "closed" },
                        }
                    }
                },
                new RandomizedObjectDetails
                {
                    Name = "armory_shelf_small",
                    Path = @"objects\gear\human\military\armory_shelf_small\armory_shelf_small",
                    Faction = Faction.Human,
                    SubCategory = SubCategory.WeaponStash,
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "4smg_no_grenade" },
                            new RandomizedObjectDetails{Name = "4smg_grenade" },
                            new RandomizedObjectDetails{Name = "4pistol_no_grenade" },
                            new RandomizedObjectDetails{Name = "4pistol_grenade" },
                            new RandomizedObjectDetails{Name = "2smg_no_grenade" },
                            new RandomizedObjectDetails{Name = "2smg_grenade" },
                            new RandomizedObjectDetails{Name = "2pistol_no_grenade" },
                            new RandomizedObjectDetails{Name = "2pistol_grenade" },
                            new RandomizedObjectDetails{Name = "empty" },
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

            }
        };
    }
}
