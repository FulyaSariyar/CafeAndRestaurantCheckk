using CafeAndRestaurant.Forms;
using System.Collections;

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
            ArrayList resim = new ArrayList();



            for (int i = 0; i <9 ; i++)
            {
                PictureBox pbmenuler = new PictureBox();

                //string yol = @"\CafeAndRestaurantCheck\CafeAndRestaurant.Lib\ImageResources\Balýklar.png";
                //pbmenuler.SizeMode = PictureBoxSizeMode.StretchImage;
                //pbmenuler.Dock = DockStyle.Fill;
                new MemoryStream(Properties.Resources.Balýklar.png);
                pbmenuler.BackColor = Color.Black;
               // pbmenuler.ImageLocation = $"@\\ImageResources{menuResim[i]}.png";
                flwpMenu.Controls.Add(pbmenuler);
                pbmenuler.ImageLocation = (string)resim[0];



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