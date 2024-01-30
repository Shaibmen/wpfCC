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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] button;
        public MainWindow()
        {
            InitializeComponent();
            button = new Button[9] { _1, _2, _3, _4, _5, _6, _7, _8, _9 };
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = 'x';
            (sender as Button).IsEnabled = false;
            

            Random random = new Random();
            int random_number = random.Next(0, 9);

            while (button[random_number].IsEnabled == false)
            {
                random_number = random.Next(0, 9);
            }


            button[random_number].Content = 'o';
            button[random_number].IsEnabled = false;
            
            
        }
    }
}
