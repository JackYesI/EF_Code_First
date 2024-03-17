    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFIRST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model1 model = new Model1();
            Accounts account = model.Account.Add(new Accounts() { Login = "login_1*", Password = "password_155"});
            model.SaveChanges();
        }
    }
}
