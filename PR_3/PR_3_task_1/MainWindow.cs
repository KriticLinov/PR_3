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

namespace PR_3_task_1
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TbAnswer.Clear();
            if (!double.TryParse(TbN.Text, out double n))
            {
                MessageBox.Show("Введите трехзначное число.");
            }

            if (n < 100 || n > 999)
            {
                MessageBox.Show("Введите трехзначное число.");
            }

            else
            {
                int lastDigit, firstDigit;
                firstDigit = (int) n / 100;
                lastDigit = (int) n % 10;

                if (firstDigit == lastDigit)
                {
                    TbAnswer.Text += "Первая и последняя цифры равны.";
                }
                
                else if (firstDigit < lastDigit)
                {
                    TbAnswer.Text += "Последняя цифра больше первой.";
                }

                else if (firstDigit > lastDigit)
                {
                    TbAnswer.Text += "Первая цифра больше последней.";
                }
            }
        }
    }
}
