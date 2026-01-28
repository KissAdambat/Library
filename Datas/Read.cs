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
            try
            {
                using(var context = new Models.librarydbContext())
                {
                    var users = context.Authors.ToList();
                    return users;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
