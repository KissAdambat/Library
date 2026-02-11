using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Library.Models;

namespace Library.Datas
{
    internal class AddNewItem
    {
        public object CreateAuthors(string name)
        {
            using (var context = new librarydbContext()) 
            {
                var author = new Authors 
                {
                    AuthorName = name,
                };
                context.Authors.Add(author);
                context.SaveChanges();

                return MessageBox.Show("Sikeresen hozzáadta!");
            }
        }

        public object CreateBooks(string title, DateTime date, int aid, int cid)
        {
            using (var context = new librarydbContext())
            {
                var book = new Books
                {
                    Title = title,
                    PublishDate = date,
                    AuthorId = aid,
                    CategoryId = cid
                };
                context.Books.Add(book);
                context.SaveChanges();

                return MessageBox.Show("Sikeresen hozzáadta!");
            }
        }
    }
}
