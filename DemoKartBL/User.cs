using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class User
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        /*public User(String UserName ,String Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }*/
        public int GetAuthorized(String UserName, String password)
        {
            if (UserName == "ecommerce" && Password == "e-commerce")
                return 1;
            else if (UserName == "ecommerce" && Password != "e-commerce")
                return 0;
            else
                return -1;
        }
    }
}
