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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RaporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.raporGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwpBinaBolumleri
            // 
            this.flwpBinaBolumleri.AutoScroll = true;
            this.flwpBinaBolumleri.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flwpBinaBolumleri.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwpBinaBolumleri.Location = new System.Drawing.Point(0, 0);
            this.flwpBinaBolumleri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flwpBinaBolumleri.Name = "flwpBinaBolumleri";
            this.flwpBinaBolumleri.Size = new System.Drawing.Size(243, 693);
            this.flwpBinaBolumleri.TabIndex = 0;
            // 
            // flwpMasa
            // 
            this.flwpMasa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flwpMasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwpMasa.Location = new System.Drawing.Point(243, 0);
            this.flwpMasa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flwpMasa.Name = "flwpMasa";
            this.flwpMasa.Size = new System.Drawing.Size(1071, 693);
            this.flwpMasa.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Chocolate;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RaporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(243, 665);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1071, 28);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RaporlarToolStripMenuItem
            // 
            this.RaporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.raporGörüntüleToolStripMenuItem});
            this.RaporlarToolStripMenuItem.Name = "RaporlarToolStripMenuItem";
            this.RaporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.RaporlarToolStripMenuItem.Text = "Raporlar";
            this.RaporlarToolStripMenuItem.Click += new System.EventHandler(this.dosyaİşlemleriToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // raporGörüntüleToolStripMenuItem
            // 
            this.raporGörüntüleToolStripMenuItem.Name = "raporGörüntüleToolStripMenuItem";
            this.raporGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.raporGörüntüleToolStripMenuItem.Text = "Rapor Görüntüle";
            this.raporGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.raporGörüntüleToolStripMenuItem_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1314, 693);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flwpMasa);
            this.Controls.Add(this.flwpBinaBolumleri);
            this.ForeColor = System.Drawing.SystemColors.Info;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPersonel";
            this.Text = "FrmPersonel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPersonel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flwpBinaBolumleri;
        private FlowLayoutPanel flwpMasa;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem RaporlarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem raporGörüntüleToolStripMenuItem;
    }
}