using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruyenChuWebAppMVC.Models
{
    public class UserModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string pass { get; set; }
        public int id_role { get; set; }

        public List<NovelModel> novels { get; set; }
    }
}
