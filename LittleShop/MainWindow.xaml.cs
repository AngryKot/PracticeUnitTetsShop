using LittleShop.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Exel = Microsoft.Office.Interop.Excel;

namespace LittleShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double sum_Card = 1;

        public MainWindow()
        {
            InitializeComponent();

            //try
            //{
            //    App.excelApp = new Exel.Application();
            //    App.excelApp.Visible = false;
            //    MessageBox.Show("У вас установлен MS Excel");
            //    if (File.Exists(App.fileMenu))
            //    {
            //        App.excelBook = App.excelApp.Workbooks.Open(App.fileMenu);

            //    }
            //    else
            //    {
            //        MessageBox.Show("Файл отсутствует"); this.Close();
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Установи MS Excel");
            //    this.Close();
            //}
        }

      
        private void b_Catalog_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("КаталогExel");
        }
        
        private void b_Order_Click(object sender, RoutedEventArgs e)
        {
            //Random rnd = new Random();
            //int value = rnd.Next(10000, 35000);
            //MessageBox.Show("Сумма на карте: " + value.ToString() + " руб.");
            //View.MakeOrderWindows createOrderWindow = new View.MakeOrderWindows(Convert.ToDouble(value));

            MessageBox.Show("КаталогТовар");
            //View.MakeOrderWindows makeOrderWindow = new View.MakeOrderWindows(sum_Card); //создание объекта окна для конструктора с параметром
            //this.Hide();
            //makeOrderWindow.Show();

            //this.Show();

            //List<string> listCat = new List<string>();//список названий листов книги

            //int countSheet = App.excelBook.Worksheets.Count;
            //for (int i = 1; i <= countSheet; i++)
            //{
            //    listCat.Add(App.excelBook.Worksheets[i].Name);
            //}

            //Random rnd = new Random();
            //int value = rnd.Next(1, 50000);
            //MessageBox.Show("Мы заглянули на вашу карту! На ней сумма: " + value.ToString() + " руб.");
        }

        private void b_Price_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("КаталогТовар");
            //View.AdminPassWindow windowPrices = new View.AdminPassWindow();
            //this.Hide();
            //windowPrices.ShowDialog();
            //this.Show();
          
        }

        

       
       

        private void b_Exit_Click(object sender, RoutedEventArgs e)
        {

            //if (
            MessageBox.Show("Вы уверены, что хотите закрыть приложение?");
            //        "Save file",
            //        MessageBoxButton.YesNo,
            //        MessageBoxImage.Question) == MessageBoxResult.Yes)
            //{
            //    App.excelApp.Quit();
            //    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(App.excelApp);
            //    GC.Collect();
            //    this.Close();
            //}


            //else
            //{
            //    this.Show();
            //}

        }
    }
}
