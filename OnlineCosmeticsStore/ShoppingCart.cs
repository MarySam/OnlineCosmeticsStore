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

        public CustomerInformation Customer { get; set; } 

        //This is a property. It has a a getter and a setter.  This is the list of items.
        //This property is public which gives us access to items outside of the class.  It works by creating an array of cosmetics objects/instances from the Cosmetics class.  
        //The same code as:public Cosmetics[] Items { get; set; }. 
        public Cosmetics[] Items
        {
            get { return this.items; }
            set { this.items = value; }
        }

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

//This is a field.  Fields are usually private and only accessable in this class. This is the container for holding our Cosmetics items.  The container or variable is called "items".  
//The variable "items" is of type Cosmetics and holds arrays. 
//private Cosmetics[] items;

//This allows us to access items outside of the class and put it into our private "items" variable.
//public Cosmetics[] Items
//{
//    get { return this.items; }
//    set { this.items = value; }
//}
