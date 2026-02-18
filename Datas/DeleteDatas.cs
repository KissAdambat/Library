using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Datas
{
    internal class DeleteDatas
    {
        public object Deleteauthors(int id)
        {
            using (var context = new librarydbContext())
            {
                var user = context.Authors.Where(x => x.AuthorId == id).FirstOrDefault();
                context.Authors.Remove(user);
                context.SaveChanges();
                return user;
            }
        }

        public object Deletebooks(int id)
        {
            using (var context = new librarydbContext())
            {
                var user = context.Books.Where(x => x.BookId == id).FirstOrDefault();
                context.Books.Remove(user);
                context.SaveChanges();
                return user;
            }
        }

        public object Deletecategories(int id)
        {
            using (var context = new librarydbContext())
            {
                var user = context.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
                context.Categories.Remove(user);
                context.SaveChanges();
                return user;
            }
        }
    }
}
