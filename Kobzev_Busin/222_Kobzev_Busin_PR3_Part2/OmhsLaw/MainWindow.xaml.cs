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

namespace OmhsLaw
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработка выбора переключателя
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (CurrentRadioButton.IsChecked == true)
            {
                InputLabel1.Text = "Введите напряжение (U):";
                InputLabel2.Text = "Введите сопротивление (R):";
                ResultLabel.Text = "Сила тока (I):";
            }
            else if (VoltageRadioButton.IsChecked == true)
            {
                InputLabel1.Text = "Введите ток (I):";
                InputLabel2.Text = "Введите сопротивление (R):";
                ResultLabel.Text = "Напряжение (U):";
            }
            else if (ResistanceRadioButton.IsChecked == true)
            {
                InputLabel1.Text = "Введите напряжение (U):";
                InputLabel2.Text = "Введите ток (I):";
                ResultLabel.Text = "Сопротивление (R):";
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(InputField1.Text) || string.IsNullOrWhiteSpace(InputField2.Text))
            {
                MessageBox.Show("Ошибка: Заполните все поля.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                double value1 = double.Parse(InputField1.Text);
                double value2 = double.Parse(InputField2.Text);

                // Проверка на отрицательные значения
                if (value1 <= 0 || value2 <= 0)
                {
                    MessageBox.Show("Ошибка: Введите положительные значения.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                double result = 0;

                if (CurrentRadioButton.IsChecked == true)
                {
                    result = value1 / value2; // I = U / R
                }
                else if (VoltageRadioButton.IsChecked == true)
                {
                    result = value1 * value2; // U = I * R
                }
                else if (ResistanceRadioButton.IsChecked == true)
                {
                    result = value1 / value2; // R = U / I
                }
                else
                {
                    MessageBox.Show("Ошибка: Выберите вычисляемую величину.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                ResultValue.Text = result.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Введите числовые значения.", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Ошибка: Деление на ноль.", "Ошибка вычисления", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
