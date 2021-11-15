using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using CafeAndRestaurant.Lib.Concrete;

namespace CafeAndRestaurant.Forms
{
    public partial class FrmPersonel : Form
    {

        public FrmPersonel()
        {
            InitializeComponent();
        }

        //public BinaBilgileri BinaBilgileri { get; set; }


        public List<BinaBilgileri> BinaBilgileri = new List<BinaBilgileri>();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < BinaBilgileri.Count; i++)
            {
                var btnKat = new Button

                {

                    Size = new Size(200, 90),
                    BackColor = ColorTranslator.FromHtml("#B0B0B0"),
                    Text =BinaBilgileri[i].BinaBolumAdi,
                    ForeColor=Color.Black

                };
                MessageBox.Show("fdlgkdıtjıe");
                btnKat.Name = $"{BinaBilgileri[i].BinaBolumAdi}";
                btnKat.Click += new EventHandler(btnKat_Click);
                //btnKat.Parent = groupBox;

                flwpBinaBolumleri.Controls.Add(btnKat);
            }

        }
        protected void btnKat_Click(object sender, EventArgs e)
        {
            //flpMenuElemanlari.Controls.Clear();
            Button oButton = (Button)sender;
            foreach (var item in BinaBilgileri)
            {
                
                if (oButton.Name == item.BinaBolumAdi)
                {
                    flwpMasa.Controls.Clear();
                    for (int i = 1; i <= int.Parse(item.MasaAdet); i++)
                    {
                        var btnMasa = new Button

                        {

                            Size = new Size(150, 150),
                            BackColor =ColorTranslator.FromHtml("#7F7F7F"),//#a45117//CD661D
                            Text = $"MASA {i}",
                            ForeColor = Color.White

                        };
                      
                        btnMasa.Name = $"Masa{i}";
                        btnMasa.Click += new EventHandler(btnMasa_Click);
                        //btnKat.Parent = groupBox;

                        flwpMasa.Controls.Add(btnMasa);
                    }
                    //MessageBox.Show($"{item.BinaBolumAdi}  {item.Fiyat} TL");
                    //MessageBox.Show("nbhmfhmfmh");
                    
                }
                //MessageBox.Show(oPictureBox.Name);
            }
        }
        protected void btnMasa_Click(object sender, EventArgs e)
        {
            //flpMenuElemanlari.Controls.Clear();
            Button oButton = (Button)sender;
            FrmSiparis frmSiparis = new FrmSiparis();
            frmSiparis.Show();
            this.Hide();

        }
        }
}
