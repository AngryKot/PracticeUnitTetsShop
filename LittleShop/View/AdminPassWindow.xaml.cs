using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для AdminPassWindow.xaml
    /// </summary>
    public partial class AdminPassWindow : Window
    {
        int countTry=3;
        public AdminPassWindow()
        {
            InitializeComponent();
        }

        private void b_Exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Покинуть настройки?", "Переход", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }


        private void b_LogIn_Click(object sender, RoutedEventArgs e)
        {

            //using (StreamReader str_log = new StreamReader(@"Login.txt", Encoding.Default))
            //{
            //    using (StreamReader str_pas = new StreamReader(@"Password.txt", Encoding.Default))
            //    {
            //        string login_1 = str_log.ReadLine();
            //        string password_1 = str_pas.ReadLine();
            //        if (login.Text == login_1 && password.Password.ToString() == password_1)
            //        {
            //            View.PricesWindow pricesWindow = new View.PricesWindow();
            //            this.Close();
            //            pricesWindow.Show();
            //            //this.Show();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Логин или пароль не верный");
            //        }
            //    }
            //}
            string login_ = login.Text;
            string password_ = password.Password;


            if (login_ == App.Login && password_ == App.Password)
            {
                MessageBox.Show("Вы успешно зашли как администратор");
                //View.PricesWindow pricesWindow = new View.PricesWindow();
                //this.Hide();
                //pricesWindow.ShowDialog();
                //this.Close();
            }
            else
            {
                countTry--;
                if (countTry == 0)
                {
                    MessageBox.Show("Попытки входа закончились");
                    this.Close();

                }
                else
                    MessageBox.Show("Кол-во попыток осталось:" + countTry );
            }

        }

        private void login_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
    }
}
