using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class TransactionService
    {

        private BANK_DBEntities db = new BANK_DBEntities();

       public Account GetAccount(int acctNum, int pin)
        {
            using (db)
            {
                return
                db
                    .Accounts
                    .Where(e => e.AccountNumber == acctNum && e.PIN == pin)
                    .Single();
                
                    
            }
        }








        }
}
