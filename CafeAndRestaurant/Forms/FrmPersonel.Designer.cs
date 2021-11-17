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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonel));
            this.flwpBinaBolumleri = new System.Windows.Forms.FlowLayoutPanel();
            this.flwpMasa = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flwpBinaBolumleri
            // 
            this.flwpBinaBolumleri.AutoScroll = true;
            this.flwpBinaBolumleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.flwpBinaBolumleri.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwpBinaBolumleri.Location = new System.Drawing.Point(0, 0);
            this.flwpBinaBolumleri.Name = "flwpBinaBolumleri";
            this.flwpBinaBolumleri.Size = new System.Drawing.Size(213, 520);
            this.flwpBinaBolumleri.TabIndex = 0;
            // 
            // flwpMasa
            // 
            this.flwpMasa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.flwpMasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwpMasa.Location = new System.Drawing.Point(213, 0);
            this.flwpMasa.Name = "flwpMasa";
            this.flwpMasa.Size = new System.Drawing.Size(937, 520);
            this.flwpMasa.TabIndex = 1;
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1150, 520);
            this.ControlBox = false;
            this.Controls.Add(this.flwpMasa);
            this.Controls.Add(this.flwpBinaBolumleri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flwpBinaBolumleri;
        private FlowLayoutPanel flwpMasa;
    }
}