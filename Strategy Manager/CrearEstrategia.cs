using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oracle_Tablespace_Monitor
{
    public partial class CrearEstrategia : Form
    {
        public CrearEstrategia(ListaEstrategia application, String conexion, String servidor, String instancia)
        {
            InitializeComponent();
            dbInstance.Text = "Database Instance: " + instancia;
            bdServer.Text = "Server: " + servidor;
            connection = conexion;
            app = application;
            backupScript.Add("run{");

        }

        private void CrearEstrategia_Load(object sender, EventArgs e)
        {

        }


    }
}
