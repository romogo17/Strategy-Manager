using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

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
            this.ARCHIVE_CB = new System.Windows.Forms.CheckBox();
            this.incrementalBackupCB = new System.Windows.Forms.CheckBox();
            this.level0 = new System.Windows.Forms.RadioButton();
            this.level1 = new System.Windows.Forms.RadioButton();
            this.levelGroupBox = new System.Windows.Forms.GroupBox();
            this.partialBackupCB = new System.Windows.Forms.CheckBox();
            this.controlCheckBox = new System.Windows.Forms.CheckBox();
            this.spfileCheckBox = new System.Windows.Forms.CheckBox();
            this.tablespaces = new System.Windows.Forms.ListBox();
            this.tablespacesList = new System.Windows.Forms.Label();
            this.backupTablespaces = new System.Windows.Forms.ListBox();
            this.LH = new System.Windows.Forms.ComboBox();
            this.ML = new System.Windows.Forms.ComboBox();
            this.Lunes = new System.Windows.Forms.CheckBox();
            this.Martes = new System.Windows.Forms.CheckBox();
            this.Jueves = new System.Windows.Forms.CheckBox();
            this.Miercoles = new System.Windows.Forms.CheckBox();
            this.Viernes = new System.Windows.Forms.CheckBox();
            this.Sabado = new System.Windows.Forms.CheckBox();
            this.Domingo = new System.Windows.Forms.CheckBox();
            this.MH = new System.Windows.Forms.ComboBox();
            this.DH = new System.Windows.Forms.ComboBox();
            this.SH = new System.Windows.Forms.ComboBox();
            this.VH = new System.Windows.Forms.ComboBox();
            this.JH = new System.Windows.Forms.ComboBox();
            this.IH = new System.Windows.Forms.ComboBox();
            this.MD = new System.Windows.Forms.ComboBox();
            this.MS = new System.Windows.Forms.ComboBox();
            this.MV = new System.Windows.Forms.ComboBox();
            this.MJ = new System.Windows.Forms.ComboBox();
            this.MI = new System.Windows.Forms.ComboBox();
            this.MM = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.levelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarEstrategia_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(665, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(310, 434);
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
            this.fullBackupCB.Location = new System.Drawing.Point(123, 151);
            this.fullBackupCB.Name = "fullBackupCB";
            this.fullBackupCB.Size = new System.Drawing.Size(97, 20);
            this.fullBackupCB.TabIndex = 25;
            this.fullBackupCB.Text = "Full Backup";
            this.fullBackupCB.UseVisualStyleBackColor = true;
            this.fullBackupCB.CheckedChanged += new System.EventHandler(this.fullBackupCB_Change);
            // 
            // ARCHIVE_CB
            // 
            this.ARCHIVE_CB.AutoSize = true;
            this.ARCHIVE_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ARCHIVE_CB.ForeColor = System.Drawing.Color.White;
            this.ARCHIVE_CB.Location = new System.Drawing.Point(123, 178);
            this.ARCHIVE_CB.Name = "ARCHIVE_CB";
            this.ARCHIVE_CB.Size = new System.Drawing.Size(131, 20);
            this.ARCHIVE_CB.TabIndex = 26;
            this.ARCHIVE_CB.Text = "Backup Archive\'s";
            this.ARCHIVE_CB.UseVisualStyleBackColor = true;
            this.ARCHIVE_CB.CheckedChanged += new System.EventHandler(this.ARCHIVE_CB_Change);
            // 
            // incrementalBackupCB
            // 
            this.incrementalBackupCB.AutoSize = true;
            this.incrementalBackupCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incrementalBackupCB.ForeColor = System.Drawing.Color.White;
            this.incrementalBackupCB.Location = new System.Drawing.Point(123, 205);
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
            this.level0.Location = new System.Drawing.Point(23, 19);
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
            this.level1.Location = new System.Drawing.Point(23, 42);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(69, 20);
            this.level1.TabIndex = 1;
            this.level1.TabStop = true;
            this.level1.Text = "Level 1";
            this.level1.UseVisualStyleBackColor = true;
            this.level1.CheckedChanged += new System.EventHandler(this.level1_Change);
            // 
            // levelGroupBox
            // 
            this.levelGroupBox.Controls.Add(this.level1);
            this.levelGroupBox.Controls.Add(this.level0);
            this.levelGroupBox.Enabled = false;
            this.levelGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelGroupBox.ForeColor = System.Drawing.Color.White;
            this.levelGroupBox.Location = new System.Drawing.Point(165, 231);
            this.levelGroupBox.Name = "levelGroupBox";
            this.levelGroupBox.Size = new System.Drawing.Size(126, 73);
            this.levelGroupBox.TabIndex = 31;
            this.levelGroupBox.TabStop = false;
            this.levelGroupBox.Text = "Level:";
            // 
            // partialBackupCB
            // 
            this.partialBackupCB.AutoSize = true;
            this.partialBackupCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partialBackupCB.ForeColor = System.Drawing.Color.White;
            this.partialBackupCB.Location = new System.Drawing.Point(123, 310);
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
            this.controlCheckBox.Enabled = false;
            this.controlCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlCheckBox.ForeColor = System.Drawing.Color.White;
            this.controlCheckBox.Location = new System.Drawing.Point(174, 337);
            this.controlCheckBox.Name = "controlCheckBox";
            this.controlCheckBox.Size = new System.Drawing.Size(69, 20);
            this.controlCheckBox.TabIndex = 33;
            this.controlCheckBox.Text = "Control";
            this.controlCheckBox.UseVisualStyleBackColor = true;
            // 
            // spfileCheckBox
            // 
            this.spfileCheckBox.AutoSize = true;
            this.spfileCheckBox.Enabled = false;
            this.spfileCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spfileCheckBox.ForeColor = System.Drawing.Color.White;
            this.spfileCheckBox.Location = new System.Drawing.Point(174, 360);
            this.spfileCheckBox.Name = "spfileCheckBox";
            this.spfileCheckBox.Size = new System.Drawing.Size(61, 20);
            this.spfileCheckBox.TabIndex = 34;
            this.spfileCheckBox.Text = "Spfile";
            this.spfileCheckBox.UseVisualStyleBackColor = true;
            // 
            // tablespaces
            // 
            this.tablespaces.BackColor = System.Drawing.SystemColors.GrayText;
            this.tablespaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablespaces.Enabled = false;
            this.tablespaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablespaces.ForeColor = System.Drawing.Color.Black;
            this.tablespaces.FormattingEnabled = true;
            this.tablespaces.ItemHeight = 16;
            this.tablespaces.Location = new System.Drawing.Point(184, 416);
            this.tablespaces.Name = "tablespaces";
            this.tablespaces.Size = new System.Drawing.Size(120, 80);
            this.tablespaces.TabIndex = 36;
            this.tablespaces.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click_tablespace);
            // 
            // tablespacesList
            // 
            this.tablespacesList.AutoSize = true;
            this.tablespacesList.Enabled = false;
            this.tablespacesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablespacesList.ForeColor = System.Drawing.Color.White;
            this.tablespacesList.Location = new System.Drawing.Point(171, 392);
            this.tablespacesList.Name = "tablespacesList";
            this.tablespacesList.Size = new System.Drawing.Size(89, 16);
            this.tablespacesList.TabIndex = 37;
            this.tablespacesList.Text = "Tablespaces";
            // 
            // backupTablespaces
            // 
            this.backupTablespaces.BackColor = System.Drawing.SystemColors.GrayText;
            this.backupTablespaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.backupTablespaces.Enabled = false;
            this.backupTablespaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupTablespaces.ForeColor = System.Drawing.Color.Black;
            this.backupTablespaces.FormattingEnabled = true;
            this.backupTablespaces.ItemHeight = 16;
            this.backupTablespaces.Location = new System.Drawing.Point(380, 416);
            this.backupTablespaces.Name = "backupTablespaces";
            this.backupTablespaces.Size = new System.Drawing.Size(120, 80);
            this.backupTablespaces.TabIndex = 38;
            this.backupTablespaces.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click_tablespaceRespaldo);
            // 
            // LH
            // 
            this.LH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.LH.Enabled = false;
            this.LH.FormattingEnabled = true;
            this.LH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24\t"});
            this.LH.Location = new System.Drawing.Point(616, 153);
            this.LH.Name = "LH";
            this.LH.Size = new System.Drawing.Size(38, 21);
            this.LH.TabIndex = 39;
            // 
            // ML
            // 
            this.ML.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ML.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.ML.Enabled = false;
            this.ML.FormattingEnabled = true;
            this.ML.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "",
            "",
            "",
            ""});
            this.ML.Location = new System.Drawing.Point(676, 154);
            this.ML.Name = "ML";
            this.ML.Size = new System.Drawing.Size(41, 21);
            this.ML.TabIndex = 40;
            // 
            // Lunes
            // 
            this.Lunes.AutoSize = true;
            this.Lunes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lunes.ForeColor = System.Drawing.Color.White;
            this.Lunes.Location = new System.Drawing.Point(512, 154);
            this.Lunes.Name = "Lunes";
            this.Lunes.Size = new System.Drawing.Size(75, 21);
            this.Lunes.TabIndex = 53;
            this.Lunes.Text = "Sunday";
            this.Lunes.UseVisualStyleBackColor = true;
            this.Lunes.CheckedChanged += new System.EventHandler(this.Lunes_CheckedChanged);
            // 
            // Martes
            // 
            this.Martes.AutoSize = true;
            this.Martes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Martes.ForeColor = System.Drawing.Color.White;
            this.Martes.Location = new System.Drawing.Point(512, 180);
            this.Martes.Name = "Martes";
            this.Martes.Size = new System.Drawing.Size(77, 21);
            this.Martes.TabIndex = 54;
            this.Martes.Text = "Monday";
            this.Martes.UseVisualStyleBackColor = true;
            this.Martes.CheckedChanged += new System.EventHandler(this.Martes_CheckedChanged);
            // 
            // Jueves
            // 
            this.Jueves.AutoSize = true;
            this.Jueves.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jueves.ForeColor = System.Drawing.Color.White;
            this.Jueves.Location = new System.Drawing.Point(512, 235);
            this.Jueves.Name = "Jueves";
            this.Jueves.Size = new System.Drawing.Size(102, 21);
            this.Jueves.TabIndex = 55;
            this.Jueves.Text = "Wednesday";
            this.Jueves.UseVisualStyleBackColor = true;
            this.Jueves.CheckedChanged += new System.EventHandler(this.Jueves_CheckedChanged);
            // 
            // Miercoles
            // 
            this.Miercoles.AutoSize = true;
            this.Miercoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Miercoles.ForeColor = System.Drawing.Color.White;
            this.Miercoles.Location = new System.Drawing.Point(512, 207);
            this.Miercoles.Name = "Miercoles";
            this.Miercoles.Size = new System.Drawing.Size(82, 21);
            this.Miercoles.TabIndex = 56;
            this.Miercoles.Text = "Tuesday";
            this.Miercoles.UseVisualStyleBackColor = true;
            this.Miercoles.CheckedChanged += new System.EventHandler(this.Miercoles_CheckedChanged);
            // 
            // Viernes
            // 
            this.Viernes.AutoSize = true;
            this.Viernes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viernes.ForeColor = System.Drawing.Color.White;
            this.Viernes.Location = new System.Drawing.Point(512, 262);
            this.Viernes.Name = "Viernes";
            this.Viernes.Size = new System.Drawing.Size(87, 21);
            this.Viernes.TabIndex = 57;
            this.Viernes.Text = "Thursday";
            this.Viernes.UseVisualStyleBackColor = true;
            this.Viernes.CheckedChanged += new System.EventHandler(this.Viernes_CheckedChanged);
            // 
            // Sabado
            // 
            this.Sabado.AutoSize = true;
            this.Sabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sabado.ForeColor = System.Drawing.Color.White;
            this.Sabado.Location = new System.Drawing.Point(512, 289);
            this.Sabado.Name = "Sabado";
            this.Sabado.Size = new System.Drawing.Size(66, 21);
            this.Sabado.TabIndex = 58;
            this.Sabado.Text = "Friday";
            this.Sabado.UseVisualStyleBackColor = true;
            this.Sabado.CheckedChanged += new System.EventHandler(this.Sabado_CheckedChanged);
            // 
            // Domingo
            // 
            this.Domingo.AutoSize = true;
            this.Domingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Domingo.ForeColor = System.Drawing.Color.White;
            this.Domingo.Location = new System.Drawing.Point(512, 316);
            this.Domingo.Name = "Domingo";
            this.Domingo.Size = new System.Drawing.Size(84, 21);
            this.Domingo.TabIndex = 59;
            this.Domingo.Text = "Saturday";
            this.Domingo.UseVisualStyleBackColor = true;
            this.Domingo.CheckedChanged += new System.EventHandler(this.Domingo_CheckedChanged);
            // 
            // MH
            // 
            this.MH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.MH.Enabled = false;
            this.MH.FormattingEnabled = true;
            this.MH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24\t"});
            this.MH.Location = new System.Drawing.Point(616, 180);
            this.MH.Name = "MH";
            this.MH.Size = new System.Drawing.Size(38, 21);
            this.MH.TabIndex = 60;
            // 
            // DH
            // 
            this.DH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.DH.Enabled = false;
            this.DH.FormattingEnabled = true;
            this.DH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24\t"});
            this.DH.Location = new System.Drawing.Point(616, 316);
            this.DH.Name = "DH";
            this.DH.Size = new System.Drawing.Size(38, 21);
            this.DH.TabIndex = 61;
            // 
            // SH
            // 
            this.SH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.SH.Enabled = false;
            this.SH.FormattingEnabled = true;
            this.SH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24\t"});
            this.SH.Location = new System.Drawing.Point(616, 289);
            this.SH.Name = "SH";
            this.SH.Size = new System.Drawing.Size(38, 21);
            this.SH.TabIndex = 62;
            // 
            // VH
            // 
            this.VH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.VH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.VH.Enabled = false;
            this.VH.FormattingEnabled = true;
            this.VH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24\t"});
            this.VH.Location = new System.Drawing.Point(616, 262);
            this.VH.Name = "VH";
            this.VH.Size = new System.Drawing.Size(38, 21);
            this.VH.TabIndex = 63;
            // 
            // JH
            // 
            this.JH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.JH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.JH.Enabled = false;
            this.JH.FormattingEnabled = true;
            this.JH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24\t"});
            this.JH.Location = new System.Drawing.Point(616, 235);
            this.JH.Name = "JH";
            this.JH.Size = new System.Drawing.Size(38, 21);
            this.JH.TabIndex = 64;
            // 
            // IH
            // 
            this.IH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.IH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.IH.Enabled = false;
            this.IH.FormattingEnabled = true;
            this.IH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24\t"});
            this.IH.Location = new System.Drawing.Point(616, 207);
            this.IH.Name = "IH";
            this.IH.Size = new System.Drawing.Size(38, 21);
            this.IH.TabIndex = 65;
            // 
            // MD
            // 
            this.MD.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MD.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.MD.Enabled = false;
            this.MD.FormattingEnabled = true;
            this.MD.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "",
            "",
            "",
            ""});
            this.MD.Location = new System.Drawing.Point(676, 316);
            this.MD.Name = "MD";
            this.MD.Size = new System.Drawing.Size(41, 21);
            this.MD.TabIndex = 66;
            // 
            // MS
            // 
            this.MS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.MS.Enabled = false;
            this.MS.FormattingEnabled = true;
            this.MS.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "",
            "",
            "",
            ""});
            this.MS.Location = new System.Drawing.Point(676, 289);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(41, 21);
            this.MS.TabIndex = 67;
            // 
            // MV
            // 
            this.MV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.MV.Enabled = false;
            this.MV.FormattingEnabled = true;
            this.MV.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "",
            "",
            "",
            ""});
            this.MV.Location = new System.Drawing.Point(676, 262);
            this.MV.Name = "MV";
            this.MV.Size = new System.Drawing.Size(41, 21);
            this.MV.TabIndex = 68;
            // 
            // MJ
            // 
            this.MJ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MJ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.MJ.Enabled = false;
            this.MJ.FormattingEnabled = true;
            this.MJ.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "",
            "",
            "",
            ""});
            this.MJ.Location = new System.Drawing.Point(676, 235);
            this.MJ.Name = "MJ";
            this.MJ.Size = new System.Drawing.Size(41, 21);
            this.MJ.TabIndex = 69;
            // 
            // MI
            // 
            this.MI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.MI.Enabled = false;
            this.MI.FormattingEnabled = true;
            this.MI.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "",
            "",
            "",
            ""});
            this.MI.Location = new System.Drawing.Point(676, 208);
            this.MI.Name = "MI";
            this.MI.Size = new System.Drawing.Size(41, 21);
            this.MI.TabIndex = 70;
            // 
            // MM
            // 
            this.MM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.MM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.MM.Enabled = false;
            this.MM.FormattingEnabled = true;
            this.MM.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "",
            "",
            "",
            ""});
            this.MM.Location = new System.Drawing.Point(676, 180);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(41, 21);
            this.MM.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(527, 121);
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
            this.label9.Location = new System.Drawing.Point(615, 118);
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
            this.label10.Location = new System.Drawing.Point(663, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 81;
            this.label10.Text = "Minutes";
            // 
            // CrearEstrategia
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(984, 687);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.MI);
            this.Controls.Add(this.MJ);
            this.Controls.Add(this.MV);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.MD);
            this.Controls.Add(this.IH);
            this.Controls.Add(this.JH);
            this.Controls.Add(this.VH);
            this.Controls.Add(this.SH);
            this.Controls.Add(this.DH);
            this.Controls.Add(this.MH);
            this.Controls.Add(this.Domingo);
            this.Controls.Add(this.Sabado);
            this.Controls.Add(this.Viernes);
            this.Controls.Add(this.Miercoles);
            this.Controls.Add(this.Jueves);
            this.Controls.Add(this.Martes);
            this.Controls.Add(this.Lunes);
            this.Controls.Add(this.ML);
            this.Controls.Add(this.LH);
            this.Controls.Add(this.backupTablespaces);
            this.Controls.Add(this.tablespacesList);
            this.Controls.Add(this.tablespaces);
            this.Controls.Add(this.spfileCheckBox);
            this.Controls.Add(this.controlCheckBox);
            this.Controls.Add(this.partialBackupCB);
            this.Controls.Add(this.levelGroupBox);
            this.Controls.Add(this.incrementalBackupCB);
            this.Controls.Add(this.ARCHIVE_CB);
            this.Controls.Add(this.fullBackupCB);
            this.Controls.Add(this.strategiesTitle);
            this.Controls.Add(this.typeBackup);
            this.Controls.Add(this.dbInstance);
            this.Controls.Add(this.bdServer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 726);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 726);
            this.Name = "CrearEstrategia";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Backup Strategies";
            this.Load += new System.EventHandler(this.CrearEstrategia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.levelGroupBox.ResumeLayout(false);
            this.levelGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox picture;
        private ListaEstrategia app;
        private System.Windows.Forms.Label bdServer;
        private System.Windows.Forms.Label dbInstance;
        private System.Windows.Forms.Label typeBackup;
        private System.Windows.Forms.Label strategiesTitle;
        private System.Windows.Forms.CheckBox fullBackupCB;
        private System.Windows.Forms.CheckBox ARCHIVE_CB;
        private System.Windows.Forms.CheckBox incrementalBackupCB;
        private System.Windows.Forms.RadioButton level1;
        private System.Windows.Forms.RadioButton level0;
        private System.Windows.Forms.GroupBox levelGroupBox;
        private System.Windows.Forms.CheckBox partialBackupCB;
        private System.Windows.Forms.CheckBox controlCheckBox;
        private System.Windows.Forms.CheckBox spfileCheckBox;
        private System.Windows.Forms.ListBox tablespaces;
        private System.Windows.Forms.Label tablespacesList;
        private System.Windows.Forms.ListBox backupTablespaces;
        private String connection;
        List<string> backupScript = new List<string>();
        

        private void fullBackupCB_Change(object sender, EventArgs e)
        {
            if (fullBackupCB.Checked)
            {
                backupScript.Add("backup database;");
                incrementalBackupCB.Enabled = false;
                levelGroupBox.Enabled = false;
                partialBackupCB.Enabled = false;
                controlCheckBox.Enabled = false;
                spfileCheckBox.Enabled = false;
                //logsCheckBox.Enabled = false;
                tablespaces.Enabled = false;
                backupTablespaces.Enabled = false;
            }
            else
            {
                backupScript.Remove("backup database;");
                incrementalBackupCB.Enabled = true;
                levelGroupBox.Enabled = false;
                partialBackupCB.Enabled = true;
                controlCheckBox.Enabled = false;
                spfileCheckBox.Enabled = false;
               // logsCheckBox.Enabled = false;
                tablespaces.Enabled = false;
                backupTablespaces.Enabled = false;
            }
        }

        private void ARCHIVE_CB_Change(object sender, EventArgs e)
        {
            if (ARCHIVE_CB.Checked)
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

        private void incrementalBackupCB_Change(object sender, EventArgs e)
        {
            if (incrementalBackupCB.Checked)
            {
                fullBackupCB.Enabled = false;
                levelGroupBox.Enabled = true;
                partialBackupCB.Enabled = false;
                controlCheckBox.Enabled = false;
                spfileCheckBox.Enabled = false;
                //logsCheckBox.Enabled = false;
                tablespaces.Enabled = false;
                backupTablespaces.Enabled = false;
            }
            else
            {
                fullBackupCB.Enabled = true;
                levelGroupBox.Enabled = false;
                partialBackupCB.Enabled = true;
                controlCheckBox.Enabled = false;
                spfileCheckBox.Enabled = false;
                //logsCheckBox.Enabled = false;
                tablespaces.Enabled = false;
                backupTablespaces.Enabled = false;
                backupScript = new List<string>();
                backupScript.Add("run{");
                level0.Checked = false;
                level1.Checked = false;
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

        private void agregarEstrategia_Click(object sender, EventArgs e)
        {
            var dateTime = DateTime.Now;
            var dateTimeOffset = new DateTimeOffset(dateTime);
            var unixDateTime = dateTimeOffset.ToUnixTimeSeconds().ToString();
            String idstrategy = "EST_" + unixDateTime;
            backupScript.Add("}");
            if (backupScript.Count > 2)
            {
                insertStrategies(idstrategy, connection);
                insertStrategiesRemote(idstrategy, connection);
                int cont = 0;
                foreach (string scriptline in backupScript)
                {
                    
                    insertStrategiesLines(idstrategy, cont, scriptline);
                    insertStrategiesLinesRemote(idstrategy, cont, scriptline, connection);
                    cont++;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Select a backup strategy");
                backupScript.Remove("}");
            }

        }

        public void insertStrategies(String idstrategy, String conexion) {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "insert_strategy";
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, idstrategy, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, conexion, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, "MEDIUM", ParameterDirection.Input));
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
        public void insertStrategiesRemote(String idstrategy, String conexion)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "insert into strategy@"+conexion+ " values(:1,:2,:3,:4)";
                //objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, idstrategy, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, conexion, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, "MEDIUM", ParameterDirection.Input));
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
               // objCmd.CommandType = CommandType.StoredProcedure;

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
        public void click_tablespace(object sender, EventArgs e)
        {
            if (tablespaces.SelectedItem != null)
            {
                backupTablespaces.Items.Add(tablespaces.SelectedItem);
                tablespaces.Items.Remove(tablespaces.SelectedItem);
            }
        }
        public void click_tablespaceRespaldo(object sender, EventArgs e)
        {
            if (backupTablespaces.SelectedItem != null)
            {
                tablespaces.Items.Add(backupTablespaces.SelectedItem);
                backupTablespaces.Items.Remove(backupTablespaces.SelectedItem);
            }
        }
        public void solicitaTablespaces(String conexion)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet tableSpaces = new DataSet("tablespaces");
                //Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "SELECT TABLESPACE_NAME from DBA_TABLESPACES@" + conexion;
                //objCmd.CommandType = CommandType.StoredProcedure;
                //Set parameters
                // OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                // objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, conexion, ParameterDirection.Input));

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

        private void Lunes_CheckedChanged(object sender, EventArgs e) {
            if (Lunes.Checked) {
                LH.Enabled = true;
                ML.Enabled = true;
                Lunes.BackColor = System.Drawing.Color.White;
               
            }
            else
            {
                
                LH.Enabled = false;
                ML.Enabled = false;

            }

        }
        private void Martes_CheckedChanged(object sender, EventArgs e)
        {
            if (Martes.Checked )
            {
                MH.Enabled = true;
                MM.Enabled = true;
            }
            else
            {
                MH.Enabled = false;
                MM.Enabled = false;
            }

        }
        private void Miercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (Miercoles.Checked)
            {
                IH.Enabled = true;
                MI.Enabled = true;
            }
            else
            {
                IH.Enabled = false;
                MI.Enabled = false;
            }

        }
        private void Jueves_CheckedChanged(object sender, EventArgs e)
        {
            if (Jueves.Checked)
            {
                JH.Enabled = true;
                MJ.Enabled = true;
            }
            else
            {
                JH.Enabled = false;
                MJ.Enabled = false;
            }

        }
        private void Viernes_CheckedChanged(object sender, EventArgs e)
        {
            if (Viernes.Checked)
            {
                VH.Enabled = true;
                MV.Enabled = true;
            }
            else
            {
                VH.Enabled = false;
                MV.Enabled = false;
            }

        }
        private void Sabado_CheckedChanged(object sender, EventArgs e)
        {
            if (Sabado.Checked )
            {
                SH.Enabled = true;
                MS.Enabled = true;
            }
            else
            {
                SH.Enabled = false;
                MS.Enabled = false;
            }

        }
        private void Domingo_CheckedChanged(object sender, EventArgs e)
        {
            if (Lunes.Checked )
            {
                DH.Enabled = true;
                MD.Enabled = true;
               
            }
            else
            {
                DH.Enabled = false;
                MD.Enabled = false;
            }
            
        }
        private void partialBackupCB_CheckedChanged(object sender, EventArgs e)
        {
            if (partialBackupCB.Checked)
            {
                tablespaces.Enabled = true;
                backupTablespaces.Enabled = true;
                fullBackupCB.Enabled = false;
                incrementalBackupCB.Enabled = false;
                spfileCheckBox.Enabled = true;
                controlCheckBox.Enabled = true;


            }
            else
            {
                tablespaces.Enabled = false;
                backupTablespaces.Enabled =false;
                fullBackupCB.Enabled = true;
                incrementalBackupCB.Enabled =true;
                spfileCheckBox.Enabled = false;
                controlCheckBox.Enabled = false;
            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

        private System.Windows.Forms.ComboBox LH;
        private System.Windows.Forms.ComboBox ML;
        private System.Windows.Forms.CheckBox Lunes;
        private System.Windows.Forms.CheckBox Martes;
        private System.Windows.Forms.CheckBox Jueves;
        private System.Windows.Forms.CheckBox Miercoles;
        private System.Windows.Forms.CheckBox Viernes;
        private System.Windows.Forms.CheckBox Sabado;
        private System.Windows.Forms.CheckBox Domingo;
        private System.Windows.Forms.ComboBox MH;
        private System.Windows.Forms.ComboBox DH;
        private System.Windows.Forms.ComboBox SH;
        private System.Windows.Forms.ComboBox VH;
        private System.Windows.Forms.ComboBox JH;
        private System.Windows.Forms.ComboBox IH;
        private System.Windows.Forms.ComboBox MD;
        private System.Windows.Forms.ComboBox MS;
        private System.Windows.Forms.ComboBox MV;
        private System.Windows.Forms.ComboBox MJ;
        private System.Windows.Forms.ComboBox MI;
        private System.Windows.Forms.ComboBox MM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;

        //public void solicitaEstrategias(String conexion)
        //{
        //    using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
        //    {
        //        DataSet basesRegistradas = new DataSet("Estrategias");
        //        //Create and execute the command
        //        OracleCommand objCmd = new OracleCommand();
        //        objCmd.Connection = objConn;
        //        objCmd.CommandText = "get_strategy";
        //        objCmd.CommandType = CommandType.StoredProcedure;
        //        //Set parameters
        //        OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
        //        objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, conexion, ParameterDirection.Input));

        //        try
        //        {
        //            objConn.Open();
        //            objCmd.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {
        //            System.Console.WriteLine("Exception: {0}", ex.ToString());
        //        }

        //        objConn.Close();
        //        objConn.Dispose();
        //    }
        //}
    }
}