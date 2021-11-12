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
    }
}