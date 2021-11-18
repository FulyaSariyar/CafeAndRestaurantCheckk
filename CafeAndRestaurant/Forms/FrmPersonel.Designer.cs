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
            this.btnRapor = new System.Windows.Forms.Button();
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
            this.flwpBinaBolumleri.Size = new System.Drawing.Size(243, 812);
            this.flwpBinaBolumleri.TabIndex = 0;
            // 
            // flwpMasa
            // 
            this.flwpMasa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flwpMasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwpMasa.Location = new System.Drawing.Point(243, 0);
            this.flwpMasa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flwpMasa.Name = "flwpMasa";
            this.flwpMasa.Size = new System.Drawing.Size(1458, 812);
            this.flwpMasa.TabIndex = 1;
            // 
            // btnRapor
            // 
            this.btnRapor.AutoEllipsis = true;
            this.btnRapor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRapor.BackColor = System.Drawing.Color.Chocolate;
            this.btnRapor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRapor.ForeColor = System.Drawing.Color.White;
            this.btnRapor.Location = new System.Drawing.Point(243, 722);
            this.btnRapor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRapor.Size = new System.Drawing.Size(1458, 90);
            this.btnRapor.TabIndex = 43;
            this.btnRapor.Text = "RAPORLAR";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // FrmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1701, 812);
            this.ControlBox = false;
            this.Controls.Add(this.btnRapor);
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
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flwpBinaBolumleri;
        private FlowLayoutPanel flwpMasa;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem RaporlarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem raporGörüntüleToolStripMenuItem;
        private Button btnRapor;
    }
}