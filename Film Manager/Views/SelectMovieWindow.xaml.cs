﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Film_Manager.Views
{
    /// <summary>
    /// Interaktionslogik für SelectMovieWindow.xaml
    /// </summary>
    public partial class SelectMovieWindow : MahApps.Metro.Controls.MetroWindow
    {
        public SelectMovieWindow()
        {
            InitializeComponent();
            ViewModels.SelectMovieViewModel.Instance.BaseWindow = this;
        }
    }
}
