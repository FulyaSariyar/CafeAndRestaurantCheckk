namespace CafeAndRestaurant.Forms
{
    partial class FrmSiparis
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
            this.gbMenü = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flpMenuElemanlari = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flwpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.gbMenü.SuspendLayout();
            this.flpMenuElemanlari.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenü
            // 
            this.gbMenü.AutoSize = true;
            this.gbMenü.BackColor = System.Drawing.Color.White;
            this.gbMenü.Controls.Add(this.button1);
            this.gbMenü.Controls.Add(this.flpMenuElemanlari);
            this.gbMenü.Controls.Add(this.flwpMenu);
            this.gbMenü.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMenü.Location = new System.Drawing.Point(0, 0);
            this.gbMenü.Name = "gbMenü";
            this.gbMenü.Size = new System.Drawing.Size(987, 605);
            this.gbMenü.TabIndex = 2;
            this.gbMenü.TabStop = false;
            this.gbMenü.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(254, 539);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(730, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "SİPARİŞ AL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flpMenuElemanlari
            // 
            this.flpMenuElemanlari.AutoScroll = true;
            this.flpMenuElemanlari.Controls.Add(this.label1);
            this.flpMenuElemanlari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMenuElemanlari.Location = new System.Drawing.Point(254, 19);
            this.flpMenuElemanlari.Margin = new System.Windows.Forms.Padding(700, 3, 3, 3);
            this.flpMenuElemanlari.Name = "flpMenuElemanlari";
            this.flpMenuElemanlari.Size = new System.Drawing.Size(730, 583);
            this.flpMenuElemanlari.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(25, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flwpMenu
            // 
            this.flwpMenu.AutoScroll = true;
            this.flwpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwpMenu.Location = new System.Drawing.Point(3, 19);
            this.flwpMenu.Name = "flwpMenu";
            this.flwpMenu.Size = new System.Drawing.Size(251, 583);
            this.flwpMenu.TabIndex = 0;
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 605);
            this.Controls.Add(this.gbMenü);
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            this.gbMenü.ResumeLayout(false);
            this.flpMenuElemanlari.ResumeLayout(false);
            this.flpMenuElemanlari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbMenü;
        private FlowLayoutPanel flpMenuElemanlari;
        private FlowLayoutPanel flwpMenu;
        private Label label1;
        private Button button1;
    }
}