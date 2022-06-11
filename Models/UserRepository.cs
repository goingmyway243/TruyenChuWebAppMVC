using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TruyenChuWebAppMVC.Models
{
    public class UserRepository
    {
        public IEnumerable<UserModel> users { get; set; }

        public UserModel GetUserById(string id)
        {
            return users.FirstOrDefault(user => user.id == id);
        }

        public UserModel GetUserByEmail(string email)
        {
            return users.FirstOrDefault(user => user.email == email);
        }
    }
}
