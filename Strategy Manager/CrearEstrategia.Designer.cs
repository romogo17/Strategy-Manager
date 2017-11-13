using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Strategy_Manager
{
    partial class CrearEstrategia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearEstrategia));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.bdServer = new System.Windows.Forms.Label();
            this.dbInstance = new System.Windows.Forms.Label();
            this.typeBackup = new System.Windows.Forms.Label();
            this.strategiesTitle = new System.Windows.Forms.Label();
            this.fullBackupCB = new System.Windows.Forms.CheckBox();
            this.incrementalBackupCB = new System.Windows.Forms.CheckBox();
            this.level0 = new System.Windows.Forms.RadioButton();
            this.level1 = new System.Windows.Forms.RadioButton();
            this.partialBackupCB = new System.Windows.Forms.CheckBox();
            this.controlCheckBox = new System.Windows.Forms.CheckBox();
            this.spfileCheckBox = new System.Windows.Forms.CheckBox();
            this.tablespaces = new System.Windows.Forms.ListBox();
            this.tablespacesList = new System.Windows.Forms.Label();
            this.backupTablespaces = new System.Windows.Forms.ListBox();
            this.sunday_checkbox = new System.Windows.Forms.CheckBox();
            this.monday_checkbox = new System.Windows.Forms.CheckBox();
            this.wednesday_checkbox = new System.Windows.Forms.CheckBox();
            this.tuesday_checkbox = new System.Windows.Forms.CheckBox();
            this.thursday_checkbox = new System.Windows.Forms.CheckBox();
            this.friday_checkbox = new System.Windows.Forms.CheckBox();
            this.saturday_checkbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.fullBackup_panel = new System.Windows.Forms.Panel();
            this.fullArchive_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.incrementalBackup_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.particalBackup_panel = new System.Windows.Forms.Panel();
            this.partialArchive_checkBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.everyday_minutes = new System.Windows.Forms.NumericUpDown();
            this.saturday_minutes = new System.Windows.Forms.NumericUpDown();
            this.friday_minutes = new System.Windows.Forms.NumericUpDown();
            this.thursday_minutes = new System.Windows.Forms.NumericUpDown();
            this.wednesday_minutes = new System.Windows.Forms.NumericUpDown();
            this.tuesday_minutes = new System.Windows.Forms.NumericUpDown();
            this.monday_minutes = new System.Windows.Forms.NumericUpDown();
            this.sunday_minutes = new System.Windows.Forms.NumericUpDown();
            this.everyday_hour = new System.Windows.Forms.NumericUpDown();
            this.monday_hour = new System.Windows.Forms.NumericUpDown();
            this.saturday_hour = new System.Windows.Forms.NumericUpDown();
            this.friday_hour = new System.Windows.Forms.NumericUpDown();
            this.thursday_hour = new System.Windows.Forms.NumericUpDown();
            this.wednesday_hour = new System.Windows.Forms.NumericUpDown();
            this.tuesday_hour = new System.Windows.Forms.NumericUpDown();
            this.sunday_hour = new System.Windows.Forms.NumericUpDown();
            this.everyday_checkBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.low_radioButton = new System.Windows.Forms.RadioButton();
            this.medium_radioButton = new System.Windows.Forms.RadioButton();
            this.high_radioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.fullBackup_panel.SuspendLayout();
            this.incrementalBackup_panel.SuspendLayout();
            this.particalBackup_panel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.everyday_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturday_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friday_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thursday_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wednesday_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuesday_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monday_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunday_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.everyday_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monday_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturday_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friday_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thursday_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wednesday_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuesday_hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunday_hour)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 847);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarEstrategia_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(518, 847);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(273, 120);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(64, 64);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture.TabIndex = 16;
            this.picture.TabStop = false;
            // 
            // bdServer
            // 
            this.bdServer.AutoSize = true;
            this.bdServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdServer.ForeColor = System.Drawing.Color.White;
            this.bdServer.Location = new System.Drawing.Point(22, 63);
            this.bdServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bdServer.Name = "bdServer";
            this.bdServer.Size = new System.Drawing.Size(63, 20);
            this.bdServer.TabIndex = 17;
            this.bdServer.Text = "Server: ";
            // 
            // dbInstance
            // 
            this.dbInstance.AutoSize = true;
            this.dbInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbInstance.ForeColor = System.Drawing.Color.White;
            this.dbInstance.Location = new System.Drawing.Point(22, 83);
            this.dbInstance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dbInstance.Name = "dbInstance";
            this.dbInstance.Size = new System.Drawing.Size(149, 20);
            this.dbInstance.TabIndex = 18;
            this.dbInstance.Text = "Database Instance:";
            // 
            // typeBackup
            // 
            this.typeBackup.AutoSize = true;
            this.typeBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBackup.ForeColor = System.Drawing.Color.White;
            this.typeBackup.Location = new System.Drawing.Point(23, 120);
            this.typeBackup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeBackup.Name = "typeBackup";
            this.typeBackup.Size = new System.Drawing.Size(119, 18);
            this.typeBackup.TabIndex = 23;
            this.typeBackup.Text = "Type of Backup: ";
            // 
            // strategiesTitle
            // 
            this.strategiesTitle.AutoSize = true;
            this.strategiesTitle.Font = new System.Drawing.Font("Arial Narrow", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strategiesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.strategiesTitle.Location = new System.Drawing.Point(19, 9);
            this.strategiesTitle.Name = "strategiesTitle";
            this.strategiesTitle.Size = new System.Drawing.Size(147, 42);
            this.strategiesTitle.TabIndex = 24;
            this.strategiesTitle.Text = "Strategies";
            // 
            // fullBackupCB
            // 
            this.fullBackupCB.AutoSize = true;
            this.fullBackupCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullBackupCB.ForeColor = System.Drawing.Color.White;
            this.fullBackupCB.Location = new System.Drawing.Point(144, 146);
            this.fullBackupCB.Name = "fullBackupCB";
            this.fullBackupCB.Size = new System.Drawing.Size(97, 20);
            this.fullBackupCB.TabIndex = 25;
            this.fullBackupCB.Text = "Full Backup";
            this.fullBackupCB.UseVisualStyleBackColor = true;
            this.fullBackupCB.CheckedChanged += new System.EventHandler(this.fullBackupCB_Change);
            // 
            // incrementalBackupCB
            // 
            this.incrementalBackupCB.AutoSize = true;
            this.incrementalBackupCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incrementalBackupCB.ForeColor = System.Drawing.Color.White;
            this.incrementalBackupCB.Location = new System.Drawing.Point(247, 146);
            this.incrementalBackupCB.Name = "incrementalBackupCB";
            this.incrementalBackupCB.Size = new System.Drawing.Size(145, 20);
            this.incrementalBackupCB.TabIndex = 27;
            this.incrementalBackupCB.Text = "Incremental Backup";
            this.incrementalBackupCB.UseVisualStyleBackColor = true;
            this.incrementalBackupCB.CheckedChanged += new System.EventHandler(this.incrementalBackupCB_Change);
            // 
            // level0
            // 
            this.level0.AutoSize = true;
            this.level0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level0.ForeColor = System.Drawing.Color.White;
            this.level0.Location = new System.Drawing.Point(150, 40);
            this.level0.Name = "level0";
            this.level0.Size = new System.Drawing.Size(69, 20);
            this.level0.TabIndex = 0;
            this.level0.TabStop = true;
            this.level0.Text = "Level 0";
            this.level0.UseVisualStyleBackColor = true;
            this.level0.CheckedChanged += new System.EventHandler(this.level0_Change);
            // 
            // level1
            // 
            this.level1.AutoSize = true;
            this.level1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1.ForeColor = System.Drawing.Color.White;
            this.level1.Location = new System.Drawing.Point(225, 40);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(69, 20);
            this.level1.TabIndex = 1;
            this.level1.TabStop = true;
            this.level1.Text = "Level 1";
            this.level1.UseVisualStyleBackColor = true;
            this.level1.CheckedChanged += new System.EventHandler(this.level1_Change);
            // 
            // partialBackupCB
            // 
            this.partialBackupCB.AutoSize = true;
            this.partialBackupCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partialBackupCB.ForeColor = System.Drawing.Color.White;
            this.partialBackupCB.Location = new System.Drawing.Point(398, 146);
            this.partialBackupCB.Name = "partialBackupCB";
            this.partialBackupCB.Size = new System.Drawing.Size(114, 20);
            this.partialBackupCB.TabIndex = 32;
            this.partialBackupCB.Text = "Partial Backup";
            this.partialBackupCB.UseVisualStyleBackColor = true;
            this.partialBackupCB.CheckedChanged += new System.EventHandler(this.partialBackupCB_CheckedChanged);
            // 
            // controlCheckBox
            // 
            this.controlCheckBox.AutoSize = true;
            this.controlCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlCheckBox.ForeColor = System.Drawing.Color.White;
            this.controlCheckBox.Location = new System.Drawing.Point(198, 42);
            this.controlCheckBox.Name = "controlCheckBox";
            this.controlCheckBox.Size = new System.Drawing.Size(69, 20);
            this.controlCheckBox.TabIndex = 33;
            this.controlCheckBox.Text = "Control";
            this.controlCheckBox.UseVisualStyleBackColor = true;
            this.controlCheckBox.CheckedChanged += new System.EventHandler(this.controlCheckBox_Change);
            // 
            // spfileCheckBox
            // 
            this.spfileCheckBox.AutoSize = true;
            this.spfileCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spfileCheckBox.ForeColor = System.Drawing.Color.White;
            this.spfileCheckBox.Location = new System.Drawing.Point(291, 42);
            this.spfileCheckBox.Name = "spfileCheckBox";
            this.spfileCheckBox.Size = new System.Drawing.Size(61, 20);
            this.spfileCheckBox.TabIndex = 34;
            this.spfileCheckBox.Text = "Spfile";
            this.spfileCheckBox.UseVisualStyleBackColor = true;
            this.spfileCheckBox.CheckedChanged += new System.EventHandler(this.spfileCheckBox_Change);
            // 
            // tablespaces
            // 
            this.tablespaces.BackColor = System.Drawing.SystemColors.Window;
            this.tablespaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablespaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablespaces.ForeColor = System.Drawing.Color.Black;
            this.tablespaces.FormattingEnabled = true;
            this.tablespaces.ItemHeight = 16;
            this.tablespaces.Location = new System.Drawing.Point(118, 106);
            this.tablespaces.Name = "tablespaces";
            this.tablespaces.Size = new System.Drawing.Size(149, 96);
            this.tablespaces.TabIndex = 36;
            this.tablespaces.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click_tablespace);
            // 
            // tablespacesList
            // 
            this.tablespacesList.AutoSize = true;
            this.tablespacesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablespacesList.ForeColor = System.Drawing.Color.White;
            this.tablespacesList.Location = new System.Drawing.Point(92, 75);
            this.tablespacesList.Name = "tablespacesList";
            this.tablespacesList.Size = new System.Drawing.Size(89, 16);
            this.tablespacesList.TabIndex = 37;
            this.tablespacesList.Text = "Tablespaces";
            // 
            // backupTablespaces
            // 
            this.backupTablespaces.BackColor = System.Drawing.SystemColors.Window;
            this.backupTablespaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backupTablespaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupTablespaces.ForeColor = System.Drawing.Color.Black;
            this.backupTablespaces.FormattingEnabled = true;
            this.backupTablespaces.ItemHeight = 16;
            this.backupTablespaces.Location = new System.Drawing.Point(343, 106);
            this.backupTablespaces.Name = "backupTablespaces";
            this.backupTablespaces.Size = new System.Drawing.Size(149, 96);
            this.backupTablespaces.TabIndex = 38;
            this.backupTablespaces.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click_tablespaceRespaldo);
            // 
            // sunday_checkbox
            // 
            this.sunday_checkbox.AutoSize = true;
            this.sunday_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunday_checkbox.ForeColor = System.Drawing.Color.White;
            this.sunday_checkbox.Location = new System.Drawing.Point(10, 63);
            this.sunday_checkbox.Name = "sunday_checkbox";
            this.sunday_checkbox.Size = new System.Drawing.Size(75, 21);
            this.sunday_checkbox.TabIndex = 53;
            this.sunday_checkbox.Text = "Sunday";
            this.sunday_checkbox.UseVisualStyleBackColor = true;
            this.sunday_checkbox.CheckedChanged += new System.EventHandler(this.sunday_checkBox_Change);
            // 
            // monday_checkbox
            // 
            this.monday_checkbox.AutoSize = true;
            this.monday_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monday_checkbox.ForeColor = System.Drawing.Color.White;
            this.monday_checkbox.Location = new System.Drawing.Point(10, 89);
            this.monday_checkbox.Name = "monday_checkbox";
            this.monday_checkbox.Size = new System.Drawing.Size(77, 21);
            this.monday_checkbox.TabIndex = 54;
            this.monday_checkbox.Text = "Monday";
            this.monday_checkbox.UseVisualStyleBackColor = true;
            this.monday_checkbox.CheckedChanged += new System.EventHandler(this.monday_checkBox_Change);
            // 
            // wednesday_checkbox
            // 
            this.wednesday_checkbox.AutoSize = true;
            this.wednesday_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wednesday_checkbox.ForeColor = System.Drawing.Color.White;
            this.wednesday_checkbox.Location = new System.Drawing.Point(10, 140);
            this.wednesday_checkbox.Name = "wednesday_checkbox";
            this.wednesday_checkbox.Size = new System.Drawing.Size(102, 21);
            this.wednesday_checkbox.TabIndex = 55;
            this.wednesday_checkbox.Text = "Wednesday";
            this.wednesday_checkbox.UseVisualStyleBackColor = true;
            this.wednesday_checkbox.CheckedChanged += new System.EventHandler(this.wednesday_checkBox_Change);
            // 
            // tuesday_checkbox
            // 
            this.tuesday_checkbox.AutoSize = true;
            this.tuesday_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuesday_checkbox.ForeColor = System.Drawing.Color.White;
            this.tuesday_checkbox.Location = new System.Drawing.Point(10, 115);
            this.tuesday_checkbox.Name = "tuesday_checkbox";
            this.tuesday_checkbox.Size = new System.Drawing.Size(82, 21);
            this.tuesday_checkbox.TabIndex = 56;
            this.tuesday_checkbox.Text = "Tuesday";
            this.tuesday_checkbox.UseVisualStyleBackColor = true;
            this.tuesday_checkbox.CheckedChanged += new System.EventHandler(this.tuesday_checkBox_Change);
            // 
            // thursday_checkbox
            // 
            this.thursday_checkbox.AutoSize = true;
            this.thursday_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thursday_checkbox.ForeColor = System.Drawing.Color.White;
            this.thursday_checkbox.Location = new System.Drawing.Point(10, 167);
            this.thursday_checkbox.Name = "thursday_checkbox";
            this.thursday_checkbox.Size = new System.Drawing.Size(87, 21);
            this.thursday_checkbox.TabIndex = 57;
            this.thursday_checkbox.Text = "Thursday";
            this.thursday_checkbox.UseVisualStyleBackColor = true;
            this.thursday_checkbox.CheckedChanged += new System.EventHandler(this.thursday_checkBox_Change);
            // 
            // friday_checkbox
            // 
            this.friday_checkbox.AutoSize = true;
            this.friday_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friday_checkbox.ForeColor = System.Drawing.Color.White;
            this.friday_checkbox.Location = new System.Drawing.Point(10, 193);
            this.friday_checkbox.Name = "friday_checkbox";
            this.friday_checkbox.Size = new System.Drawing.Size(66, 21);
            this.friday_checkbox.TabIndex = 58;
            this.friday_checkbox.Text = "Friday";
            this.friday_checkbox.UseVisualStyleBackColor = true;
            this.friday_checkbox.CheckedChanged += new System.EventHandler(this.friday_checkBox_Change);
            // 
            // saturday_checkbox
            // 
            this.saturday_checkbox.AutoSize = true;
            this.saturday_checkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saturday_checkbox.ForeColor = System.Drawing.Color.White;
            this.saturday_checkbox.Location = new System.Drawing.Point(10, 217);
            this.saturday_checkbox.Name = "saturday_checkbox";
            this.saturday_checkbox.Size = new System.Drawing.Size(84, 21);
            this.saturday_checkbox.TabIndex = 59;
            this.saturday_checkbox.Text = "Saturday";
            this.saturday_checkbox.UseVisualStyleBackColor = true;
            this.saturday_checkbox.CheckedChanged += new System.EventHandler(this.saturday_checkBox_Change);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 79;
            this.label8.Text = "Days";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(115, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 80;
            this.label9.Text = "Hour";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(171, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 81;
            this.label10.Text = "Minutes";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.fullBackup_panel);
            this.flowLayoutPanel1.Controls.Add(this.incrementalBackup_panel);
            this.flowLayoutPanel1.Controls.Add(this.particalBackup_panel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(46, 174);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(556, 379);
            this.flowLayoutPanel1.TabIndex = 82;
            // 
            // fullBackup_panel
            // 
            this.fullBackup_panel.Controls.Add(this.fullArchive_checkBox);
            this.fullBackup_panel.Controls.Add(this.label1);
            this.fullBackup_panel.Location = new System.Drawing.Point(3, 3);
            this.fullBackup_panel.Name = "fullBackup_panel";
            this.fullBackup_panel.Size = new System.Drawing.Size(544, 72);
            this.fullBackup_panel.TabIndex = 0;
            this.fullBackup_panel.Visible = false;
            // 
            // fullArchive_checkBox
            // 
            this.fullArchive_checkBox.AutoSize = true;
            this.fullArchive_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullArchive_checkBox.ForeColor = System.Drawing.Color.White;
            this.fullArchive_checkBox.Location = new System.Drawing.Point(95, 42);
            this.fullArchive_checkBox.Name = "fullArchive_checkBox";
            this.fullArchive_checkBox.Size = new System.Drawing.Size(82, 20);
            this.fullArchive_checkBox.TabIndex = 1;
            this.fullArchive_checkBox.Text = "Archive\'s";
            this.fullArchive_checkBox.UseVisualStyleBackColor = true;
            this.fullArchive_checkBox.CheckedChanged += new System.EventHandler(this.fullArchive_checkBox_Change);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Backup Options";
            // 
            // incrementalBackup_panel
            // 
            this.incrementalBackup_panel.Controls.Add(this.level1);
            this.incrementalBackup_panel.Controls.Add(this.label3);
            this.incrementalBackup_panel.Controls.Add(this.level0);
            this.incrementalBackup_panel.Controls.Add(this.label2);
            this.incrementalBackup_panel.Location = new System.Drawing.Point(3, 81);
            this.incrementalBackup_panel.Name = "incrementalBackup_panel";
            this.incrementalBackup_panel.Size = new System.Drawing.Size(544, 72);
            this.incrementalBackup_panel.TabIndex = 1;
            this.incrementalBackup_panel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(92, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "lncremental Backup Options";
            // 
            // particalBackup_panel
            // 
            this.particalBackup_panel.Controls.Add(this.partialArchive_checkBox);
            this.particalBackup_panel.Controls.Add(this.label4);
            this.particalBackup_panel.Controls.Add(this.controlCheckBox);
            this.particalBackup_panel.Controls.Add(this.spfileCheckBox);
            this.particalBackup_panel.Controls.Add(this.tablespacesList);
            this.particalBackup_panel.Controls.Add(this.tablespaces);
            this.particalBackup_panel.Controls.Add(this.picture);
            this.particalBackup_panel.Controls.Add(this.backupTablespaces);
            this.particalBackup_panel.Location = new System.Drawing.Point(3, 159);
            this.particalBackup_panel.Name = "particalBackup_panel";
            this.particalBackup_panel.Size = new System.Drawing.Size(544, 217);
            this.particalBackup_panel.TabIndex = 2;
            this.particalBackup_panel.Visible = false;
            // 
            // partialArchive_checkBox
            // 
            this.partialArchive_checkBox.AutoSize = true;
            this.partialArchive_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partialArchive_checkBox.ForeColor = System.Drawing.Color.White;
            this.partialArchive_checkBox.Location = new System.Drawing.Point(95, 42);
            this.partialArchive_checkBox.Name = "partialArchive_checkBox";
            this.partialArchive_checkBox.Size = new System.Drawing.Size(82, 20);
            this.partialArchive_checkBox.TabIndex = 1;
            this.partialArchive_checkBox.Text = "Archive\'s";
            this.partialArchive_checkBox.UseVisualStyleBackColor = true;
            this.partialArchive_checkBox.CheckedChanged += new System.EventHandler(this.partialArchive_checkBox_Change);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Partial Backup Options";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(46, 556);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(556, 285);
            this.flowLayoutPanel2.TabIndex = 83;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.everyday_minutes);
            this.panel4.Controls.Add(this.friday_checkbox);
            this.panel4.Controls.Add(this.saturday_minutes);
            this.panel4.Controls.Add(this.thursday_checkbox);
            this.panel4.Controls.Add(this.friday_minutes);
            this.panel4.Controls.Add(this.wednesday_checkbox);
            this.panel4.Controls.Add(this.thursday_minutes);
            this.panel4.Controls.Add(this.tuesday_checkbox);
            this.panel4.Controls.Add(this.wednesday_minutes);
            this.panel4.Controls.Add(this.tuesday_minutes);
            this.panel4.Controls.Add(this.monday_minutes);
            this.panel4.Controls.Add(this.sunday_minutes);
            this.panel4.Controls.Add(this.everyday_hour);
            this.panel4.Controls.Add(this.monday_hour);
            this.panel4.Controls.Add(this.saturday_hour);
            this.panel4.Controls.Add(this.friday_hour);
            this.panel4.Controls.Add(this.thursday_hour);
            this.panel4.Controls.Add(this.wednesday_hour);
            this.panel4.Controls.Add(this.tuesday_hour);
            this.panel4.Controls.Add(this.sunday_hour);
            this.panel4.Controls.Add(this.everyday_checkBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.sunday_checkbox);
            this.panel4.Controls.Add(this.monday_checkbox);
            this.panel4.Controls.Add(this.saturday_checkbox);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 275);
            this.panel4.TabIndex = 0;
            // 
            // everyday_minutes
            // 
            this.everyday_minutes.Location = new System.Drawing.Point(174, 245);
            this.everyday_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.everyday_minutes.Name = "everyday_minutes";
            this.everyday_minutes.Size = new System.Drawing.Size(50, 20);
            this.everyday_minutes.TabIndex = 98;
            // 
            // saturday_minutes
            // 
            this.saturday_minutes.Location = new System.Drawing.Point(174, 219);
            this.saturday_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.saturday_minutes.Name = "saturday_minutes";
            this.saturday_minutes.Size = new System.Drawing.Size(50, 20);
            this.saturday_minutes.TabIndex = 97;
            // 
            // friday_minutes
            // 
            this.friday_minutes.Location = new System.Drawing.Point(174, 193);
            this.friday_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.friday_minutes.Name = "friday_minutes";
            this.friday_minutes.Size = new System.Drawing.Size(50, 20);
            this.friday_minutes.TabIndex = 96;
            // 
            // thursday_minutes
            // 
            this.thursday_minutes.Location = new System.Drawing.Point(174, 167);
            this.thursday_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.thursday_minutes.Name = "thursday_minutes";
            this.thursday_minutes.Size = new System.Drawing.Size(50, 20);
            this.thursday_minutes.TabIndex = 95;
            // 
            // wednesday_minutes
            // 
            this.wednesday_minutes.Location = new System.Drawing.Point(174, 141);
            this.wednesday_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.wednesday_minutes.Name = "wednesday_minutes";
            this.wednesday_minutes.Size = new System.Drawing.Size(50, 20);
            this.wednesday_minutes.TabIndex = 94;
            // 
            // tuesday_minutes
            // 
            this.tuesday_minutes.Location = new System.Drawing.Point(174, 115);
            this.tuesday_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.tuesday_minutes.Name = "tuesday_minutes";
            this.tuesday_minutes.Size = new System.Drawing.Size(50, 20);
            this.tuesday_minutes.TabIndex = 93;
            // 
            // monday_minutes
            // 
            this.monday_minutes.Location = new System.Drawing.Point(174, 89);
            this.monday_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.monday_minutes.Name = "monday_minutes";
            this.monday_minutes.Size = new System.Drawing.Size(50, 20);
            this.monday_minutes.TabIndex = 92;
            // 
            // sunday_minutes
            // 
            this.sunday_minutes.Location = new System.Drawing.Point(174, 63);
            this.sunday_minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.sunday_minutes.Name = "sunday_minutes";
            this.sunday_minutes.Size = new System.Drawing.Size(50, 20);
            this.sunday_minutes.TabIndex = 91;
            // 
            // everyday_hour
            // 
            this.everyday_hour.Location = new System.Drawing.Point(118, 245);
            this.everyday_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.everyday_hour.Name = "everyday_hour";
            this.everyday_hour.Size = new System.Drawing.Size(50, 20);
            this.everyday_hour.TabIndex = 90;
            // 
            // monday_hour
            // 
            this.monday_hour.Location = new System.Drawing.Point(118, 89);
            this.monday_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.monday_hour.Name = "monday_hour";
            this.monday_hour.Size = new System.Drawing.Size(50, 20);
            this.monday_hour.TabIndex = 84;
            // 
            // saturday_hour
            // 
            this.saturday_hour.Location = new System.Drawing.Point(118, 219);
            this.saturday_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.saturday_hour.Name = "saturday_hour";
            this.saturday_hour.Size = new System.Drawing.Size(50, 20);
            this.saturday_hour.TabIndex = 89;
            // 
            // friday_hour
            // 
            this.friday_hour.Location = new System.Drawing.Point(118, 193);
            this.friday_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.friday_hour.Name = "friday_hour";
            this.friday_hour.Size = new System.Drawing.Size(50, 20);
            this.friday_hour.TabIndex = 88;
            // 
            // thursday_hour
            // 
            this.thursday_hour.Location = new System.Drawing.Point(118, 167);
            this.thursday_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.thursday_hour.Name = "thursday_hour";
            this.thursday_hour.Size = new System.Drawing.Size(50, 20);
            this.thursday_hour.TabIndex = 87;
            // 
            // wednesday_hour
            // 
            this.wednesday_hour.Location = new System.Drawing.Point(118, 141);
            this.wednesday_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.wednesday_hour.Name = "wednesday_hour";
            this.wednesday_hour.Size = new System.Drawing.Size(50, 20);
            this.wednesday_hour.TabIndex = 85;
            // 
            // tuesday_hour
            // 
            this.tuesday_hour.Location = new System.Drawing.Point(118, 115);
            this.tuesday_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.tuesday_hour.Name = "tuesday_hour";
            this.tuesday_hour.Size = new System.Drawing.Size(50, 20);
            this.tuesday_hour.TabIndex = 86;
            // 
            // sunday_hour
            // 
            this.sunday_hour.Location = new System.Drawing.Point(118, 63);
            this.sunday_hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.sunday_hour.Name = "sunday_hour";
            this.sunday_hour.Size = new System.Drawing.Size(50, 20);
            this.sunday_hour.TabIndex = 83;
            // 
            // everyday_checkBox
            // 
            this.everyday_checkBox.AutoSize = true;
            this.everyday_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.everyday_checkBox.ForeColor = System.Drawing.Color.White;
            this.everyday_checkBox.Location = new System.Drawing.Point(10, 245);
            this.everyday_checkBox.Name = "everyday_checkBox";
            this.everyday_checkBox.Size = new System.Drawing.Size(86, 21);
            this.everyday_checkBox.TabIndex = 82;
            this.everyday_checkBox.Text = "Everyday";
            this.everyday_checkBox.UseVisualStyleBackColor = true;
            this.everyday_checkBox.CheckedChanged += new System.EventHandler(this.everyday_checkBox_Change);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Strategies Running Time";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.low_radioButton);
            this.panel5.Controls.Add(this.medium_radioButton);
            this.panel5.Controls.Add(this.high_radioButton);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(276, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 275);
            this.panel5.TabIndex = 1;
            // 
            // low_radioButton
            // 
            this.low_radioButton.AutoSize = true;
            this.low_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.low_radioButton.ForeColor = System.Drawing.Color.White;
            this.low_radioButton.Location = new System.Drawing.Point(60, 119);
            this.low_radioButton.Name = "low_radioButton";
            this.low_radioButton.Size = new System.Drawing.Size(50, 20);
            this.low_radioButton.TabIndex = 3;
            this.low_radioButton.TabStop = true;
            this.low_radioButton.Text = "Low";
            this.low_radioButton.UseVisualStyleBackColor = true;
            // 
            // medium_radioButton
            // 
            this.medium_radioButton.AutoSize = true;
            this.medium_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medium_radioButton.ForeColor = System.Drawing.Color.White;
            this.medium_radioButton.Location = new System.Drawing.Point(60, 93);
            this.medium_radioButton.Name = "medium_radioButton";
            this.medium_radioButton.Size = new System.Drawing.Size(74, 20);
            this.medium_radioButton.TabIndex = 2;
            this.medium_radioButton.TabStop = true;
            this.medium_radioButton.Text = "Medium";
            this.medium_radioButton.UseVisualStyleBackColor = true;
            // 
            // high_radioButton
            // 
            this.high_radioButton.AutoSize = true;
            this.high_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.high_radioButton.ForeColor = System.Drawing.Color.White;
            this.high_radioButton.Location = new System.Drawing.Point(60, 67);
            this.high_radioButton.Name = "high_radioButton";
            this.high_radioButton.Size = new System.Drawing.Size(54, 20);
            this.high_radioButton.TabIndex = 1;
            this.high_radioButton.TabStop = true;
            this.high_radioButton.Text = "High";
            this.high_radioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Priority";
            // 
            // CrearEstrategia
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(710, 687);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.partialBackupCB);
            this.Controls.Add(this.incrementalBackupCB);
            this.Controls.Add(this.fullBackupCB);
            this.Controls.Add(this.strategiesTitle);
            this.Controls.Add(this.typeBackup);
            this.Controls.Add(this.dbInstance);
            this.Controls.Add(this.bdServer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(726, 726);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(726, 726);
            this.Name = "CrearEstrategia";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Backup Strategies";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.fullBackup_panel.ResumeLayout(false);
            this.fullBackup_panel.PerformLayout();
            this.incrementalBackup_panel.ResumeLayout(false);
            this.incrementalBackup_panel.PerformLayout();
            this.particalBackup_panel.ResumeLayout(false);
            this.particalBackup_panel.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.everyday_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturday_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friday_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thursday_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wednesday_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuesday_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monday_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunday_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.everyday_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monday_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturday_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friday_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thursday_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wednesday_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tuesday_hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunday_hour)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label bdServer;
        private System.Windows.Forms.Label dbInstance;
        private System.Windows.Forms.Label typeBackup;
        private System.Windows.Forms.Label strategiesTitle;
        private System.Windows.Forms.CheckBox fullBackupCB;
        private System.Windows.Forms.CheckBox incrementalBackupCB;
        private System.Windows.Forms.RadioButton level1;
        private System.Windows.Forms.RadioButton level0;
        private System.Windows.Forms.CheckBox partialBackupCB;
        private System.Windows.Forms.CheckBox controlCheckBox;
        private System.Windows.Forms.CheckBox spfileCheckBox;
        private System.Windows.Forms.ListBox tablespaces;
        private System.Windows.Forms.Label tablespacesList;
        private System.Windows.Forms.ListBox backupTablespaces;
        private System.Windows.Forms.CheckBox sunday_checkbox;
        private System.Windows.Forms.CheckBox monday_checkbox;
        private System.Windows.Forms.CheckBox wednesday_checkbox;
        private System.Windows.Forms.CheckBox tuesday_checkbox;
        private System.Windows.Forms.CheckBox thursday_checkbox;
        private System.Windows.Forms.CheckBox friday_checkbox;
        private System.Windows.Forms.CheckBox saturday_checkbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel fullBackup_panel;
        private System.Windows.Forms.CheckBox fullArchive_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel incrementalBackup_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel particalBackup_panel;
        private System.Windows.Forms.CheckBox partialArchive_checkBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox everyday_checkBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown everyday_minutes;
        private System.Windows.Forms.NumericUpDown saturday_minutes;
        private System.Windows.Forms.NumericUpDown friday_minutes;
        private System.Windows.Forms.NumericUpDown thursday_minutes;
        private System.Windows.Forms.NumericUpDown wednesday_minutes;
        private System.Windows.Forms.NumericUpDown tuesday_minutes;
        private System.Windows.Forms.NumericUpDown monday_minutes;
        private System.Windows.Forms.NumericUpDown sunday_minutes;
        private System.Windows.Forms.NumericUpDown everyday_hour;
        private System.Windows.Forms.NumericUpDown monday_hour;
        private System.Windows.Forms.NumericUpDown saturday_hour;
        private System.Windows.Forms.NumericUpDown friday_hour;
        private System.Windows.Forms.NumericUpDown thursday_hour;
        private System.Windows.Forms.NumericUpDown wednesday_hour;
        private System.Windows.Forms.NumericUpDown tuesday_hour;
        private System.Windows.Forms.NumericUpDown sunday_hour;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton low_radioButton;
        private System.Windows.Forms.RadioButton medium_radioButton;
        private System.Windows.Forms.RadioButton high_radioButton;
        private System.Windows.Forms.Label label6;
        private ListaEstrategia app;
        private String connection;
        List<string> backupScript = new List<string>();
        private String priority;
        List<int> runTime = new List<int>();

        //------------------------------------------ FULL BACKUP ----------------------------------------------------------------
        private void fullBackupCB_Change(object sender, EventArgs e)
        {
            if (fullBackupCB.Checked)
            {
                backupScript.Add("backup database;");
                incrementalBackupCB.Enabled = false;
                partialBackupCB.Enabled = false;
                fullBackup_panel.Visible = true;
            }
            else
            {
                backupScript.Remove("backup database;");
                incrementalBackupCB.Enabled = true;
                partialBackupCB.Enabled = true;
                fullBackup_panel.Visible = false;
                fullArchive_checkBox.Checked = false;
            }
        }

        private void fullArchive_checkBox_Change(object sender, EventArgs e)
        {
            if (fullArchive_checkBox.Checked)
            {
                List<string> aux = backupScript;
                backupScript = new List<string>();

                backupScript.Add("crosscheck archivelog all;");
                backupScript.Add("run{");
                backupScript.Add("SQL \"alter system switch logfile\";");
                backupScript.Add("backup archivelog all;");
                foreach (string scriptline in aux)
                    if (scriptline != "run{")
                        backupScript.Add(scriptline);
            }
            else
            {
                backupScript.Remove("crosscheck archivelog all;");
                backupScript.Remove("SQL \"alter system switch logfile\";");
                backupScript.Remove("backup archivelog all;");
            }
        }

