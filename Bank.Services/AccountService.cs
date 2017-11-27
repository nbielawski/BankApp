using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    class AccountService
    {

        public bool CreateAccount(int acctNum, int pin, int custID, int acctBal)
        {
            using (var ctx = new BANK_DBEntities())
            {
                var entity =
                        new Account
                        {
                            AccountNumber = acctNum,
                            PIN = pin,
                            Balance = acctBal,
                            CustomerID = custID

                        };

                ctx.Accounts.Add(entity);

                return ctx.SaveChanges() == 1;
            }





        }
    }
}
