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

namespace sumN
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
        public static double Fac (int n)
        {
            double factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool check = int.TryParse(countBox1.Text, out _) && double.TryParse(countBox2.Text, out _);
                if (check)
                {
                    double sum = 0;
                    var n = int.Parse(countBox1.Text);
                    var x = double.Parse(countBox2.Text);
                    for (int i = 1; i <= n; i++)
                    {
                        sum += Math.Cos(i * Math.PI / 4) * Math.Pow(x,i) / Fac(i);
                    }
                    resultBox.Text = $"Сумма {n} рядов = {1 + sum}";
                }
                else resultBox.Text = "Введены некорректные данные";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
