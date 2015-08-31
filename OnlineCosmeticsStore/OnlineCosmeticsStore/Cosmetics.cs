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
        }
    }
}
