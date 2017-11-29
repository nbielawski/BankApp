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
            Console.WriteLine(" ________  ______  _______    ______  ________        _______    ______   __    __  __    __ ");
            Console.WriteLine(@"|        \|      \|       \  /      \|        \      |       \  /      \ |  \  |  \|  \  /  \");
            Console.WriteLine(@"| $$$$$$$$ \$$$$$$| $$$$$$$\|  $$$$$$\\$$$$$$$$      | $$$$$$$\|  $$$$$$\| $$\ | $$| $$ /  $$");
            Console.WriteLine(@"| $$__      | $$  | $$__| $$| $$___\$$  | $$         | $$__/ $$| $$__| $$| $$$\| $$| $$/  $$ ");
            Console.WriteLine(@"| $$  \     | $$  | $$    $$ \$$    \   | $$         | $$    $$| $$    $$| $$$$\ $$| $$  $$  ");
            Console.WriteLine(@"| $$$$$     | $$  | $$$$$$$\ _\$$$$$$\  | $$         | $$$$$$$\| $$$$$$$$| $$\$$ $$| $$$$$\  ");
            Console.WriteLine(@"| $$       _| $$_ | $$  | $$|  \__| $$  | $$         | $$__/ $$| $$  | $$| $$ \$$$$| $$ \$$\ ");
            Console.WriteLine(@"| $$      |   $$ \| $$  | $$ \$$    $$  | $$         | $$    $$| $$  | $$| $$  \$$$| $$  \$$\");
            Console.WriteLine(@" \$$       \$$$$$$ \$$   \$$  \$$$$$$    \$$    ______\$$$$$$$  \$$   \$$ \$$   \$$ \$$   \$$");
            string ofNick = @"                                              /      \                                      
                                      ______ |  $$$$$$\                                     
                                     /      \ | $$_  \$$                                     
                                    |  $$$$$$\| $$ \                                         
                                    | $$  | $$| $$$$                                         
                                    | $$__ / $$| $$                                           
                                     \$$    $$| $$                                           
                                      \$$$$$$  \$$                                           
                               __ __  ______ ______   __ __
                              |  \  |  \|      \ /      \ |  \  /  \                         
                              | $$\ | $$ \$$$$$$|  $$$$$$\| $$ /  $$                         
                              | $$$\| $$  | $$  | $$   \$$| $$/  $$                          
                              | $$$$\ $$  | $$  | $$      | $$  $$                           
                              | $$\$$ $$  | $$  | $$   __ | $$$$$\                           
                              | $$ \$$$$ _ | $$_ | $$__ /  \| $$ \$$\                          
                              | $$  \$$$|   $$ \ \$$    $$| $$  \$$\                         
                               \$$   \$$ \$$$$$$  \$$$$$$  \$$   \$$  ";

            Console.WriteLine(ofNick);

            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();
            Console.Clear();


            AuthService welcome = new AuthService();

            Console.WriteLine("Please enter your account number:");
            int acctNum = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Please enter your pin");
            int pin = int.Parse(Console.ReadLine());

            Console.Clear();

            welcome.VerifyUser(acctNum, pin);





            int choice = int.Parse(Console.ReadLine());

            Console.Clear();           

            

            switch (choice)
            {


                case 1:
                    AccountController.GetAccount(acctNum, pin);
                    break;
                

                case 2:
                    AccountController.Withdrawl(acctNum, pin);
                                                          

                    break;

                
                case 3:
                    
                    AccountController.Deposit(acctNum, pin);

                    break;

                case 4:
                    Console.WriteLine("Thank you for choosing First Bank of Nick!");
                    break;
            }


            


            Console.ReadLine();
        }
    }
}
