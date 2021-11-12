using CafeAndRestaurant.Forms;

namespace CafeAndRestaurant
{
    public partial class FrmIlk : Form
    {
        public FrmIlk()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();  
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBahçe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();  
            this.Hide();
        }

        private void cb6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNext1_Click_1(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Hide();
        }
    }
}