using CafeAndRestaurant.Lib.Abstract;
using CafeAndRestaurant.Lib.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeAndRestaurant.Forms
{
    public partial class FrmSiparis : Form
    {
        private List<Menu> menuler = new List<Menu>();

        public List<Siparis> SiparisBilgileri = new List<Siparis>();
        public List<SiparisDetay> SiparisDetaylari = new List<SiparisDetay>();


        string[] menuResimIsimleri = { "Balıklar", "FastFood", "Kahvaltı", "Mezeler", "Tatlılar", "Salatalar", "Yemekler", "Çorbalar", "İçecekler" };
        public FrmSiparis()
        {
            InitializeComponent();

        }
        public void JsonConverter(string menuIsmi)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"/Menuler/{menuIsmi}.json";
            StreamReader fileJson = new StreamReader(path);
            string dosyaİcerigi = fileJson.ReadToEnd();
            menuler = JsonConvert.DeserializeObject<List<Menu>>(dosyaİcerigi);

            //MessageBox.Show($"{menuler.Count} ürün içeri aktarıldı");
            foreach (var eleman in menuler)
            {
                MemoryStream stream = new MemoryStream(eleman.Fotograf);
                var groupBox = new GroupBox();
                groupBox.Name = $"grpBox{eleman.UrunAd}";

                //Sol taraf menü listesi click olaylaarı
                var pbox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(210, 160),
                    Image = Image.FromStream(stream)

                };
                pbox.Name = $"{eleman.UrunAd}";
                pbox.Click += new EventHandler(pboxUrunler_Click);
                pbox.Parent = groupBox;
                flpMenuElemanlari.Controls.Add(pbox);

                // Label içerisinde ürün bilgileri yazdırıldı
                Label lblDetay = new Label
                {
                    Text = $"{eleman.UrunAd} {eleman.Fiyat} TL",
                    ForeColor = Color.White,
                    //BackColor = Color.Transparent,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    BackColor = Color.Chocolate,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(13, 110),
                    AutoSize = true
                };
                lblDetay.Parent = pbox;
            }
        }
        //private List<Menu> siparişler = new List<Menu>();

        //Menüde bulunan ürünlerin click olayı
        private void pboxUrunler_Click(object sender, EventArgs e)
        {


            PictureBox oPictureBox = (PictureBox)sender;
            foreach (var item in menuler)
            {
                if (oPictureBox.Name == item.UrunAd)
                {
                    // Tıklanan ürünün sipariş listesine atılması.
                    dtGrdSiparis.Rows.Add(item.UrunAd, item.Fiyat + " TL ");
                    int sum = 0;
                    for (int i = 0; i < (dtGrdSiparis.Rows.Count) - 1; ++i)
                    {
                        //var gelen=(dtGrdSiparis.Rows[i].Cells[1].Value).ToString();

                        sum += Convert.ToInt32((dtGrdSiparis.Rows[i].Cells[1].Value).ToString().Split(" ").First());
                    }

                    SiparisDetaylari.Add(new SiparisDetay
                    {
                        Fiyat = item.Fiyat,
                        UrunAd = item.UrunAd,
                        Tutar = sum.ToString(),
                    });



                    lblToplam.Text = $"TOPLAM   :  { sum.ToString()}";

                    //MessageBox.Show($"{item.UrunAd}  {item.Fiyat} TL");
                }

            }


        }
        //sol menü pbox clik event
        private void pbox_Click(object sender, EventArgs e)
        {

            flpMenuElemanlari.Controls.Clear();
            PictureBox oPictureBox = (PictureBox)sender;
            foreach (var item in menuResimIsimleri)
            {
                if (oPictureBox.Name == item)
                {
                    JsonConverter(item);
                }
                //MessageBox.Show(oPictureBox.Name);
            }

        }

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"/MenuAD";
            // var path = @"C:\Users\win10\Desktop\MenuAD";
            var resim = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                .Where(x => new string[] { ".bmp", ".jpg", ".png" }
                                .Contains(new FileInfo(x).Extension.ToLower()))
                                .Take(20)
                                .ToList();

            for (int i = 0; i < resim.Count(); i++)
            {
                var groupBox = new GroupBox();
                groupBox.Name = $"grpBox{menuResimIsimleri[i]}";


                var pbox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(220, 170),
                    //ClientSize = new Size(200, 180),
                    ImageLocation = resim[i]
                };
                pbox.Name = $"{menuResimIsimleri[i]}";
                pbox.Click += new EventHandler(pbox_Click);
                pbox.Parent = groupBox;
                flwpMenu.Controls.Add(pbox);

                //Label içerisinde menü isimleri yazdırıldı
                Label lblDetay = new Label
                {
                    Text = $"{menuResimIsimleri[i]}",
                    ForeColor = Color.Chocolate,
                    //BackColor = Color.Transparent,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    BackColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(7, 7)
                    //Margin = new Thickness(20)
                };

                lblDetay.Parent = pbox;
            }
        }
        private Siparis sp = new Siparis();
        private void btn_SiparisAl_Click(object sender, EventArgs e)
        {
            FrmPersonel frmPersonel = new FrmPersonel();
            foreach (var item in SiparisBilgileri)
            {

                if (item.Durum == SiparisDurum.Aktif)
                {
                    item.Durum = SiparisDurum.Pasif;
                }


                Button b = new Button
                {
                    Name = item.Masa
                };
                //frmPersonel.ChangecolorDolu(b);

                //if (frmPersonel != null)
                //{

                //    foreach (Control c in frmPersonel.Controls)
                //    {
                //        if (c is Button)
                //        {
                //            if (c.Text == item.Masa)
                //            {
                //                c.BackColor = System.Drawing.Color.Green;
                //                break;
                //            }
                //        }
                //    }

                //    MessageBox.Show("fghjk");

                //}
            }
            //frmPersonel.Show();
            this.Hide();
        }

        private void btnAdisyonKapat_Click(object sender, EventArgs e)
        {
            
        }
    }
}