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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaEstrategia));
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstrategias = new System.Windows.Forms.ToolStripMenuItem();
            this.crearEstrategiaDeRespaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.strategiesTitle = new System.Windows.Forms.Label();
            this.dbServer = new System.Windows.Forms.Label();
            this.dbInstance = new System.Windows.Forms.Label();
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
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.opcionesToolStripMenuItem.Text = "Options";
            // 
            // registrarEstrategias
            // 
            this.registrarEstrategias.Name = "registrarEstrategias";
            this.registrarEstrategias.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.registrarEstrategias.Size = new System.Drawing.Size(305, 30);
            this.registrarEstrategias.Text = "Register Strategies";
            this.registrarEstrategias.Click += new System.EventHandler(this.registrarEstrategias_click);
            // 
            // crearEstrategiaDeRespaldoToolStripMenuItem
            // 
            this.crearEstrategiaDeRespaldoToolStripMenuItem.Name = "crearEstrategiaDeRespaldoToolStripMenuItem";
            this.crearEstrategiaDeRespaldoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.crearEstrategiaDeRespaldoToolStripMenuItem.Size = new System.Drawing.Size(305, 30);
            this.crearEstrategiaDeRespaldoToolStripMenuItem.Text = "Edit Strategies";
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
            this.myLayout.Location = new System.Drawing.Point(48, 180);
            this.myLayout.Name = "myLayout";
            this.myLayout.Size = new System.Drawing.Size(1146, 500);
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
            // strategiesTitle
            // 
            this.strategiesTitle.AutoSize = true;
            this.strategiesTitle.Font = new System.Drawing.Font("Arial Narrow", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strategiesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(149)))), ((int)(((byte)(191)))));
            this.strategiesTitle.Location = new System.Drawing.Point(37, 44);
            this.strategiesTitle.Name = "strategiesTitle";
            this.strategiesTitle.Size = new System.Drawing.Size(373, 62);
            this.strategiesTitle.TabIndex = 18;
            this.strategiesTitle.Text = "Backup Strategies";
            // 
            // dbServer
            // 
            this.dbServer.AutoSize = true;
            this.dbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbServer.ForeColor = System.Drawing.Color.White;
            this.dbServer.Location = new System.Drawing.Point(47, 106);
            this.dbServer.Name = "dbServer";
            this.dbServer.Size = new System.Drawing.Size(96, 29);
            this.dbServer.TabIndex = 19;
            this.dbServer.Text = "Server: ";
            // 
            // dbInstance
            // 
            this.dbInstance.AutoSize = true;
            this.dbInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbInstance.ForeColor = System.Drawing.Color.White;
            this.dbInstance.Location = new System.Drawing.Point(47, 135);
            this.dbInstance.Name = "dbInstance";
            this.dbInstance.Size = new System.Drawing.Size(222, 29);
            this.dbInstance.TabIndex = 20;
            this.dbInstance.Text = "Database Instance: ";
            // 
            // ListaEstrategia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1227, 709);
            this.Controls.Add(this.dbInstance);
            this.Controls.Add(this.dbServer);
            this.Controls.Add(this.strategiesTitle);
            this.Controls.Add(this.myLayout);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "ListaEstrategia";
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
        private ToolStripMenuItem registrarEstrategias;
        private MenuStrip menuStrip1;
        private FlowLayoutPanel myLayout;
        private ToolStripMenuItem crearEstrategiaDeRespaldoToolStripMenuItem;
        private DataGridView dataGridView1;
        private String busquedaBase;
        private String busquedaServidor;
        private Application app;

        private void registrarEstrategias_click(object sender, EventArgs e)
        {
            CrearEstrategia ce = new CrearEstrategia(app);
            ce.ShowDialog(this);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //String baseBusqueda="";
            //String servidor = "";
            //if (e.RowIndex>= 0) {
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //    baseBusqueda = row.Cells["DATABASE_INSTANCE"].Value.ToString();
            //    servidor = row.Cells["CONN_NAME"].Value.ToString();
            //    ListaEstrategia lista = new ListaEstrategia(this, servidor, baseBusqueda);
            //    System.Windows.Forms.MessageBox.Show(servidor + baseBusqueda);
            //    lista.ShowDialog();
               
            //}
        } 

        /* private void editarBaseDatosToolStripMenuItem_click(object sender, EventArgs e)
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

        public void solicitaEstrategias(String conexion)
        {
            using (OracleConnection objConn = new OracleConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                DataSet basesRegistradas = new DataSet("Estrategias");
                //Create and execute the command
                OracleCommand objCmd = new OracleCommand();
                objCmd.Connection = objConn;
                objCmd.CommandText = "get_strategy";
                objCmd.CommandType = CommandType.StoredProcedure;
                //Set parameters
                OracleParameter retParam = objCmd.Parameters.Add("return_value", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
                objCmd.Parameters.Add(new OracleParameter("1", OracleDbType.Varchar2, conexion, ParameterDirection.Input));

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

        private Label strategiesTitle;
        private Label dbServer;
        private Label dbInstance;
    }
    
}

