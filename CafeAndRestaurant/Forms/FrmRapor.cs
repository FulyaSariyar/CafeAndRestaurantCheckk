using CafeAndRestaurant.Lib.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAndRestaurant.Forms
{
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        private List<SiparisDetay> SiparisDetay = new List<SiparisDetay>();
        private void btnBack2_Click(object sender, EventArgs e)
        {
            //FrmGiris frmGiris = new FrmGiris();
            //frmGiris.Show();
            this.Close();
        }

        private void brnGunRapor_Click(object sender, EventArgs e)
        {
            var path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Siparis.json";

            FileStream fileStream = new FileStream(path2, FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);
            string dosyaİcerigi = reader.ReadToEnd();
            SiparisDetay = JsonConvert.DeserializeObject<List<SiparisDetay>>(dosyaİcerigi);
            MessageBox.Show($"{SiparisDetay.Count}adert ürün içeri aktarıldı");
            reader.Close();

            int sum=0;
            foreach (SiparisDetay item in SiparisDetay)
            {
                if(item.SiparisTarihi.Day==DateTime.Now.Day)
                {
                    dtGrdGunluk.Rows.Add(item.UrunAd, item.Fiyat );
                    sum += Convert.ToInt32(item.Fiyat.ToString().Split(" ").First());
                }    
            }
            dtGrdGunluk.Rows.Add("TOPLAM", sum + " TL ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Siparis.json";

            FileStream fileStream = new FileStream(path2, FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);
            string dosyaİcerigi = reader.ReadToEnd();
            SiparisDetay = JsonConvert.DeserializeObject<List<SiparisDetay>>(dosyaİcerigi);
            MessageBox.Show($"{SiparisDetay.Count}adert ürün içeri aktarıldı");
            reader.Close();

            int sum = 0;
            foreach (SiparisDetay item in SiparisDetay)
            {
                if (item.SiparisTarihi.Day<DateTime.Now.Day && item.SiparisTarihi.Day>DateTime.Now.Day-29)               
                    {
                    dtgrdAylik.Rows.Add(item.UrunAd, item.Fiyat + " TL ");
                    sum += Convert.ToInt32(item.Fiyat.ToString().Split(" ").First());
                }
            }
            dtgrdAylik.Rows.Add("TOPLAM", sum + " TL ");

        }
    }
}
