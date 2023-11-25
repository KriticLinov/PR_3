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

namespace PR_3_task_2
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
            if (!double.TryParse(TbA.Text, out double a))
            {
                MessageBox.Show("Введите число в A.");
            }

            if (!double.TryParse(TbB.Text, out double b))
            {
                MessageBox.Show("Введите число в B.");
            }
            if (a != b)
            {
                double y1, y2;
                y1 = (a + b) + a;
                y2 = (a + b) + b;
                TbAnswerA.Text += y1;
                TbAnswerB.Text += y2;
            }
            else if (a == b)
            {
                double y1, y2;
                y1 = a;
                y2 = b;
                TbAnswerA.Text += y1;
                TbAnswerB.Text += y2;
            }


        }
    }
}
