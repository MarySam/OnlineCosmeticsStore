using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCosmeticsStore
{
    /// <summary> This class has all of the cosmetics items.
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
        {
            Foundation,
            Mascara,
            Eyeshadow,
            Lipstick,
            Eyeliner,
            Blush,
        }
        #endregion

    }
}
