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
    /// Логика взаимодействия для Ex12.xaml
    /// </summary>
    public partial class Ex12 : Window
    {
        public Ex12()
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
            string line = Data.Text;
            string res = RemoveVowel(line);
            Result.Text = res;

        }
        private string RemoveVowel(string line)
        {
            string vowel = "уеыаоэяиюёУЕЫАОЭЯИЮЁ";
            foreach(char c in vowel)
            {
                line = line.Replace(c, '*');

            }
            return line;
        }
    }
}
