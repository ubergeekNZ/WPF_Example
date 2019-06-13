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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommsDemo.Views
{
    /// <summary>
    /// Interaction logic for Humidity.xaml
    /// </summary>
    public partial class Humidity : UserControl
    {
        public Humidity()
        {
            InitializeComponent();
        }
        public string HumidityMinPath { get; set; }
        public string HumidityMaxPath { get; set; }
        public string HumidityOnPath { get; set; }
    }
}
