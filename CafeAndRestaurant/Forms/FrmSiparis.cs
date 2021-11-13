using CafeAndRestaurant.Lib.Abstract;
using Newtonsoft.Json;
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
    public partial class FrmSiparis : Form
    {
        private List<Menu> menuler = new List<Menu>();
        string[] menuResimIsimleri = { "Balıklar", "FastFood", "Kahvaltı", "Mezeler", "Tatlılar", "Mezeler", "Pastalar", "Salatalar", "Yemekler" };
        public FrmSiparis()
        {
            InitializeComponent();
        }

        public void JsonConverter(string menuIsmi)
        {

            string yol = $"C:/Users/HP/Documents/GitHub/CafeAndRestaurantCheck/CafeAndRestaurant.Lib/Resources/{menuIsmi}.json";
            //MessageBox.Show(relativePath);
            //string yol1 = "../CafeAndRestaurantCheck/CafeAndRestaurant.Lib/Resources/Balıklar.json";

            ///string yol2=System.AppDomain.CurrentDomain.DynamicDirectory + @"/CafeAndRestaurantCheck/CafeAndRestaurant.Lib/Resources/Balıklar.json";
            //menu1 = Menu as Menu;
            StreamReader fileJson = new StreamReader(yol);
            string dosyaİcerigi = fileJson.ReadToEnd();
            menuler = JsonConvert.DeserializeObject<List<Menu>>(dosyaİcerigi);
            MessageBox.Show($"{menuler.Count} ürün içeri aktarıldı");
            List<Menu> eleman1 = new List<Menu>();
            foreach (var eleman in menuler)
            {
                MemoryStream stream = new MemoryStream(eleman.Fotograf);
                //pbResim.Image = Image.FromStream(stream);
                var pbox = new PictureBox
                {

                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(190, 140),
                    Image = Image.FromStream(stream)

                };
                flpMenuElemanlari.Controls.Add(pbox);

            }
        }


        private void pbox_Click(object sender, EventArgs e)
        {
            flpMenuElemanlari.Controls.Clear();
            PictureBox oPictureBox = (PictureBox)sender;
            foreach (var item in menuResimIsimleri)
            {
                if (oPictureBox.Name == item)
                {
                    JsonConverter(item);
                }
                //MessageBox.Show(oPictureBox.Name);
            }

        }

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            //string[] menuResim = { "Balıklar", "Çorbalar", "FastFood", "İçecekler", "Kahvaltı", "Mezeler", "Pastalar", "Salatalar", "Yemekler" };
            //MemoryStream mS = new MemoryStream();
            // ArrayList resim = new ArrayList();

            //string[] menuResim = { "Balıklar", "Çorbalar", "FastFood", "İçecekler", "Kahvaltı", "Mezeler", "Pastalar", "Salatalar", "Yemekler" };
            //MemoryStream mS = new MemoryStream();

            var path = @"C:\Users\HP\Desktop\MenuAD";
            var resim = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                .Where(x => new string[] { ".bmp", ".jpg", ".png" }
                                .Contains(new FileInfo(x).Extension.ToLower()))
                                .Take(20)
                                .ToList();

            for (int i = 0; i < resim.Count(); i++)
            {
                var groupBox = new GroupBox();
                groupBox.Name = $"grpBox{menuResimIsimleri[i]}";

                var pbox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(190, 140),
                    //ClientSize = new Size(200, 180),
                    ImageLocation = resim[i]
                };
                pbox.Name = $"{menuResimIsimleri[i]}";
                pbox.Click += new EventHandler(pbox_Click);
                pbox.Parent = groupBox;
                flwpMenu.Controls.Add(pbox);

                Label lblDetay = new Label
                {
                    Text = $"{menuResimIsimleri[i]}",
                    ForeColor = Color.Chocolate,
                    //BackColor = Color.Transparent,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    BackColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    
                    //Margin = new Thickness(20)


                };

                lblDetay.Parent = pbox;
            }
        }
    }
}
