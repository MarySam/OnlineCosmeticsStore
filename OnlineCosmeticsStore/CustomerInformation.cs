using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCosmeticsStore
{
    public class CustomerInformation
    {
        //Variable
        private static int lastAccountNumber = 0;

        //Properties
        public string CustomerName { get; set; }

        [Key]
        public string EmailAddress { get; set; }

        public string Address { get; set; }

        public int AccountNumber { get; private set; }


        //For the account number to increment by 1
        /// <summary>
        /// Default Constructor
        /// </summary>

        //Constructors
        public CustomerInformation()
        {
            lastAccountNumber = lastAccountNumber + 1;
            AccountNumber = lastAccountNumber;
        }

        public static CustomerInformation CreateCustomerInformation()
        {
            #region Entering in Name
            Console.WriteLine("Please enter your name");
            string customerNameInput = Console.ReadLine();
            #endregion

            #region Entering in Email Address
            Console.WriteLine("Please enter your Email address");
            string customerEmailAddressInput = Console.ReadLine();
            #endregion

            #region Entering in Address
            Console.WriteLine("Please enter you address");
            string customerAddressInput = Console.ReadLine();
            #endregion

            using (var db = new CustomerModel())
            {
                CustomerInformation customerAccount = new CustomerInformation();
                customerAccount.CustomerName = customerNameInput;
                customerAccount.EmailAddress = customerEmailAddressInput;
                customerAccount.Address = customerAddressInput;

                Console.WriteLine("CustomerName: {0}, CustomerEmailAddress: {1}, Address: {2}, AccountNumber {3}", customerAccount.CustomerName, customerAccount.EmailAddress, customerAccount.Address, customerAccount.AccountNumber);
                Console.ReadLine();

                db.CustomerInformations.Add(customerAccount);
                db.SaveChanges();

                return customerAccount;
            }
        }
        public static CustomerInformation[] GetAllCustomerInformationByEmail(string emailAddress)
        {
            using (var db = new CustomerModel())
            {
                var customerInfo = db.CustomerInformations.Where(info => info.EmailAddress == emailAddress);
                return customerInfo.ToArray();
            }
        }
    }
}


