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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            FrmIlk frmIlk = new FrmIlk();
            frmIlk.Show();
            this.Hide();
        }

        private void btnBack1_Click_1(object sender, EventArgs e)
        {
            FrmIlk frmIlk = new FrmIlk();
            frmIlk.Show();
            this.Hide();
        }

        private void btnBack1_Click_2(object sender, EventArgs e)
        {
            FrmIlk frmIlk = new FrmIlk();
            frmIlk.Show();
            this.Hide();
        }

        private void btnYönetici_Click(object sender, EventArgs e)
        {
             FrmRapor frmRaporlar = new FrmRapor();
            frmRaporlar.Show();
            this.Hide();
        }
    }
}
