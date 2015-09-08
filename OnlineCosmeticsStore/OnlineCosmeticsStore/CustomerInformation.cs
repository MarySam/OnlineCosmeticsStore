using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCosmeticsStore
{
    class CustomerInformation
    {
        #region Properties
        public string CustomerName { get; set; }
        public int AccountNumber { get; set; }
        public string Address { get; set; }
        #endregion

        //public override string ToString()
        //{
        //    return string.Format("Customer Name: {0}\nAccount Number: {1}\nAddress: {2}", this.CustomerName, this.AccountNumber, this.Address);
        //}
    }
}
