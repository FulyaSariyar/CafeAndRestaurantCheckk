using CafeAndRestaurant.Lib.Abstract;
using CafeAndRestaurant.Lib.Concrete;
using Newtonsoft.Json;
using System.Data;


namespace CafeAndRestaurant.Forms
{
    public partial class FrmSiparis : Form
    {
        private List<Menu> menuler = new List<Menu>();

        public List<Siparis> SiparisBilgileri = new List<Siparis>();
        public List<SiparisDetay> siparisDetaylari = new List<SiparisDetay>();
        public static FrmPersonel frmPer = new FrmPersonel();


        string[] menuResimIsimleri = { "Balıklar", "FastFood", "Kahvaltı", "Mezeler", "Tatlılar", "Salatalar", "Yemekler", "Çorbalar", "İçecekler" };

        public FrmSiparis()
        {
            InitializeComponent();
           


        }
        private Button _btn;
        public FrmSiparis(Button btn)
        {
            InitializeComponent();
            _btn = btn;


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

                        sum += Convert.ToInt32((dtGrdSiparis.Rows[i].Cells[1].Value).ToString().Split(" ").First());
                    }

                    siparisDetaylari.Add(new SiparisDetay()
                    {
                        Fiyat = item.Fiyat,
                        UrunAd = item.UrunAd,
                        Tutar = sum.ToString()
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

            this.siparisDetaylari = Context.SiparisDetaylari;


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
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    BackColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Location = new Point(7, 7)
                };

                lblDetay.Parent = pbox;
            }
        }
        private void btnAdisyonKapat_Click(object sender, EventArgs e)
        {

            Context.Save();
        }

        private void btn_SiparisAl_Click_1(object sender, EventArgs e)
        {
            FrmPersonel frmPersonel = new FrmPersonel();
            foreach (var item in SiparisBilgileri)
            {
                var r = item.Masa;
                //Button kapatilacakButton = SiparisBilgileri.Controls[item.Masa] as Button;


                //frmPersonel.MasaBoşalt(r as Button);

                if (item.Durum == SiparisDurum.Aktif)
                {
                    item.Durum = SiparisDurum.Pasif;
                    
                }
            }

            this.Hide();
            this.Close();
        }

        Bitmap bitmap;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Bitmap dataGridAdisyon = new Bitmap(this.dtGrdSiparis.Width, this.dtGrdSiparis.Height);
            //dtGrdSiparis.DrawToBitmap(dataGridAdisyon, new System.Drawing.Rectangle(0, 0, this.dtGrdSiparis.Width, this.dtGrdSiparis.Height));

            Bitmap Adisyon = new Bitmap(this.flowLayoutPanel1.Width, this.flowLayoutPanel1.Height);
            dtGrdSiparis.DrawToBitmap(Adisyon, new System.Drawing.Rectangle(0, 0, this.flowLayoutPanel1.Width, this.flowLayoutPanel1.Height));

            Bitmap lbl = new Bitmap(this.lblToplam.Width, this.lblToplam.Height);
            lblToplam.DrawToBitmap(lbl, new System.Drawing.Rectangle(0, 0, this.lblToplam.Width, this.lblToplam.Height));

            e.Graphics.DrawImage(Adisyon, 135, 65);
            e.Graphics.DrawImage(lbl, this.dtGrdSiparis.Width, this.flowLayoutPanel1.Height);
        }

        private void btnAdisyonKapat_Click_1(object sender, EventArgs e)
        {
            Context.Save();
            //FrmPersonel frm = (_frmsiparis)Application.OpenForms["form_adi "];
            PrintDialog daraGridViewPrintDialog = new PrintDialog();
            daraGridViewPrintDialog.Document = printDocument1;
            daraGridViewPrintDialog.UseEXDialog = true;
            printDocument1.Print();
            this.Close();
            
            _btn.BackColor = ColorTranslator.FromHtml("#7F7F7F");
            this.Hide();




        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            
            
            //this.Hide();
        }
        //frmPersonel.Show();
    }
}