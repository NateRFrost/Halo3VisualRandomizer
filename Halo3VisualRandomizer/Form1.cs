using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static Halo3VisualRandomizer.Randomizer;

namespace Halo3VisualRandomizer
{
    public partial class Form1 : Form
    {
        Randomizer Randomizer = new Randomizer();
        RandomizerSettings Settings = new RandomizerSettings();

        public Form1()
        {
            InitializeComponent();
        }

        public static string GetSteamPath()
        {
            const string steamRegistryKey = @"Software\Valve\Steam";
            const string steamRegistryValue = "SteamPath";

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(steamRegistryKey))
            {
                if (key != null)
                {
                    object value = key.GetValue(steamRegistryValue);
                    if (value != null)
                    {
                        return value.ToString();
                    }
                }
            }

            return null;
        }

        private static string SelectFolder()
        {
            using (FolderBrowserDialog folder_browser_dialogue = new FolderBrowserDialog())
            {
                //folder_browser_dialogue.InitialDirectory = @"c:\";
                var steam_apps_path = GetSteamPath();
                if (steam_apps_path != null)
                {
                    Debug.WriteLine(steam_apps_path);
                    //folder_browser_dialogue.InitialDirectory = steam_apps_path + @"\steamapps\common";
                }
                else
                {
                    Debug.WriteLine("steam path not found from registery");
                }
                if (folder_browser_dialogue.ShowDialog() == DialogResult.OK)
                {
                    return folder_browser_dialogue.SelectedPath;
                }
            }
            return "";
        }

        private void MCCPathButton_Click(object sender, EventArgs e)
        {
            MCCPathBox.Text = SelectFolder();
        }

        private void EKPathButton_Click(object sender, EventArgs e)
        {
            EKPathBox.Text = SelectFolder();
        }

        private async void begin_randomization_button_Click(object sender, EventArgs e)
        {
            begin_randomization_button.Enabled = false;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            var progress = new Progress<int>(v => { progressBar1.Value = v; });
            var text_progress = new Progress<string>(v => { progress_label.Text += v + "\n"; });
            await Task.Run(() => begin_randomization(progress, text_progress));
            begin_randomization_button.Enabled = true;
        }

        private void begin_randomization(IProgress<int> progress, IProgress<string> text_progress)
        {
            int seed = 0;
            foreach (char c in seed_box.Text)
            {
                seed += c % 200;
            }
            Settings.Seed = seed;
            Settings.MCCPath = MCCPathBox.Text;
            Settings.EkPath = EKPathBox.Text;
            Settings.RandomizeSquads = randomize_squads_checkbox.Checked;
            Settings.GiveVehicleChance = (float)give_vehicle_updown.Value;
            //Settings.MakeMuleChance = (float)mule_updown.Value;
            Settings.MakeHunterChance = (float)hunter_chance_updown.Value;
            //Settings.MakeEngineerChance = (float)engineer_chance_updown.Value;
            Settings.SquadSizeMultiplier = (float)squad_size_multiplier_updown.Value;
            Settings.RandomizeVehicles = randomize_vehicles_checkbox.Checked;
            Settings.RandomizeWeapons = randomize_weapons_checkbox.Checked;
            Settings.RandomizeEquipments = randomize_equipment_checkbox.Checked;
            Settings.RandomizeEnvironmentalObjects = randomize_objects_checkbox.Checked;
            Settings.RandomizeWeaponStashTypes = randomize_weapon_stash_type_checkbox.Checked;
            Settings.RandomizeCutscenes = randomize_cutscenes_checkbox.Checked;
            Settings.RandomizeStartingProfiles = randomize_starting_profiles_checkbox.Checked;
            SetCompatibleCharacters();
            Randomizer.Randomize(Settings, progress, text_progress);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void SetCharactersAllCompatible()
        {
            List<CheckedListBox> checkedListBoxes = new List<CheckedListBox>() { humanCompatabilityCheckedListBox, covenantCompatabilityCheckedListBox, eliteCompatabilityCheckedListBox, floodCompatabilityCheckedListBox, forerunnerCompatabilityCheckedListBox };
            foreach (CheckedListBox checkedListBox in checkedListBoxes)
            {
                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    checkedListBox.SetItemChecked(i, true);
                }
            }
        }

        private void SetCompatibleCharacters()
        {
            SetCompatibleCharacters(RandomizerSettings.HumanCompatability, humanCompatabilityCheckedListBox);
            SetCompatibleCharacters(RandomizerSettings.CovenantCompatability, covenantCompatabilityCheckedListBox);
            SetCompatibleCharacters(RandomizerSettings.EliteCompatability, eliteCompatabilityCheckedListBox);
            SetCompatibleCharacters(RandomizerSettings.FloodCompatability, floodCompatabilityCheckedListBox);
            SetCompatibleCharacters(RandomizerSettings.ForerunnerCompatability, forerunnerCompatabilityCheckedListBox);
        }

        private void SetCompatibleCharacters(RandomizerSettings.FactionCompatability factionCompatability, CheckedListBox factionCheckedListBox)
        {
            factionCompatability.RemoveAllCompatibleFactions();
            for (int i = 0; i < factionCheckedListBox.Items.Count; i++)
            {
                switch (factionCheckedListBox.Items[i])
                {
                    case "human":
                        factionCompatability.AddCompatibleFaction(RandomizedItems.Faction.Human);
                        break;
                    case "covenant":
                        factionCompatability.AddCompatibleFaction(RandomizedItems.Faction.Covenant);
                        break;
                    case "elite":
                        factionCompatability.AddCompatibleFaction(RandomizedItems.Faction.Elite);
                        break;
                    case "flood":
                        factionCompatability.AddCompatibleFaction(RandomizedItems.Faction.Flood);
                        break;
                    case "forerunner":
                        factionCompatability.AddCompatibleFaction(RandomizedItems.Faction.Forerunner);
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetCharactersAllCompatible();
        }
    }
}
