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
    /// Interaction logic for Mode.xaml
    /// </summary>
    public partial class Mode : UserControl
    {
        public Mode()
        {
            InitializeComponent();
        }
        public string WineLedPath { get; set; }
        public string PantryLedPath { get; set; }
        public string FridgeLedPath { get; set; }
        public string ChillLedPath { get; set; }
    }
}
