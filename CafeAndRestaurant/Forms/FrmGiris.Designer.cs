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
            this.gbGiris.Location = new System.Drawing.Point(297, 67);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Size = new System.Drawing.Size(520, 221);
            this.gbGiris.TabIndex = 1;
            this.gbGiris.TabStop = false;
            // 
            // pbGiris
            // 
            this.pbGiris.BackColor = System.Drawing.Color.Transparent;
            this.pbGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGiris.BackgroundImage")));
            this.pbGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGiris.Location = new System.Drawing.Point(6, 18);
            this.pbGiris.Name = "pbGiris";
            this.pbGiris.Size = new System.Drawing.Size(47, 28);
            this.pbGiris.TabIndex = 2;
            this.pbGiris.TabStop = false;
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.btnPersonel.Location = new System.Drawing.Point(322, 112);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(157, 73);
            this.btnPersonel.TabIndex = 1;
            this.btnPersonel.Text = "Personel";
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnYönetici
            // 
            this.btnYönetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.btnYönetici.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYönetici.Location = new System.Drawing.Point(79, 46);
            this.btnYönetici.Name = "btnYönetici";
            this.btnYönetici.Size = new System.Drawing.Size(157, 73);
            this.btnYönetici.TabIndex = 0;
            this.btnYönetici.Text = "Yönetici";
            this.btnYönetici.UseVisualStyleBackColor = false;
            this.btnYönetici.Click += new System.EventHandler(this.btnYönetici_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.btnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack1.ForeColor = System.Drawing.Color.Black;
            this.btnBack1.Location = new System.Drawing.Point(12, 408);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(114, 30);
            this.btnBack1.TabIndex = 2;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click_2);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1139, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack1);
            this.Controls.Add(this.gbGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGiris";
            this.Text = "Giriş";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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