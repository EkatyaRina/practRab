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
    /// Логика взаимодействия для Ex4.xaml
    /// </summary>
    public partial class Ex4 : Window
    {
        public Ex4()
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
            StringBuilder st = new StringBuilder();
            foreach (char c in line)
            {
                if(c != 'у' && c != 'е' && c != 'ы' && c != 'а' && c != 'о' && c != 'и' && c != 'э' && c != 'я' && c != 'ю' && c != 'ё')
                {
                    st.Append(c);
                }
            }
            return st.ToString();
        }
    }
}
