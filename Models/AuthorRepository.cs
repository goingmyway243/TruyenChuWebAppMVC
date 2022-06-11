using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruyenChuWebAppMVC.Models
{
    public class AuthorRepository
    {
        public IEnumerable<AuthorModel> authors { get; set; }

        public AuthorModel GetAuthorById(int id)
        {
            return authors.FirstOrDefault(author => author.id == id);
        }
    }
}
