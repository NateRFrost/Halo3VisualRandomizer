using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo3VisualRandomizer.RandomizedItems
{
    public partial class RandomizedItems
    {
        public class Level
        {
            public string Name { get; set; }
            public string FancyName { get; set; } = "";
            public bool CutsceneOnly { get; set; } = false;
            public bool Randomize { get; set; } = true;
            public bool HasAiResources { get; set; } = false;
        }

        public static List<Level> Levels = new List<Level>()
        {
            new Level{Name = "005_intro", FancyName = "Arrival", CutsceneOnly = true},
            new Level{Name = "010_jungle", FancyName = "Sierra 117", HasAiResources = true},
            new Level{Name = "020_base", FancyName = "Crow's Nest", HasAiResources = true},
            new Level{Name = "030_outskirts", FancyName = "Tsavo Highway", HasAiResources = true},
            new Level{Name = "040_voi", FancyName = "The Storm"},
            new Level{Name = "050_floodvoi", FancyName = "Floodgate"},
            new Level{Name = "070_waste", FancyName = "The Ark"},
            new Level{Name = "100_citadel", FancyName = "The Covenant"},
            new Level{Name = "110_hc", FancyName = "Cortana"},
            new Level{Name = "120_halo", FancyName = "Halo", HasAiResources = true},
            new Level{Name = "130_epilogue", FancyName = "Epilogue", CutsceneOnly = true },
        };
    }
}
