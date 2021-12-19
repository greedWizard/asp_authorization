using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public static class UserHelper
    {
        public static string hashPasswordToMD5(this string s)
        {
            using var provider = System.Security.Cryptography.MD5.Create();
            StringBuilder builder = new StringBuilder();

            foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(s)))
                builder.Append(b.ToString("x2").ToLower());

            return builder.ToString();
        }
    }

    public class User
    {
        private string password;

        public string login { get; set; }
        
        public string Password { get { return password; } set {
                password = UserHelper.hashPasswordToMD5(value);
            }
        }
        public string fullname { get; set; }
        public DateTime birthday { get; set; }
    }
}
