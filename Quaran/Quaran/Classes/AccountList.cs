using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quaran.Classes
{
   public  class AccountList
    {
        public static List<Account> accounts = new List<Account>()
        {
            new Account {id=1,name="Ahmed Mohammed",Email="Ad@gmail.com",password="Ad*123",confirmPassword="Ad@123" },
            new Account {id=2,name="Ahmed Ahmed",Email="Ad2@gmail.com",password="Ad*123",confirmPassword="Ad@123" },
            new Account {id=3,name="Ahmed Adam",Email="Ad3@gmail.com",password="Ad*123",confirmPassword="Ad@123" },

        };
    }
}
