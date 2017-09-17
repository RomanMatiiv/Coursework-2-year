using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Курсач
{
    public class Users
    {
        public int password;
        public string login;
        public string salt;

        public Users(string login,string password,string salt)
        {
            this.login = login;
            this.salt = salt;
            this.password = password.GetHashCode() + salt.GetHashCode();
        }

        public Users() { }
    }
}
