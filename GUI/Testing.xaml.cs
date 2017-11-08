using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Constructor.Patterns.Creational;

namespace Constructor.GUI
{
    /// <summary>
    /// Логика взаимодействия для Testing.xaml
    /// </summary>
    public partial class Testing : Page
    {
        public Testing()
        {
            InitializeComponent();
            ITaskFactory factory=new TestFactory();
            var list = factory.GetContent();
        }
        
    }
}
