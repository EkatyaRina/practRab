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
using System.Windows.Shapes;

namespace practRab
{
    /// <summary>
    /// Логика взаимодействия для Ex2.xaml
    /// </summary>
    public partial class Ex2 : Window
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void exit_ButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void result_ButtonClick(object sender, RoutedEventArgs e)
        {
            string formula = Data.Text;
            int countOpenBrackets = 0;
            int countCloseBrackets = 0;
            foreach(char c in formula)
            {
                if(c == '(' || c == '[' || c == '{')
                {
                    countOpenBrackets++;
                }
                else if(c == ')' || c == ']' || c == '}') 
                {
                countCloseBrackets++;
                }
                if(countOpenBrackets != countCloseBrackets)
                {
                    Result.Text = "Формула введена неверно";
                }
                else
                {
                    Result.Text = "Формула введена верно";
                }
            }

        }
    }
}
