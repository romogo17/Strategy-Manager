namespace Oracle_Tablespace_Monitor
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

    partial class Application
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application));
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarBaseDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.myLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarBaseDatosToolStripMenuItem,
            this.editarBaseDeDatosToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.opcionesToolStripMenuItem.Text = "Options";
            // 
            // registrarBaseDatosToolStripMenuItem
            // 
            this.registrarBaseDatosToolStripMenuItem.Name = "registrarBaseDatosToolStripMenuItem";
            this.registrarBaseDatosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.registrarBaseDatosToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.registrarBaseDatosToolStripMenuItem.Text = "Register Database";
            this.registrarBaseDatosToolStripMenuItem.Click += new System.EventHandler(this.registrarBaseDatosToolStripMenuItem_click);
            // 
            // editarBaseDeDatosToolStripMenuItem
            // 
            this.editarBaseDeDatosToolStripMenuItem.Name = "editarBaseDeDatosToolStripMenuItem";
            this.editarBaseDeDatosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.editarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(302, 30);
            this.editarBaseDeDatosToolStripMenuItem.Text = "Edit Database";
            this.editarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.editarBaseDatosToolStripMenuItem_click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1227, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myLayout
            // 
            this.myLayout.AutoScroll = true;
            this.myLayout.Controls.Add(this.dataGridView1);
            this.myLayout.Location = new System.Drawing.Point(50, 177);
            this.myLayout.Name = "myLayout";
            this.myLayout.Size = new System.Drawing.Size(1136, 503);
            this.myLayout.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(992, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(992, 188);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.mainTitle.Location = new System.Drawing.Point(36, 80);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(635, 83);
            this.mainTitle.TabIndex = 18;
            this.mainTitle.Text = "Database Connections";
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1227, 709);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.myLayout);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Application";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strategy Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.myLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem registrarBaseDatosToolStripMenuItem;
        private MenuStrip menuStrip1;
        private FlowLayoutPanel myLayout;
        private DataGridView dataGridView1;
        private ToolStripMenuItem editarBaseDeDatosToolStripMenuItem;

        private void registrarBaseDatosToolStripMenuItem_click(object sender, EventArgs e)
        {
            RegistroBase ch = new RegistroBase(this);
            ch.ShowDialog(this);
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String baseBusqueda="";
            String servidor = "";
            String conexion = "";
            if (e.RowIndex>= 0) {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                baseBusqueda = row.Cells["DATABASE_INSTANCE"].Value.ToString();
                servidor = row.Cells["CONN_NAME"].Value.ToString();
                conexion = row.Cells["CONN_ID"].Value.ToString();
                ListaEstrategia lista = new ListaEstrategia(this, servidor, baseBusqueda, conexion);
                //System.Windows.Forms.MessageBox.Show(servidor + baseBusqueda);
                lista.ShowDialog();
               
            }
        }
        private void editarBaseDatosToolStripMenuItem_click(object sender, EventArgs e)
        {
                int index = dataGridView1.CurrentCell.RowIndex;
                if (index >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[index];
                    String baseD= row.Cells["DATABASE_INSTANCE"].Value.ToString();
                    String ser = row.Cells["CONN_NAME"].Value.ToString();
                    String ip = row.Cells["IP"].Value.ToString();
                    String puerto = row.Cells["PORT"].Value.ToString();
                    String alive = row.Cells["ALIVE"].Value.ToString();
                    EditarBase ce = new EditarBase(this, baseD, ser, ip, puerto, alive);
                    ce.ShowDialog(this);
                }
        }

        public void solicitaBases()
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet basesRegistradas = new DataSet("Bases");
                // Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "get_database";
                objCmd.CommandType = CommandType.StoredProcedure;
                // Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                //objCmd.Parameters.Add("return_value", OracleDbType.Int32, sgaSize, System.Data.ParameterDirection.Input);

                try
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                    OracleDataAdapter a = new OracleDataAdapter(objCmd);
                    a.TableMappings.Add("MyTable", "sample_table"); // possible need for this
                    a.Fill(basesRegistradas);
                    dataGridView1.DataSource = basesRegistradas.Tables[0];
                    //return sqlInfo;
                    //System.Console.WriteLine("Memory Usage is {0}", retParam.Value);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Exception: {0}", ex.ToString());
                }

                objConn.Close();
                objConn.Dispose();
            }
        }

        private Label mainTitle;
    }
    
}

