using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo3VisualRandomizer.RandomizedItems
{
    public partial class RandomizedItems
    {
        public class SquadSpecialCase
        {
            public List<string> SquadNames { get; set; } = new List<string>();
            public bool Skip { get; set; } = false;
            public bool RandomizeCharacters { get; set; } = true;
            public bool RandomizeWeapons { get; set; } = true;
            public bool RandomizeVehicles { get; set; } = true;
            public bool RandomizeEquipment { get; set; } = true;
            public List<string> AllowedCharacters { get; set; } = new List<string>();
            public List<string> AllowedWeapons { get; set; } = new List<string>();
            public List<string> AllowedVehicles { get; set; } = new List<string>();
            public List<string> AllowedVehicleVariants { get; set; } = new List<string>();

        }

        public static List<SquadSpecialCase> SquadSpecialCases { get; set; } = new List<SquadSpecialCase>()
        {
            new SquadSpecialCase()
            {
                SquadNames = new List<string>() 
                { 
                    "init_allies_brass", 
                    "init_allies",
                    "cell_b_hornets01a",
                    "cell_b_hornets01b",
                },
                RandomizeVehicles = false,
                AllowedCharacters = {"marine", "worker", "elite"}
                
            },
            new SquadSpecialCase()
            {
                SquadNames=new List<string>(){
                    "intro_hog",
                    "intro_troop_hogs",
                    "intro_troop_hogs02",
                },
                AllowedVehicles = new List<string>() {"warthog"},
                AllowedVehicleVariants = new List<string>() {"default", "gauss", "troop", "no_turret"},
            },
            new SquadSpecialCase()
            {
                SquadNames=new List<string>(){
                    "warthog01",
                },
                AllowedVehicles = new List<string>() {"warthog", "warthog_snow", "hornet", "hornet_lite", "mauler", "mongoose", "mongoose_snow", "ghost", "banshee"},
                AllowedVehicleVariants = new List<string>() {"default", "gauss", "troop", "no_turret",},
            },
            new SquadSpecialCase()
            {
                SquadNames = new List<string>()
                {
                    "evac_hangar_jetpack05",
                    "evac_hangar_jetpack06",
                    "evac_hangar_jetpack08",
                    "evac_hangar_jetpack09",
                    "evac_hangar_jetpack012",
                    "evac_hangar_jetpack013",
                    "evac_hangar_jetpack07_legend",

                },
                RandomizeVehicles = false,
                AllowedCharacters = {"brute_jumppack", "floodcombat", "flood_combat"}

            },
            new SquadSpecialCase()
            {
                SquadNames = new List<string>() 
                {
                    
                    "bugger_squad00",
                    "bugger_intro_hum01",
                    "343_spark",
                    "bb_guilty_spark",
                    "f1_guilty_spark",
                    "f2_guilty_spark",
                    "f3_p2_guilty_spark",
                    "abb_guilty_spark",
                    "lb_guilty_spark",
                    "f3_p1_guilty_spark",
                    "f4_guilty_spark",
                    "f5_guilty_spark",
                    "la_guilty_spark",
                    "dw_guilty_spark",
                    "crater_spark",
                    "lock_c_ext_spark",
                    "sq_arbiter",
                    "sq_jw_arbiter",
                    "sq_gc_arbiter",
                    "sq_pa_arbiter",
                    "sq_ss_arbiter",
                    "sq_pb_arbiter",
                    "sq_ba_arbiter",
                    "sq_dam_arbiter",
                    "sq_arbiter",
                    "sq_jw_arbiter",
                    "sq_gc_arbiter",
                    "sq_pa_arbiter",
                    "sq_ss_arbiter",
                    "sq_pb_arbiter",
                    "sq_ba_arbiter",
                    "sq_dam_arbiter",
                    "020_arbiter",
                    "evac_arbiter",
                    "test_ware_arbiter",
                    "cortana_office_arbiter",
                    "test_worker_arbiter",
                    "sq_wt_arbiter",
                    "sq_wh_arbiter",
                    "sq_lb_arbiter",
                    "sq_fb_arbiter",
                    "sq_la_arbiter",
                    "allies_f1_arbiter",
                    "allies_f2_arbiter",
                    "allies_f3_arbiter_follow",
                    "allies_f3_arbiter",
                    "allies_abb_arbiter",
                    "ring_arbiter",
                    "crater_arbiter",
                    "test_lock_c_arbiter",
                    "cell_c_arbiter",
                    "sq_phr_arbiter",
                    "arbiter",
                    "arbiter_trench",
                    "arbiter_fodder",
                    "sq_ss_johnson",
                    "evac_hangar_johnson",
                    "fake_johnson",
                    "allies_abb_johnson",
                    "allies_lz_johnson",
                    "allies_fl_johnson",
                    "allies_sd_johnson",
                    "johnson",

                },
                RandomizeCharacters = false,
                RandomizeVehicles = false,
            },
            new SquadSpecialCase()
            {
                SquadNames = new List<string>()
                {
                    "beach_cov_aa",
                    "lakebed_a_wraith_01",
                    "lakebed_b_wraith_01",
                    "lakebed_b_wraith_02",
                    "cell_c_aa_right",
                    "cell_c_aa_left",
                    "sq_garage_wraith"
                },
                AllowedVehicles = new List<string>() {"wraith",},
            },
            //Must be able to be dropped by phantom
            new SquadSpecialCase()
            {
                SquadNames = new List<string>()
                {
                    "hangar_a_cov_phantom",
                    "hangar_a_cov_init_phantom_drop",
                    "hangar_a_phantom04_legend",
                    "hangar_a_cov_phantom01_5",
                    "hangar_a_phantom04_legend_a",
                    "hangar_a_phantom04_legend_b",
                    "hangar_a_phantom04_legend_c",
                    "hangar_a_cov_phantom01_drop_a",
                    "hangar_a_cov_phantom01_drop_b",
                    "hangar_a_cov_phantom02_drop_a",
                    "hangar_a_cov_phantom03_drop_a",
                    "hangar_a_cov_phantom03_drop_b",
                    "cov_dw_bridge_pack_0",
                    "cov_dw_bridge_pack_1",
                    "cov_dw_bridge_grunts",
                    "sq_jw_l_cov_01",
                    "sq_jw_l_cov_02",
                    "sq_jw_l_cov_03",
                    "sq_jw_l_grunts_01",
                    "sq_jw_l_grunts_02",
                    "sq_jw_l_grunts_03",
                    "sq_jw_l_grunts_02",
                    "sq_jw_l_grunts_03",
                    "sq_garage_second01",
                    "sq_garage_second02",
                    "sq_garage_second03",
                    "sq_garage_third01",
                    "sq_garage_third02",
                    "sq_garage_third03",
                },
                RandomizeVehicles = false,
                AllowedCharacters = {"grunt", "jackal", "brute", "bugger", "elite", "hunter"}
            },
            new SquadSpecialCase()
            {
                SquadNames = new List<string>()
                {
                    "sq_dam_chieftan",
                },
                RandomizeVehicles = false,
                AllowedCharacters = {"brute",}
            },
            //Never Randomize
            new SquadSpecialCase()
            {
                SquadNames = new List<string>()
                {
                    "sq_cc_phantom_01",
                    "sq_jw_phantom_01",
                    "sq_jw_phantom_02",
                    "sq_jw_phantom_03",
                    "sq_jw_phantom_04",
                    "sq_jw_phantom_05",
                    "sq_ss_pelican_01",
                    "sq_ss_pelican_02",
                    "sq_ss_phantom_01",
                    "sq_ss_phantom_02",
                    "sq_ss_phantom_03",
                    "sq_ba_phantom_01",
                    "sq_ba_phantom_02",
                    "sq_dam_pelican",
                    "sq_dam_phantom_01",
                    "sq_dam_phantom_02",
                    "sq_dam_phantom_03",
                    "sq_dam_phantom_04",
                    "sq_cc_phantom_01",
                    "sq_jw_phantom_01",
                    "sq_jw_phantom_02",
                    "sq_jw_phantom_03",
                    "sq_jw_phantom_04",
                    "sq_jw_phantom_05",
                    "sq_ss_pelican_01",
                    "sq_ss_pelican_02",
                    "sq_ss_phantom_01",
                    "sq_ss_phantom_02",
                    "sq_ss_phantom_03",
                    "sq_ba_phantom_01",
                    "sq_ba_phantom_02",
                    "sq_dam_pelican",
                    "sq_dam_phantom_01",
                    "sq_dam_phantom_02",
                    "sq_dam_phantom_03",
                    "sq_dam_phantom_04",
                    "hangar_a_cov_init_phantom",
                    "hangar_a_cov_phantom01",
                    "evac_hangar_hum_pelican",
                    "hangar_a_return_phantom01",
                    "evac_hangar_hum_pelican02",
                    "hangar_a_pelican",
                    "hangar_a_cov_phantom02",
                    "hangar_a_cov_phantom03",
                    "sq_garage_phantom1",
                    "sq_garage_pelican1",
                    "sq_garage_pelican2",
                    "sq_pond_phantom1",
                    "sq_exit_pelican01",
                    "sq_garage_phantom2",
                    "sq_round_phantom01",
                    "sq_round_phantom02",
                    "sq_round_phantom03",
                    "sq_garage_pelican3",
                    "lakebed_a_init_phantoms",
                    "test_intro_hog",
                    "lakebed_b_phantoms",
                    "lakebed_a_ghosts02_phantom",
                    "lakebed_a_end_phantom",
                    "factory_b_end_phantom",
                    "work_cov_phantom01",
                    "work_marines_pelican01",
                    "test_bfg_phantom",
                    "factory_b_phantom",
                    "lakebed_b_pelicans01",
                    "cortana_office_pelican01",
                    "sq_la_phantom_01",
                    "sq_la_phantom_02",
                    "cov_bb_front_phantom",
                    "cov_f3_phantom",
                    "allies_f5_pelican",
                    "allies_abb_pelican",
                    "allies_lz_pelican_0",
                    "cov_la_p2_phantom",
                    "allies_fl_pelican",
                    "cov_dw_phantom",
                    "cov_amb_bowls_phantom01",
                    "cov_b2_phantom",
                    "cov_b2_hunter_phantom",
                    "cov_b2_phantom_bfg",
                    "allies_sd_pelican",
                    "allies_lz_pelican_1",
                    "cov_amb_bowls_phantom02",
                    "beach_pelican",
                    "beach_phantom_cov",
                    "patha_pelican",
                    "cella_cov01_phantoms01",
                    "cella_pelicans",
                    "tank_marines_pelican",
                    "cell_b_pelicans02",
                    "cell_b_phantoms01",
                    "crater_elite_phantom",
                    "crater_pelican_start",
                    "cell_b_elite_phantoms",
                    "cell_b_phantoms02",
                    "cell_a_pelican_supply",
                    "test_cell_c_pelican01",
                    "test_cell_c_pelican02",
                    "cell_b_pelican",
                    "crater_cov_phantom01",
                    "tank_cov_phantoms01",
                    "cell_c_elite_phantoms",
                    "lock_c_ext_elite_phantom",
                    "tank_pelican_drop",
                    "johnson_boss_squad",
                },
                Skip = true
            }
        };

    }
}
