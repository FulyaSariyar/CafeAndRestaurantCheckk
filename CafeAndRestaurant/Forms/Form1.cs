using CafeAndRestaurant.Forms;
using System.Collections;

namespace CafeAndRestaurant
{
    public partial class FrmIlk : Form
    {
        public FrmIlk()
        {
            InitializeComponent();
            for (int i = 1; i <= 20; i++)
            {
                cbBahce.Items.Add(i);
            }
            for (int i = 1; i <= 20; i++)
            {
                cbZemin.Items.Add(i);
            }
            for (int i = 1; i <= 20; i++)
            {
                cbKat1.Items.Add(i);
            }
            for (int i = 1; i <= 20; i++)
            {
                cbKat2.Items.Add(i);
            }
            for (int i = 1; i <= 20; i++)
            {
                cbKat3.Items.Add(i);
            }
            for (int i = 1; i <= 20; i++)
            {
                cbKat4.Items.Add(i);
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void FrmIlk_Load(object sender, EventArgs e)
        {






//            string[] menuResim = { "Balýklar", "Çorbalar", "FastFood", "Ýçecekler", "Kahvaltý", "Mezeler", "Pastalar", "Salatalar", "Yemekler" };
//            MemoryStream mS = new MemoryStream();


//            for (int i = 0; i < 2; i++)
//            {
//                PictureBox pbmenuler = new PictureBox();
//                // pbmenuler.Image = Image.FromStream(Menu);
//                pbmenuler.SizeMode = PictureBoxSizeMode.StretchImage;
//                pbmenuler.Dock = DockStyle.Fill;
//                // pbmenuler.BackColor = Color.Black;
                

//                string[] menuResim = { "Balýklar", "Çorbalar", "FastFood", "Ýçecekler", "Kahvaltý", "Mezeler", "Pastalar", "Salatalar", "Yemekler" };
//           MemoryStream mS = new MemoryStream();
//            ArrayList resim = new ArrayList();



//            for (int i = 0; i <9 ; i++)
//            {
//                PictureBox pbmenuler = new PictureBox();

//                //string yol = @"\CafeAndRestaurantCheck\CafeAndRestaurant.Lib\ImageResources\Balýklar.png";
//                //pbmenuler.SizeMode = PictureBoxSizeMode.StretchImage;
//                //pbmenuler.Dock = DockStyle.Fill;
//                new MemoryStream(Properties.Resources.Balýklar.png);
//                pbmenuler.BackColor = Color.Black;
//               // pbmenuler.ImageLocation = $"@\\ImageResources{menuResim[i]}.png";
//>>>>>>> fc505e3329586c3c26d0dcf526233c802abdd27f
//                flwpMenu.Controls.Add(pbmenuler);
//                pbmenuler.ImageLocation = (string)resim[0];



//<<<<<<< HEAD


//=======
//>>>>>>> fc505e3329586c3c26d0dcf526233c802abdd27f
//            }
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Hide();
        }

        private void cb6_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cb6.Checked == true)
                {
                    cbKat4.Show();
                    cbZemin.Visible = false;
                    cbKat1.Visible = false;
                    cbKat2.Visible = false;
                    cbKat3.Visible = false;
                    cbBahce.Visible = false;
                }
                else
                {
                    cbZemin.Visible = true;
                    cbKat1.Visible = true;
                    cbKat2.Visible = true;
                    cbKat3.Visible = true;
                    cbBahce.Visible = true;
                }
            }

        }

        private void btnNext1_Click_1(object sender, EventArgs e)
        {
            FrmGiris frmGiris = new FrmGiris();
            frmGiris.Show();
            this.Hide();
        }


        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cb1.Checked == true)
                {
                    cbBahce.Show();
                    cbZemin.Visible = false;
                    cbKat1.Visible = false;
                    cbKat2.Visible = false;
                    cbKat3.Visible = false;
                    cbKat4.Visible = false;
                }
                else
                {
                    cbZemin.Visible = true;
                    cbKat1.Visible = true;
                    cbKat2.Visible = true;
                    cbKat3.Visible = true;
                    cbKat4.Visible = true;
                }
            }

           


        }

        private void cbBahce_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flwpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (cb2.Checked == true)
                {
                    cbZemin.Show();
                    cbBahce.Visible = false;
                    cbKat1.Visible = false;
                    cbKat2.Visible = false;
                    cbKat3.Visible = false;
                    cbKat4.Visible = false;
                }
                else
                {
                    cbBahce.Visible = true;
                    cbKat1.Visible = true;
                    cbKat2.Visible = true;
                    cbKat3.Visible = true;
                    cbKat4.Visible = true;
                }
            }
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
            {
                
                    if (cb3.Checked == true)
                    {
                        cbKat1.Show();
                        cbBahce.Visible = false;
                        cbZemin.Visible = false;
                        cbKat2.Visible = false;
                        cbKat3.Visible = false;
                        cbKat4.Visible = false;
                    }
                    else
                    {
                        cbBahce.Visible = true;
                        cbZemin.Visible = true;
                        cbKat2.Visible = true;
                        cbKat3.Visible = true;
                        cbKat4.Visible = true;
                    }
                }
            }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
            {

                if (cb4.Checked == true)
                {
                    cbKat2.Show();
                    cbBahce.Visible = false;
                    cbZemin.Visible = false;
                    cbKat1.Visible = false;
                    cbKat3.Visible = false;
                    cbKat4.Visible = false;
                }
                else
                {
                    cbBahce.Visible = true;
                    cbZemin.Visible = true;
                    cbKat1.Visible = true;
                    cbKat3.Visible = true;
                    cbKat4.Visible = true;
                }
            }
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
            {

                if (cb5.Checked == true)
                {
                    cbKat3.Show();
                    cbBahce.Visible = false;
                    cbZemin.Visible = false;
                    cbKat1.Visible = false;
                    cbKat2.Visible = false;
                    cbKat4.Visible = false;
                }
                else
                {
                    cbBahce.Visible = true;
                    cbZemin.Visible = true;
                    cbKat1.Visible = true;
                    cbKat2.Visible = true;
                    cbKat4.Visible = true;
                }
            }
        }

    }
}