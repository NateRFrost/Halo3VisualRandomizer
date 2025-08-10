using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Halo3VisualRandomizer.RandomizedItems.RandomizedItems;

namespace Halo3VisualRandomizer.RandomizedItems
{
    public partial class RandomizedItems
    {
        public static RandomizedObjectList vehicles = new RandomizedObjectList()
        {
            Name = "vehicles",
            Type = "vehi",
            ResourceFileType = "*ehi",
            ResourceFileExtension = "scenario_vehicles_resource",
            PaletteName = "vehicle palette",
            PaletteNameAiResources = "vehicle references",
            List = new List<RandomizedObjectDetails>()
            {
                new RandomizedObjectDetails{Name = "banshee", Path =  @"objects\vehicles\banshee\banshee", Weight = 3, Faction = Faction.Covenant, SubCategory = SubCategory.Air},
                new RandomizedObjectDetails{Name = "brute_chopper", Path =  @"objects\vehicles\brute_chopper\brute_chopper", Faction = Faction.Covenant, SubCategory = SubCategory.Land},
                new RandomizedObjectDetails{Name = "hornet", Path =  @"objects\vehicles\hornet\hornet", Weight = 1, Faction = Faction.Human, SubCategory = SubCategory.Air},
                new RandomizedObjectDetails{Name = "hornet_lite", Path =  @"objects\levels\dlc\sidewinder\hornet_lite\hornet_lite", Weight = 1, Faction = Faction.Human, SubCategory = SubCategory.Air, CopyPropertiesFrom = @"objects\vehicles\hornet\hornet"},
                new RandomizedObjectDetails{Name = "hornet_lite", Path =  @"objects\levels\multi\s3d_sky_bridge\hornet_lite\hornet_lite", Weight = 1, Faction = Faction.Human, SubCategory = SubCategory.Air, CopyPropertiesFrom = @"objects\vehicles\hornet\hornet"},
                new RandomizedObjectDetails{Name = "mauler", Path =  @"objects\vehicles\mauler\mauler", Faction = Faction.Covenant, SubCategory = SubCategory.Land, Seats = 4},
                new RandomizedObjectDetails{Name = "ghost",  Path = @"objects\vehicles\ghost\ghost" , Faction = Faction.Covenant, SubCategory = SubCategory.Land},
                //new RandomizedObjectDetails{Name = "wraith_anti_air",  Path = @"objects\vehicles\wraith\wraith_anti_air", Seats = 2, Weight = 4, Faction = Faction.Covenant, SubCategory = SubCategory.Land},
                new RandomizedObjectDetails{Name = "mongoose",  Path = @"objects\vehicles\mongoose\mongoose" , Seats = 2, Faction = Faction.Human, SubCategory = SubCategory.Land},
                new RandomizedObjectDetails{Name = "mongoose_snow",  Path = @"objects\vehicles\mongoose\mongoose_snow" , Seats = 2, Faction = Faction.Human, SubCategory = SubCategory.Land, CopyPropertiesFrom = @"objects\vehicles\mongoose\mongoose"},
                new RandomizedObjectDetails{Name = "scorpion",  Path = @"objects\vehicles\scorpion\scorpion",Seats = 2, Weight = 4, Faction = Faction.Human, SubCategory = SubCategory.Land},
                new RandomizedObjectDetails{Name = "scorpion_snow",  Path = @"objects\vehicles\scorpion\scorpion_snow",Seats = 2, Weight = 4, Faction = Faction.Human, SubCategory = SubCategory.Land, CopyPropertiesFrom = @"objects\vehicles\scorpion\scorpion"},
                //new RandomizedObjectDetails{Name = "warthog_gauss",  Path = @"objects\vehicles\warthog\warthog_gauss",Seats = 3, Faction = Faction.Human, SubCategory = SubCategory.Land},
                //new RandomizedObjectDetails{Name = "warthog_gause_snow",  Path = @"objects\vehicles\warthog\warthog_gause_snow",Seats = 3, Faction = Faction.Human, SubCategory = SubCategory.Land, CopyPropertiesFrom = @"objects\vehicles\warthog\warthog_gause"},
                //new RandomizedObjectDetails{Name = "warthog_troop",  Path = @"objects\vehicles\warthog\warthog_troop",Seats = 5, Faction = Faction.Human, SubCategory = SubCategory.Land},
                //new RandomizedObjectDetails{Name = "warthog_wrecked_turret",  Path = @"objects\vehicles\warthog\warthog_wrecked_turret", Faction = Faction.Human, SubCategory = SubCategory.Turret},
                new RandomizedObjectDetails{Name = "plasma_cannon",  Path = @"objects\weapons\turret\plasma_cannon\plasma_cannon" , Faction = Faction.Covenant, SubCategory = SubCategory.Turret},
                new RandomizedObjectDetails{Name = "machinegun_turret",  Path = @"objects\weapons\turret\machinegun_turret\machinegun_turret" , Faction = Faction.Human, SubCategory = SubCategory.Turret},
                new RandomizedObjectDetails{Name = "shade",  Path = @"objects\vehicles\shade\shade" , Faction = Faction.Covenant, SubCategory = SubCategory.Turret},
                new RandomizedObjectDetails{Name = "missile_pod",  Path = @"objects\weapons\turret\missile_pod\missile_pod" , Faction = Faction.Human, SubCategory = SubCategory.Turret},
                new RandomizedObjectDetails{
                    Name = "warthog",
                    Path = @"objects\vehicles\warthog\warthog",
                    Seats = 3,
                    Faction = Faction.Human,
                    SubCategory = SubCategory.Land,
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "default"},
                            new RandomizedObjectDetails{Name = "gauss" },
                            new RandomizedObjectDetails{Name = "troop" },
                            new RandomizedObjectDetails{Name = "no_turret" },
                            new RandomizedObjectDetails{Name = "wrecked_turret" },
                        }
                    }
                },
                new RandomizedObjectDetails{
                    Name = "warthog_snow",
                    Path = @"objects\vehicles\warthog\warthog_snow",
                    Seats = 3,
                    Faction = Faction.Human,
                    SubCategory = SubCategory.Land,
                    CopyPropertiesFrom = @"objects\vehicles\warthog\warthog",
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "default"},
                            new RandomizedObjectDetails{Name = "gauss" },
                            new RandomizedObjectDetails{Name = "troop" },
                            new RandomizedObjectDetails{Name = "no_turret" },
                            new RandomizedObjectDetails{Name = "wrecked_turret" },
                        }
                    }
                },
                new RandomizedObjectDetails{
                    Name = "wraith",
                    Path = @"objects\vehicles\wraith\wraith",
                    Seats = 2,
                    Weight = 4,
                    Faction = Faction.Covenant,
                    SubCategory = SubCategory.Land,
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "default"},
                            new RandomizedObjectDetails{Name = "anti_air" },
                        }
                    }
                },
            }
        };
    }
}
