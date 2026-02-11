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
    /// Interaction logic for AddAuthors.xaml
    /// </summary>
    public partial class AddAuthors : Page
    {
        AddNewItem Author = new AddNewItem(); 
        public AddAuthors()
        {
            InitializeComponent();
        }

        private void addauthorsclick_Click(object sender, RoutedEventArgs e)
        {
            var name = authorsnametext.Text;
            if (authorsnametext.Text == "")
            {
                MessageBox.Show("Üres mezőket töltse ki!");
            }
            else {
                Author.CreateAuthors(name);
            }
        }
    }
}
