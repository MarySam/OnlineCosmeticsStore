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
            bool success = false;
            short attempts = 1;
            Console.WriteLine("**********WELCOME TO MARY'S ONLINE COSMETICS STORE**********");
            {
                while (!success && attempts++ <4)

                {
                    Console.WriteLine("Please choose one of the following optons.\n1.Login\n2.Sign Up\n3.Browse as a Guest");
                    var userValue = Console.ReadLine();
                    int convertedUserValue;
                    if (int.TryParse(userValue, out convertedUserValue) == true)

                        if (convertedUserValue == 1)
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
                    if (convertedUserValue == 2)
                    {
                        Console.WriteLine("Ok, great! Let's get your account set up.");
                        CustomerInformation.CreateCustomerInformation();
                    }

                    //Here we are calling up the Cosmetics class to display to the user all of the items that we have in store.
                    if (convertedUserValue == 3)
                    {
                        Console.WriteLine("Ok, let's check out what cool items we have in store!");
                        var cosmeticslist = Cosmetics.GetAllCosmetics();
                        Console.WriteLine(cosmeticslist);
                        Console.ReadLine();
                    }
                    else if (convertedUserValue == 0 || convertedUserValue < 0 || convertedUserValue > 3)
                    {
                        Console.Write("Sorry that is not a valid option, press 'Enter' to continue.");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}





