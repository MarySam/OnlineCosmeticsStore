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
        public string Name { get; set; }
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
        NailPolish,
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
            message = "Ok, great!";

            else if (userValue.ToLower() == "no")
            message = "Ok, have a great day!";

            else
                message = "Please restart the program and type in 'Yes' or 'No'";

            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
