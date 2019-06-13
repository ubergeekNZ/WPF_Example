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
    /// Interaction logic for LedSegment.xaml
    /// </summary>
    public partial class LedSegment : UserControl
    {
        public LedSegment()
        {
            InitializeComponent();
        }

        public string UpperFirstPath { get; set; }
        public string UpperSecondPath { get; set; }
        public string UpperThirdPath { get; set; }
        public string UpperFourthPath { get; set; }
        public string LowerFirstPath { get; set; }
        public string LowerSecondPath { get; set; }
        public string LowerThirdPath { get; set; }
        public string LowerFourthPath { get; set; }
    }
}
