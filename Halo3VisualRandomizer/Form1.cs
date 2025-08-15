using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Halo3VisualRandomizer.RandomizedItems.RandomizedItems;
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
            tabControl1.Enabled = false;
            tableLayoutPanelPaths.Enabled = false;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            var progress = new Progress<int>(v => { progressBar1.Value = v; });
            var text_progress = new Progress<string>(v => { progress_label.Text += v + "\n"; });
            await Task.Run(() => begin_randomization(progress, text_progress));
            tabControl1.Enabled = true;
            tableLayoutPanelPaths.Enabled = true;
            begin_randomization_button.Enabled = true;
        }

        private void begin_randomization(IProgress<int> progress, IProgress<string> text_progress)
        {
            SetCompatibleCharacters();
            CopyManagedBlam();
            Randomizer.Randomize(Settings, progress, text_progress);
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
                if (!factionCheckedListBox.GetItemChecked(i))
                {
                    continue; // Skip unchecked items
                }
                switch (factionCheckedListBox.Items[i])
                {
                    case "human":
                        factionCompatability.AddCompatibleFaction(Faction.Human);
                        break;
                    case "covenant":
                        factionCompatability.AddCompatibleFaction(Faction.Covenant);
                        break;
                    case "elite":
                        factionCompatability.AddCompatibleFaction(Faction.Elite);
                        break;
                    case "flood":
                        factionCompatability.AddCompatibleFaction(Faction.Flood);
                        break;
                    case "forerunner":
                        factionCompatability.AddCompatibleFaction(Faction.Forerunner);
                        break;
                }
            }
            Debug.WriteLine($"Faction: {factionCompatability.Faction} Compatible Factions: {string.Join(", ", factionCompatability.CompatibleFactions)}");
        }



        private void SetUpWeightTable(TableLayoutPanel panel, RandomizedObjectList objectList)
        {
            panel.RowCount = 0;
            panel.RowStyles.Clear();
            panel.RowCount++;
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panel.Controls.Add(new Label() { Text = "Name", AutoSize = true }, 0, panel.RowCount - 1);
            panel.Controls.Add(new Label() { Text = "Weight", AutoSize = true }, 1, panel.RowCount - 1);
            foreach (var item in objectList.List)
            {
                if (!item.Editable)
                {
                    continue; // Skip items that are not editable
                }
                panel.RowCount++;
                panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                panel.Controls.Add(new Label() { Text = item.FancyName, AutoSize = true, Anchor = AnchorStyles.Left}, 0, panel.RowCount - 1);
                var updown = new NumericUpDown()
                {
                    Minimum = 0,
                    Maximum = 100,
                    Value = item.Weight,
                    Name = item.Name + "_weight",
                    Tag = item

                };
                updown.DataBindings.Add("Value", item, "Weight", true, DataSourceUpdateMode.OnPropertyChanged);
                panel.Controls.Add(updown, 1, panel.RowCount - 1);

            }
        }

        private void SetUpLevelsTable(TableLayoutPanel panel)
        {
            panel.RowCount = 0;
            panel.RowStyles.Clear();
            panel.RowCount++;
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panel.Controls.Add(new Label() { Text = "Name", AutoSize = true }, 0, panel.RowCount - 1);
            panel.Controls.Add(new Label() { Text = "Randomize", AutoSize = true }, 1, panel.RowCount - 1);
            foreach (var level in Levels)
            {

                panel.RowCount++;
                panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                panel.Controls.Add(new Label() { Text = level.FancyName, AutoSize = true, Anchor = AnchorStyles.Left }, 0, panel.RowCount - 1);
                var checkbox = new CheckBox()
                {
                    Checked = level.Randomize,
                    Name = level.Name + "_randomize",
                    Tag = level
                };
                checkbox.DataBindings.Add("Checked", level, "Randomize", true, DataSourceUpdateMode.OnPropertyChanged);
                panel.Controls.Add(checkbox, 1, panel.RowCount - 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetCharactersAllCompatible();
            SetUpWeightTable(tableLayoutPanelCharacters, RandomizedItems.RandomizedItems.characters);
            SetUpWeightTable(tableLayoutPanelWeapons, RandomizedItems.RandomizedItems.weapons);
            SetUpWeightTable(tableLayoutPanelVehicles, RandomizedItems.RandomizedItems.vehicles);
            SetUpWeightTable(tableLayoutPanelEquipment, RandomizedItems.RandomizedItems.equipments);
            SetUpLevelsTable(tableLayoutPanelLevels);
            seed_box.DataBindings.Add("Text", Settings, "SeedString", true, DataSourceUpdateMode.OnPropertyChanged); 
            MCCPathBox.DataBindings.Add("Text", Settings, "MCCPath", true, DataSourceUpdateMode.OnPropertyChanged);
            EKPathBox.DataBindings.Add("Text", Settings, "EkPath", true, DataSourceUpdateMode.OnPropertyChanged);
            randomize_squads_checkbox.DataBindings.Add("Checked", Settings, "RandomizeSquads", true, DataSourceUpdateMode.OnPropertyChanged);
            give_vehicle_updown.DataBindings.Add("Value", Settings, "GiveVehicleChance", true, DataSourceUpdateMode.OnPropertyChanged);
            //mule_updown.DataBindings.Add("Value", Settings, "MakeMuleChance", true, DataSourceUpdateMode.OnPropertyChanged);
            hunter_chance_updown.DataBindings.Add("Value", Settings, "MakeHunterChance", true, DataSourceUpdateMode.OnPropertyChanged);
            squad_size_multiplier_updown.DataBindings.Add("Value", Settings, "SquadSizeMultiplier", true, DataSourceUpdateMode.OnPropertyChanged);
            randomize_vehicles_checkbox.DataBindings.Add("Checked", Settings, "RandomizeVehicles", true, DataSourceUpdateMode.OnPropertyChanged);
            randomize_weapons_checkbox.DataBindings.Add("Checked", Settings, "RandomizeWeapons", true, DataSourceUpdateMode.OnPropertyChanged);
            randomize_equipment_checkbox.DataBindings.Add("Checked", Settings, "RandomizeEquipments", true, DataSourceUpdateMode.OnPropertyChanged);
            randomize_objects_checkbox.DataBindings.Add("Checked", Settings, "RandomizeEnvironmentalObjects", true, DataSourceUpdateMode.OnPropertyChanged);
            randomize_weapon_stash_type_checkbox.DataBindings.Add("Checked", Settings, "RandomizeWeaponStashTypes", true, DataSourceUpdateMode.OnPropertyChanged);
            randomize_cutscenes_checkbox.DataBindings.Add("Checked", Settings, "RandomizeCutscenes", true, DataSourceUpdateMode.OnPropertyChanged);
            randomize_starting_profiles_checkbox.DataBindings.Add("Checked", Settings, "RandomizeStartingProfiles", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public void CopyManagedBlam()
        {
            string fileToCopy = Settings.EkPath + @"\bin\ManagedBlam.dll";
            string destinationDirectory = "";
            if (!File.Exists(fileToCopy))
            {
                throw new Exception("ManagedBlam.dll not found. Make sure EK path is correct");
            }
            if (!File.Exists(@"ManagedBlam.dll"))
            {
                Debug.WriteLine("Copying ManagedBlam from EK");
                File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy), true);
                if (!File.Exists(@"ManagedBlam.dll"))
                {
                    throw new Exception("failed to copy ManagedBlam.dll");
                }
            }
        }
    }
}
