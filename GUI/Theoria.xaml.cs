using System;
using System.Collections.Generic;
using System.IO;
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

namespace Constructor.GUI
{
    /// <summary>
    /// Логика взаимодействия для Theoria.xaml
    /// </summary>
    public partial class Theoria : Page
    {
        public Theoria()
        {
            InitializeComponent();
           
        }

        private void TreeViewItem_Selected(object sender, RoutedEventArgs e)//1
        {
            string text = File.ReadAllText("Content\\Поняття тестування.txt", Encoding.Default);
            var document = new FlowDocument();
            var paragraph = new Paragraph();
            paragraph.Inlines.Add(text);
            document.Blocks.Add(paragraph);
            richTextBox.Document = document;
        }
        private void TreeViewItem_Selected_Testing2(object sender, RoutedEventArgs e)
        {
            string text = File.ReadAllText("Content\\Види тестування.txt", Encoding.Default);
            var document = new FlowDocument();
            var paragraph = new Paragraph();
            paragraph.Inlines.Add(text);
            document.Blocks.Add(paragraph);
            richTextBox.Document = document;
        }

        private void TreeViewItem_Selected_Test_case_main(object sender, RoutedEventArgs e)
        {
            string text = File.ReadAllText("Content\\test_main.txt", Encoding.Default);
            var document = new FlowDocument();
            var paragraph = new Paragraph();
            paragraph.Inlines.Add(text);
            document.Blocks.Add(paragraph);
            richTextBox.Document = document;
        }

        private void TreeViewItem_Selected_Method(object sender, RoutedEventArgs e)
        {
            string text = File.ReadAllText("Content\\Методи тестування.txt", Encoding.Default);
            var document = new FlowDocument();
            var paragraph = new Paragraph();
            paragraph.Inlines.Add(text);
            document.Blocks.Add(paragraph);
            richTextBox.Document = document;
        }

        private void TreeViewItem_Selected_Test_case_vydy(object sender, RoutedEventArgs e)
        {
            string text = File.ReadAllText("Content\\Види тест-кейсів.txt", Encoding.Default);
            var document = new FlowDocument();
            var paragraph = new Paragraph();
            paragraph.Inlines.Add(text);
            document.Blocks.Add(paragraph);
            richTextBox.Document = document;
        }

        private void TreeViewItem_Selected_Test_case_good_and_bad(object sender, RoutedEventArgs e)
        {
            string text = File.ReadAllText("Content\\Переваги та недоліки.txt", Encoding.Default);
            var document = new FlowDocument();
            var paragraph = new Paragraph();
            paragraph.Inlines.Add(text);
            document.Blocks.Add(paragraph);
            richTextBox.Document = document;
        }

        private void TreeViewItem_Selected_Bug_main(object sender, RoutedEventArgs e)
        {
            string text = File.ReadAllText("Content\\Баг.txt", Encoding.Default);
            var document = new FlowDocument();
            var paragraph = new Paragraph();
            paragraph.Inlines.Add(text);
            document.Blocks.Add(paragraph);
            richTextBox.Document = document;
        }

        private void TreeViewItem_Selected_Bug_2(object sender, RoutedEventArgs e)
        {
            string text = File.ReadAllText("Content\\Основні поля.txt", Encoding.Default);
            var document = new FlowDocument();
            var paragraph = new Paragraph();
            paragraph.Inlines.Add(text);
            document.Blocks.Add(paragraph);
            richTextBox.Document = document;
        }

        private void TreeViewItem_Selected_Vymogi(object sender, RoutedEventArgs e)
        {
            string text = File.ReadAllText("Content\\Вимоги.txt", Encoding.Default);
            var document = new FlowDocument();
            var paragraph = new Paragraph();
            paragraph.Inlines.Add(text);
            document.Blocks.Add(paragraph);
            richTextBox.Document = document;
        }
    }
}
