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

namespace MaxMin
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
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Num1.Text) ||
                string.IsNullOrWhiteSpace(Num2.Text) ||
                string.IsNullOrWhiteSpace(Num3.Text))
            {
                MessageBox.Show("Введите все три числа!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!double.TryParse(Num1.Text, out double num1) ||
                !double.TryParse(Num2.Text, out double num2) ||
                !double.TryParse(Num3.Text, out double num3))
            {
                MessageBox.Show("Введите корректные числовые значения!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (MaxRadio.IsChecked == false && MinRadio.IsChecked == false)
            {
                MessageBox.Show("Выберите минимум или максимум!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            double result = MaxRadio.IsChecked == true ? Math.Max(Math.Max(num1, num2), num3) : Math.Min(Math.Min(num1, num2), num3);
            ResultText.Text = $"Результат: {result}";
        }
    }
    
}
