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

        private void FrmIlk_Load(object sender, EventArgs e)
        {
           
           string[] menuResim = { "Balýklar", "Çorbalar", "FastFood", "Ýçecekler", "Kahvaltý", "Mezeler", "Pastalar", "Salatalar", "Yemekler" };
            MemoryStream mS = new MemoryStream();
            

            for (int i = 0; i <2 ; i++)
            {
                PictureBox pbmenuler = new PictureBox();
                pbmenuler.Image = Image.FromStream(Menu);
                pbmenuler.SizeMode = PictureBoxSizeMode.StretchImage;
                pbmenuler.Dock = DockStyle.Fill;
               // pbmenuler.BackColor = Color.Black;
                flwpMenu.Controls.Add(pbmenuler);

                
                
            }
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