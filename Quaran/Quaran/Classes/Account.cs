using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quaran
{
    public class Account
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }




        public Account getCurrentAccount(Account newAccount)
        {
            //account = newAccount;
            return newAccount;
        }


    }
}
