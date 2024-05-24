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

namespace practRab
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

        private void Ex1_ButtonClick(object sender, RoutedEventArgs e)
        {
            Ex1 ex1 = new Ex1();
            ex1.Show();
            Close();
        }

        private void Ex2_ButtonClick(object sender, RoutedEventArgs e)
        {
            Ex2 ex2 = new Ex2();
            ex2.Show();
            Close();
        }

        private void Ex3_ButtonClick(object sender, RoutedEventArgs e)
        {
            Ex3 ex3 = new Ex3();
            ex3.Show();
            Close();
        }

        private void Ex4_ButtonClick(object sender, RoutedEventArgs e)
        {
            Ex4 ex4 = new Ex4();
            ex4.Show();
            Close();
        }

        private void Ex5_ButtonClick(object sender, RoutedEventArgs e)
        {
            Ex5 ex5 = new Ex5();
            ex5.Show();
            Close();

        }

        private void Ex11_ButtonClick(object sender, RoutedEventArgs e)
        {
            Ex11 ex11 = new Ex11();
            ex11.Show();
            Close();
        }

        private void Ex12_ButtonClick(object sender, RoutedEventArgs e)
        {
            Ex12 ex12 = new Ex12();
            ex12.Show();
            Close();
        }
    }
}