//------------------------------------------ INCREMENTAL BACKUP ----------------------------------------------------------------
        private void incrementalBackupCB_Change(object sender, EventArgs e)
        {
            if (incrementalBackupCB.Checked)
            {
                fullBackupCB.Enabled = false;
                partialBackupCB.Enabled = false;
                incrementalBackup_panel.Visible = true;
            }
            else
            {
                fullBackupCB.Enabled = true;
                partialBackupCB.Enabled = true;
                backupScript = new List<string>();
                backupScript.Add("run{");
                level0.Checked = false;
                level1.Checked = false;
                incrementalBackup_panel.Visible = false;
            }
        }

        private void level0_Change(object sender, EventArgs e)
        {
            if (level0.Checked)
                backupScript.Add("backup incremental level 0 database;");
            else
                backupScript.Remove("backup incremental level 0 database;");
        }

        private void level1_Change(object sender, EventArgs e)
        {
            if (level1.Checked)
                backupScript.Add("backup incremental level 1 database;");
            else
                backupScript.Remove("backup incremental level 1 database;");
        }

//------------------------------------------ PARTIAL BACKUP ----------------------------------------------------------------
        private void partialBackupCB_CheckedChanged(object sender, EventArgs e)
        {
            if (partialBackupCB.Checked)
            {
                fullBackupCB.Enabled = false;
                incrementalBackupCB.Enabled = false;
                particalBackup_panel.Visible = true;
            }
            else
            {
                fullBackupCB.Enabled = true;
                incrementalBackupCB.Enabled = true;
                particalBackup_panel.Visible = false;
                partialArchive_checkBox.Checked = false;
                controlCheckBox.Checked = false;
                spfileCheckBox.Checked = false;
                if (backupTablespaces.Items != null) {
                    foreach (string itemTablespace in backupTablespaces.Items)
                        tablespaces.Items.Add(itemTablespace);
                    for (int i = 0; i < backupTablespaces.Items.Count; i = 0)
                    {
                        backupScript.Remove("backup tablespace " + backupTablespaces.Items[i].ToString().ToLower() + ";");
                        backupTablespaces.Items.Remove(backupTablespaces.Items[i]);
                    }
                }
            }
        }

        private void partialArchive_checkBox_Change(object sender, EventArgs e)
        {
            if (partialArchive_checkBox.Checked)
            {
                List<string> aux = backupScript;
                backupScript = new List<string>();
                backupScript.Add("crosscheck archivelog all;");
                backupScript.Add("run{");
                backupScript.Add("SQL \"alter system switch logfile\";");
                backupScript.Add("backup archivelog all;");
                foreach (string scriptline in aux)
                    if (scriptline != "run{")
                        backupScript.Add(scriptline);
            }
            else
            {
                backupScript.Remove("crosscheck archivelog all;");
                backupScript.Remove("SQL \"alter system switch logfile\";");
                backupScript.Remove("backup archivelog all;");
            }
        }

        private void controlCheckBox_Change(object sender, EventArgs e)
        {
            if (controlCheckBox.Checked)
                backupScript.Add("backup current controlfile;");
            else
                backupScript.Remove("backup current controlfile;");
        }

        private void spfileCheckBox_Change(object sender, EventArgs e)
        {
            if (spfileCheckBox.Checked)
                backupScript.Add("backup spfile;");
            else
                backupScript.Remove("backup spfile;");
        }

        public void click_tablespace(object sender, EventArgs e)
        {
            if (tablespaces.SelectedItem != null)
            {
                backupTablespaces.Items.Add(tablespaces.SelectedItem);
                backupScript.Add("backup tablespace " + tablespaces.SelectedItem.ToString().ToLower() + ";");
                tablespaces.Items.Remove(tablespaces.SelectedItem);
            }
        }
        public void click_tablespaceRespaldo(object sender, EventArgs e)
        {
            if (backupTablespaces.SelectedItem != null)
            {
                tablespaces.Items.Add(backupTablespaces.SelectedItem);
                backupTablespaces.Items.Remove(backupTablespaces.SelectedItem);
                backupScript.Remove("backup tablespace " + tablespaces.SelectedItem.ToString().ToLower() + ";");
            }
        }

