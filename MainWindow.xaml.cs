/*
 *Josh Degazio
 *June 6, 2018
 *QuadraticPlusPlus
 *User inputs values, which the program uses in the quadratic formula to calculate roots. Program then displays roots.
*/
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
using System.Drawing;

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
        double zero1;
        double zero2;
        Ellipse e_zero1 = new Ellipse();
        Ellipse e_zero2 = new Ellipse();

        public MainWindow()
        {
            InitializeComponent();


            e_zero1.Height = 10;
            e_zero1.Width = 10;
            e_zero1.Fill = Brushes.Green;

            e_zero2.Height = 10;
            e_zero2.Width = 10;
            e_zero2.Fill = Brushes.Green;
        }

        public void Click_Calc(object Sender, RoutedEventArgs e)
        {
            canvas_Graph.Children.Remove(e_zero1);
            canvas_Graph.Children.Remove(e_zero2);
            canvas_Graph.Visibility = Visibility.Hidden;
            btn_Graph.Visibility = Visibility.Visible;
            double.TryParse(inpt_ValueA.Text, out a);
            double.TryParse(inpt_ValueB.Text, out b);
            double.TryParse(inpt_ValueC.Text, out c);

            zero1 = (-b - Math.Sqrt((b * b) - (4 * (a) * (c)))) / (2 * a);
            zero2 = (-b + Math.Sqrt((b * b) - (4 * (a) * (c)))) / (2 * a);

            txt_Output.Text = "Zero 1: " + zero1.ToString() + ". Zero 2: " + zero2.ToString();

            
        }

        public void Click_Graph(object Sender, RoutedEventArgs e)
        {
            canvas_Graph.Visibility = Visibility.Visible;
            DrawZeros();
        }

        public void DrawZeros()
        {
            canvas_Graph.Visibility = Visibility.Visible;
            canvas_Graph.Children.Remove(e_zero1);
            canvas_Graph.Children.Remove(e_zero2);
            canvas_Graph.Children.Add(e_zero1);
            canvas_Graph.Children.Add(e_zero2);
            Canvas.SetTop(e_zero1, 130);
            Canvas.SetTop(e_zero2, 130);


            if (zero1 == 9)
            {
                Canvas.SetLeft(e_zero1, 350);
            }
            else if (zero1 == 8)
            {
                Canvas.SetLeft(e_zero1, 330);
            }
            else if (zero1 == 7)
            {
                Canvas.SetLeft(e_zero1, 310);
            }
            else if (zero1 == 6)
            {
                Canvas.SetLeft(e_zero1, 290);
            }
            else if (zero1 == 5)
            {
                Canvas.SetLeft(e_zero1, 270);
            }
            else if (zero1 == 4)
            {
                Canvas.SetLeft(e_zero1, 250);
            }
            else if (zero1 == 3)
            {
                Canvas.SetLeft(e_zero1, 230);
            }
            else if (zero1 == 2)
            {
                Canvas.SetLeft(e_zero1, 210);
            }
            else if (zero1 == 1)
            {
                Canvas.SetLeft(e_zero1, 190);
            }
            else if (zero1 == 0)
            {
                Canvas.SetLeft(e_zero1, 175);
            }
            else if (zero1 == -1)
            {
                Canvas.SetLeft(e_zero1, 162);
            }
            else if (zero1 == -2)
            {
                Canvas.SetLeft(e_zero1, 142);
            }
            else if (zero1 == -3)
            {
                Canvas.SetLeft(e_zero1, 122);
            }
            else if (zero1 == -4)
            {
                Canvas.SetLeft(e_zero1, 102);
            }
            else if (zero1 == -5)
            {
                Canvas.SetLeft(e_zero1, 82);
            }
            else if (zero1 == -6)
            {
                Canvas.SetLeft(e_zero1, 62);
            }
            else if (zero1 == -7)
            {
                Canvas.SetLeft(e_zero1, 42);
            }
            else if (zero1 == -8)
            {
                Canvas.SetLeft(e_zero1, 22);
            }
            else if (zero1 == -9)
            {
                Canvas.SetLeft(e_zero1, 2);
            }
            else
            {
                MessageBox.Show("Error");
            }



            if (zero2 == 9)
            {
                Canvas.SetLeft(e_zero2, 350);
            }
            else if (zero2 == 8)
            {
                Canvas.SetLeft(e_zero2, 330);
            }
            else if (zero2 == 7)
            {
                Canvas.SetLeft(e_zero2, 310);
            }
            else if (zero2 == 6)
            {
                Canvas.SetLeft(e_zero2, 290);
            }
            else if (zero2 == 5)
            {
                Canvas.SetLeft(e_zero2, 270);
            }
            else if (zero2 == 4)
            {
                Canvas.SetLeft(e_zero2, 250);
            }
            else if (zero2 == 3)
            {
                Canvas.SetLeft(e_zero2, 230);
            }
            else if (zero2 == 2)
            {
                Canvas.SetLeft(e_zero2, 210);
            }
            else if (zero2 == 1)
            {
                Canvas.SetLeft(e_zero2, 190);
            }
            else if (zero2 == 0)
            {
                Canvas.SetLeft(e_zero2, 175);
            }
            else if (zero2 == -1)
            {
                Canvas.SetLeft(e_zero2, 165);
            }
            else if (zero2 == -2)
            {
                Canvas.SetLeft(e_zero2, 145);
            }
            else if (zero2 == -3)
            {
                Canvas.SetLeft(e_zero2, 125);
            }
            else if (zero2 == -4)
            {
                Canvas.SetLeft(e_zero2, 105);
            }
            else if (zero2 == -5)
            {
                Canvas.SetLeft(e_zero2, 85);
            }
            else if (zero2 == -6)
            {
                Canvas.SetLeft(e_zero2, 65);
            }
            else if (zero2 == -7)
            {
                Canvas.SetLeft(e_zero2, 45);
            }
            else if (zero2 == -8)
            {
                Canvas.SetLeft(e_zero2, 25);
            }
            else if (zero2 == -9)
            {
                Canvas.SetLeft(e_zero2, 5);
            }
            else
            {
                MessageBox.Show("Error");
            } 
        }
    }
}
