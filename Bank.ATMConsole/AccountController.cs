using Bank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ATMConsole
{
    public class AccountController
    {
        public static void GetAccount(int acctNum, int pin)
        {
            TransactionService svc = new TransactionService();
            var currentUser = svc.GetAccount(acctNum, pin);

            Console.WriteLine("Your Balance is: " + currentUser.Balance);

        }

       public static void MakeDeposit(int acctNum, int pin, int depositAmt)
        {
            TransactionService svc = new TransactionService();
            var currentUser = svc.GetAccount(acctNum, pin);
            
            


        }
        

    }
}
