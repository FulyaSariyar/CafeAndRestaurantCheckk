﻿using System;
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
using System.Reflection;

namespace CafeAndRestaurant.Forms
{
    public partial class FrmPersonel : Form
    {
        string masaAd;
        string binaAd;
        
        public FrmPersonel()
        {
            InitializeComponent();
         
        }
        private List<BinaBilgileri> _binaBilgileri;
        public FrmPersonel(List<BinaBilgileri> binaBilgileri)
        {
            _binaBilgileri= binaBilgileri;
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
                    //BackColor = ColorTranslator.FromHtml("#B0B0B0"),ffd2691e
                    BackColor = ColorTranslator.FromHtml("#ee7621"),
                    Text = BinaBilgileri[i].BinaBolumAdi,
                    ForeColor = Color.White

                };
                
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
                            //BackColor = ColorTranslator.FromHtml("#7F7F7F"),//#a45117//CD661D
                            BackColor = Color.Chocolate,
                            Text = $"MASA {i}",
                            ForeColor = Color.White
                        };

                        btnMasa.Name = $"Masa{i}";
                        
                        masaAd = $"Masa{i}";
                        binaAd = item.BinaBolumAdi;
                        btnMasa.Click += new EventHandler(btnMasa_Click);
                        flwpMasa.Controls.Add(btnMasa);
                        //Controls.Add(btnMasa);
                       
                    }
                }
            }
        }
        public void MasaBoşalt(Button masaAd )
        {
            masaAd.BackColor = ColorTranslator.FromHtml("#7F7F7F");
        }

        private FrmSiparis _frmSiparis;
        protected void btnMasa_Click(object sender, EventArgs e)
        {
            Button oButton = (Button)sender;
            _frmSiparis = new FrmSiparis(oButton);
            _frmSiparis.SiparisBilgileri.Add(new Siparis
            {
                KatIsim=binaAd,
                Masa = masaAd,
            }); 
            

            oButton.BackColor = Color.Green;
            
            _frmSiparis.Show();
            _frmSiparis.SiparisBilgileri = _frmSiparis.SiparisBilgileri;
            //_frmSiparis.MdiParent = this;
            //_frmSiparis.Show();
            //this.Hide();

        }

        private void dosyaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void raporGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRapor frm = new FrmRapor();
            frm.Show();
        }
    }
}
