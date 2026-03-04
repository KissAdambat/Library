using Library.Datas;
using Library.Models;
using Library.Views;
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

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Read read = new Read();
        SghowDatas sghow = new SghowDatas();
        public MainWindow()
        {
            InitializeComponent();
            MainPage.Navigate(new Views.SghowDatas());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainPage_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void authors(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new Views.AddAuthors());
        }
        private void books(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new Views.AddBooks());
        }
        private void ReadAuthors(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new Views.ShowAuthors());
        }
        private void ReadBooks(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new Views.ShowBooks());
        }
        private void ReadCategories(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new Views.Showcategories());
        }
        private void categories(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new Views.AddCategories());
        }
        private void deleteauthors(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new Views.DeleteAuthors());
        }
        private void deletebooks(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new Views.DeleteBooks());
        }
        private void deletecategories(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(new Views.DeleteCategories());
        }
    }
}
