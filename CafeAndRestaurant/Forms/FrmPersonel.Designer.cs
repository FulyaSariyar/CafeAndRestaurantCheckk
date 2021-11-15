namespace CafeAndRestaurant.Forms
{
    partial class FrmPersonel
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
            this.flwpBinaBolumleri = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flwpBinaBolumleri
            // 
            this.flwpBinaBolumleri.AutoScroll = true;
            this.flwpBinaBolumleri.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwpBinaBolumleri.Location = new System.Drawing.Point(0, 0);
            this.flwpBinaBolumleri.Name = "flwpBinaBolumleri";
            this.flwpBinaBolumleri.Size = new System.Drawing.Size(213, 520);
            this.flwpBinaBolumleri.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(219, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(649, 520);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 520);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flwpBinaBolumleri);
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flwpBinaBolumleri;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}