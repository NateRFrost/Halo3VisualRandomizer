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
                new RandomizedObjectDetails{FancyName = "Autoturret", Name = "autoturret_equipment", Path = @"objects\equipment\autoturret_equipment\autoturret_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{FancyName = "Bubble Shield", Name = "bubbleshield_equipment", Path = @"objects\equipment\bubbleshield_equipment\bubbleshield_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{FancyName = "Gravity Lift", Name = "gravlift_equipment", Path = @"objects\equipment\gravlift_equipment\gravlift_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{FancyName = "Gravity Lift Deployed", Name = "gravlift_permanent", Path = @"objects\equipment\gravlift_permanent\gravlift_permanent", Weight = 3, SubCategory = SubCategory.Obstacle},
                new RandomizedObjectDetails{FancyName = "Deployable Cover", Name = "instantcover_equipment", Path = @"objects\equipment\instantcover_equipment\instantcover_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{FancyName = "Deployable Cover Deployed", Name = "instantcover", Path = @"objects\equipment\instantcover\instantcover", Weight = 3, SubCategory = SubCategory.Obstacle},
                new RandomizedObjectDetails{FancyName = "Invincibility", Name = "invincibility_equipment", Path = @"objects\equipment\invincibility_equipment\invincibility_equipment", Weight = 5, SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{FancyName = "Invisibility", Name = "invisibility_equipment", Path = @"objects\equipment\invisibility_equipment\invisibility_equipment", Weight = 5, SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{FancyName = "Radar Jammer", Name = "jammer_equipment", Path = @"objects\equipment\jammer_equipment\jammer_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{FancyName = "Power Drain", Name = "powerdrain_equipment", Path = @"objects\equipment\powerdrain_equipment\powerdrain_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{FancyName = "Regenerator", Name = "regenerator_equipment", Path = @"objects\equipment\regenerator_equipment\regenerator_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{FancyName = "Flare", Name = "superflare_equipment", Path = @"objects\equipment\superflare_equipment\superflare_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{FancyName = "Tripmine", Name = "tripmine_equipment", Path = @"objects\equipment\tripmine_equipment\tripmine_equipment", SubCategory = SubCategory.ArmorAbility},
                new RandomizedObjectDetails{FancyName = "Tripmine Deployed", Name = "tripmine_permanent", Path = @"objects\equipment\tripmine\tripmine_permanent", Weight = 3, SubCategory = SubCategory.Obstacle},
                new RandomizedObjectDetails{FancyName = "Frag Grenade", Name = "frag_grenade", Path = @"objects\weapons\grenade\frag_grenade\frag_grenade", SubCategory = SubCategory.Grenade, Weight = 50},
                new RandomizedObjectDetails{FancyName = "Plasma Grenade", Name = "plasma_grenade", Path = @"objects\weapons\grenade\plasma_grenade\plasma_grenade", SubCategory = SubCategory.Grenade, Weight = 50},
                new RandomizedObjectDetails{FancyName = "Spike Grenade", Name = "claymore_grenade", Path = @"objects\weapons\grenade\claymore_grenade\claymore_grenade", SubCategory = SubCategory.Grenade, Weight = 50},
                new RandomizedObjectDetails{FancyName = "Firebomb Grenade", Name = "firebomb_grenade", Path = @"objects\weapons\grenade\firebomb_grenade\firebomb_grenade", SubCategory = SubCategory.Grenade, Weight = 20},
                //new RandomizedObjectDetails{Name = "powerup_blue", Path = @"objects\multi\powerups\powerup_blue\powerup_blue", Weight = 1},
                //new RandomizedObjectDetails{Name = "powerup_red", Path = @"objects\multi\powerups\powerup_red\powerup_red", Weight = 1},
                //new RandomizedObjectDetails{Name = "powerup_yellow", Path = @"objects\multi\powerups\powerup_yellow\powerup_yellow", Weight = 1},
            }
        };
    }
}