//------------------------------------------ PRIORITY ----------------------------------------------------------------
        private String prioritySelected()
        {
            String priori;
            if (high_radioButton.Checked)
                priori = "HIGH";
            else
            {
                if (medium_radioButton.Checked)
                    priori = "MEDIUM";
                else
                    priori = "LOW";
            }
            return priori;
        }

//------------------------------------------ RUNNING TIME ----------------------------------------------------------------
        private void sunday_checkBox_Change(object sender, EventArgs e)
        {
            if (sunday_checkbox.Checked)
                runTime.Add(0);
            else
                runTime.Remove(0);
        }
        private void monday_checkBox_Change(object sender, EventArgs e)
        {
            if (monday_checkbox.Checked)
                runTime.Add(1);
            else
                runTime.Remove(1);
        }
        private void tuesday_checkBox_Change(object sender, EventArgs e)
        {
            if (tuesday_checkbox.Checked)
                runTime.Add(2);
            else
                runTime.Remove(2);
        }
        private void wednesday_checkBox_Change(object sender, EventArgs e)
        {
            if (wednesday_checkbox.Checked)
                runTime.Add(3);
            else
                runTime.Remove(3);
        }
        private void thursday_checkBox_Change(object sender, EventArgs e)
        {
            if (thursday_checkbox.Checked)
                runTime.Add(4);
            else
                runTime.Remove(4);
        }
        private void friday_checkBox_Change(object sender, EventArgs e)
        {
            if (friday_checkbox.Checked)
                runTime.Add(5);
            else
                runTime.Remove(5);
        }
        private void saturday_checkBox_Change(object sender, EventArgs e)
        {
            if (saturday_checkbox.Checked)
                runTime.Add(6);
            else
                runTime.Remove(6);
        }
        private void everyday_checkBox_Change(object sender, EventArgs e)
        {
            if (everyday_checkBox.Checked)
                runTime.Add(-1);
            else
                runTime.Remove(-1);
        }

        private int obteinHour(int value)
        {
            int hour;
            switch (value)
            {
                case 0:
                    hour = Decimal.ToInt32(sunday_hour.Value);
                    break;
                case 1:
                    hour = Decimal.ToInt32(monday_hour.Value);
                    break;
                case 2:
                    hour = Decimal.ToInt32(tuesday_hour.Value);
                    break;
                case 3:
                    hour = Decimal.ToInt32(wednesday_hour.Value);
                    break;
                case 4:
                    hour = Decimal.ToInt32(thursday_hour.Value);
                    break;
                case 5:
                    hour = Decimal.ToInt32(friday_hour.Value);
                    break;
                case 6:
                    hour = Decimal.ToInt32(saturday_hour.Value);
                    break;
                default:
                    hour = Decimal.ToInt32(everyday_hour.Value);
                    break;
            }
            return hour;
        }

        private int obteinMinute(int value)
        {
            int minutes;
            switch (value)
            {
                case 0:
                    minutes = Decimal.ToInt32(sunday_minutes.Value);
                    break;
                case 1:
                    minutes = Decimal.ToInt32(monday_minutes.Value);
                    break;
                case 2:
                    minutes = Decimal.ToInt32(tuesday_minutes.Value);
                    break;
                case 3:
                    minutes = Decimal.ToInt32(wednesday_minutes.Value);
                    break;
                case 4:
                    minutes = Decimal.ToInt32(thursday_minutes.Value);
                    break;
                case 5:
                    minutes = Decimal.ToInt32(friday_minutes.Value);
                    break;
                case 6:
                    minutes = Decimal.ToInt32(saturday_minutes.Value);
                    break;
                default:
                    minutes = Decimal.ToInt32(everyday_minutes.Value);
                    break;
            }
            return minutes;
        }

        private void saveRunningTime(String idstrategy,String connection)
        {
            int hour, minute;
            foreach (int time in runTime)
            {
                hour = obteinHour(time);
                minute = obteinMinute(time);
                if (hour < 0 && hour > 23)
                    hour = 0;
                if (minute < 0 && minute > 59)
                    minute = 59;
                insertFrecuency(idstrategy, time, hour, minute);
                //insertFrecuencyRemote(idstrategy, connection, time, hour, minute);
            }
        }

