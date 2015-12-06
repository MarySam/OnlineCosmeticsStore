using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace OnlineCosmeticsStore
{
    public class CustomerInformation
    {
        private static int lastAccountNumber = 0;
        private static List<CustomerInformation> customerInformations = new List<CustomerInformation>();
        private static bool accountsLoaded = false;

        //Properties
        public string CustomerName { get; set; }


        public string EmailAddress { get; set; }

        public string Address { get; set; }
        [Key]
        public int AccountNumber { get; private set; }

        //Constructors
        public CustomerInformation()
        {
            lastAccountNumber = lastAccountNumber + 1;
            AccountNumber = lastAccountNumber;
        }

        public static CustomerInformation CreateCustomerInformation(string customerName, string customerEmailAddress, string customerAddress)
        {
            using (var db = new CustomerModel())
            {
                if (!accountsLoaded)
                {
                    //This increments based on the count of rows.
                    lastAccountNumber = db.CustomerInformations.Count();
                    accountsLoaded = true;
                }

                CustomerInformation customerAccount = new CustomerInformation();
                customerAccount.CustomerName = customerName;
                customerAccount.EmailAddress = customerEmailAddress;
                customerAccount.Address = customerAddress;

                customerInformations.Add(customerAccount);
                db.CustomerInformations.Add(customerAccount);
                db.SaveChanges();

                return customerAccount;
            }
        }

        public static CustomerInformation[] GetAllCustomerInformationByEmail(string emailAddress)
        {
            using (var db = new CustomerModel())
            {
                var customerInfo = db.CustomerInformations.Where(info => info.EmailAddress.ToLower() == emailAddress);
                return customerInfo.ToArray();
            }
        }
    }
}





