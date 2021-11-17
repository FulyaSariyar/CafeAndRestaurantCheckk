using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAndRestaurant.Lib.Concrete
{
    public class SiparisDetay
    {
        public string UrunAd { get; set; }

        public string Fiyat { get; set; }

        public DateTime SiparisTarihi = DateTime.Now;
        public string Tutar { get; set; }

       

        //public int Adet { get; set; }

        //public string TutarTL => string.Format("{0:0.00}₺", Tutar()); // 9.00₺ //prop geti bu

        //public decimal Tutar() => Adet * BirimFiyat; // metodun returnu bu 
    }
}
