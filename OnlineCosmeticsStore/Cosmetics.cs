using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCosmeticsStore
{
    /// <summary>
    /// MyFirstAtHomeProject
    /// </summary>
    class Cosmetics
    {
        #region Properties
        public string CosmeticName { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public MakeupType Type { get; set; }
        #endregion

        #region Enum
        public enum MakeupType
        { Foundation,
        Mascara,
        Eyeshadow,
        Lipstick,
        Eyeliner,
        Blush,
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mary's Online Cosmetic Store!\nAre you interested in seeing what we have in store? Yes or No?");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue.ToLower() == "yes")
            {
                message = "Ok, great! Let's set you up with an account, please enter your Name";
            }
            else if (userValue.ToLower() == "no")
            {
                message = "Ok, have a great day!";
            }
            else
            {
                message = "Please restart the program and type in 'Yes' or 'No'";
            }

            Console.WriteLine(message);
            string customerInput = Console.ReadLine();

            //If the uservalue does not equal "yes" at all, the program will end.
            if (userValue.ToLower() != "yes")
            {
                return;
            }

            #region Entering in Address
            Console.WriteLine("Please enter you address");
            string customerAddressInput = Console.ReadLine();
            #endregion

            #region CustomerAccountSetup
            CustomerInformation customerAccount = new CustomerInformation();
            customerAccount.CustomerName = customerInput;
            customerAccount.Address = customerAddressInput;

            Console.WriteLine("AccountNumber: {0}, CustomerName: {1}, Address: {2}", customerAccount.AccountNumber, customerAccount.CustomerName, customerAccount.Address);
            Console.ReadLine();
            #endregion
        }
    }
}
