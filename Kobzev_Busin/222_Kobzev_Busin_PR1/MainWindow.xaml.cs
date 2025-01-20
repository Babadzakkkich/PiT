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

namespace _222_Kobzev_Busin_PR1
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);

                double f_x = 0;

                if (rbSh.IsChecked == true)
                    f_x = Math.Sinh(x);
                else if (rbX2.IsChecked == true)
                    f_x = Math.Pow(x, 2);
                else if (rbExp.IsChecked == true)
                    f_x = Math.Exp(x);

                double result = 0;

                if (x * y > 0)
                    result = Math.Pow(f_x + y, 2) - Math.Sqrt(f_x * y);
                else if (x * y < 0)
                    result = Math.Pow(f_x + y, 2) - Math.Sqrt(Math.Abs(f_x * y));
                else if (x * y == 0)
                    result = Math.Pow(f_x + y, 2) + 1;

                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Text = "";
            txtY.Text = "";
            txtResult.Text = "";
            rbSh.IsChecked = true;
        }
    }
}

