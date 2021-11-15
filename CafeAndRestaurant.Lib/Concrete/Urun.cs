using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAndRestaurant.Lib.Concrete
{
    public class Urun
    {
        public string UrunAd { get; set; }
        public string Fiyat { get; set; }
        // public string Id { get; set; }
        public byte[] Fotograf { get; set; }

        public override string ToString() => $"{UrunAd}-{Fiyat}";
    }
}
