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
        private Cosmetics[] items = new Cosmetics[100];
        private int itemCount = 0;

        public CustomerInformation Customer { get; set; }

        public Cosmetics[] Items
        {
            get { return this.items; }
        }

        public void AddItem(Cosmetics item)
        {
            this.Items[this.itemCount] = item;
            this.itemCount++;
        }

        public void RemoveLastItem()
        {
            if (this.itemCount == 0)
            {
                return;
            }

            this.Items[this.itemCount - 1] = null;
            this.itemCount--;
        }

        public int ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Add an Item to my Shopping Cart");
            Console.WriteLine("2. Remove the last Item from my Shopping Cart");
            Console.WriteLine("3. Checkout");
            Console.Write("Please select an option: ");

            string userInput = Console.ReadLine();
            int option;
            if (!int.TryParse(userInput, out option))
            {
                option = -1;
            }

            return option;
        }

        private void AddUserItem()
        {
            Console.Write("Please enter the item number you would like to add: ");
            string userInput = Console.ReadLine();
            int itemNumber;
            if (!int.TryParse(userInput, out itemNumber))
            {
                itemNumber = -1;
            }

            Cosmetics itemToAdd = Cosmetics.GetCosmeticsItem(itemNumber);
            if (itemToAdd == null)
            {
                Console.WriteLine("Sorry, we couldn't find that item. Please try again.");
            }
            else
            {
                this.AddItem(itemToAdd);
            }
        }

        private void RemoveUserItem()
        {
            Console.Write("Please enter the item number you would like to remove: ");
            string userInput = Console.ReadLine();
            int itemNumber;
            if (!int.TryParse(userInput, out itemNumber))
            {
                itemNumber = -1;
            }

            Cosmetics itemToRemove = Cosmetics.GetCosmeticsItem(itemNumber);
            if (itemToRemove == null)
            {
                Console.WriteLine("Sorry, we couldn't find that item. Please try again.");
            }
            else
            {
                this.AddItem(itemToRemove);
            }
        }

        public void AddRemoveItems()
        {
            int optx = 0;
            while (optx != 3)
            {
                optx = this.ShowMenu();

                switch (optx)
                {
                    case 1:
                        this.AddUserItem();
                        break;
                    case 2:
                        this.RemoveLastItem();
                        break;
                    default:
                        break;
                }

                // Output the shopping cart info after every iteration of the loop.
                Console.WriteLine(this);
            }
        }

        //Total Price is a property.
        public double TotalPrice
        {
            get
            {
                double total = 0;
                foreach (Cosmetics currentItem in Items)
                {
                    if (currentItem == null)
                    {
                        break;
                    }

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

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("Customer: {0}\n", this.Customer.CustomerName);
            builder.AppendFormat("Total Price: {0}\n", this.TotalPrice);
            builder.AppendLine("Items:");
            foreach (Cosmetics item in this.Items)
            {
                if (item == null)
                {
                    break;
                }

                builder.AppendLine(item.ToString());
            }

            return builder.ToString();
        }
    }
}

//public override string ToString()
//{
//    StringBuilder builder = new StringBuilder();
//    builder.AppendFormat("Customer: {0}\n", this.Customer.CustomerName);
//    builder.AppendFormat("Total Price: {0}\n", this.TotalPrice);
//    builder.AppendLine("Items:");
//    foreach (Cosmetics item in this.Items)
//    {
//        builder.AppendLine(item.ToString());
//    }

//    return builder.ToString();
//}

//public CustomerInformation Customer { get; set; }

//public bool RemoveItem(Cosmetics item)
//{
//    int indexToRemove = -1;
//    for (int index = 0; index < this.Items.Length; index++)
//    {
//        Cosmetics currentItem = this.Items[index];
//        if (currentItem == null)
//        {
//            break;
//        }

//        if (currentItem.CosmeticItemNumber == item.CosmeticItemNumber)
//        {
//            indexToRemove = index;
//            break;
//        }
//    }

//    if (indexToRemove == -1)
//    {
//        return false;
//    }


//}


