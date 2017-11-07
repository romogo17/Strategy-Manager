using Oracle.ManagedDataAccess.Client;
using System;
using System.Configuration;
using System.Data;

namespace Oracle_Tablespace_Monitor
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
            this.comboServidores = new System.Windows.Forms.ComboBox();
            this.backupParcial = new System.Windows.Forms.RadioButton();
            this.backupFull = new System.Windows.Forms.RadioButton();
            this.backupParcialIncremental = new System.Windows.Forms.RadioButton();
            this.tableSpaces = new System.Windows.Forms.ListBox();
            this.tableSpacesRespaldo = new System.Windows.Forms.ListBox();
            this.archive = new System.Windows.Forms.CheckBox();
            this.controlFile = new System.Windows.Forms.CheckBox();
            this.spFile = new System.Windows.Forms.CheckBox();
            this.servidores = new System.Windows.Forms.Label();
            this.tsSelecionados = new System.Windows.Forms.Label();
            this.tsTodos = new System.Windows.Forms.Label();
            this.arcLabel = new System.Windows.Forms.Label();
            this.cfLabel = new System.Windows.Forms.Label();
            this.spfLabel = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(952, 634);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.agregarEstrategia_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(1072, 634);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // comboServidores
            // 
            this.comboServidores.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.comboServidores.Location = new System.Drawing.Point(198, 142);
            this.comboServidores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboServidores.Name = "comboServidores";
            this.comboServidores.Size = new System.Drawing.Size(180, 28);
            this.comboServidores.TabIndex = 4;
            this.comboServidores.Text = "Servidor";
            // 
            // backupParcial
            // 
            this.backupParcial.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backupParcial.Location = new System.Drawing.Point(72, 226);
            this.backupParcial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backupParcial.Name = "backupParcial";
            this.backupParcial.Size = new System.Drawing.Size(224, 37);
            this.backupParcial.TabIndex = 5;
            this.backupParcial.Text = "Backup Parcial Completo";
            this.backupParcial.Click += new System.EventHandler(this.activaParcial);
            // 
            // backupFull
            // 
            this.backupFull.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backupFull.Location = new System.Drawing.Point(304, 226);
            this.backupFull.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backupFull.Name = "backupFull";
            this.backupFull.Size = new System.Drawing.Size(130, 37);
            this.backupFull.TabIndex = 6;
            this.backupFull.Text = "Backup Full";
            this.backupFull.Click += new System.EventHandler(this.activaFull);
            // 
            // backupParcialIncremental
            // 
            this.backupParcialIncremental.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.backupParcialIncremental.Location = new System.Drawing.Point(436, 226);
            this.backupParcialIncremental.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backupParcialIncremental.Name = "backupParcialIncremental";
            this.backupParcialIncremental.Size = new System.Drawing.Size(234, 37);
            this.backupParcialIncremental.TabIndex = 0;
            this.backupParcialIncremental.Text = "Backup Parcial Incremental";
            // 
            // tableSpaces
            // 
            this.tableSpaces.ItemHeight = 20;
            this.tableSpaces.Location = new System.Drawing.Point(102, 512);
            this.tableSpaces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableSpaces.Name = "tableSpaces";
            this.tableSpaces.Size = new System.Drawing.Size(178, 144);
            this.tableSpaces.TabIndex = 7;
            // 
            // tableSpacesRespaldo
            // 
            this.tableSpacesRespaldo.ItemHeight = 20;
            this.tableSpacesRespaldo.Location = new System.Drawing.Point(454, 512);
            this.tableSpacesRespaldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableSpacesRespaldo.Name = "tableSpacesRespaldo";
            this.tableSpacesRespaldo.Size = new System.Drawing.Size(178, 144);
            this.tableSpacesRespaldo.TabIndex = 0;
            // 
            // archive
            // 
            this.archive.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.archive.Location = new System.Drawing.Point(219, 425);
            this.archive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.archive.Name = "archive";
            this.archive.Size = new System.Drawing.Size(24, 23);
            this.archive.TabIndex = 9;
            // 
            // controlFile
            // 
            this.controlFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.controlFile.Location = new System.Drawing.Point(614, 423);
            this.controlFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlFile.Name = "controlFile";
            this.controlFile.Size = new System.Drawing.Size(21, 25);
            this.controlFile.TabIndex = 8;
            // 
            // spFile
            // 
            this.spFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.spFile.Location = new System.Drawing.Point(398, 423);
            this.spFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spFile.Name = "spFile";
            this.spFile.Size = new System.Drawing.Size(20, 20);
            this.spFile.TabIndex = 0;
            // 
            // servidores
            // 
            this.servidores.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.servidores.Location = new System.Drawing.Point(98, 146);
            this.servidores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.servidores.Name = "servidores";
            this.servidores.Size = new System.Drawing.Size(86, 35);
            this.servidores.TabIndex = 12;
            this.servidores.Text = "Servidores";
            // 
            // tsSelecionados
            // 
            this.tsSelecionados.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tsSelecionados.Location = new System.Drawing.Point(432, 472);
            this.tsSelecionados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tsSelecionados.Name = "tsSelecionados";
            this.tsSelecionados.Size = new System.Drawing.Size(202, 35);
            this.tsSelecionados.TabIndex = 10;
            this.tsSelecionados.Text = "Tablespaces Selecionados";
            // 
            // tsTodos
            // 
            this.tsTodos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tsTodos.Location = new System.Drawing.Point(136, 472);
            this.tsTodos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tsTodos.Name = "tsTodos";
            this.tsTodos.Size = new System.Drawing.Size(105, 35);
            this.tsTodos.TabIndex = 11;
            this.tsTodos.Text = "Tablespaces";
            // 
            // arcLabel
            // 
            this.arcLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.arcLabel.Location = new System.Drawing.Point(136, 425);
            this.arcLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arcLabel.Name = "arcLabel";
            this.arcLabel.Size = new System.Drawing.Size(74, 20);
            this.arcLabel.TabIndex = 14;
            this.arcLabel.Text = "Archives";
            // 
            // cfLabel
            // 
            this.cfLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cfLabel.Location = new System.Drawing.Point(498, 425);
            this.cfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cfLabel.Name = "cfLabel";
            this.cfLabel.Size = new System.Drawing.Size(92, 22);
            this.cfLabel.TabIndex = 15;
            this.cfLabel.Text = "Control File";
            // 
            // spfLabel
            // 
            this.spfLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.spfLabel.Location = new System.Drawing.Point(330, 423);
            this.spfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.spfLabel.Name = "spfLabel";
            this.spfLabel.Size = new System.Drawing.Size(58, 22);
            this.spfLabel.TabIndex = 13;
            this.spfLabel.Text = "spFile";
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(315, 532);
            this.picture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(102, 105);
            this.picture.TabIndex = 16;
            this.picture.TabStop = false;
            // 
            // CrearEstrategia
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1218, 683);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboServidores);
            this.Controls.Add(this.backupParcial);
            this.Controls.Add(this.backupFull);
            this.Controls.Add(this.backupParcialIncremental);
            this.Controls.Add(this.tableSpaces);
            this.Controls.Add(this.controlFile);
            this.Controls.Add(this.spFile);
            this.Controls.Add(this.tableSpacesRespaldo);
            this.Controls.Add(this.archive);
            this.Controls.Add(this.tsSelecionados);
            this.Controls.Add(this.tsTodos);
            this.Controls.Add(this.servidores);
            this.Controls.Add(this.spfLabel);
            this.Controls.Add(this.arcLabel);
            this.Controls.Add(this.cfLabel);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1240, 739);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1240, 739);
            this.Name = "CrearEstrategia";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de Estrategia de Respaldo";
            this.Load += new System.EventHandler(this.CrearEstrategia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboServidores;
        private System.Windows.Forms.RadioButton backupParcial;
        private System.Windows.Forms.RadioButton backupFull;
        private System.Windows.Forms.RadioButton backupParcialIncremental;
        private System.Windows.Forms.ListBox tableSpaces;
        private System.Windows.Forms.ListBox tableSpacesRespaldo;
        private System.Windows.Forms.CheckBox controlFile;
        private System.Windows.Forms.CheckBox archive;
        private System.Windows.Forms.CheckBox spFile;

        private System.Windows.Forms.Label tsTodos;
        private System.Windows.Forms.Label tsSelecionados;
        private System.Windows.Forms.Label servidores;

        private System.Windows.Forms.Label cfLabel;
        private System.Windows.Forms.Label arcLabel;
        private System.Windows.Forms.Label spfLabel;

        private System.Windows.Forms.PictureBox picture;

        private Application app;

        private void agregarEstrategia_Click(object sender, EventArgs e)
        {
            DateTime foo = DateTime.Now;
            long unixTime = ((DateTimeOffset)foo).ToUnixTimeSeconds();

            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "insert_strategy";
                objCmd.CommandType = CommandType.StoredProcedure;


                //OracleCommand objCmd2 = new OracleCommand();
                //objCmd2.Connection = objConn;
                //objCmd2.CommandText = "Insert into CONEXIONES VALUES (:1,:2,:3,:4,:5)";

                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, "EST_", ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("2", OracleDbType.Varchar2, "C_1509986176", ParameterDirection.Input));
                objCmd.Parameters.Add(new OracleParameter("3", OracleDbType.Varchar2, "MEDIUM", ParameterDirection.Input));
                //objCmd.Parameters.Add(new OracleParameter("4", OracleDbType.Decimal, 1, ParameterDirection.Input));
                //objCmd2.Parameters.Add(new OracleParameter("5", OracleDbType.Char, '1', ParameterDirection.Input));
                try
                {
                    objConn.Open();
                    //objCmd2.ExecuteNonQuery();
                    objCmd.ExecuteNonQuery();
                    this.Close();
                    System.Windows.Forms.MessageBox.Show("Estrategia Registrada correctamente");

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
        private void activaParcial(object sender,EventArgs e)
        {
            this.tableSpaces.Enabled = true;
            this.tableSpacesRespaldo.Enabled = true;
            this.controlFile.Enabled = true;
            this.archive.Enabled = true;
            this.spFile.Enabled = true;
        }
        private void activaFull(object sender, EventArgs e)
        {
            this.tableSpaces.Enabled = false;
            this.tableSpacesRespaldo.Enabled = false;
            this.controlFile.Enabled = false;
            this.archive.Enabled = false;
            this.spFile.Enabled = false;
        }
    }
}