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

namespace Library.Views
{
    /// <summary>
    /// Interaction logic for AddBooks.xaml
    /// </summary>
    public partial class AddBooks : Page
    {

        public AddBooks()
        {
            InitializeComponent();
        }

        private void addbooksclick_Click(object sender, RoutedEventArgs e)
        {
            string title = booksnametext.Text;
            int aid = Convert.ToInt32(authoridtext.Text);
            int cid = Convert.ToInt32(categoriesidtext.Text);
            DateTime date = (DateTime)DaTe.SelectedDate;
            if(date.Year == 0001 || booksnametext.Text == "" || authoridtext.Text == "" || categoriesidtext.Text == "")
            {
                MessageBox.Show("Üres mezőket töltse ki!");
            }
            else
            {
                AddNewItem book = new AddNewItem();
                book.CreateBooks(title, date, aid, cid);
            }
        }
    }
}
