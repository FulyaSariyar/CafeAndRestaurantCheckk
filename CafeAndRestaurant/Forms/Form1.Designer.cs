namespace CafeAndRestaurant
{
    partial class FrmIlk
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIlk));
            this.gbBinaBilgileri = new System.Windows.Forms.GroupBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.Btn1 = new System.Windows.Forms.Button();
            this.gbBinaBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbBinaBilgileri
            // 
            this.gbBinaBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gbBinaBilgileri.Controls.Add(this.cb6);
            this.gbBinaBilgileri.Controls.Add(this.cb5);
            this.gbBinaBilgileri.Controls.Add(this.cb4);
            this.gbBinaBilgileri.Controls.Add(this.cb3);
            this.gbBinaBilgileri.Controls.Add(this.cb2);
            this.gbBinaBilgileri.Controls.Add(this.cb1);
            this.gbBinaBilgileri.Location = new System.Drawing.Point(21, 32);
            this.gbBinaBilgileri.Name = "gbBinaBilgileri";
            this.gbBinaBilgileri.Size = new System.Drawing.Size(154, 264);
            this.gbBinaBilgileri.TabIndex = 0;
            this.gbBinaBilgileri.TabStop = false;
            this.gbBinaBilgileri.Tag = "";
            this.gbBinaBilgileri.Text = "Binanıza Ait Kat Bilgileri";
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.Location = new System.Drawing.Point(11, 147);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(49, 19);
            this.cb6.TabIndex = 5;
            this.cb6.Text = "Kat6";
            this.cb6.UseVisualStyleBackColor = true;
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.Location = new System.Drawing.Point(11, 122);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(49, 19);
            this.cb5.TabIndex = 4;
            this.cb5.Text = "Kat3";
            this.cb5.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(11, 97);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(49, 19);
            this.cb4.TabIndex = 3;
            this.cb4.Text = "Kat2";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(11, 72);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(52, 19);
            this.cb3.TabIndex = 2;
            this.cb3.Text = "Kat 1";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(11, 47);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(80, 19);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "Zemin Kat";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(11, 22);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(103, 19);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Bahçe Bölümü";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.Transparent;
            this.Btn1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn1.Location = new System.Drawing.Point(694, 430);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(75, 23);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "NEXT";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // FrmIlk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 465);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.gbBinaBilgileri);
            this.Name = "FrmIlk";
            this.Text = "Hoşgeldiniz";
            this.gbBinaBilgileri.ResumeLayout(false);
            this.gbBinaBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbBinaBilgileri;
        private CheckBox cb6;
        private CheckBox cb5;
        private CheckBox cb4;
        private CheckBox cb3;
        private CheckBox cb2;
        private CheckBox cb1;
        private Button Btn1;
    }
}