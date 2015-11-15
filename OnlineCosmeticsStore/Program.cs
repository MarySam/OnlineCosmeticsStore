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
            try
            {
                CustomerInformation customer = new CustomerInformation();
                customer.CustomerName = "Guest";

                while (!success && attempts++ < 4)
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
                                customer = CustomerInformation.CreateCustomerInformation();
                                break;
                            }
                            else
                            {   //In case there are more than one accounts with the same email address.  For simplicity, we are defaulting to the first account on file. Hence the [0] element.
                                customer = customerInfo[0];
                                Console.WriteLine("Welcome Back {0}", customer.CustomerName);
                                //A break to take the logged in customer out of the while loop so that they could see what items we have in store.
                                break;
                            }
                        }
                    //Here we are calling up the CustomerInformation class so that the user can set up their account.  
                    if (convertedUserValue == 2)
                    {
                        Console.WriteLine("Ok, great! Let's get your account set up.");
                        customer = CustomerInformation.CreateCustomerInformation();
                        //This breaks out of the while loop and takes the customer to the items in the store.
                        break;
                    }
                    if (convertedUserValue == 3)
                    {
                        //This breaks out of the while loop and takes the customer to the items in the store.
                        break;
                    }
                    else if (convertedUserValue == 0 || convertedUserValue < 0 || convertedUserValue > 3)
                    {
                        Console.Write("Sorry that is not a valid option, press 'Enter' to continue.");
                        Console.ReadLine();
                    }
                }//end while bracket

                //Calls the cosmetics class which houses the DisplayContents property.
                Console.WriteLine("Ok, let's check out what cool items we have in store!");
                var cosmeticslist = Cosmetics.GetAllCosmetics();
                Cosmetics.DisplayContents();

                //foreach (var item in cosmeticslist)
                //{
                //    Console.WriteLine(item);
                //}
                //Console.ReadLine();

                Console.WriteLine("Let's go shopping!");

                ShoppingCart shoppingCart = new ShoppingCart();
                shoppingCart.Customer = customer;

                List<Cosmetics> shoppingList = new List<Cosmetics>();
                shoppingList.Add(cosmeticslist[0]);
                shoppingList.Add(cosmeticslist[3]);

                shoppingCart.Items = shoppingList.ToArray();
                Console.WriteLine("Here's what you bought:");
                Console.WriteLine(shoppingCart);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, the system is down.  Please try again later.");
                Console.ReadLine();
            }
        }
    }
}





