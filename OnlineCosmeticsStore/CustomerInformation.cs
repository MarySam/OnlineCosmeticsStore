using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCosmeticsStore
{
    class CustomerInformation
    {
        #region Variables
        static int lastAccountNumber = 0;
        #endregion

        #region Properties
        public string CustomerName { get; set; }
        public int AccountNumber { get; private set; }
        public string Address { get; set; }
        #endregion

        //For the account number to increment by 1
        /// <summary>
        /// Default Constructor
        /// </summary>
        #region Constructors
        public CustomerInformation()
        {
            lastAccountNumber = lastAccountNumber + 1;
            AccountNumber = lastAccountNumber;
        }
        #endregion

        //public override string ToString()
        //{
        //    return string.Format("Customer Name: {0}\nAccount Number: {1}\nAddress: {2}", this.CustomerName, this.AccountNumber, this.Address);
        //}
    }
}
