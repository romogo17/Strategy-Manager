using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;

namespace Strategy_Manager
{
    public partial class ConsultaError : Form
    {
        public ConsultaError(String estrategia,String momento,String error)
        {
            InitializeComponent();
            logId.Text = "Log: "+estrategia;
            logDate.Text = "Date: " + momento;
            logDescrip.Text = error;       
        }

    }
}
