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


        public List<BinaBilgileri> BinaBilgileri;
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < 6; i++)           
            {
                var pbox = new Button
                  
                {
 
                Size = new Size(150, 70),
                    BackColor = Color.ForestGreen,
                  //Text=binaBilgiler.Bina
                   
                    
                    //ClientSize = new Size(200, 180),

                };
                MessageBox.Show("fdlgkdıtjıe");
                
                flwpBinaBolumleri.Controls.Add(pbox);

            }

        }
    }
}
