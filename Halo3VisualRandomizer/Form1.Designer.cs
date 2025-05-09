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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hunter_chance_updown = new System.Windows.Forms.NumericUpDown();
            this.hunter_chance_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.seed_box = new System.Windows.Forms.TextBox();
            this.randomize_squads_label = new System.Windows.Forms.Label();
            this.randomize_squads_checkbox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.randomize_starting_profiles_checkbox = new System.Windows.Forms.CheckBox();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.MCCPathButton = new System.Windows.Forms.Button();
            this.EKPathButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progress_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.humanCompatabilityCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.covenantCompatabilityCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.eliteCompatabilityCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.floodCompatabilityCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.forerunnerCompatabilityCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.give_vehicle_updown = new System.Windows.Forms.NumericUpDown();
            this.give_vehicle_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.squad_size_multiplier_updown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hunter_chance_updown)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.give_vehicle_updown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squad_size_multiplier_updown)).BeginInit();
            this.SuspendLayout();
            // 
            // begin_randomization_button
            // 
            this.begin_randomization_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.begin_randomization_button.Location = new System.Drawing.Point(1276, 536);
            this.begin_randomization_button.Name = "begin_randomization_button";
            this.begin_randomization_button.Size = new System.Drawing.Size(390, 47);
            this.begin_randomization_button.TabIndex = 1;
            this.begin_randomization_button.Text = "Start Randomization";
            this.begin_randomization_button.UseVisualStyleBackColor = true;
            this.begin_randomization_button.Click += new System.EventHandler(this.begin_randomization_button_Click);
            // 
            // EKPathBox
            // 
            this.EKPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EKPathBox.Location = new System.Drawing.Point(3, 41);
            this.EKPathBox.Name = "EKPathBox";
            this.EKPathBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EKPathBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.EKPathBox.Size = new System.Drawing.Size(628, 26);
            this.EKPathBox.TabIndex = 3;
            this.EKPathBox.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\H3EK";
            // 
            // MCCPathBox
            // 
            this.MCCPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MCCPathBox.Location = new System.Drawing.Point(3, 3);
            this.MCCPathBox.Name = "MCCPathBox";
            this.MCCPathBox.Size = new System.Drawing.Size(628, 26);
            this.MCCPathBox.TabIndex = 4;
            this.MCCPathBox.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Halo The Master Chief Collection";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.squad_size_multiplier_updown, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.hunter_chance_updown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.hunter_chance_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.seed_box, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.randomize_squads_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.randomize_squads_checkbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.randomize_starting_profiles_checkbox, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.randomize_cutscenes_checkbox, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.randomize_weapon_stash_type_checkbox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.randomize_objects_checkbox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.randomize_equipment_checkbox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.randomize_weapons_checkbox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.randomize_vehicles_checkbox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.give_vehicle_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.give_vehicle_updown, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 401);
            this.tableLayoutPanel1.TabIndex = 8;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
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
            this.hunter_chance_updown.Location = new System.Drawing.Point(395, 65);
            this.hunter_chance_updown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hunter_chance_updown.Name = "hunter_chance_updown";
            this.hunter_chance_updown.Size = new System.Drawing.Size(162, 26);
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
            this.hunter_chance_label.Location = new System.Drawing.Point(4, 62);
            this.hunter_chance_label.Name = "hunter_chance_label";
            this.hunter_chance_label.Size = new System.Drawing.Size(382, 40);
            this.hunter_chance_label.TabIndex = 6;
            this.hunter_chance_label.Text = "Overwrite squad with hunter chance (with hunter fuel rod)";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "Seed";
            // 
            // seed_box
            // 
            this.seed_box.Location = new System.Drawing.Point(395, 4);
            this.seed_box.Name = "seed_box";
            this.seed_box.Size = new System.Drawing.Size(135, 26);
            this.seed_box.TabIndex = 21;
            // 
            // randomize_squads_label
            // 
            this.randomize_squads_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_squads_label.AutoSize = true;
            this.randomize_squads_label.Location = new System.Drawing.Point(4, 34);
            this.randomize_squads_label.Name = "randomize_squads_label";
            this.randomize_squads_label.Size = new System.Drawing.Size(197, 27);
            this.randomize_squads_label.TabIndex = 0;
            this.randomize_squads_label.Text = "Randomize enemy squads";
            // 
            // randomize_squads_checkbox
            // 
            this.randomize_squads_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_squads_checkbox.AutoSize = true;
            this.randomize_squads_checkbox.Checked = true;
            this.randomize_squads_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomize_squads_checkbox.Location = new System.Drawing.Point(395, 37);
            this.randomize_squads_checkbox.Name = "randomize_squads_checkbox";
            this.randomize_squads_checkbox.Size = new System.Drawing.Size(22, 21);
            this.randomize_squads_checkbox.TabIndex = 1;
            this.randomize_squads_checkbox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 50);
            this.label10.TabIndex = 24;
            this.label10.Text = "Randomize starting loadouts";
            // 
            // randomize_starting_profiles_checkbox
            // 
            this.randomize_starting_profiles_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_starting_profiles_checkbox.AutoSize = true;
            this.randomize_starting_profiles_checkbox.Checked = true;
            this.randomize_starting_profiles_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randomize_starting_profiles_checkbox.Location = new System.Drawing.Point(395, 353);
            this.randomize_starting_profiles_checkbox.Name = "randomize_starting_profiles_checkbox";
            this.randomize_starting_profiles_checkbox.Size = new System.Drawing.Size(22, 44);
            this.randomize_starting_profiles_checkbox.TabIndex = 25;
            this.randomize_starting_profiles_checkbox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(356, 27);
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
            this.randomize_cutscenes_checkbox.Location = new System.Drawing.Point(395, 325);
            this.randomize_cutscenes_checkbox.Name = "randomize_cutscenes_checkbox";
            this.randomize_cutscenes_checkbox.Size = new System.Drawing.Size(22, 21);
            this.randomize_cutscenes_checkbox.TabIndex = 23;
            this.randomize_cutscenes_checkbox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(350, 40);
            this.label7.TabIndex = 18;
            this.label7.Text = "Weapon stashes won\'t only randomize to similar variants";
            // 
            // randomize_weapon_stash_type_checkbox
            // 
            this.randomize_weapon_stash_type_checkbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.randomize_weapon_stash_type_checkbox.AutoSize = true;
            this.randomize_weapon_stash_type_checkbox.Location = new System.Drawing.Point(395, 284);
            this.randomize_weapon_stash_type_checkbox.Name = "randomize_weapon_stash_type_checkbox";
            this.randomize_weapon_stash_type_checkbox.Size = new System.Drawing.Size(22, 34);
            this.randomize_weapon_stash_type_checkbox.TabIndex = 19;
            this.randomize_weapon_stash_type_checkbox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 27);
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
            this.randomize_objects_checkbox.Location = new System.Drawing.Point(395, 256);
            this.randomize_objects_checkbox.Name = "randomize_objects_checkbox";
            this.randomize_objects_checkbox.Size = new System.Drawing.Size(22, 21);
            this.randomize_objects_checkbox.TabIndex = 17;
            this.randomize_objects_checkbox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 27);
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
            this.randomize_equipment_checkbox.Location = new System.Drawing.Point(395, 228);
            this.randomize_equipment_checkbox.Name = "randomize_equipment_checkbox";
            this.randomize_equipment_checkbox.Size = new System.Drawing.Size(22, 21);
            this.randomize_equipment_checkbox.TabIndex = 15;
            this.randomize_equipment_checkbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 27);
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
            this.randomize_weapons_checkbox.Location = new System.Drawing.Point(395, 200);
            this.randomize_weapons_checkbox.Name = "randomize_weapons_checkbox";
            this.randomize_weapons_checkbox.Size = new System.Drawing.Size(22, 21);
            this.randomize_weapons_checkbox.TabIndex = 13;
            this.randomize_weapons_checkbox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 27);
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
            this.randomize_vehicles_checkbox.Location = new System.Drawing.Point(395, 172);
            this.randomize_vehicles_checkbox.Name = "randomize_vehicles_checkbox";
            this.randomize_vehicles_checkbox.Size = new System.Drawing.Size(22, 21);
            this.randomize_vehicles_checkbox.TabIndex = 11;
            this.randomize_vehicles_checkbox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel2.Controls.Add(this.MCCPathBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.EKPathBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.MCCPathButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.EKPathButton, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(651, 447);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1015, 76);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // MCCPathButton
            // 
            this.MCCPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MCCPathButton.Location = new System.Drawing.Point(637, 3);
            this.MCCPathButton.Name = "MCCPathButton";
            this.MCCPathButton.Size = new System.Drawing.Size(375, 32);
            this.MCCPathButton.TabIndex = 5;
            this.MCCPathButton.Text = "Select MCC Folder";
            this.MCCPathButton.UseVisualStyleBackColor = true;
            this.MCCPathButton.Click += new System.EventHandler(this.MCCPathButton_Click);
            // 
            // EKPathButton
            // 
            this.EKPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EKPathButton.Location = new System.Drawing.Point(637, 41);
            this.EKPathButton.Name = "EKPathButton";
            this.EKPathButton.Size = new System.Drawing.Size(375, 32);
            this.EKPathButton.TabIndex = 6;
            this.EKPathButton.Text = "Select H3EK Folder";
            this.EKPathButton.UseVisualStyleBackColor = true;
            this.EKPathButton.Click += new System.EventHandler(this.EKPathButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(654, 543);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(601, 33);
            this.progressBar1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.progress_label);
            this.panel1.Location = new System.Drawing.Point(651, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 417);
            this.panel1.TabIndex = 11;
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.Location = new System.Drawing.Point(12, 11);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(0, 20);
            this.progress_label.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 436);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.00966F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.99034F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(635, 147);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
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
            this.humanCompatabilityCheckedListBox.Location = new System.Drawing.Point(3, 23);
            this.humanCompatabilityCheckedListBox.Name = "humanCompatabilityCheckedListBox";
            this.humanCompatabilityCheckedListBox.Size = new System.Drawing.Size(120, 119);
            this.humanCompatabilityCheckedListBox.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Covenant";
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
            this.covenantCompatabilityCheckedListBox.Location = new System.Drawing.Point(129, 23);
            this.covenantCompatabilityCheckedListBox.Name = "covenantCompatabilityCheckedListBox";
            this.covenantCompatabilityCheckedListBox.Size = new System.Drawing.Size(120, 119);
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
            this.eliteCompatabilityCheckedListBox.Location = new System.Drawing.Point(255, 23);
            this.eliteCompatabilityCheckedListBox.Name = "eliteCompatabilityCheckedListBox";
            this.eliteCompatabilityCheckedListBox.Size = new System.Drawing.Size(120, 119);
            this.eliteCompatabilityCheckedListBox.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(255, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Elite";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(381, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Flood";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(507, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "Forerunner";
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
            this.floodCompatabilityCheckedListBox.Location = new System.Drawing.Point(381, 23);
            this.floodCompatabilityCheckedListBox.Name = "floodCompatabilityCheckedListBox";
            this.floodCompatabilityCheckedListBox.Size = new System.Drawing.Size(120, 119);
            this.floodCompatabilityCheckedListBox.TabIndex = 35;
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
            this.forerunnerCompatabilityCheckedListBox.Location = new System.Drawing.Point(507, 23);
            this.forerunnerCompatabilityCheckedListBox.Name = "forerunnerCompatabilityCheckedListBox";
            this.forerunnerCompatabilityCheckedListBox.Size = new System.Drawing.Size(120, 119);
            this.forerunnerCompatabilityCheckedListBox.TabIndex = 36;
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
            this.give_vehicle_updown.Location = new System.Drawing.Point(395, 106);
            this.give_vehicle_updown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.give_vehicle_updown.Name = "give_vehicle_updown";
            this.give_vehicle_updown.Size = new System.Drawing.Size(162, 26);
            this.give_vehicle_updown.TabIndex = 3;
            this.give_vehicle_updown.Value = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            // 
            // give_vehicle_label
            // 
            this.give_vehicle_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.give_vehicle_label.AutoSize = true;
            this.give_vehicle_label.Location = new System.Drawing.Point(4, 103);
            this.give_vehicle_label.Name = "give_vehicle_label";
            this.give_vehicle_label.Size = new System.Drawing.Size(197, 32);
            this.give_vehicle_label.TabIndex = 2;
            this.give_vehicle_label.Text = "Give squad vehicle chance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "What factions each faction can randomize into (affects characters only)";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(329, 32);
            this.label15.TabIndex = 26;
            this.label15.Text = "Squad size multiplier (unstable when not at 1)";
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
            this.squad_size_multiplier_updown.Location = new System.Drawing.Point(395, 139);
            this.squad_size_multiplier_updown.Name = "squad_size_multiplier_updown";
            this.squad_size_multiplier_updown.Size = new System.Drawing.Size(162, 26);
            this.squad_size_multiplier_updown.TabIndex = 27;
            this.squad_size_multiplier_updown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1698, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.begin_randomization_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Halo 3 Visual Randomizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hunter_chance_updown)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.give_vehicle_updown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squad_size_multiplier_updown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button begin_randomization_button;
        private TextBox EKPathBox;
        private TextBox MCCPathBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label randomize_squads_label;
        private CheckBox randomize_squads_checkbox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button MCCPathButton;
        private Button EKPathButton;
        private NumericUpDown hunter_chance_updown;
        private Label hunter_chance_label;
        private CheckBox randomize_vehicles_checkbox;
        private Label label3;
        private CheckBox randomize_weapons_checkbox;
        private Label label4;
        private CheckBox randomize_equipment_checkbox;
        private Label label5;
        private CheckBox randomize_objects_checkbox;
        private Label label6;
        private CheckBox randomize_weapon_stash_type_checkbox;
        private Label label7;
        private Label label8;
        private TextBox seed_box;
        private CheckBox randomize_cutscenes_checkbox;
        private Label label9;
        private CheckBox randomize_starting_profiles_checkbox;
        private Label label10;
        private ProgressBar progressBar1;
        private Panel panel1;
        private Label progress_label;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private CheckedListBox humanCompatabilityCheckedListBox;
        private Label label11;
        private CheckedListBox covenantCompatabilityCheckedListBox;
        private CheckedListBox forerunnerCompatabilityCheckedListBox;
        private CheckedListBox floodCompatabilityCheckedListBox;
        private Label label14;
        private Label label13;
        private Label label12;
        private CheckedListBox eliteCompatabilityCheckedListBox;
        private Label give_vehicle_label;
        private NumericUpDown give_vehicle_updown;
        private Label label1;
        private NumericUpDown squad_size_multiplier_updown;
        private Label label15;
    }
}

