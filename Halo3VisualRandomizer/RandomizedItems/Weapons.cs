using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo3VisualRandomizer.RandomizedItems
{
    public partial class RandomizedItems
    {
        public static RandomizedObjectList weapons = new RandomizedObjectList()
        {
            Name = "weapons",
            Type = "weap",
            ResourceFileType = "*eap",
            ResourceFileExtension = "scenario_weapons_resource",
            PaletteName = "weapon palette",
            PaletteNameAiResources = "weapon references",
            List = new List<RandomizedObjectDetails>()
            {
                new RandomizedObjectDetails{Name = "energy_blade", Path = @"objects\weapons\melee\energy_blade\energy_blade", CompatibleEnemies = characters.FilterName("elite") , Faction = Faction.Covenant, Weight = 5},
                new RandomizedObjectDetails{Name = "gravity_hammer", Path = @"objects\weapons\melee\gravity_hammer\gravity_hammer", CompatibleEnemies = characters.FilterName("brute"), Faction = Faction.Covenant, Weight = 5},
                //new RandomizedObjectDetails{Name = "jackal_shield", Path = @"objects\weapons\melee\jackal_shield\jackal_shield" },
                //new RandomizedObjectDetails{Name = "skirmisher_bracers", Path = @"objects\weapons\melee\skirmisher_bracers\skirmisher_bracers" },
                //new RandomizedObjectDetails{Name = "unarmed", Path = @"objects\weapons\melee\unarmed\unarmed", CompatibleEnemies = characters.List.Where(o => o.Name.Contains("engineer")).ToList() },
                new RandomizedObjectDetails{Name = "magnum", Path = @"objects\weapons\pistol\magnum\magnum", AmmoMag = 8, AmmoTotal = 32, CompatibleEnemies = characters, Faction = Faction.Human, Weight = 20},
                new RandomizedObjectDetails{Name = "automag", Path = @"objects\weapons\pistol\automag\automag", AmmoMag = 12, AmmoTotal = 36, CompatibleEnemies = characters, Faction = Faction.Human, Weight = 20, CopyPropertiesFrom = @"objects\weapons\pistol\magnum\magnum"},
                new RandomizedObjectDetails{Name = "needler", Path = @"objects\weapons\pistol\needler\needler", AmmoMag = 19, AmmoTotal = 76, CompatibleEnemies = characters, Faction = Faction.Covenant, Weight = 20},
                new RandomizedObjectDetails{Name = "plasma_pistol", Path = @"objects\weapons\pistol\plasma_pistol\plasma_pistol", CompatibleEnemies = characters, Faction = Faction.Covenant, Weight = 20},
                new RandomizedObjectDetails{Name = "excavator", Path = @"objects\weapons\pistol\excavator\excavator", AmmoMag = 5, AmmoTotal = 10, CompatibleEnemies = characters, Faction = Faction.Covenant, Weight = 20},
                new RandomizedObjectDetails{Name = "assault_rifle", Path = @"objects\weapons\rifle\assault_rifle\assault_rifle", AmmoMag = 32, AmmoTotal = 96, CompatibleEnemies = characters, Faction = Faction.Human, Weight = 20},
                new RandomizedObjectDetails{Name = "battle_rifle", Path = @"objects\weapons\rifle\battle_rifle\battle_rifle", AmmoMag = 36, AmmoTotal = 108, CompatibleEnemies = characters, Weight = 14, Faction = Faction.Human},
                new RandomizedObjectDetails{Name = "beam_rifle", Path = @"objects\weapons\rifle\beam_rifle\beam_rifle", CompatibleEnemies = characters, Faction = Faction.Covenant, Weight = 20},
                new RandomizedObjectDetails{Name = "covenant_carbine", Path = @"objects\weapons\rifle\covenant_carbine\covenant_carbine", AmmoMag = 18, AmmoTotal = 54, CompatibleEnemies = characters, Weight = 14, Faction = Faction.Covenant},
                new RandomizedObjectDetails{Name = "plasma_rifle", Path = @"objects\weapons\rifle\plasma_rifle\plasma_rifle", CompatibleEnemies = characters, Faction = Faction.Covenant, Weight = 20},
                new RandomizedObjectDetails{Name = "plasma_rifle_red", Path = @"objects\weapons\rifle\plasma_rifle_red\plasma_rifle_red", CompatibleEnemies = characters, Faction = Faction.Covenant, Weight = 20, CopyPropertiesFrom = @"objects\weapons\rifle\plasma_rifle\plasma_rifle"},
                new RandomizedObjectDetails{Name = "shotgun", Path = @"objects\weapons\rifle\shotgun\shotgun", AmmoMag = 6, AmmoTotal = 18, CompatibleEnemies = characters, Faction = Faction.Human, Weight = 20},
                new RandomizedObjectDetails{Name = "smg", Path = @"objects\weapons\rifle\smg\smg", AmmoMag = 60, AmmoTotal = 180, CompatibleEnemies = characters, Faction = Faction.Human, Weight = 20},
                new RandomizedObjectDetails{Name = "smg_silenced", Path = @"objects\weapons\rifle\smg_silenced\smg_silenced", AmmoMag = 48, AmmoTotal = 144, CompatibleEnemies = characters, Faction = Faction.Human, Weight = 20, CopyPropertiesFrom = @"objects\weapons\rifle\smg\smg"},
                new RandomizedObjectDetails{Name = "sniper_rifle", Path = @"objects\weapons\rifle\sniper_rifle\sniper_rifle", AmmoMag = 4, AmmoTotal = 12, CompatibleEnemies = characters, Weight = 8, Faction = Faction.Human},
                new RandomizedObjectDetails{Name = "spike_rifle", Path = @"objects\weapons\rifle\spike_rifle\spike_rifle", AmmoMag = 40, AmmoTotal = 120, CompatibleEnemies = characters, Faction = Faction.Covenant, Weight = 20},
                new RandomizedObjectDetails{Name = "flak_cannon", Path = @"objects\weapons\support_high\flak_cannon\flak_cannon", AmmoMag = 5, AmmoTotal = 20, CompatibleEnemies = characters, Weight = 8, Faction = Faction.Covenant},
                new RandomizedObjectDetails{Name = "rocket_launcher", Path = @"objects\weapons\support_high\rocket_launcher\rocket_launcher", AmmoMag = 2, AmmoTotal = 8, CompatibleEnemies = characters, Weight = 8, Faction = Faction.Human},
                new RandomizedObjectDetails{Name = "spartan_laser", Path = @"objects\weapons\support_high\spartan_laser\spartan_laser", CompatibleEnemies = characters, Weight = 8, Faction = Faction.Human},
                new RandomizedObjectDetails{Name = "plasma_cannon", Path = @"objects\weapons\turret\plasma_cannon\plasma_cannon", AmmoMag = 200, AmmoTotal = 200, CompatibleEnemies = characters, Weight = 4, Faction = Faction.Covenant},
                new RandomizedObjectDetails{Name = "machinegun_turret", Path = @"objects\weapons\turret\machinegun_turret\machinegun_turret", AmmoMag = 200, AmmoTotal = 200, CompatibleEnemies = characters, Weight = 4, Faction = Faction.Human},
                new RandomizedObjectDetails{Name = "flamethrower", Path = @"tags\objects\weapons\turret\flamethrower\flamethrower", CompatibleEnemies = characters, Weight = 4, Faction = Faction.Human},
                new RandomizedObjectDetails{Name = "missile_pod", Path = @"tags\objects\weapons\turret\missile_pod\missile_pod",  AmmoMag = 8, AmmoTotal = 8,CompatibleEnemies = characters, Weight = 4, Faction = Faction.Human},
                new RandomizedObjectDetails{Name = "brute_shot", Path = @"tags\objects\weapons\support_low\brute_shot\brute_shot",  AmmoMag = 6, AmmoTotal = 18,CompatibleEnemies = characters, Weight = 20, Faction = Faction.Covenant},
                new RandomizedObjectDetails{Name = "sentinel_gun", Path = @"tags\objects\weapons\support_low\sentinel_gun\sentinel_gun",CompatibleEnemies = characters, Weight = 20, Faction = Faction.Forerunner},
                new RandomizedObjectDetails{Name = "flag", Path = @"objects\weapons\multiplayer\flag\flag", CompatibleEnemies = characters, Weight = 1},
                //new RandomizedObjectDetails{Name = "ball", Path = @"objects\weapons\multiplayer\ball\ball", CompatibleEnemies = characters, Weight = 1},
                new RandomizedObjectDetails{Name = "golf_club", Path = @"objects\levels\shared\golf_club\golf_club", CompatibleEnemies = characters.FilterName("brute"), Weight = 1, CopyPropertiesFrom = @"objects\weapons\melee\gravity_hammer\gravity_hammer"},
                new RandomizedObjectDetails{Name = "hornet_lite", Path = @"objects\levels\dlc\sidewinder\hornet_lite\weapon\hornet_lite", CompatibleEnemies = characters, Weight = 0, Faction = Faction.Human, CopyPropertiesFrom = @"objects\vehicles\hornet\weapon\hornet_missile"},
                new RandomizedObjectDetails{Name = "hornet_lite", Path = @"objects\levels\multi\s3d_sky_bridge\hornet_lite\weapon\hornet_lite", CompatibleEnemies = characters, Weight = 0, Faction = Faction.Human, CopyPropertiesFrom = @"objects\vehicles\hornet\weapon\hornet_missile"},
            }
        };
    }
}
