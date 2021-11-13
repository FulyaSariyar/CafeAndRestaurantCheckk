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
            this.gbMenü.Controls.Add(this.flpMenuElemanlari);
            this.gbMenü.Controls.Add(this.flwpMenu);
            this.gbMenü.Location = new System.Drawing.Point(12, 12);
            this.gbMenü.Name = "gbMenü";
            this.gbMenü.Size = new System.Drawing.Size(963, 581);
            this.gbMenü.TabIndex = 2;
            this.gbMenü.TabStop = false;
            this.gbMenü.Text = "groupBox1";
            // 
            // flpMenuElemanlari
            // 
            this.flpMenuElemanlari.AutoScroll = true;
            this.flpMenuElemanlari.Controls.Add(this.label1);
            this.flpMenuElemanlari.Location = new System.Drawing.Point(296, 60);
            this.flpMenuElemanlari.Name = "flpMenuElemanlari";
            this.flpMenuElemanlari.Size = new System.Drawing.Size(629, 428);
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
            this.flwpMenu.Location = new System.Drawing.Point(18, 60);
            this.flwpMenu.Name = "flwpMenu";
            this.flwpMenu.Size = new System.Drawing.Size(221, 472);
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
    }
}