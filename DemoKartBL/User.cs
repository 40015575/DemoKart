using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class User
    {
        public Dictionary<String, String> SigninList = new Dictionary<string, string>() { { "Supriya", "4444" }, { "Chaithu", "3333" }, { "risabh", "6785" }, { "user", "login" } };
        public String UserName { get; set; }
        public String Password { get; set; }
        public int Getauthorized(String user, String pass)
        {
            if (SigninList.ContainsKey(user) && SigninList[user] == pass)
                return 1;
            else if (SigninList.ContainsKey(user) && SigninList[user] != pass)
                return 0;
            else
            {
                SigninList.Add(user, pass);
                return 2;
            }
        }

    }
}
