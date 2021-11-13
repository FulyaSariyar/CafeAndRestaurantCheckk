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
        //public Stream Fotograf { get; protected set; }
        public byte[] Fotograf { get; set; }
        public string UrunAd { get; set; }
        public string Fiyat { get; set; }
        public override string ToString() => $"{UrunAd} {Fiyat}";
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
