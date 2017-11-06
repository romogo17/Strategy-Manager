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
    public partial class EditarBase : Form
    {
        public EditarBase(Application application,String a,String b,String c,String d,String e)
        {
            app = application;
            InitializeComponent();
            llenaFormulario(a, b, c, d, e);
        }


    }
}
