using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo3VisualRandomizer.RandomizedItems
{
    public partial class RandomizedItems
    {
        public static RandomizedObjectList bipeds = new RandomizedObjectList()
        {
            Name = "bipeds",
            List = new List<RandomizedObjectDetails>()
            {
                new RandomizedObjectDetails
                {
                    Name = "marine",
                    Path = @"objects\characters\marine\marine",
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "johnson" },
                            new RandomizedObjectDetails{Name = "wounded" },
                            new RandomizedObjectDetails{Name = "pilot" },
                            new RandomizedObjectDetails{Name = "sarge_lehto" },
                            new RandomizedObjectDetails{Name = "johnson_combat" },
                            new RandomizedObjectDetails{Name = "johnson_dress" },
                            new RandomizedObjectDetails{Name = "default" },
                            new RandomizedObjectDetails{Name = "ma4" },
                            new RandomizedObjectDetails{Name = "ma6" },
                            new RandomizedObjectDetails{Name = "blind" },
                            new RandomizedObjectDetails{Name = "ma2" },
                            new RandomizedObjectDetails{Name = "sg1" },
                            new RandomizedObjectDetails{Name = "ma5" },
                            new RandomizedObjectDetails{Name = "ma3" },
                            new RandomizedObjectDetails{Name = "ma1" },
                            new RandomizedObjectDetails{Name = "dead" },
                            new RandomizedObjectDetails{Name = "sg2" },
                            new RandomizedObjectDetails{Name = "cinem1" },
                            new RandomizedObjectDetails{Name = "cinem2" },
                            new RandomizedObjectDetails{Name = "cinem3" },
                            new RandomizedObjectDetails{Name = "cinem4" },
                            new RandomizedObjectDetails{Name = "cinem5" },
                            new RandomizedObjectDetails{Name = "cinem6" },
                            new RandomizedObjectDetails{Name = "cinem7" },
                            new RandomizedObjectDetails{Name = "cinem8a" },
                            new RandomizedObjectDetails{Name = "cinem8b" },
                            new RandomizedObjectDetails{Name = "cinem8c" },
                            new RandomizedObjectDetails{Name = "cinem8d" },
                            new RandomizedObjectDetails{Name = "cinem8e" },
                            new RandomizedObjectDetails{Name = "cinem8f" },
                            new RandomizedObjectDetails{Name = "cinem8g" },
                            new RandomizedObjectDetails{Name = "cinem8h" },
                            new RandomizedObjectDetails{Name = "cinem8i" },
                            new RandomizedObjectDetails{Name = "cinem8j" },
                            new RandomizedObjectDetails{Name = "johnson_beatup" },
                            new RandomizedObjectDetails{Name = "johnson_dead" },
                        }
                    }
                },
                new RandomizedObjectDetails
                {
                    Name = "elite",
                    Path = @"objects\characters\elite\elite",
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "minor_scl" },
                            new RandomizedObjectDetails{Name = "minor_dog" },
                            new RandomizedObjectDetails{Name = "major_scl" },
                            new RandomizedObjectDetails{Name = "major_dog" },
                            new RandomizedObjectDetails{Name = "spec_ops_scl" },
                            new RandomizedObjectDetails{Name = "spec_ops_dog" },
                            new RandomizedObjectDetails{Name = "stealth_scl" },
                            new RandomizedObjectDetails{Name = "stealth_dog" },
                            new RandomizedObjectDetails{Name = "stealth_major_scl" },
                            new RandomizedObjectDetails{Name = "stealth_major_dog" },
                            new RandomizedObjectDetails{Name = "soc_cinematic" },
                            new RandomizedObjectDetails{Name = "soc" },
                        }
                    }
                },
                new RandomizedObjectDetails
                {
                    Name = "brute",
                    Path = @"objects\characters\brute\brute",
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "minor" },
                            new RandomizedObjectDetails{Name = "captain" },
                            new RandomizedObjectDetails{Name = "jumppack" },
                            new RandomizedObjectDetails{Name = "stalker" },
                            new RandomizedObjectDetails{Name = "chieftain_armor" },
                            new RandomizedObjectDetails{Name = "chieftain_weapon" },
                            new RandomizedObjectDetails{Name = "tracker" },
                            new RandomizedObjectDetails{Name = "major" },
                            new RandomizedObjectDetails{Name = "ultra" },
                            new RandomizedObjectDetails{Name = "captain_ultra" },
                            new RandomizedObjectDetails{Name = "bodyguard" },
                            new RandomizedObjectDetails{Name = "captain_major" },
                        }
                    }
                },
                new RandomizedObjectDetails
                {
                    Name = "miranda",
                    Path = @"objects\characters\miranda\miranda",
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "default" },
                            new RandomizedObjectDetails{Name = "combat" },
                            new RandomizedObjectDetails{Name = "dress" },
                            new RandomizedObjectDetails{Name = "dead" },
                        }
                    }
                },
                new RandomizedObjectDetails
                {
                    Name = "lord_hood",
                    Path = @"objects\characters\lord_hood\lord_hood",
                    Variants = new RandomizedObjectList
                    {
                        List = new List<RandomizedObjectDetails>()
                        {
                            new RandomizedObjectDetails{Name = "default" },
                            new RandomizedObjectDetails{Name = "no_hat" },
                            new RandomizedObjectDetails{Name = "dress" },
                            new RandomizedObjectDetails{Name = "dress_no_hat" },
                        }
                    }
                },
            }
        };
    }
}
