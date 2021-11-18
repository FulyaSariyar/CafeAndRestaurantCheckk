namespace CafeAndRestaurant.Forms
{
    partial class FrmGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.gbGiris = new System.Windows.Forms.GroupBox();
            this.pbGiris = new System.Windows.Forms.PictureBox();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnYönetici = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.gbGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGiris
            // 
            this.gbGiris.BackColor = System.Drawing.Color.Transparent;
            this.gbGiris.Controls.Add(this.pbGiris);
            this.gbGiris.Controls.Add(this.btnPersonel);
            this.gbGiris.Controls.Add(this.btnYönetici);
            this.gbGiris.Location = new System.Drawing.Point(123, 96);
            this.gbGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbGiris.Size = new System.Drawing.Size(594, 272);
            this.gbGiris.TabIndex = 1;
            this.gbGiris.TabStop = false;
            // 
            // pbGiris
            // 
            this.pbGiris.BackColor = System.Drawing.Color.Transparent;
            this.pbGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGiris.BackgroundImage")));
            this.pbGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGiris.Location = new System.Drawing.Point(7, 24);
            this.pbGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbGiris.Name = "pbGiris";
            this.pbGiris.Size = new System.Drawing.Size(54, 37);
            this.pbGiris.TabIndex = 2;
            this.pbGiris.TabStop = false;
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.Chocolate;
            this.btnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPersonel.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPersonel.Location = new System.Drawing.Point(350, 105);
            this.btnPersonel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(179, 97);
            this.btnPersonel.TabIndex = 1;
            this.btnPersonel.Text = "PERSONEL";
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnYönetici
            // 
            this.btnYönetici.BackColor = System.Drawing.Color.Chocolate;
            this.btnYönetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnYönetici.ForeColor = System.Drawing.SystemColors.Info;
            this.btnYönetici.Location = new System.Drawing.Point(93, 105);
            this.btnYönetici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYönetici.Name = "btnYönetici";
            this.btnYönetici.Size = new System.Drawing.Size(179, 97);
            this.btnYönetici.TabIndex = 0;
            this.btnYönetici.Text = "YÖNETİCİ";
            this.btnYönetici.UseVisualStyleBackColor = false;
            this.btnYönetici.Click += new System.EventHandler(this.btnYönetici_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack1.BackColor = System.Drawing.Color.Chocolate;
            this.btnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack1.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBack1.Location = new System.Drawing.Point(14, 395);
            this.btnBack1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(153, 60);
            this.btnBack1.TabIndex = 2;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click_2);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(843, 471);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.gbGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.gbGiris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGiris)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox gbGiris;
        private Button btnBack1;
        private PictureBox pbGiris;
        private Button btnPersonel;
        private Button btnYönetici;
    }
}