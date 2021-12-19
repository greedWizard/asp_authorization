using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserService
    {

        public List<User> Users = new List<User>
        {
            new User {login="admin", Password="12345", fullname="PortalAdmin", birthday=new DateTime(2000, 6, 28)},
        };
        public bool F = false;
        public bool CheckCredentials(string login, string password)
        {
            bool F = Users.Any(u=>u.login==login && u.Password==UserHelper.hashPasswordToMD5(password));
            return F;
        }
    }
}
