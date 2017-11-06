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

    partial class ListaEstrategia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaEstrategia));
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstrategias = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEstrategiaDeRespaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.myLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEstrategias,
            this.crearEstrategiaDeRespaldoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.opcionesToolStripMenuItem.Text = "Options";
            // 
            // registrarEstrategias
            // 
            this.registrarEstrategias.Name = "registrarEstrategias";
            this.registrarEstrategias.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.registrarEstrategias.Size = new System.Drawing.Size(235, 22);
            this.registrarEstrategias.Text = "Registro de Estrategias";
            // 
            // crearEstrategiaDeRespaldoToolStripMenuItem
            // 
            this.crearEstrategiaDeRespaldoToolStripMenuItem.Name = "crearEstrategiaDeRespaldoToolStripMenuItem";
            this.crearEstrategiaDeRespaldoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.crearEstrategiaDeRespaldoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.crearEstrategiaDeRespaldoToolStripMenuItem.Text = "Editar Estrategia";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myLayout
            // 
            this.myLayout.AutoScroll = true;
            this.myLayout.Controls.Add(this.dataGridView1);
            this.myLayout.Location = new System.Drawing.Point(9, 37);
            this.myLayout.Margin = new System.Windows.Forms.Padding(2);
            this.myLayout.Name = "myLayout";
            this.myLayout.Size = new System.Drawing.Size(798, 405);
            this.myLayout.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(807, 402);
            this.dataGridView1.TabIndex = 3;
            // 
            // ListaEstrategia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(818, 461);
            this.Controls.Add(this.myLayout);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ListaEstrategia";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto 4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.myLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem registrarEstrategias;
        private MenuStrip menuStrip1;
        private FlowLayoutPanel myLayout;
        private ToolStripMenuItem crearEstrategiaDeRespaldoToolStripMenuItem;
        private DataGridView dataGridView1;
        private String busquedaBase;
        private String busquedaServidor;
        private Application app;

        /*private void registrarBaseDatosToolStripMenuItem_click(object sender, EventArgs e)
        {
            RegistroBase ch = new RegistroBase(this);
            ch.ShowDialog(this);
        }
        private void creaEstrategiaToolStripMenuItem_click(object sender, EventArgs e)
        {
            CrearEstrategia ce = new CrearEstrategia(this);
            ce.ShowDialog(this);
        }*/
        /*private void editarBaseDatosToolStripMenuItem_click(object sender, EventArgs e)
        {
            try
            {
                String a = dataGridView1.SelectedRows[0].Cells["BASEDATOS"].Value.ToString();
                String b = dataGridView1.SelectedRows[0].Cells["SERVIDOR"].Value.ToString();
                String c = dataGridView1.SelectedRows[0].Cells["IP"].Value.ToString();
                String d = dataGridView1.SelectedRows[0].Cells["PUERTO"].Value.ToString();
                String ee = dataGridView1.SelectedRows[0].Cells["ALIVE"].Value.ToString();
                EditarBase ce = new EditarBase(this, a, b, c, d, ee);
                ce.ShowDialog(this);
            }
            catch(Exception ex) {
                System.Windows.Forms.MessageBox.Show("Por favor, selecciona la fila desde el borde izquierdo de la tabla");
            }
        }*/

        public void solicitaEstrategias()
        {
            /*   using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
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
               }*/
        }
    }
    
}

