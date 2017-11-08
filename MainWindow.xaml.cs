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
using Constructor.Patterns;
using Frame = Constructor.GUI.Frame;

namespace Constructor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Button[] buttons = new Button[0];

        public MainWindow()
        {
            InitializeComponent();
           // buttons = new[] {Home, Theoria, Reporting, Constructor};
            ShowFrame(Home,new RoutedEventArgs());
            //buttons.Select(x => (x.Click.ame));
        }

        public void ShowFrame(object sender, RoutedEventArgs e)
        {
           // buttons.Select(b => b.Background = new SolidColorBrush(Color.FromRgb(41, 41, 41)));
            if (!(sender is Button)) return;

            var button = (Button) sender;
            Frame frame = new Frame() {};
            switch (button.Name)
            {
                case "Home":
                    Struct.Facade.ShowHome(frame);
                    break;
                case "Theoria":
                    Struct.Facade.ShowTheoria(frame);
                    break;
                case "Constructor":
                    Struct.Facade.ShowConstruct(frame);
                    break;
                case "Reporting":
                    Struct.Facade.ShowReporting(frame);
                    break;
                case "Testing":
                    Struct.Facade.ShowTests(frame);
                    break;
            }
            Content.Source = new Uri(frame.FrameSource, UriKind.RelativeOrAbsolute);//new Uri(AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug","")+frame.FrameSource,UriKind.Absolute);
            Header.Text = frame.Header;
            //button.Background = Brushes.DarkGray;
            //buttons.Where(x => x.Name != button.Name).Select(b => b.Background=new  SolidColorBrush(Color.FromRgb(41,41,41)));
        }
    }
}
