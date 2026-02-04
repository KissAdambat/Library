using Library.Datas;
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

namespace Library.Views
{
    /// <summary>
    /// Interaction logic for SghowDatas.xaml
    /// </summary>
    public partial class SghowDatas : Page
    {
        Read read = new Read();
        public SghowDatas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = read.Readauthours();
        }

        private void books_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = read.Readbooks();
        }

        private void categories_Click(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = read.Readcategories();
        }
    }
}
