using CafeAndRestaurant.Forms;
using CafeAndRestaurant.Lib.Abstract;
using CafeAndRestaurant.Lib.Concrete;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Drawing.Imaging;
using System.Reflection;
using System.Xml.Serialization;

namespace CafeAndRestaurant
{
    public partial class FrmIlk : Form
    {

        private List<Menu> menuler = new List<Menu>();
        string[] menuResimIsimleri = { "Balýklar", "FastFood", "Kahvaltý", "Mezeler", "Tatlýlar", "Mezeler", "Pastalar", "Salatalar", "Yemekler" };
        public FrmIlk()
        {
            InitializeComponent();
            for (int i = 1; i <= 20; i++)
            {
                cbBahçe.Items.Add(i);
                cbZemin.Items.Add(i);
                cbKat1.Items.Add(i);
                cbKat2.Items.Add(i);
                cbKat3.Items.Add(i);
                cbKat4.Items.Add(i);
                cbTeras.Items.Add(i);
            }
        }

        private void FrmIlk_Load(object sender, EventArgs e)
        {

        }

        List<BinaBilgileri> binaBilgileri = new List<BinaBilgileri>();
        List<string> katAd = new List<string>();
        List<string> katMasa = new List<string>();
        private FrmPersonel _frmPersonel;
        private void btnNext1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                string bilgi = checkedListBox1.CheckedItems[i].ToString();
                katAd.Add(bilgi);
            }

            foreach (Control control in grpBxCombolar.Controls)
            {
                if (control is ComboBox && control.Text != "")
                    katMasa.Add(control.Text);
            }
            katMasa.Reverse();

            for (int i = 0; i < katAd.Count; i++)
            {
                binaBilgileri.Add(new BinaBilgileri()
                {
                    BinaBolumAdi = katAd[i],
                    MasaAdet = katMasa[i]
                });
            }
            _frmPersonel = new FrmPersonel();

            foreach (BinaBilgileri item in binaBilgileri)
            {

                _frmPersonel.BinaBilgileri.Add(item);
            }
            FrmPersonel frmPersonel = new FrmPersonel();
            frmPersonel.BinaBilgileri = _frmPersonel.BinaBilgileri;
            frmPersonel.Show();
            this.Hide();


        }

        private void ListeyiDoldur()
        {
            lstUrunler.Items.Clear();
            foreach (Urun urun in UrunContext.Urunler)
            {
                lstUrunler.Items.Add(urun);
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Json verileri içeri aktarma
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"/Menuler/{cmbKategori.Text}.json";
            StreamReader reader = new StreamReader(path);
            string dosyaIcerigi = reader.ReadToEnd();
            UrunContext.Urunler = JsonConvert.DeserializeObject<List<Urun>>(dosyaIcerigi);
            MessageBox.Show($"{UrunContext.Urunler.Count} adet ürün içeri aktarýldý");
            ListeyiDoldur();

            // Json veri dosyasýna ürün ekleme
            Urun yeniUrun = new Urun()
            {
                UrunAd = txtUrunAd.Text,
                Fiyat = txtFiyat.Text,

            };
            if (pbResim.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbResim.Image.Save(resimStream, ImageFormat.Jpeg);

                yeniUrun.Fotograf = resimStream.ToArray();
            }
            UrunContext.Urunler.Add(yeniUrun);
            ListeyiDoldur();
            UrunContext.Save();

            // Json dosyasýna verileri aktarma

            //SaveFileDialog dialog = new SaveFileDialog();
            //dialog.Title = "Dýþarý aktar";
            //dialog.Filter = "JSON Format | *.json";
            //dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //DialogResult result = dialog.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    FileStream fileStream = new FileStream(dialog.FileName, FileMode.OpenOrCreate);

                //StreamWriter writer = new StreamWriter(path);
                //writer.Write(JsonConvert.SerializeObject(UrunContext.Urunler, Formatting.Indented));
                //writer.Close();
                //writer.Dispose();
                //MessageBox.Show($"{UrunContext.Urunler.Count} adet kiþi dýþarý aktarýldý.");
            //}

        }

        private void pbResim_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir fotoðraf seçiniz";
            dialog.Filter = "Resim Dosyalarý | *.jpeg; *.jpg; *.png; *.jfif";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbResim.ImageLocation = dialog.FileName;
            }
        }

      
    }
}