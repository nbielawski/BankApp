using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class AuthService
    {

        private BANK_DBEntities db = new BANK_DBEntities();
        MenuService menuService = new MenuService();

        public bool VerifyUser(int acctNum, int pin)
        {
            var query = from a in db.Accounts
                        where a.AccountNumber == acctNum && a.PIN == pin
                        select a;
            foreach (var a in query)
            {
                menuService.ListOptions();
                return true;
            }
            Console.WriteLine("Account Number and/or Pin Number is not correct");
            return false;
        }
    }
}
