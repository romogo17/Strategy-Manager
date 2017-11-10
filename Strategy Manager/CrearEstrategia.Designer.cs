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
            this.fullBackUpARCHIVE_CB = new System.Windows.Forms.CheckBox();
            this.incrementalBackupCB = new System.Windows.Forms.CheckBox();
            this.level0 = new System.Windows.Forms.RadioButton();
            this.level1 = new System.Windows.Forms.RadioButton();
            this.levelGroupBox = new System.Windows.Forms.GroupBox();
            this.partialBackupCB = new System.Windows.Forms.CheckBox();
            this.controlCheckBox = new System.Windows.Forms.CheckBox();
            this.spfileCheckBox = new System.Windows.Forms.CheckBox();
            this.logsCheckBox = new System.Windows.Forms.CheckBox();
            this.tablespaces = new System.Windows.Forms.ListBox();
            this.tablespacesList = new System.Windows.Forms.Label();
            this.backupTablespaces = new System.Windows.Forms.ListBox();
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
            this.picture.Location = new System.Drawing.Point(310, 448);
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
            // fullBackUpARCHIVE_CB
            // 
            this.fullBackUpARCHIVE_CB.AutoSize = true;
            this.fullBackUpARCHIVE_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullBackUpARCHIVE_CB.ForeColor = System.Drawing.Color.White;
            this.fullBackUpARCHIVE_CB.Location = new System.Drawing.Point(123, 178);
            this.fullBackUpARCHIVE_CB.Name = "fullBackUpARCHIVE_CB";
            this.fullBackUpARCHIVE_CB.Size = new System.Drawing.Size(184, 20);
            this.fullBackUpARCHIVE_CB.TabIndex = 26;
            this.fullBackUpARCHIVE_CB.Text = "Full Backup with ARCHIVE";
            this.fullBackUpARCHIVE_CB.UseVisualStyleBackColor = true;
            this.fullBackUpARCHIVE_CB.CheckedChanged += new System.EventHandler(this.fullBackUpARCHIVE_CB_Change);
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
            // logsCheckBox
            // 
            this.logsCheckBox.AutoSize = true;
            this.logsCheckBox.Enabled = false;
            this.logsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsCheckBox.ForeColor = System.Drawing.Color.White;
            this.logsCheckBox.Location = new System.Drawing.Point(174, 383);
            this.logsCheckBox.Name = "logsCheckBox";
            this.logsCheckBox.Size = new System.Drawing.Size(57, 20);
            this.logsCheckBox.TabIndex = 35;
            this.logsCheckBox.Text = "Logs";
            this.logsCheckBox.UseVisualStyleBackColor = true;
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
            this.tablespaces.Items.AddRange(new object[] {
            "users",
            "temp"});
            this.tablespaces.Location = new System.Drawing.Point(184, 434);
            this.tablespaces.Name = "tablespaces";
            this.tablespaces.Size = new System.Drawing.Size(120, 96);
            this.tablespaces.TabIndex = 36;
            // 
            // tablespacesList
            // 
            this.tablespacesList.AutoSize = true;
            this.tablespacesList.Enabled = false;
            this.tablespacesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablespacesList.ForeColor = System.Drawing.Color.White;
            this.tablespacesList.Location = new System.Drawing.Point(171, 411);
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
            this.backupTablespaces.Items.AddRange(new object[] {
            "users",
            "temp"});
            this.backupTablespaces.Location = new System.Drawing.Point(380, 434);
            this.backupTablespaces.Name = "backupTablespaces";
            this.backupTablespaces.Size = new System.Drawing.Size(120, 96);
            this.backupTablespaces.TabIndex = 38;
            // 
            // CrearEstrategia
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(816, 586);
            this.Controls.Add(this.backupTablespaces);
            this.Controls.Add(this.tablespacesList);
            this.Controls.Add(this.tablespaces);
            this.Controls.Add(this.logsCheckBox);
            this.Controls.Add(this.spfileCheckBox);
            this.Controls.Add(this.controlCheckBox);
            this.Controls.Add(this.partialBackupCB);
            this.Controls.Add(this.levelGroupBox);
            this.Controls.Add(this.incrementalBackupCB);
            this.Controls.Add(this.fullBackUpARCHIVE_CB);
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
            this.MaximumSize = new System.Drawing.Size(832, 625);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(832, 625);
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
        private System.Windows.Forms.CheckBox fullBackUpARCHIVE_CB;
        private System.Windows.Forms.CheckBox incrementalBackupCB;
        private System.Windows.Forms.RadioButton level1;
        private System.Windows.Forms.RadioButton level0;
        private System.Windows.Forms.GroupBox levelGroupBox;
        private System.Windows.Forms.CheckBox partialBackupCB;
        private System.Windows.Forms.CheckBox controlCheckBox;
        private System.Windows.Forms.CheckBox spfileCheckBox;
        private System.Windows.Forms.CheckBox logsCheckBox;
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
                fullBackUpARCHIVE_CB.Enabled = false;
                incrementalBackupCB.Enabled = false;
                levelGroupBox.Enabled = false;
                partialBackupCB.Enabled = false;
                controlCheckBox.Enabled = false;
                spfileCheckBox.Enabled = false;
                logsCheckBox.Enabled = false;
                tablespaces.Enabled = false;
                backupTablespaces.Enabled = false;
                //System.Windows.Forms.MessageBox.Show(backupScript[0].ToString()+" - "+backupScript[1].ToString());
            }
            else
            {
                backupScript.Remove("backup database;");
                fullBackUpARCHIVE_CB.Enabled = true;
                incrementalBackupCB.Enabled = true;
                levelGroupBox.Enabled = false;
                partialBackupCB.Enabled = true;
                controlCheckBox.Enabled = false;
                spfileCheckBox.Enabled = false;
                logsCheckBox.Enabled = false;
                tablespaces.Enabled = false;
                backupTablespaces.Enabled = false;
            }
        }

        private void fullBackUpARCHIVE_CB_Change(object sender, EventArgs e)
        {
            if (fullBackUpARCHIVE_CB.Checked)
            {
                backupScript = new List<string>();
                backupScript.Add("crosscheck archivelog all;");
                backupScript.Add("run{");
                backupScript.Add("SQL \"alter system switch logfile\";");
                backupScript.Add("backup database plus archivelog;");
                fullBackupCB.Enabled = false;
                incrementalBackupCB.Enabled = false;
                levelGroupBox.Enabled = false;
                partialBackupCB.Enabled = false;
                controlCheckBox.Enabled = false;
                spfileCheckBox.Enabled = false;
                logsCheckBox.Enabled = false;
                tablespaces.Enabled = false;
                backupTablespaces.Enabled = false;
            }
            else
            {
                backupScript = new List<string>();
                backupScript.Add("run{");
                fullBackupCB.Enabled = true;
                incrementalBackupCB.Enabled = true;
                levelGroupBox.Enabled = false;
                partialBackupCB.Enabled = true;
                controlCheckBox.Enabled = false;
                spfileCheckBox.Enabled = false;
                logsCheckBox.Enabled = false;
                tablespaces.Enabled = false;
                backupTablespaces.Enabled = false;
            }
        }

        private void incrementalBackupCB_Change(object sender, EventArgs e)
        {
            if (incrementalBackupCB.Checked)
            {
                fullBackupCB.Enabled = false;
                fullBackUpARCHIVE_CB.Enabled = false;
                levelGroupBox.Enabled = true;
                partialBackupCB.Enabled = false;
                controlCheckBox.Enabled = false;
                spfileCheckBox.Enabled = false;
                logsCheckBox.Enabled = false;
                tablespaces.Enabled = false;
                backupTablespaces.Enabled = false;
            }
            else
            {
                fullBackupCB.Enabled = true;
                fullBackUpARCHIVE_CB.Enabled = true;
                levelGroupBox.Enabled = false;
                partialBackupCB.Enabled = true;
                controlCheckBox.Enabled = false;
                spfileCheckBox.Enabled = false;
                logsCheckBox.Enabled = false;
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
                foreach (string scriptline in backupScript)
                {
                    insertStrategiesLines(idstrategy, scriptline);
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

        public void insertStrategiesLines(String idstrategy, String line)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "insert_strategyline";
                objCmd.CommandType = CommandType.StoredProcedure;

                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, idstrategy, ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, line, ParameterDirection.Input));
                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    this.Close();
                    System.Windows.Forms.MessageBox.Show("Strategy line register successfully");

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                }

                objConn.Close();
                objConn.Dispose();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }

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