﻿using System;
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
    public partial class ListaLogs : Form
    {
        public ListaLogs(String estrategia)
        {
            InitializeComponent();
            strategy.Text = "Strategy : " + estrategia;
            solicitaLogs(estrategia);
            solicitaError(estrategia);
       
        }

    }
}
