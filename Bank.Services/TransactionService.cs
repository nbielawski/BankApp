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

        public int MakeDeposit(int acctNum, int pin, int depositAmt)
        {

            int DepositAmt = depositAmt;
            using (var ctx = db)
            {

                var query = 
                    from a in ctx.Accounts
                    where a.AccountNumber == acctNum && a.PIN == pin
                    select a;
                var account = query.Single();

                account.Balance = account.Balance +  DepositAmt;

                ctx.SaveChanges();

                return account.Balance;


            }
        }


        public int MakeWithdrawl(int acctNum, int pin, int withdrawlAmt)
        {

            int WithdrawlAmt = withdrawlAmt;
            using (var ctx = db)
            {

                var query =
                    from a in ctx.Accounts
                    where a.AccountNumber == acctNum && a.PIN == pin
                    select a;
                var account = query.Single();

                account.Balance = account.Balance - WithdrawlAmt;

                ctx.SaveChanges();

                return account.Balance;


            }
        }










    }
}
