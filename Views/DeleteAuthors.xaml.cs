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
using Library.Datas;
using Library.Models;


namespace Library.Views
{
    /// <summary>
    /// Interaction logic for DeleteAuthors.xaml
    /// </summary>
    public partial class DeleteAuthors : Page
    {
        Read read = new Read();
        DeleteDatas deleteDatas = new DeleteDatas();
        public DeleteAuthors()
        {
            InitializeComponent();
            datagrid.ItemsSource = read.Readauthours();
        }

        private void deleteauthors_Click(object sender, RoutedEventArgs e)
        {
            var selectedAuthor = datagrid.SelectedItem as Authors;
            if (selectedAuthor == null)
            {
                MessageBox.Show("Nincs kiválasztva elem!");
            }
            else
            {
                int id = selectedAuthor.AuthorId;
                deleteDatas.Deleteauthors(id);
                datagrid.ItemsSource = read.Readauthours();
            }
        }
    }
}
