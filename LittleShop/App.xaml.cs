using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Exel = Microsoft.Office.Interop.Excel;

namespace LittleShop
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string Login = "adm";
        public static string Password = "pass";


        public static Exel.Application excelApp;
        public static Exel.Workbook excelBook;
        public static Exel.Worksheet excelSheet;
        public static Exel.Range excelCells;

        public static string pathExe = Environment.CurrentDirectory;
        public static string fileMenu = pathExe + @"\Shop.xlsx";
    }
}
