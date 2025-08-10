using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo3VisualRandomizer.RandomizedItems
{
    public partial class RandomizedItems
    {
        public static RandomizedObjectList equipments = new RandomizedObjectList()
        {
            Name = "equipments",
            Type = "eqip",
            ResourceFileType = "*qip",
            ResourceFileExtension = "scenario_equipment_resource",
            PaletteName = "equipment palette",
            List = new List<RandomizedObjectDetails>()
            {
                new RandomizedObjectDetails{Name = "autoturret_equipment", Path = @"objects\equipment\autoturret_equipment\autoturret_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{Name = "bubbleshield_equipment", Path = @"objects\equipment\bubbleshield_equipment\bubbleshield_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{Name = "gravlift_equipment", Path = @"objects\equipment\gravlift_equipment\gravlift_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{Name = "gravlift_permanent", Path = @"objects\equipment\gravlift_permanent\gravlift_permanent", Weight = 3, SubCategory = SubCategory.Obstacle},
                new RandomizedObjectDetails{Name = "instantcover", Path = @"objects\equipment\instantcover\instantcover", Weight = 3, SubCategory = SubCategory.Obstacle},
                new RandomizedObjectDetails{Name = "instantcover_equipment", Path = @"objects\equipment\instantcover_equipment\instantcover_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{Name = "invincibility_equipment", Path = @"objects\equipment\invincibility_equipment\invincibility_equipment", Weight = 5, SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{Name = "invisibility_equipment", Path = @"objects\equipment\invisibility_equipment\invisibility_equipment", Weight = 5, SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{Name = "jammer_equipment", Path = @"objects\equipment\jammer_equipment\jammer_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{Name = "powerdrain_equipment", Path = @"objects\equipment\powerdrain_equipment\powerdrain_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{Name = "regenerator_equipment", Path = @"objects\equipment\regenerator_equipment\regenerator_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{Name = "superflare_equipment", Path = @"objects\equipment\superflare_equipment\superflare_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{Name = "tripmine_equipment", Path = @"objects\equipment\tripmine_equipment\tripmine_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{Name = "tripmine_permanent", Path = @"objects\equipment\tripmine\tripmine_permanent", Weight = 3, SubCategory = SubCategory.Obstacle},
                new RandomizedObjectDetails{Name = "frag_grenade", Path = @"objects\weapons\grenade\frag_grenade\frag_grenade", SubCategory = SubCategory.Grenade, Weight = 50},
                new RandomizedObjectDetails{Name = "plasma_grenade", Path = @"objects\weapons\grenade\plasma_grenade\plasma_grenade", SubCategory = SubCategory.Grenade, Weight = 50},
                new RandomizedObjectDetails{Name = "claymore_grenade", Path = @"objects\weapons\grenade\claymore_grenade\claymore_grenade", SubCategory = SubCategory.Grenade, Weight = 50},
                new RandomizedObjectDetails{Name = "firebomb_grenade", Path = @"objects\weapons\grenade\firebomb_grenade\firebomb_grenade", SubCategory = SubCategory.Grenade, Weight = 20},
                //new RandomizedObjectDetails{Name = "powerup_blue", Path = @"objects\multi\powerups\powerup_blue\powerup_blue", Weight = 1},
                //new RandomizedObjectDetails{Name = "powerup_red", Path = @"objects\multi\powerups\powerup_red\powerup_red", Weight = 1},
                //new RandomizedObjectDetails{Name = "powerup_yellow", Path = @"objects\multi\powerups\powerup_yellow\powerup_yellow", Weight = 1},
            }
        };
    }
}
