using System.Drawing;
using System.Windows.Forms;

namespace Halo3VisualRandomizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.begin_randomization_button = new System.Windows.Forms.Button();
            this.EKPathBox = new System.Windows.Forms.TextBox();
            this.MCCPathBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelPaths = new System.Windows.Forms.TableLayoutPanel();
            this.MCCPathButton = new System.Windows.Forms.Button();
            this.EKPathButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progress_label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.forerunnerCompatabilityCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.floodCompatabilityCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.humanCompatabilityCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.covenantCompatabilityCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.eliteCompatabilityCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanelCharacters = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.squad_size_multiplier_updown = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.hunter_chance_updown = new System.Windows.Forms.NumericUpDown();
            this.hunter_chance_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.seed_box = new System.Windows.Forms.TextBox();
            this.randomize_squads_label = new System.Windows.Forms.Label();
            this.randomize_squads_checkbox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.randomize_cutscenes_checkbox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.randomize_weapon_stash_type_checkbox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.randomize_objects_checkbox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.randomize_equipment_checkbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.randomize_weapons_checkbox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.randomize_vehicles_checkbox = new System.Windows.Forms.CheckBox();
            this.give_vehicle_label = new System.Windows.Forms.Label();
            this.give_vehicle_updown = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelWeapons = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelVehicles = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelEquipment = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelLevels = new System.Windows.Forms.TableLayoutPanel();
            this.randomize_starting_profiles_checkbox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.randomize_squad_characters_checkbox = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.randomize_squad_weapons_checkbox = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.randomize_squad_vehicles_checkbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanelPaths.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squad_size_multiplier_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hunter_chance_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.give_vehicle_updown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // begin_randomization_button
            // 
            this.begin_randomization_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.begin_randomization_button.Location = new System.Drawing.Point(1985, 777);
            this.begin_randomization_button.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.begin_randomization_button.Name = "begin_randomization_button";
            this.begin_randomization_button.Size = new System.Drawing.Size(607, 68);
            this.begin_randomization_button.TabIndex = 1;
            this.begin_randomization_button.Text = "Start Randomization";
            this.begin_randomization_button.UseVisualStyleBackColor = true;
            this.begin_randomization_button.Click += new System.EventHandler(this.begin_randomization_button_Click);
            // 
            // EKPathBox
            // 
            this.EKPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EKPathBox.Location = new System.Drawing.Point(5, 60);
            this.EKPathBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EKPathBox.Name = "EKPathBox";
            this.EKPathBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EKPathBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.EKPathBox.Size = new System.Drawing.Size(976, 35);
            this.EKPathBox.TabIndex = 3;
            this.EKPathBox.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\H3EK";
            // 
            // MCCPathBox
            // 
            this.MCCPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MCCPathBox.Location = new System.Drawing.Point(5, 4);
            this.MCCPathBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MCCPathBox.Name = "MCCPathBox";
            this.MCCPathBox.Size = new System.Drawing.Size(976, 35);
            this.MCCPathBox.TabIndex = 4;
            this.MCCPathBox.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Halo The Master Chief Collection";
            // 
            // tableLayoutPanelPaths
            // 
            this.tableLayoutPanelPaths.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPaths.ColumnCount = 2;
            this.tableLayoutPanelPaths.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanelPaths.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanelPaths.Controls.Add(this.MCCPathBox, 0, 0);
            this.tableLayoutPanelPaths.Controls.Add(this.EKPathBox, 0, 1);
            this.tableLayoutPanelPaths.Controls.Add(this.MCCPathButton, 1, 0);
            this.tableLayoutPanelPaths.Controls.Add(this.EKPathButton, 1, 1);
            this.tableLayoutPanelPaths.Location = new System.Drawing.Point(1012, 648);
            this.tableLayoutPanelPaths.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanelPaths.Name = "tableLayoutPanelPaths";
            this.tableLayoutPanelPaths.RowCount = 2;
            this.tableLayoutPanelPaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPaths.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPaths.Size = new System.Drawing.Size(1579, 112);
            this.tableLayoutPanelPaths.TabIndex = 9;
            // 
            // MCCPathButton
            // 
            this.MCCPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MCCPathButton.Location = new System.Drawing.Point(991, 4);
            this.MCCPathButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MCCPathButton.Name = "MCCPathButton";
            this.MCCPathButton.Size = new System.Drawing.Size(583, 46);
            this.MCCPathButton.TabIndex = 5;
            this.MCCPathButton.Text = "Select MCC Folder";
            this.MCCPathButton.UseVisualStyleBackColor = true;
            this.MCCPathButton.Click += new System.EventHandler(this.MCCPathButton_Click);
            // 
            // EKPathButton
            // 
            this.EKPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EKPathButton.Location = new System.Drawing.Point(991, 60);
            this.EKPathButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EKPathButton.Name = "EKPathButton";
            this.EKPathButton.Size = new System.Drawing.Size(583, 46);
            this.EKPathButton.TabIndex = 6;
            this.EKPathButton.Text = "Select H3EK Folder";
            this.EKPathButton.UseVisualStyleBackColor = true;
            this.EKPathButton.Click += new System.EventHandler(this.EKPathButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(1017, 787);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(935, 48);
            this.progressBar1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.progress_label);
            this.panel1.Location = new System.Drawing.Point(1013, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1578, 607);
            this.panel1.TabIndex = 11;
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.Location = new System.Drawing.Point(19, 16);
            this.progress_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(0, 29);
            this.progress_label.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Controls.Add(this.tableLayoutPanelCharacters);
            this.tabPage3.Location = new System.Drawing.Point(10, 47);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(963, 775);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Characters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.MaximumSize = new System.Drawing.Size(750, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 58);
            this.label1.TabIndex = 17;
            this.label1.Text = "What factions the characters of each faction can randomize into (when possible wi" +
    "thout softlocking)";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.forerunnerCompatabilityCheckedListBox, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.floodCompatabilityCheckedListBox, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.label14, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label13, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.humanCompatabilityCheckedListBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.covenantCompatabilityCheckedListBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.eliteCompatabilityCheckedListBox, 2, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 95);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.00966F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.99034F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(885, 237);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // forerunnerCompatabilityCheckedListBox
            // 
            this.forerunnerCompatabilityCheckedListBox.FormattingEnabled = true;
            this.forerunnerCompatabilityCheckedListBox.Items.AddRange(new object[] {
            "human",
            "covenant",
            "elite",
            "forerunner",
            "flood"});
            this.forerunnerCompatabilityCheckedListBox.Location = new System.Drawing.Point(713, 37);
            this.forerunnerCompatabilityCheckedListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.forerunnerCompatabilityCheckedListBox.Name = "forerunnerCompatabilityCheckedListBox";
            this.forerunnerCompatabilityCheckedListBox.Size = new System.Drawing.Size(167, 196);
            this.forerunnerCompatabilityCheckedListBox.TabIndex = 36;
            // 
            // floodCompatabilityCheckedListBox
            // 
            this.floodCompatabilityCheckedListBox.FormattingEnabled = true;
            this.floodCompatabilityCheckedListBox.Items.AddRange(new object[] {
            "human",
            "covenant",
            "elite",
            "forerunner",
            "flood"});
            this.floodCompatabilityCheckedListBox.Location = new System.Drawing.Point(536, 37);
            this.floodCompatabilityCheckedListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.floodCompatabilityCheckedListBox.Name = "floodCompatabilityCheckedListBox";
            this.floodCompatabilityCheckedListBox.Size = new System.Drawing.Size(167, 196);
            this.floodCompatabilityCheckedListBox.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(713, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 33);
            this.label14.TabIndex = 34;
            this.label14.Text = "Forerunner";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(536, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 33);
            this.label13.TabIndex = 33;
            this.label13.Text = "Flood";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 33);
            this.label12.TabIndex = 32;
            this.label12.Text = "Elite";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 33);
            this.label11.TabIndex = 29;
            this.label11.Text = "Covenant";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "Human";
            // 
            // humanCompatabilityCheckedListBox
            // 
            this.humanCompatabilityCheckedListBox.FormattingEnabled = true;
            this.humanCompatabilityCheckedListBox.Items.AddRange(new object[] {
            "human",
            "covenant",
            "elite",
            "forerunner",
            "flood"});
            this.humanCompatabilityCheckedListBox.Location = new System.Drawing.Point(5, 37);
            this.humanCompatabilityCheckedListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.humanCompatabilityCheckedListBox.Name = "humanCompatabilityCheckedListBox";
            this.humanCompatabilityCheckedListBox.Size = new System.Drawing.Size(167, 196);
            this.humanCompatabilityCheckedListBox.TabIndex = 28;
            // 
            // covenantCompatabilityCheckedListBox
            // 
            this.covenantCompatabilityCheckedListBox.FormattingEnabled = true;
            this.covenantCompatabilityCheckedListBox.Items.AddRange(new object[] {
            "human",
            "covenant",
            "elite",
            "forerunner",
            "flood"});
            this.covenantCompatabilityCheckedListBox.Location = new System.Drawing.Point(182, 37);
            this.covenantCompatabilityCheckedListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.covenantCompatabilityCheckedListBox.Name = "covenantCompatabilityCheckedListBox";
            this.covenantCompatabilityCheckedListBox.Size = new System.Drawing.Size(167, 196);
            this.covenantCompatabilityCheckedListBox.TabIndex = 30;
            // 
            // eliteCompatabilityCheckedListBox
            // 
            this.eliteCompatabilityCheckedListBox.FormattingEnabled = true;
            this.eliteCompatabilityCheckedListBox.Items.AddRange(new object[] {
            "human",
            "covenant",
            "elite",
            "forerunner",
            "flood"});
            this.eliteCompatabilityCheckedListBox.Location = new System.Drawing.Point(359, 37);
            this.eliteCompatabilityCheckedListBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.eliteCompatabilityCheckedListBox.Name = "eliteCompatabilityCheckedListBox";
            this.eliteCompatabilityCheckedListBox.Size = new System.Drawing.Size(167, 196);
            this.eliteCompatabilityCheckedListBox.TabIndex = 31;
            // 
            // tableLayoutPanelCharacters
            // 
            this.tableLayoutPanelCharacters.AutoSize = true;
            this.tableLayoutPanelCharacters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelCharacters.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelCharacters.ColumnCount = 2;
            this.tableLayoutPanelCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharacters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharacters.Location = new System.Drawing.Point(6, 363);
            this.tableLayoutPanelCharacters.Name = "tableLayoutPanelCharacters";
            this.tableLayoutPanelCharacters.RowCount = 1;
            this.tableLayoutPanelCharacters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCharacters.Size = new System.Drawing.Size(3, 2);
            this.tableLayoutPanelCharacters.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 832);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 775);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.randomize_squad_vehicles_checkbox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.randomize_squad_weapons_checkbox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.randomize_squad_characters_checkbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.squad_size_multiplier_updown, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.hunter_chance_updown, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.hunter_chance_label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.seed_box, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.randomize_squads_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.randomize_squads_checkbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.randomize_starting_profiles_checkbox, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.randomize_cutscenes_checkbox, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.randomize_weapon_stash_type_checkbox, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.randomize_objects_checkbox, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.randomize_equipment_checkbox, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.randomize_weapons_checkbox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.randomize_vehicles_checkbox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.give_vehicle_label, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.give_vehicle_updown, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(894, 573);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // squad_size_multiplier_updown
            // 
            this.squad_size_multiplier_updown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.squad_size_multiplier_updown.DecimalPlaces = 3;
            this.squad_size_multiplier_updown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.squad_size_multiplier_updown.Location = new System.Drawing.Point(636, 281);
            this.squad_size_multiplier_updown.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.squad_size_multiplier_updown.Name = "squad_size_multiplier_updown";
            this.squad_size_multiplier_updown.Size = new System.Drawing.Size(252, 35);
            this.squad_size_multiplier_updown.TabIndex = 27;
            this.squad_size_multiplier_updown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 277);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(497, 43);
            this.label15.TabIndex = 26;
            this.label15.Text = "Squad size multiplier (unstable when not at 1)";
            // 
            // hunter_chance_updown
            // 
            this.hunter_chance_updown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hunter_chance_updown.DecimalPlaces = 3;
            this.hunter_chance_updown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.hunter_chance_updown.Location = new System.Drawing.Point(636, 193);
            this.hunter_chance_updown.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.hunter_chance_updown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hunter_chance_updown.Name = "hunter_chance_updown";
            this.hunter_chance_updown.Size = new System.Drawing.Size(252, 35);
            this.hunter_chance_updown.TabIndex = 7;
            this.hunter_chance_updown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // hunter_chance_label
            // 
            this.hunter_chance_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.hunter_chance_label.AutoSize = true;
            this.hunter_chance_label.Location = new System.Drawing.Point(6, 189);
            this.hunter_chance_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hunter_chance_label.Name = "hunter_chance_label";
            this.hunter_chance_label.Size = new System.Drawing.Size(619, 43);
            this.hunter_chance_label.TabIndex = 6;
            this.hunter_chance_label.Text = "Overwrite squad with hunter chance (with hunter fuel rod)";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 43);
            this.label8.TabIndex = 20;
            this.label8.Text = "Seed";
            // 
            // seed_box
            // 
            this.seed_box.Location = new System.Drawing.Point(636, 5);
            this.seed_box.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.seed_box.Name = "seed_box";
            this.seed_box.Size = new System.Drawing.Size(208, 35);
            this.seed_box.TabIndex = 21;
            // 
            // randomize_squads_label
            // 
            this.randomize_squads_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_squads_label.AutoSize = true;
            this.randomize_squads_label.Location = new System.Drawing.Point(6, 45);
            this.randomize_squads_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.randomize_squads_label.Name = "randomize_squads_label";
            this.randomize_squads_label.Size = new System.Drawing.Size(219, 35);
            this.randomize_squads_label.TabIndex = 0;
            this.randomize_squads_label.Text = "Randomize squads";
            // 
            // randomize_squads_checkbox
            // 
            this.randomize_squads_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_squads_checkbox.AutoSize = true;
            this.randomize_squads_checkbox.Checked = true;
            this.randomize_squads_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomize_squads_checkbox.Location = new System.Drawing.Point(636, 49);
            this.randomize_squads_checkbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.randomize_squads_checkbox.Name = "randomize_squads_checkbox";
            this.randomize_squads_checkbox.Size = new System.Drawing.Size(28, 27);
            this.randomize_squads_checkbox.TabIndex = 1;
            this.randomize_squads_checkbox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 501);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(539, 35);
            this.label9.TabIndex = 22;
            this.label9.Text = "Randomize cutscene dialogue and biped variants";
            // 
            // randomize_cutscenes_checkbox
            // 
            this.randomize_cutscenes_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_cutscenes_checkbox.AutoSize = true;
            this.randomize_cutscenes_checkbox.Checked = true;
            this.randomize_cutscenes_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomize_cutscenes_checkbox.Location = new System.Drawing.Point(636, 505);
            this.randomize_cutscenes_checkbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.randomize_cutscenes_checkbox.Name = "randomize_cutscenes_checkbox";
            this.randomize_cutscenes_checkbox.Size = new System.Drawing.Size(28, 27);
            this.randomize_cutscenes_checkbox.TabIndex = 23;
            this.randomize_cutscenes_checkbox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 465);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(612, 35);
            this.label7.TabIndex = 18;
            this.label7.Text = "Weapon stashes won\'t only randomize to similar variants";
            // 
            // randomize_weapon_stash_type_checkbox
            // 
            this.randomize_weapon_stash_type_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_weapon_stash_type_checkbox.AutoSize = true;
            this.randomize_weapon_stash_type_checkbox.Location = new System.Drawing.Point(636, 469);
            this.randomize_weapon_stash_type_checkbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.randomize_weapon_stash_type_checkbox.Name = "randomize_weapon_stash_type_checkbox";
            this.randomize_weapon_stash_type_checkbox.Size = new System.Drawing.Size(28, 27);
            this.randomize_weapon_stash_type_checkbox.TabIndex = 19;
            this.randomize_weapon_stash_type_checkbox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 429);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(315, 35);
            this.label6.TabIndex = 16;
            this.label6.Text = "Randomize weapon stashes";
            // 
            // randomize_objects_checkbox
            // 
            this.randomize_objects_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_objects_checkbox.AutoSize = true;
            this.randomize_objects_checkbox.Checked = true;
            this.randomize_objects_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomize_objects_checkbox.Location = new System.Drawing.Point(636, 433);
            this.randomize_objects_checkbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.randomize_objects_checkbox.Name = "randomize_objects_checkbox";
            this.randomize_objects_checkbox.Size = new System.Drawing.Size(28, 27);
            this.randomize_objects_checkbox.TabIndex = 17;
            this.randomize_objects_checkbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 393);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(430, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "Randomize world equipment/grenades";
            // 
            // randomize_equipment_checkbox
            // 
            this.randomize_equipment_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_equipment_checkbox.AutoSize = true;
            this.randomize_equipment_checkbox.Checked = true;
            this.randomize_equipment_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomize_equipment_checkbox.Location = new System.Drawing.Point(636, 397);
            this.randomize_equipment_checkbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.randomize_equipment_checkbox.Name = "randomize_equipment_checkbox";
            this.randomize_equipment_checkbox.Size = new System.Drawing.Size(28, 27);
            this.randomize_equipment_checkbox.TabIndex = 15;
            this.randomize_equipment_checkbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 357);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Randomize world weapons";
            // 
            // randomize_weapons_checkbox
            // 
            this.randomize_weapons_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_weapons_checkbox.AutoSize = true;
            this.randomize_weapons_checkbox.Checked = true;
            this.randomize_weapons_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomize_weapons_checkbox.Location = new System.Drawing.Point(636, 361);
            this.randomize_weapons_checkbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.randomize_weapons_checkbox.Name = "randomize_weapons_checkbox";
            this.randomize_weapons_checkbox.Size = new System.Drawing.Size(28, 27);
            this.randomize_weapons_checkbox.TabIndex = 13;
            this.randomize_weapons_checkbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 321);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Randomize world vehicles";
            // 
            // randomize_vehicles_checkbox
            // 
            this.randomize_vehicles_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_vehicles_checkbox.AutoSize = true;
            this.randomize_vehicles_checkbox.Checked = true;
            this.randomize_vehicles_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomize_vehicles_checkbox.Location = new System.Drawing.Point(636, 325);
            this.randomize_vehicles_checkbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.randomize_vehicles_checkbox.Name = "randomize_vehicles_checkbox";
            this.randomize_vehicles_checkbox.Size = new System.Drawing.Size(28, 27);
            this.randomize_vehicles_checkbox.TabIndex = 11;
            this.randomize_vehicles_checkbox.UseVisualStyleBackColor = true;
            // 
            // give_vehicle_label
            // 
            this.give_vehicle_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.give_vehicle_label.AutoSize = true;
            this.give_vehicle_label.Location = new System.Drawing.Point(6, 233);
            this.give_vehicle_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.give_vehicle_label.Name = "give_vehicle_label";
            this.give_vehicle_label.Size = new System.Drawing.Size(299, 43);
            this.give_vehicle_label.TabIndex = 2;
            this.give_vehicle_label.Text = "Give squad vehicle chance";
            // 
            // give_vehicle_updown
            // 
            this.give_vehicle_updown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.give_vehicle_updown.DecimalPlaces = 3;
            this.give_vehicle_updown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.give_vehicle_updown.Location = new System.Drawing.Point(636, 237);
            this.give_vehicle_updown.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.give_vehicle_updown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.give_vehicle_updown.Name = "give_vehicle_updown";
            this.give_vehicle_updown.Size = new System.Drawing.Size(252, 35);
            this.give_vehicle_updown.TabIndex = 3;
            this.give_vehicle_updown.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tableLayoutPanelWeapons);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(963, 775);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Weapons";
            // 
            // tableLayoutPanelWeapons
            // 
            this.tableLayoutPanelWeapons.AutoSize = true;
            this.tableLayoutPanelWeapons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelWeapons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelWeapons.ColumnCount = 2;
            this.tableLayoutPanelWeapons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWeapons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWeapons.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelWeapons.Name = "tableLayoutPanelWeapons";
            this.tableLayoutPanelWeapons.RowCount = 1;
            this.tableLayoutPanelWeapons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWeapons.Size = new System.Drawing.Size(3, 2);
            this.tableLayoutPanelWeapons.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.tableLayoutPanelVehicles);
            this.tabPage4.Location = new System.Drawing.Point(10, 47);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(963, 775);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Vehicles";
            // 
            // tableLayoutPanelVehicles
            // 
            this.tableLayoutPanelVehicles.AutoSize = true;
            this.tableLayoutPanelVehicles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelVehicles.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelVehicles.ColumnCount = 2;
            this.tableLayoutPanelVehicles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVehicles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVehicles.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelVehicles.Name = "tableLayoutPanelVehicles";
            this.tableLayoutPanelVehicles.RowCount = 1;
            this.tableLayoutPanelVehicles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelVehicles.Size = new System.Drawing.Size(3, 2);
            this.tableLayoutPanelVehicles.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.tableLayoutPanelEquipment);
            this.tabPage5.Location = new System.Drawing.Point(10, 47);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(963, 775);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Equipment";
            // 
            // tableLayoutPanelEquipment
            // 
            this.tableLayoutPanelEquipment.AutoSize = true;
            this.tableLayoutPanelEquipment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelEquipment.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelEquipment.ColumnCount = 2;
            this.tableLayoutPanelEquipment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEquipment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEquipment.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelEquipment.Name = "tableLayoutPanelEquipment";
            this.tableLayoutPanelEquipment.RowCount = 1;
            this.tableLayoutPanelEquipment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEquipment.Size = new System.Drawing.Size(3, 2);
            this.tableLayoutPanelEquipment.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.tableLayoutPanelLevels);
            this.tabPage6.Location = new System.Drawing.Point(10, 47);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(963, 775);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "Levels";
            // 
            // tableLayoutPanelLevels
            // 
            this.tableLayoutPanelLevels.AutoSize = true;
            this.tableLayoutPanelLevels.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelLevels.ColumnCount = 2;
            this.tableLayoutPanelLevels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLevels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLevels.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanelLevels.Name = "tableLayoutPanelLevels";
            this.tableLayoutPanelLevels.RowCount = 2;
            this.tableLayoutPanelLevels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLevels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLevels.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanelLevels.TabIndex = 15;
            // 
            // randomize_starting_profiles_checkbox
            // 
            this.randomize_starting_profiles_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_starting_profiles_checkbox.AutoSize = true;
            this.randomize_starting_profiles_checkbox.Checked = true;
            this.randomize_starting_profiles_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomize_starting_profiles_checkbox.Location = new System.Drawing.Point(636, 541);
            this.randomize_starting_profiles_checkbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.randomize_starting_profiles_checkbox.Name = "randomize_starting_profiles_checkbox";
            this.randomize_starting_profiles_checkbox.Size = new System.Drawing.Size(28, 27);
            this.randomize_starting_profiles_checkbox.TabIndex = 25;
            this.randomize_starting_profiles_checkbox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 537);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(317, 35);
            this.label10.TabIndex = 28;
            this.label10.Text = "Randomize starting loadouts";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 81);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(324, 35);
            this.label16.TabIndex = 29;
            this.label16.Text = "Randomize squad characters";
            // 
            // randomize_squad_characters_checkbox
            // 
            this.randomize_squad_characters_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_squad_characters_checkbox.AutoSize = true;
            this.randomize_squad_characters_checkbox.Checked = true;
            this.randomize_squad_characters_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomize_squad_characters_checkbox.Location = new System.Drawing.Point(636, 85);
            this.randomize_squad_characters_checkbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.randomize_squad_characters_checkbox.Name = "randomize_squad_characters_checkbox";
            this.randomize_squad_characters_checkbox.Size = new System.Drawing.Size(28, 27);
            this.randomize_squad_characters_checkbox.TabIndex = 30;
            this.randomize_squad_characters_checkbox.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 117);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(311, 35);
            this.label17.TabIndex = 31;
            this.label17.Text = "Randomize squad weapons";
            // 
            // randomize_squad_weapons_checkbox
            // 
            this.randomize_squad_weapons_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_squad_weapons_checkbox.AutoSize = true;
            this.randomize_squad_weapons_checkbox.Checked = true;
            this.randomize_squad_weapons_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomize_squad_weapons_checkbox.Location = new System.Drawing.Point(636, 121);
            this.randomize_squad_weapons_checkbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.randomize_squad_weapons_checkbox.Name = "randomize_squad_weapons_checkbox";
            this.randomize_squad_weapons_checkbox.Size = new System.Drawing.Size(28, 27);
            this.randomize_squad_weapons_checkbox.TabIndex = 32;
            this.randomize_squad_weapons_checkbox.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 153);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(301, 35);
            this.label18.TabIndex = 33;
            this.label18.Text = "Randomize squad vehicles";
            // 
            // randomize_squad_vehicles_checkbox
            // 
            this.randomize_squad_vehicles_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_squad_vehicles_checkbox.AutoSize = true;
            this.randomize_squad_vehicles_checkbox.Checked = true;
            this.randomize_squad_vehicles_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomize_squad_vehicles_checkbox.Location = new System.Drawing.Point(636, 157);
            this.randomize_squad_vehicles_checkbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.randomize_squad_vehicles_checkbox.Name = "randomize_squad_vehicles_checkbox";
            this.randomize_squad_vehicles_checkbox.Size = new System.Drawing.Size(28, 27);
            this.randomize_squad_vehicles_checkbox.TabIndex = 34;
            this.randomize_squad_vehicles_checkbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2641, 863);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tableLayoutPanelPaths);
            this.Controls.Add(this.begin_randomization_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Halo 3 Visual Randomizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanelPaths.ResumeLayout(false);
            this.tableLayoutPanelPaths.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squad_size_multiplier_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hunter_chance_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.give_vehicle_updown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button begin_randomization_button;
        private TextBox EKPathBox;
        private TextBox MCCPathBox;
        private TableLayoutPanel tableLayoutPanelPaths;
        private Button MCCPathButton;
        private Button EKPathButton;
        private ProgressBar progressBar1;
        private Panel panel1;
        private Label progress_label;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanelCharacters;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private CheckedListBox forerunnerCompatabilityCheckedListBox;
        private CheckedListBox floodCompatabilityCheckedListBox;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label2;
        private CheckedListBox humanCompatabilityCheckedListBox;
        private CheckedListBox covenantCompatabilityCheckedListBox;
        private CheckedListBox eliteCompatabilityCheckedListBox;
        private TableLayoutPanel tableLayoutPanel1;
        private NumericUpDown squad_size_multiplier_updown;
        private Label label15;
        private NumericUpDown hunter_chance_updown;
        private Label hunter_chance_label;
        private Label label8;
        private TextBox seed_box;
        private Label randomize_squads_label;
        private CheckBox randomize_squads_checkbox;
        private Label label9;
        private CheckBox randomize_cutscenes_checkbox;
        private Label label7;
        private CheckBox randomize_weapon_stash_type_checkbox;
        private Label label6;
        private CheckBox randomize_objects_checkbox;
        private Label label5;
        private CheckBox randomize_equipment_checkbox;
        private Label label4;
        private CheckBox randomize_weapons_checkbox;
        private Label label3;
        private CheckBox randomize_vehicles_checkbox;
        private Label give_vehicle_label;
        private NumericUpDown give_vehicle_updown;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TableLayoutPanel tableLayoutPanelWeapons;
        private TableLayoutPanel tableLayoutPanelVehicles;
        private TableLayoutPanel tableLayoutPanelEquipment;
        private TableLayoutPanel tableLayoutPanelLevels;
        private CheckBox randomize_starting_profiles_checkbox;
        private Label label17;
        private CheckBox randomize_squad_characters_checkbox;
        private Label label16;
        private Label label10;
        private CheckBox randomize_squad_vehicles_checkbox;
        private Label label18;
        private CheckBox randomize_squad_weapons_checkbox;
    }
}

