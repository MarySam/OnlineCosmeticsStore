using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCosmeticsStore
{
    /// <summary> This class has all of the cosmetics items.
    /// MyFirstAtHomeProject
    /// </summary>
    public class Cosmetics
    {
        #region Properties
        [Key]
        public int CosmeticItemNumber { get; set; }

        public string CosmeticName { get; set; }

        public double Price { get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }

        public MakeupType Type { get; set; }
        #endregion

        //The enum data type is an integer by default.  The first item in the list starts at 0.
        public enum MakeupType
        {
            Foundation,
            Mascara,
            Eyeshadow,
            Lipstick,
            Eyeliner,
            Blush,
        }
        //This code loads up our database and turns it to an array.
        public static Cosmetics[] GetAllCosmetics()
        {
            using (var db = new CosmeticsModel())
            {
                var allCosmetics = db.CosmeticsList;
                return allCosmetics.ToArray();

            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", this.CosmeticName, this.Type, this.Price);
        }

        public static void DisplayContents()
        {
            
            Cosmetics[] DisplayAllCosmetics = GetAllCosmetics();

            Console.WriteLine("{0,-15} {1,-30} {2,6} {3,20} {4,20} {5,20}", "Item Number", "Cosmetic Name", "Price", "Color", "Brand", "Type");

            for (int x = 0; x < DisplayAllCosmetics.Length; x++)
            {
                Console.Write("{0,-15} ", DisplayAllCosmetics[x].CosmeticItemNumber);
                Console.Write("{0,-30} ", DisplayAllCosmetics[x].CosmeticName);
                Console.Write("{0,6:c} ", DisplayAllCosmetics[x].Price);
                Console.Write("{0,20} ", DisplayAllCosmetics[x].Color);
                Console.Write("{0,20} ", DisplayAllCosmetics[x].Brand);
                Console.Write("{0,20} ", DisplayAllCosmetics[x].Type);

                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }


}




//db.CosmeticsList.Add(new Cosmetics());
//db.SaveChanges();

