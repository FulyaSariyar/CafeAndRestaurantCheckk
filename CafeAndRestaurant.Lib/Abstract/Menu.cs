using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAndRestaurant.Lib.Abstract
{
   public class Menu
    {
        public Stream MenuResmi { get; set; }
        public string Ad { get; set; }

        public enum MenuResimleri : byte //256 silah tanımlayabiliriz : byte ile.
        {
            Balıklar,
            Çorbalar,
            FastFood,
            İçecekler,
            Kahvaltı,
            Mezeler,
            Pastalar,
            Salatalar,
            Yemekler
        };
    }
}