//------------------------------------------ ADD STRATEGIES ----------------------------------------------------------------
        private void agregarEstrategia_Click(object sender, EventArgs e)
        {
            var dateTime = DateTime.Now;
            var dateTimeOffset = new DateTimeOffset(dateTime);
            var unixDateTime = dateTimeOffset.ToUnixTimeSeconds().ToString();
            String idstrategy;
            if (idEstrategia1 == "") {idstrategy = "EST_" + unixDateTime; }
            else { idstrategy = idEstrategia1; }
            backupScript.Add("}");
            if (runTime.Count >= 1)
            {
                if (backupScript.Count > 2)
                {
                    priority = prioritySelected();
                    insertStrategies(idstrategy, connection, priority);
                    //insertStrategiesRemote(idstrategy, connection, priority);
                    int cont = 0;
                    foreach (string scriptline in backupScript)
                    {
                        insertStrategiesLines(idstrategy, cont, scriptline);
                        //insertStrategiesLinesRemote(idstrategy, cont, scriptline, connection);
                        cont++;
                    }
                    saveRunningTime(idstrategy, connection);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Select a backup strategy");
                    backupScript.Remove("}");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Select a running time for the strategy");
                backupScript.Remove("}");
            }
        }

//------------------------------------------ INSERT STRATEGIES ----------------------------------------------------------------
        public void insertStrategies(String idstrategy, String conexion, String priori) {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "insert_strategy";
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, idstrategy, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, conexion, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, priori, ParameterDirection.Input));
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    app.solicitaEstrategias(conexion);
                    this.Close();
                    System.Windows.Forms.MessageBox.Show("Strategy register successfully");

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                }

                objConn.Close();
                objConn.Dispose();
            }
        }
        public void insertStrategiesRemote(String idstrategy, String conexion, String priori)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "insert into strategy@"+conexion+ " values(:1,:2,:3,:4)";

                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, idstrategy, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, conexion, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, priori, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("4", OracleDbType.Decimal,1, ParameterDirection.Input));
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    app.solicitaEstrategias(conexion);
                    this.Close();
                    System.Windows.Forms.MessageBox.Show("Strategy register successfully");

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                }

                objConn.Close();
                objConn.Dispose();
            }
        }

