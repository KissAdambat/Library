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
    /// Interaction logic for AddCategories.xaml
    /// </summary>
    public partial class AddCategories : Page
    {
        public AddCategories()
        {
            InitializeComponent();
        }

        private void addcategoriesclick_Click(object sender, RoutedEventArgs e)
        {
            if(categoriesnametext.Text == "")
            {
                MessageBox.Show("Üres mezőket töltse ki!");
            }
            else
            {
                string name = categoriesnametext.Text;
                Datas.AddNewItem category = new Datas.AddNewItem();
                category.CreateCategories(name);
            }
        }
    }
}
