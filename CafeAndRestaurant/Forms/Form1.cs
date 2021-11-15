using CafeAndRestaurant.Forms;
using CafeAndRestaurant.Lib.Abstract;
using CafeAndRestaurant.Lib.Concrete;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
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


            // _frmPersonel.BinaBilgileri.Add( binaBilgileri);

            MessageBox.Show("sdçfmlsdjfsjdfk");

            //FrmGiris frmGiris = new FrmGiris();
            //frmGiris.Show();
            //this.Hide();
            FrmPersonel frmPersonel = new FrmPersonel();
            frmPersonel.BinaBilgileri = _frmPersonel.BinaBilgileri;
            frmPersonel.Show();
            this.Hide();


        }
    }
}