using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCosmeticsStore
{
    public class Orders
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

        public int TotalQuantity
        {
            get
            {
                int total = 0;
                Cosmetics currentItem = this.Items[total];
                while (currentItem != null)
                {
                    total++;
                    currentItem = this.Items[total];
                }

                return total;
            }
        }

    }
}




