
using Bank.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class CustomerService
    {

        //create cinnection to the DB //get DB context
        //Create new customer
        //add customer to db 
        //save db


        public bool CreateCustomer(string first, string last)
        {
            using (var ctx = new BANK_DBEntities())
            {
                var entity =
                        new Customer
                        {
                            FirstName = first,
                            LastName = last
                        };

                ctx.Customers.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }

       


     















    }
}
