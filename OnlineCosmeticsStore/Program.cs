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
            Console.WriteLine("Welcome to Mary's Online Cosmetic Store!\nPlease enter 'Yes' if you would like to set up an account with us or 'no' if you are just browsing");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue.ToLower() == "yes")
            {
                message = "Ok, great! Let's set you set up";
            }
            else if (userValue.ToLower() == "no")
            {
                message = "Ok, have fun browsing!";
            }
            else
            {
                message = "Goodbye";
            }

            Console.WriteLine(message);
            Console.ReadLine();
                       
            {
                return;
            }
                      
        }

    }
}

//If the uservalue does not equal "yes" at all, the program will end.
//if (userValue.ToLower() != "yes")



