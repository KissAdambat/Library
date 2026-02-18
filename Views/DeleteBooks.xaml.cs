using Library.Datas;
using Library.Models;
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
    /// Interaction logic for DeleteBooks.xaml
    /// </summary>
    public partial class DeleteBooks : Page
    {
        Read read = new Read();
        DeleteDatas deleteDatas = new DeleteDatas();
        public DeleteBooks()
        {
            InitializeComponent();
            datagrid.ItemsSource = read.Readbooks();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedBook = datagrid.SelectedItem as Books;
            if (selectedBook == null)
            {
                MessageBox.Show("Nincs kiválasztva elem!");
            }
            else
            {
                int id = selectedBook.BookId;
                deleteDatas.Deletebooks(id);
                datagrid.ItemsSource = read.Readbooks();
            }
        }
    }
}
