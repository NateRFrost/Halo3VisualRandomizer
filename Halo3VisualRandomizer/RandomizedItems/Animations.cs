using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Halo3VisualRandomizer.RandomizedItems.RandomizedItems.AnimationGraph;

namespace Halo3VisualRandomizer.RandomizedItems
{
    public partial class RandomizedItems
    {
        public static List<List<string>> animation_mode_groups = new List<List<string>>()
        {
            new List<string>(){"wraith_d", "scorption_d", "ghost_d", "mauler_d", "hornet_d", "warthog_d"},
            new List<string>(){"scorpion_g", "wraith_g", "mauler_g"},
            new List<string>(){"hornet_p_l", "passenger_p_l"},
            new List<string>(){"hornet_p_r", "passenger_p_r"},
            new List<string>(){"warthog_p"},
            new List<string>(){"shade_d", "turret_g", "warthog_g"},
        };


        public class AnimationGraph
        {
            public string Path { get; set; } = "";
            public List<WeaponClassCopyGroup> weapon_class_copy_groups = new List<WeaponClassCopyGroup>();

            public class WeaponClassCopyGroup
            {
                private List<string> weaponClassesCopyTo = new List<string>();
                public List<string> WeaponClassesCopyTo
                {
                    get
                    {
                        return weaponClassesCopyTo;
                    }

                    set
                    {
                        weaponClassesCopyTo = value;
                    }
                }
                private List<string> weaponClassesCopyFrom = new List<string>();
                public List<string> WeaponClassesCopyFrom
                {
                    get
                    {
                        return weaponClassesCopyFrom;
                    }

                    set
                    {
                        weaponClassesCopyFrom = value;
                    }
                }
            }
        }

        public static List<AnimationGraph> animation_graphs = new List<AnimationGraph>()
        {
            new AnimationGraph(){
                Path = @"objects\characters\brute\brute",
                weapon_class_copy_groups =
                {
                    //new WeaponClassCopyGroup(){WeaponClassesCopyFrom = {"rifle"}, WeaponClassesCopyTo = {"pistol" } },
                    new WeaponClassCopyGroup(){WeaponClassesCopyFrom = {"hammer"}, WeaponClassesCopyTo = { "flag", "sword", "ball" } }
                }
            },
            new AnimationGraph(){
                Path = @"objects\characters\elite\elite",
                weapon_class_copy_groups =
                {
                    new WeaponClassCopyGroup(){WeaponClassesCopyFrom = { "sword" }, WeaponClassesCopyTo = {"flag", "hammer", "ball" } }
                }
            },
            new AnimationGraph(){
                Path = @"objects\characters\grunt\grunt",
                weapon_class_copy_groups =
                {
                    new WeaponClassCopyGroup(){WeaponClassesCopyFrom = { "pistol" }, WeaponClassesCopyTo = {"flag", "hammer", "ball", "turret", "sword", "hammer", "support" } }
                }
            },
            new AnimationGraph(){
                Path = @"objects\characters\hunter\hunter",
            },
            new AnimationGraph(){
                Path = @"objects\characters\jackal\jackal",
                weapon_class_copy_groups =
                {
                    new WeaponClassCopyGroup(){WeaponClassesCopyFrom = { "pistol" }, WeaponClassesCopyTo = {"flag", "hammer", "ball", "turret", "sword", "hammer", "missile", "rifle", "support" } }
                }
            },
            new AnimationGraph(){
                Path = @"objects\characters\bugger\bugger",
                weapon_class_copy_groups =
                {
                    new WeaponClassCopyGroup(){WeaponClassesCopyFrom = { "pistol" }, WeaponClassesCopyTo = {"flag", "hammer", "ball", "turret", "sword", "hammer", "missile", "support" } }
                }
            },
            new AnimationGraph(){
                Path = @"objects\characters\marine\marine",
                weapon_class_copy_groups =
                {
                    new WeaponClassCopyGroup(){WeaponClassesCopyFrom = { "pistol" }, WeaponClassesCopyTo = {"flag", "hammer", "ball", "turret", "sword", "hammer", "missile", "support"} }
                }
            },
        };
    }
}
