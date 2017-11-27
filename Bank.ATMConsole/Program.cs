using Bank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ATMConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AuthService welcome = new AuthService();

            Console.WriteLine("Please enter your account number:");
            int acctNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your pin");
            int pin = int.Parse(Console.ReadLine());



            welcome.VerifyUser( acctNum, pin);


          
            

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {

                
                case 1:
                    AccountController.GetAccount(acctNum, pin);
                    break;
                //TODO: write method handle case 2

                case 2:
                    Console.WriteLine("Please enter the amount you would like to withdrawl.");
                    int withdrawlAmt = int.Parse(Console.ReadLine());

                    if (withdrawlAmt % 20 != 0)
                    {
                        Console.WriteLine("Please enter an amount that is a multiple of 20");
                    }

                    else if (withdrawlAmt > 0) // replace 0 with Account Balance
                    {
                        Console.WriteLine("Insufficient funds");
                    }
                    else
                    {
                        Console.WriteLine("Please collect your cash.\n" + "Your new balance is:$");
                        
                    }

                    break;

                //TODO: write method wot handle deposit
                case 3:
                    Console.WriteLine("Please enter the amount you wuold like to deposit");
                    int depositAmt = int.Parse(Console.ReadLine());
                    Console.WriteLine($"You have entered {depositAmt}. Your new balance is:$" );

                    break;

                case 4:
                    Console.WriteLine("Thank you for choosing First Bank of Nick!");
                    break;
            }



            Console.ReadLine();
        }
    }
}
