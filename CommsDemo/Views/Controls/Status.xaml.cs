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
    /// Interaction logic for Advanced.xaml
    /// </summary>
    public partial class Advanced : UserControl
    {
        public Advanced()
        {
            InitializeComponent();
        }
        public string WifiLedPath { get; set; }
        public string ErrorLedPath { get; set; }
        public string ShabatLedPath { get; set; }
        public string ServiceLedPath { get; set; }
    }
}