//------------------------------------------ INSERT STRATEGY LINES ----------------------------------------------------------------
        public void insertStrategiesLines(String idstrategy, int nline, String line)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "insert_strategyline";
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, idstrategy, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("2", OracleDbType.Decimal, nline, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, line, ParameterDirection.Input));
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    this.Close();
                    System.Windows.Forms.MessageBox.Show(line);

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                }

                objConn.Close();
                objConn.Dispose();
            }
        }
        public void insertStrategiesLinesRemote(String idstrategy, int nline, String line,String conection)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "insert into strategy_line@"+connection+ " values(:1,:2,:3)";

                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, idstrategy, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("2", OracleDbType.Decimal, nline, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, line, ParameterDirection.Input));
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    this.Close();
                    System.Windows.Forms.MessageBox.Show(line);

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                }

                objConn.Close();
                objConn.Dispose();
            }
        }

//------------------------------------------ INSERT FRECUENCY ----------------------------------------------------------------
        public void insertFrecuency(String idstrategy, int day, int hour, int minute)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "insert_frequency";
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, idstrategy, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("2", OracleDbType.Int32, day, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("3", OracleDbType.Int32, hour, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("4", OracleDbType.Int32, minute, ParameterDirection.Input));
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    this.Close();
                    System.Windows.Forms.MessageBox.Show("Frequency register successfully");

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                }

                objConn.Close();
                objConn.Dispose();
            }
        }
        public void insertFrecuencyRemote(String idstrategy, String conexion, int day, int hour, int minute)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "insert into frequency@" + conexion + " values(:1,:2,:3,:4)";

                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, idstrategy, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("2", OracleDbType.Int32, day, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("3", OracleDbType.Int32, hour, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("4", OracleDbType.Int32, minute, ParameterDirection.Input));
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    this.Close();
                    System.Windows.Forms.MessageBox.Show("Frequency register successfully");

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                }

                objConn.Close();
                objConn.Dispose();
            }
        }

//------------------------------------------ GET TABLESPACES ----------------------------------------------------------------
        public void solicitaTablespaces(String conexion)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet tableSpaces = new DataSet("tablespaces");
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "SELECT TABLESPACE_NAME from DBA_TABLESPACES@" + conexion;

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    OracleDataAdapter a = new OracleDataAdapter(objCmd);
                    a.Fill(tableSpaces);
                    foreach (DataRow ts in tableSpaces.Tables[0].Rows)
                    {
                        tablespaces.Items.Add(ts.ItemArray[0]);
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
            }
        }

//------------------------------------------ CANCEL ----------------------------------------------------------------
        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }
        private String idEstrategia1;
    }
}