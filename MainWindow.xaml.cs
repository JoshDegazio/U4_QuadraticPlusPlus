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

namespace U4_Josh_Quadratic___Extended
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a;
        double b;
        double c;

        public MainWindow()
        {
            InitializeComponent();

        }

        public void Click_Calc(object Sender, RoutedEventArgs e)
        {
            double.TryParse(inpt_ValueA.Text, out a);
            double.TryParse(inpt_ValueB.Text, out b);
            double.TryParse(inpt_ValueC.Text, out c);

            double zero1 = (b + Math.Sqrt((b * b) - (4 * (a) * (c)))) / (2 * a);
            double zero2 = (b - Math.Sqrt((b * b) - (4 * (a) * (c)))) / (2 * a);

            txt_Output.Text = "Zero 1: " + zero1.ToString() + ". Zero 2: " + zero2.ToString();
        }
    }
}
