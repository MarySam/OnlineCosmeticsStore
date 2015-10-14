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
    }
}
