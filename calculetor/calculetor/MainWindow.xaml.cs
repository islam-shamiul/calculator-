using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathParserTK;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculetor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "0";
        }

        

        

        private void three_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "3";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "2";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "1";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "9";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   if (!screen.Text.Contains("."))
                {
                    screen.Text = screen.Text + ".";
                }
        }
        
        private void clean_Click_1(object sender, RoutedEventArgs e)
        {
            screen.Text = "";
        }

        private void lPar_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "(";
        }

        private void rPar_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + ")";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "+";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "-";
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "*";
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "/";
        }

        private void equal_Click(object sender, RoutedEventArgs e)
        {
            MathParser parser = new MathParser();
            string s1 = screen.Text;
            bool isRadians = false;
            double d1 = parser.Parse(s1, isRadians);
            screen.Text=d1.ToString("0.000000");
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(screen.Text !="")
            {
                screen.Text = screen.Text.Remove(screen.Text.Length-1);
            }
        }
    }
}
