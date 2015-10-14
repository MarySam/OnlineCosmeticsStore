using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCosmeticsStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***WELCOME TO MARY'S ONLINE COSMETICS STORE***\n Would you like to login or sign up for an account with us?\nPlease enter 'login' or 'sign up'.\nOr else press 'enter' to browse our store");
            string userValue = Console.ReadLine();
            
            if (userValue.ToLower() == ("login"))
            {
                Console.WriteLine("Ok, great! Please enter in your email address");

                //Here we are displaying the email back to the user and converting it all to lowercase for consistency.
                var email = Console.ReadLine();
                string convertedEmail = email.ToLower();

                //Here we are using the email address as the key to browse through the database.  The customer info variable is used to store the value returned by the method.
                var customerInfo = CustomerInformation.GetAllCustomerInformationByEmail(convertedEmail);

                //If the email address entered does not match any email addresses on file, the user will be prompted to create an account.
                if (customerInfo.Length == 0)
                {
                    Console.WriteLine("Sorry, we don't have this email address on file. Please set up a new account.");
                    CustomerInformation.CreateCustomerInformation();
                }
                else
                {   //In case there are more than one accounts with the same email address.  For simplicity, we are defaulting to the first account on file. Hence the [0] element.
                    CustomerInformation loggedInCustomer = customerInfo[0];
                    Console.WriteLine("Welcome Back {0}", loggedInCustomer.CustomerName);
                }
            }
            
            //Here we are calling up the CustomerInformation class so that the user can set up their account.  
            if (userValue.ToLower() == ("sign up"))
            {
                Console.WriteLine("Ok, great! Let's get your account set up");
                CustomerInformation.CreateCustomerInformation();
            }

            //Here we are calling up the Cosmetics class to display to the user all of the items that we have in store.
            else
            {
                Console.WriteLine("Ok, let's check out what cool items we have in store!");
                var cosmeticslist = Cosmetics.GetAllCosmetics();
                Console.WriteLine(cosmeticslist);
                Console.ReadLine();
            }

            {
                return;
            }

        }

    }
}

//If the uservalue does not equal "yes" at all, the program will end.
//if (userValue.ToLower() != "yes")



