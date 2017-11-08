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

namespace Oracle_Tablespace_Monitor
{
    public partial class ConsultaLog : Form
    {
        public ConsultaLog(String estrategia,String momento,String log)
        {
            InitializeComponent();
            logId.Text = "Log: "+estrategia;
            logDate.Text = "Date: " + momento;
            logDescrip.Text = log;       
        }

    }
}
