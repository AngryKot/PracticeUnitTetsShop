using LittleShop.Properties;
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
using System.Windows.Forms.DataVisualization.Charting;
using LittleShop.Classes;

namespace LittleShop.View
{
    /// <summary>
    /// Логика взаимодействия для MakeOrderWindows.xaml
    /// </summary>
    public partial class MakeOrderWindows : Window
    {

        public string List;

        List<Classes.Product> listProducts;
        List<Classes.Product> listBasketProducts = new List<Product>();

        Product currentItem;
        Random rand = new Random();
       // public double SummaBankCard { get; set; }		//Сумма на карте
        public double SummaOrder { get; set; } 		//Сумма заказа
        public double SummaBankCard = 1000.000;
        public List<Classes.ProductsinOrder> listProductsInOrders; //список блюд в заказе
        //Для диаграммы
        ChartArea area;					//Площадь диаграммы
        Series series;						//Серия точек

        int TovarC; char Page2;

        public double sum_Order;
        public double sum_Card=1;
        public MakeOrderWindows(double sum)
        {
            InitializeComponent();
            area = new ChartArea("Default");
            chartSumma.ChartAreas.Add(area);
            series = new Series("Summa");
            chartSumma.Series.Add(series);
            chartSumma.Series["Summa"].ChartArea = "Default";
            chartSumma.Series["Summa"].ChartType = SeriesChartType.Pie;
            this.DataContext = this;			//Элементы интерфейса связать с данными
            this.SummaBankCard = sum;     //Сумма на карте
            tB_bank_Order.Text = "Баланс: " + this.SummaBankCard;
            listProductsInOrders = new List<Classes.ProductsinOrder>();
            SummaOrder = 0;
            tB_orderpr_Order.Text = "Сумма заказа: " + SummaOrder;
        }

       

        private void b_BackPage_Click(object sender, RoutedEventArgs e)
        {
            //if (Page == 2)
            //{
            //    imgContent.Content = Resources["Image.Barb"];
            //    imgContent2.Content = Resources["Image.Drac"];
            //}
            //if (Page == 1)
            //{
            //    return;
                
            //}
            
            //else
            //{
            //    Page = Convert.ToInt32(PageNum.Text);
            //    Page -= 1;
            //    PageNum.Text = Convert.ToString(Page);
            //}

        }

        private void b_NextPage_Click(object sender, RoutedEventArgs e)
        {
            //Page=Convert.ToInt32(PageNum.Text);
            //Page += 1;
            //PageNum.Text = Convert.ToString(Page);

            //if (Page == 2)
            //{
            //    imgContent.Content = Resources["Image.Por"];
            //    imgContent2.Content = Resources["Image.OMG"];
            //}
            
        }
        //"D:/Новая папка/Csharp/LittleShop/LittleShop/Resourses/Категории/Dolls/Poecwlain.png"
        private void b_BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result= MessageBox.Show("Покинуть каталог?","Переход", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }

            
            
        }

        private void b_Cart(object sender, RoutedEventArgs e)
        {
            //View.ShopCart windowcart = new View.ShopCart();
            //this.Close();
            //windowcart.ShowDialog();
            //Random rnd = new Random();
            //sum_Card = rnd.Next(1, 9999);
            //MessageBox.Show($"Сумма Вашего заказа составила {sum_Card}");
            View.ShopCart windowcart = new View.ShopCart(); //создание объекта окна
            windowcart.Owner = this; //Указать владельца у дополнительного окна
            windowcart.ShowDialog(); //Показать модальное дополнительное
            this.Hide();

        }

        private void b_AddToCartDrac(object sender, RoutedEventArgs e)
        {

        }

        private void b_AddToCartBarb(object sender, RoutedEventArgs e)
        {

        }



       

        private void lst_Category_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string categoryName = list_Category.SelectedItem.ToString();
            App.excelSheet = App.excelBook.Sheets[categoryName];

            listProducts = new List<Classes.Product>();
            Classes.Product product;

            App.excelCells = App.excelSheet.UsedRange;

            //получить все заполненные ячейки листа в цикле
            for (int i = 1; i <= App.excelSheet.UsedRange.Rows.Count; i++)
            {
                product = new Classes.Product(); 
                product.Name = (string)App.excelCells.Cells[i, 1].Value2; 
                product.Cost = (int)App.excelCells.Cells[i, 2].Value2;
                product.Widht = (int)App.excelCells.Cells[i, 3].Value2;
                product.Photo = App.pathExe + $"\\{categoryName}\\{App.excelCells.Cells[i, 5].Value2}.png";
                listProducts.Add(product); 

            }

            
            ListBoxProducts.ItemsSource = listProducts; 
        }

        private void ListBoxProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CreateOrder_Click(object sender, RoutedEventArgs e)
        {
            
            Classes.ProductsinOrder productInOrder = null;
            //Объект из списка (товар) в строке которой нажали кнопку
            Classes.Product product = (sender as Button).DataContext as Classes.Product;
            string productName = product.Name;		//Название товара
            int productCost = product.Cost;			//Стоимость товара
            if (SummaOrder + productCost <= SummaBankCard)  //Проверка под сумму на карте
            {
                TovarC = Convert.ToInt32(tb_CartCurrent.Text);
                TovarC += 1;
                tb_CartCurrent.Text = Convert.ToString(TovarC);

                SummaOrder += productCost;			//Общая сумма в заказе
                //SummaBankCard -= productCost;
                tB_orderpr_Order.Text = "Сумма заказа: " + SummaOrder;
                //tB_bank_Order.Text = "Остаток на счете: " + SummaBankCard;
                //Поиск этого товара среди заказанных товаров
                int index = listProductsInOrders.FindIndex(x => x.Name == productName);
                if (index < 0)        //Такого товара еще в заказе нет
                {
                    //Создаем новый элемент списка
                    productInOrder = new Classes.ProductsinOrder();
                    productInOrder.Name = productName;
                    productInOrder.Cost = productCost;
                    productInOrder.Count = 1;   //Для нового
                    productInOrder.Costing = productCost;	//Стоимость
                    listProductsInOrders.Add(productInOrder);	//добавляем в список
                }
                else         //Такой товар уже есть в заказе, поэтому увеличиваем его количество 
                {
                    listProductsInOrders[index].Count++;
                    listProductsInOrders[index].Costing =
                                                listProductsInOrders[index].Cost * listProductsInOrders[index].Count;
                }
                ChartShow();					//Метод отображения диаграммы
            }
            else
            {
                MessageBox.Show("У Вас уже не хватает денег");
            }

        }
        public void ChartShow()
        {
            chartSumma.Series["Summa"].Points.Clear();
            //Сектор Оставшиеся деньги
            chartSumma.Series["Summa"].Points.AddXY(0, SummaBankCard - SummaOrder);
            //Сектор Сумма заказа
            chartSumma.Series["Summa"].Points.AddXY(0, SummaOrder);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            list_Category.Items.Clear();
            for (int i = 1; i <= App.excelBook.Worksheets.Count; i++)
            {
                list_Category.Items.Add(App.excelBook.Worksheets[i].Name);
            }
        }
    }
}
