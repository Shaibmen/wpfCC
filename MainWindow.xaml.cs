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

    public partial class MainWindow : Window
    {
        Button[] button;
        bool storona = false;
        bool gameEnded = false;
        int AvailableCells = 9;
        public MainWindow()
        {
            InitializeComponent();
            button = new Button[9] { _1, _2, _3, _4, _5, _6, _7, _8, _9 };
            
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            if (gameEnded == true)
            {
                return;
            }

            Button clickedButton = (Button)sender;


            if (storona == true)
            {
                clickedButton.Content = 'x';
                clickedButton.IsEnabled = false;
            }
            else
            {
                clickedButton.Content = 'o';
                clickedButton.IsEnabled = false;
            }

            AvailableCells--;
            Itog();

            Random random = new Random();
            int random_number = random.Next(0, 9);

            if (gameEnded == false)
            {
                while (button[random_number].IsEnabled == false || button[random_number] == clickedButton)
                {
                    random_number = random.Next(0, 9);
                }

                if (storona == true)
                {
                    button[random_number].Content = 'o';
                    button[random_number].IsEnabled = false;
                }
                else
                {
                    button[random_number].Content = 'x';
                    button[random_number].IsEnabled = false;
                }

                AvailableCells--;
                Itog();
            } 
        }



        void Itog()
        { 


            if (_1.Content.ToString() == _2.Content.ToString() && _2.Content.ToString() == _3.Content.ToString() && _1.Content.ToString() != " ")
            {
                LabelItog.Content = "Победа";
                _2LabelItog.Content = "" + _1.Content.ToString();
            }
            else if (_4.Content.ToString() == _5.Content.ToString() && _5.Content.ToString() == _6.Content.ToString() && _4.Content.ToString() != " ")
            {
                LabelItog.Content = "Победа";
                _2LabelItog.Content = "" + _4.Content.ToString();
            }
            else if (_7.Content.ToString() == _8.Content.ToString() && _8.Content.ToString() == _9.Content.ToString() && _7.Content.ToString() != " ")
            {
                LabelItog.Content = "Победа";
                _2LabelItog.Content = "" + _7.Content.ToString();
            }

            else if (_1.Content.ToString() == _4.Content.ToString() && _4.Content.ToString() == _7.Content.ToString() && _1.Content.ToString() != " ")
            {
                LabelItog.Content = "Победа";
                _2LabelItog.Content = "" + _1.Content.ToString();
            }
            else if (_2.Content.ToString() == _5.Content.ToString() && _5.Content.ToString() == _8.Content.ToString() && _2.Content.ToString() != " ")
            {
                LabelItog.Content = "Победа";
                _2LabelItog.Content = "" + _2.Content.ToString();
            }
            else if (_3.Content.ToString() == _6.Content.ToString() && _6.Content.ToString() == _9.Content.ToString() && _3.Content.ToString() != " ")
            {
                LabelItog.Content = "Победа";
                _2LabelItog.Content = "" + _3.Content.ToString();
            }

            else if (_1.Content.ToString() == _5.Content.ToString() && _5.Content.ToString() == _9.Content.ToString() && _1.Content.ToString() != " ")
            {
                LabelItog.Content = "Победа";
                _2LabelItog.Content = "" + _1.Content.ToString();
            }
            else if (_3.Content.ToString() == _5.Content.ToString() && _5.Content.ToString() == _7.Content.ToString() && _3.Content.ToString() != " ")
            {
                LabelItog.Content = "Победа";
                _2LabelItog.Content = "" + _3.Content.ToString();
            }
            else if (AvailableCells == 0)
            {
                LabelItog.Content = "Ничья";

            }
            if (LabelItog.Content.ToString() == "Победа" || LabelItog.Content.ToString() == "Ничья")
            {
                gameEnded = true;
            }
        }

        void Restart()
        {
            AvailableCells = 9;
            LabelItog.Content = " ";
            _2LabelItog.Content = " ";
            gameEnded = false;
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
            Smena();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Restart();
        }

        void Smena()
        {
            if (storona == true)
            {
                storona = false;
            }
            else if (storona == false)
            {
                storona = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Smena();
            Restart();
        }
    }
}
