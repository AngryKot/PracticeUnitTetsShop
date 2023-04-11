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

namespace LittleShop.View
{
    /// <summary>
    /// Логика взаимодействия для PricesWindow.xaml
    /// </summary>
    public partial class PricesWindow : Window
    {
        public PricesWindow()
        {
            InitializeComponent();
        }

        private void b_BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Покинуть настройку?", "Переход", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                foreach (Window window in App.Current.Windows)
                {
                    if (!(window is MainWindow))
                        window.Close();
                }


            }

            else
            {
                this.Show();
            }
        
        }

        private void b_Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b_BackPage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void b_NextPage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
