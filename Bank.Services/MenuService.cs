using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class MenuService
    {
        public void ListOptions()
        {
            Console.Clear();
            Console.WriteLine("Welcome!\n\n\n"+
                "Display Balnace.................1\n"
                + "Withdrawl.................2\n"
                + "Deposit.................3\n"
                + "End Session.................4"
                );
        }

    }
}
