namespace Strategy_Manager
{
    using System;
    using System.Windows.Forms;
    using LiveCharts;
    using LiveCharts.Configurations;
    using LiveCharts.Wpf;
    //using System.Data.OracleClient;
    //using Oracle.DataAccess.Client;
    //using Oracle.DataAccess.Types;
    using Oracle.ManagedDataAccess.Client;
    using Oracle.ManagedDataAccess.Types;
    using System.Data;
    using System.Configuration;
    using System.Windows.Media;
    using System.IO;
    using System.Reflection;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Threading;
    using System.Linq;
    using System.Xml;

    partial class ConsultaError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaError));
            this.strategiesTitle = new System.Windows.Forms.Label();
            this.logDescrip = new System.Windows.Forms.TextBox();
            this.logId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // strategiesTitle
            // 
            this.strategiesTitle.AutoSize = true;
            this.strategiesTitle.Font = new System.Drawing.Font("Arial Narrow", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strategiesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.strategiesTitle.Location = new System.Drawing.Point(22, 24);
            this.strategiesTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.strategiesTitle.Name = "strategiesTitle";
            this.strategiesTitle.Size = new System.Drawing.Size(0, 42);
            this.strategiesTitle.TabIndex = 22;
            // 
            // logDescrip
            // 
            this.logDescrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logDescrip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.logDescrip.Location = new System.Drawing.Point(12, 122);
            this.logDescrip.Multiline = true;
            this.logDescrip.Name = "logDescrip";
            this.logDescrip.ReadOnly = true;
            this.logDescrip.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logDescrip.Size = new System.Drawing.Size(794, 327);
            this.logDescrip.TabIndex = 26;
            this.logDescrip.Text = "Hola";
            // 
            // logId
            // 
            this.logId.AutoSize = true;
            this.logId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logId.ForeColor = System.Drawing.Color.White;
            this.logId.Location = new System.Drawing.Point(8, 66);
            this.logId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logId.Name = "logId";
            this.logId.Size = new System.Drawing.Size(48, 20);
            this.logId.TabIndex = 28;
            this.logId.Text = "Log : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "Error Specification";
            // 
            // logDate
            // 
            this.logDate.AutoSize = true;
            this.logDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logDate.ForeColor = System.Drawing.Color.White;
            this.logDate.Location = new System.Drawing.Point(8, 99);
            this.logDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logDate.Name = "logDate";
            this.logDate.Size = new System.Drawing.Size(48, 20);
            this.logDate.TabIndex = 29;
            this.logDate.Text = "Date:";
            // 
            // ConsultaError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(818, 461);
            this.Controls.Add(this.logDate);
            this.Controls.Add(this.logId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logDescrip);
            this.Controls.Add(this.strategiesTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsultaError";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label estrategia;


        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
        private void editarBaseDatosToolStripMenuItem_click(object sender, EventArgs e)
        {

        }

        public void solicitaLogs(String estrategia)
        {   

            
        }
        private Label strategiesTitle;
        private TextBox logDescrip;
        private Label logId;
        private Label label1;
        private Label logDate;
    }

}

