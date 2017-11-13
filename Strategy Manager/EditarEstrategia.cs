using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategy_Manager
{
    public partial class EditarEstrategia : Form
    {
        public EditarEstrategia(ListaEstrategia application, String conexion, String servidor, String instancia, String idEstrategia, String priority, String activo)
        {
            app = application;
            InitializeComponent();
            strategyIdTfd.Text = idEstrategia;
            connectionTfd.Text = conexion;
            priorityTfd.Text = priority;
            if (activo == "1") {
                checkBox1.Checked = true;
            }
            else { checkBox1.Checked = false; }
            solicitaLogs(idEstrategia);
        }
    }
}
