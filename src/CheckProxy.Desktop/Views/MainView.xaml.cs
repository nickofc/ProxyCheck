﻿using MahApps.Metro.Controls;
using System;
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
using CheckProxy.Desktop.ViewModels;

namespace CheckProxy.Desktop.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : MetroWindow
    {
        public readonly MainViewModel ViewModel;

        public MainView()
        {
            InitializeComponent();
            ViewModel = new MainViewModel(this);
            DataContext = ViewModel;
        }
    }
}