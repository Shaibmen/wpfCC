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
        bool storona = true;
        public MainWindow()
        {
            InitializeComponent();
            button = new Button[9] { _1, _2, _3, _4, _5, _6, _7, _8, _9 };
            
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {


            Itog();
            Random random = new Random();
            int random_number = random.Next(0, 9);

            (sender as Button).IsEnabled = false;
            button[random_number].IsEnabled = false;

            while (button[random_number].IsEnabled == false)
            {
                random_number = random.Next(0, 9);
            }


            if (storona == true)
            {
                (sender as Button).Content = 'x';
                if (_1.IsEnabled == true | _2.IsEnabled == true | _3.IsEnabled == true | _4.IsEnabled == true | _5.IsEnabled == true | _6.IsEnabled == true | _7.IsEnabled == true | _8.IsEnabled == true | _9.IsEnabled == true)
                {
                    button[random_number].Content = 'o';
                }
            }
            else
            {
                (sender as Button).Content = 'o';
                button[random_number].Content = 'x';
            }







        }

        void Itog()
        {
            _1.IsEnabled = false;
        }

        void Block()
        {
            _1.IsEnabled = false;
            _2.IsEnabled = false;
            _3.IsEnabled = false;
            _4.IsEnabled = false;
            _5.IsEnabled = false;
            _6.IsEnabled = false;
            _7.IsEnabled = false;
            _8.IsEnabled = false;
            _9.IsEnabled = false;
        }
        void Restart()
        {
            _1.IsEnabled = true;
            _2.IsEnabled = true;
            _3.IsEnabled = true;
            _4.IsEnabled = true;
            _5.IsEnabled = true;
            _6.IsEnabled = true;
            _7.IsEnabled = true;
            _8.IsEnabled = true;
            _9.IsEnabled = true;
            _1.Content = " ";
            _2.Content = " ";
            _3.Content = " ";
            _4.Content = " ";
            _5.Content = " ";
            _6.Content = " ";
            _7.Content = " ";
            _8.Content = " ";
            _9.Content = " ";
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Restart();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (storona == true)
            {
                storona = false;
            }
            else if (storona == false)
            {
                storona = true;
            }
            Restart();
        }
    }
}
