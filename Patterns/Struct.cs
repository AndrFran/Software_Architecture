using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Constructor.DataBase;
using Constructor.GUI;

namespace Constructor.Patterns
{
    public class Struct
    {
        #region ФАСАД
        public static class Facade
        {
            public static void ShowHome(Frame content)
            {
                content.Header = "Домашня сторінка";
                content.FrameSource = @"GUI\Home.xaml";
            }
            public static void ShowTheoria(Frame content)
            {
                content.Header = "Теоретичні відомості";
                content.FrameSource = @"GUI\Theoria.xaml";
            }
            public static void ShowTests(Frame content)
            {
                content.Header = "Тести";
                content.FrameSource = @"GUI\Testing.xaml";
            }
            public static void ShowConstruct(Frame content)
            {
                content.Header = "Конструктор";
                content.FrameSource = @"GUI\Constructor.xaml";
            }
            public static void ShowReporting(Frame content)
            {
                content.Header = "Звіт";
                content.FrameSource = @"GUI\Reporting.xaml";
            }
        }
        #endregion
        #region Сінглетон

        public  class dbConnection
        {
            private dbConnection()
            {
                Data = new LabPIContext();
            }
            private LabPIContext Data = null;
            private  static  dbConnection _Instance= new dbConnection();
            public static dbConnection GetInstance() => _Instance;
            public DbSet<Test> GetTests() => Data.Tests;
        }
#endregion
    }
}
