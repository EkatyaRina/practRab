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
    /// Логика взаимодействия для Ex11.xaml
    /// </summary>
    public partial class Ex11 : Window
    {
        public Ex11()
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
            string text = Data.Text;
            string[] words = text.Split(' ', ',','.','!',';',':','?') ;
            string longWord= "";
            string shortWord = "";
            foreach(string word in words)
            {
                if(word.Length> longWord.Length)
                {
                longWord = word;
                }
                if(word.Length< shortWord.Length || shortWord=="")
                {
                shortWord = word;
                }
            }
            ResultLong.Text = longWord;
            ResultShort.Text = shortWord;

        }
    }
}
