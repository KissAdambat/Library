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
    /// Interaction logic for DeleteCategories.xaml
    /// </summary>
    public partial class DeleteCategories : Page
    {
        Read read = new Read();
        DeleteDatas deleteDatas = new DeleteDatas();
        public DeleteCategories()
        {
            InitializeComponent();
            datagrid.ItemsSource = read.Readcategories();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedcategory = datagrid.SelectedItem as Categories;
            if (selectedcategory == null)
            {
                MessageBox.Show("Nincs kiválasztva elem!");
            }
            else
            {
                int id = selectedcategory.CategoryId;
                deleteDatas.Deletecategories(id);
                datagrid.ItemsSource = read.Readcategories();
            }
        }
    }
}
