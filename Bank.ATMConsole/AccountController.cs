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


       public static void Deposit(int acctNum, int pin)
        {
            TransactionService svc = new TransactionService();
            Console.WriteLine("Please enter the amount you would like to deposit");
            int depositAmt = int.Parse(Console.ReadLine());
            var currentUser = svc.MakeDeposit(acctNum, pin, depositAmt);

            
            Console.WriteLine("Deposit successful!\n" + "Your new balance is: $" + currentUser);
        }

        public static void Withdrawl(int acctNum, int pin)
        {
            TransactionService svc = new TransactionService();
            Console.WriteLine("Please enter the amount you would like to withdrawl");
            int withdrawlAmt = int.Parse(Console.ReadLine());
            var currentUser = svc.MakeWithdrawl(acctNum, pin, withdrawlAmt);
            
            
            

            if (withdrawlAmt % 20 != 0)
            {
                Console.WriteLine("Please enter an amount that is a multiple of 20");
            }

            else if (withdrawlAmt > currentUser ) 
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                Console.WriteLine("Please collect your cash.\n" + "Your new balance is: $" + currentUser); 

            }

            
        }



    }
}
