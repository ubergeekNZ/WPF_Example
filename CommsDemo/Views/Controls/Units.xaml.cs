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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommsDemo.Views
{
    /// <summary>
    /// Interaction logic for Units.xaml
    /// </summary>
    public partial class Units : UserControl
    {
        public Units()
        {
            InitializeComponent();
        }
        public string UpperCelsiusPath { get; set; }
        public string UpperFahrenheitPath { get; set; }
        public string LowerCelsiusPath { get; set; }
        public string LowerFahrenheitPath { get; set; }
    }
}
