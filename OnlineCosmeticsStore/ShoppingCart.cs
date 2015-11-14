using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCosmeticsStore
{
    public class ShoppingCart
    {
        private Cosmetics[] items;

        public Cosmetics[] Items
        {
            get { return this.items; }
            set { this.items = value; }
        }

        public CustomerInformation Customer { get; set; }

        //Total Price is a property.
        public double TotalPrice
        {
            get
            {
                double total = 0;
                foreach (Cosmetics currentItem in Items)
                {
                    total = total + currentItem.Price;
                }

                return total;
        
            }
        }
       
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Customer: {0}\n", this.Customer.CustomerName);
            builder.AppendFormat("Total Price: {0}\n", this.TotalPrice);
            builder.AppendLine("Items:");
            foreach (Cosmetics item in this.Items)
            {
                builder.AppendLine(item.ToString());
            }

            return builder.ToString();
        }
    }
}



