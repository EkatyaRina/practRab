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
    /// Логика взаимодействия для Ex1.xaml
    /// </summary>
    public partial class Ex1 : Window
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void exit_ButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow main= new MainWindow();
            main.Show();
            Close();
        }

        private void result_ButtonClick(object sender, RoutedEventArgs e)
        {
            string line = Data.Text;
            List<string> dublicatList = new List<string>();
            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (i + 1 < line.Length && line[i + 1] == c)
                {
                    dublicatList.Add(c.ToString());
                    i++;
                }
            }
            Result.ItemsSource= dublicatList;
      
        }
    }
}
