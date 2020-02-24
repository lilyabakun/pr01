using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            Account account1 = new Account("name", 3, 2.5);
            account.SetName("Petr");
            account.Getname();
        }
    }
}
