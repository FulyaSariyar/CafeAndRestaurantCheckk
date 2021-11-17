using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeAndRestaurant.Lib.Concrete
{
    public class Urun
    {
        #region
        private string _urunKategori;
        private string _urunAd;
        private string _urunFiyat;
        #endregion
        public string UrunKategori 
        {
            get
            {
                return _urunKategori;
            }
            set
            {
                _urunKategori = value; 
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("kategori boş geçilemez");
                }
            }
        }
        public string UrunAd {
            get 
            {
                return _urunAd.Substring(0, 1).ToUpper() + _urunAd.Substring(1).ToLower();
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("Ürün adı boş geçilemez"); 
                }
                foreach (char harf in value)
                {

                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf)|| char.IsDigit(harf))
                        throw new Exception("Ürün adında harf dışında geçersiz karakter bulunmaktadır");
                }
                if (value.Length > 50)
                    throw new Exception(" girilen ifade 50 karakterden büyük olmasın");

                _urunAd = value;
            }
        }
        public string Fiyat {get;set;}
        // public string Id { get; set; }
        public byte[] Fotograf { get; set; }

        public override string ToString() => $"{UrunAd}-{Fiyat}";
    }
}
