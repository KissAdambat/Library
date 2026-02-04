using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Datas
{
    internal class Read
    {
        public List<Authors> Readauthours()
        {
              using(var context = new librarydbContext())
              {
                   var users = context.Authors.ToList();
                   return users;
              }
        }


        public List<Books> Readbooks()
        {
              using(var context = new librarydbContext())
              {
                   var users = context.Books.ToList();
                   return users;
              }
        }

        public List<Categories> Readcategories()
        {
              using(var context = new librarydbContext())
              {
                   var users = context.Categories.ToList();
                   return users;
              }
        }
    }
}
