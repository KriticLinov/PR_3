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

namespace PR_3_task_3
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
            TbAnswerA.Clear();
            TbAnswerB.Clear();
            TbAnswerC.Clear();
            if (!double.TryParse(TbA.Text, out double a))
            {
                MessageBox.Show("Введите число в A.");
            }

            if (!double.TryParse(TbB.Text, out double b))
            {
                MessageBox.Show("Введите число в B.");
            }

            if (!double.TryParse(TbC.Text, out double c))
            {
                MessageBox.Show("Введите число в C.");
            }

            if ((a > b) & (b > c))
            {
                double y1, y2, y3;
                y1 = a * 2;
                y2 = b * 2;
                y3 = c * 2;
                TbAnswerA.Text += y1;
                TbAnswerB.Text += y2;
                TbAnswerC.Text += y3;
            }
            
            else if ((a < b) & (b < c))
            {
                double y1, y2, y3;
                y1 = a * 2;
                y2 = b * 2;
                y3 = c * 2;
                TbAnswerA.Text += y1;
                TbAnswerB.Text += y2;
                TbAnswerC.Text += y3;
            }

            else
            {
                double y1, y2, y3;
                y1 = a * -1;
                y2 = b * -1;
                y3 = c * -1;
                TbAnswerA.Text += y1;
                TbAnswerB.Text += y2;
                TbAnswerC.Text += y3;
            }
        }
    }
}
