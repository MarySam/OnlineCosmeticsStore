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
    }
}


//db.CosmeticsList.Add(new Cosmetics());
//db.SaveChanges();

