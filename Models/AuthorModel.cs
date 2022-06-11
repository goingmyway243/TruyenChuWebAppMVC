using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruyenChuWebAppMVC.Models
{
    public class AuthorModel
    {
        public int id { get; set; }
        public string author_name { get; set; }
        public List<NovelModel> novels { get; set; }
    }
}
