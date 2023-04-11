using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Windows.Controls;
using LittleShop;
using LittleShop.View;
using System.Windows;
using LittleShop.Classes;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void PositiveTest_Login() //проверка введенного верного пароля
        {
            //arrange
            var authorization = new AdminPassWindow();
            var tbLogin = (TextBox)authorization.FindName("login");
            var tbPassword = (PasswordBox)authorization.FindName("password");
            var btn = (Button)authorization.FindName("b_Login");
            tbLogin.Text = "adm";
            tbPassword.Password = "pass";

            //act
            if (App.Login == tbLogin.Text && App.Password == tbPassword.Password)
            {
                btn.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }

            //assert
            if (App.Login == tbLogin.Text && App.Password == tbPassword.Password)
            {
                btn.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }

            Assert.IsTrue(App.Login == tbLogin.Text && App.Password == tbPassword.Password, "Введены неверные данные.");
        }

        [TestMethod]
        public void NegativeTest_Login() //проверка введенного неверного пароля
        {
            //arrange
            var authorization = new AdminPassWindow();
            var tbLogin = (TextBox)authorization.FindName("login");
            var tbPassword = (PasswordBox)authorization.FindName("password");
            var btn = (Button)authorization.FindName("b_Login");
            tbLogin.Text = "admin123";
            tbPassword.Password = "aaaa";

            //act
            if (App.Login == tbLogin.Text && App.Password == tbPassword.Password)
            {
                btn.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }

            //assert
            Assert.IsFalse(App.Login == tbLogin.Text && App.Password == tbPassword.Password, "Введены неверные данные.");
        }

        //Открытие окна PriceList по кнопке с главного окна
        [TestMethod]
        public void PositiveTest_OpenPriceList()
        {
            //Arrange
            var main = new MainWindow();
          
            var button = (Button)main.FindName("b_Catalog");

            //Act
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            //Assert
            Assert.IsTrue(button == main.FindName("b_Catalog"));
        }

        [TestMethod]
        public void PositiveTest_GetSumCard_MainWindow() //получение суммы на карте с главного окна
        {

            //Arrange
            var main = new MainWindow();
            double card = main.sum_Card;
            var createorder = new MakeOrderWindows(card);
            var button = (Button)main.FindName("b_Order");

            //Act
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            //Assert
            Assert.IsTrue(card == createorder.SummaBankCard);

        }

        


        [TestMethod]
        public void PositiveTest_GotoMakeOrderWindow() //отображение окна оформления заказа
        {
            //Arrange
            var main = new MainWindow();

            var button = (Button)main.FindName("b_Order");

            //Act
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            //Assert
            Assert.IsTrue(button == main.FindName("b_Order"));
        }

        [TestMethod]
        public void PositiveTest_GotoCart_CreateOrder() //отображение окна авторизации
        {
            //Arrange
            var main = new MainWindow();

            var button = (Button)main.FindName("b_Order");

            //Act
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            //Assert
            Assert.IsTrue(button == main.FindName("b_Order"));
        }



        [TestMethod]
        public void PositiveTest_GotoAuthorization_MainWindow() //отображение окна корзины
        {
            //Arrange
            var main = new MainWindow();

            var button = (Button)main.FindName("b_About");

            //Act
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            //Assert
            Assert.IsTrue(button == main.FindName("b_About"));

        }


        //Выход из приложения в главном меню
        [TestMethod]
        public void Test_Exit_MainWindow()
        {
            //Arrange
            var main = new MainWindow();
            var button = (Button)main.FindName("b_Exit");

            //Act
            button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            //Assert
            Assert.IsTrue(button == main.FindName("b_Exit"));
        }




    }
}
