using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TruyenChuWebAppMVC.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Không được để trống tài khoản!")]
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        [Required(ErrorMessage = "Không được để trống mật khẩu!")]
        public string pass { get; set; }
        public int id_role { get; set; }

        public bool loginState { get; set; }
        public List<NovelModel> novels { get; set; }
    }
}
