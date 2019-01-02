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

namespace Canculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MethodSuma(double a, double b)
        {
            Result.Text = (a + b).ToString();
        }

        private void MethodRiznica(double a, double b)
        {
            Result.Text = (a - b).ToString();
        }

        private void MethodMnojenya(double a, double b)
        {
            Result.Text = (a * b).ToString();
        }

        private void MethodDilenya(double a, double b)
        {
            if (b != 0)
            {
                Result.Text = (a / b).ToString();
            }
            else
            {
                Result.Text = "Не можна ділити на 0";
            }

        }

        private void MethodStepin(double a, double b)
        {
            Result.Text = Math.Pow(a, b).ToString();
        }

        private void MethodKoren(double a)
        {

            Result.Text = Math.Sqrt(a).ToString();
        }

        private void Dorivnye_Click(object sender, RoutedEventArgs e)
        {
            double a = Double.Parse(TextBox1.Text);
            double b = Double.Parse(TextBox2.Text);
            switch (Diya.Text)
            {
                case "+":
                    MethodSuma(a, b);
                    break;
                case "-":
                    MethodRiznica(a, b);
                    break;
                case "*":
                    MethodMnojenya(a, b);
                    break;
                case "/":
                    MethodDilenya(a,b);
                    break;
                case "^":
                    MethodStepin(a, b);
                    break;
                case "#":
                    MethodKoren(a);
                    break;
                default:break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Diya.Text = "+";
        }

        private void Riznica_Click(object sender, RoutedEventArgs e)
        {
            Diya.Text = "-";
        }

        private void Mnojenya_Click(object sender, RoutedEventArgs e)
        {
            Diya.Text = "*";
        }

        private void Dilenya_Click(object sender, RoutedEventArgs e)
        {
            Diya.Text = "/";
        }

        private void Stepin_Click(object sender, RoutedEventArgs e)
        {
            Diya.Text = "^";
        }

        private void Koren_Click(object sender, RoutedEventArgs e)
        {
            Diya.Text = "Корень";
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            Diya.Text = "";
            Result.Text = "";

        }
    }
}
