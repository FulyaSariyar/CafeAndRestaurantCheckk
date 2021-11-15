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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbMenü = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtGrdGunluk = new System.Windows.Forms.DataGridView();
            this.urnAdiSiparis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urnFiyatSiparis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.flpMenuElemanlari = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flwpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.gbMenü.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdGunluk)).BeginInit();
            this.flpMenuElemanlari.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenü
            // 
            this.gbMenü.AutoSize = true;
            this.gbMenü.BackColor = System.Drawing.Color.White;
            this.gbMenü.Controls.Add(this.flowLayoutPanel1);
            this.gbMenü.Controls.Add(this.button1);
            this.gbMenü.Controls.Add(this.flpMenuElemanlari);
            this.gbMenü.Controls.Add(this.flwpMenu);
            this.gbMenü.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMenü.Location = new System.Drawing.Point(0, 0);
            this.gbMenü.Name = "gbMenü";
            this.gbMenü.Size = new System.Drawing.Size(1253, 546);
            this.gbMenü.TabIndex = 2;
            this.gbMenü.TabStop = false;
            this.gbMenü.Text = "groupBox1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dtGrdGunluk);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(896, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 461);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dtGrdGunluk
            // 
            this.dtGrdGunluk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdGunluk.BackgroundColor = System.Drawing.Color.White;
            this.dtGrdGunluk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdGunluk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrdGunluk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdGunluk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urnAdiSiparis,
            this.urnFiyatSiparis});
            this.dtGrdGunluk.GridColor = System.Drawing.Color.White;
            this.dtGrdGunluk.Location = new System.Drawing.Point(0, 3);
            this.dtGrdGunluk.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.dtGrdGunluk.Name = "dtGrdGunluk";
            this.dtGrdGunluk.RowHeadersVisible = false;
            this.dtGrdGunluk.RowTemplate.Height = 25;
            this.dtGrdGunluk.Size = new System.Drawing.Size(355, 226);
            this.dtGrdGunluk.TabIndex = 17;
            // 
            // urnAdiSiparis
            // 
            this.urnAdiSiparis.FillWeight = 150F;
            this.urnAdiSiparis.HeaderText = "Sipariş";
            this.urnAdiSiparis.Name = "urnAdiSiparis";
            // 
            // urnFiyatSiparis
            // 
            this.urnFiyatSiparis.HeaderText = "Fiyat";
            this.urnFiyatSiparis.Name = "urnFiyatSiparis";
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
            this.button1.Location = new System.Drawing.Point(954, 480);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(296, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "SİPARİŞ AL";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flpMenuElemanlari
            // 
            this.flpMenuElemanlari.AutoScroll = true;
            this.flpMenuElemanlari.Controls.Add(this.label1);
            this.flpMenuElemanlari.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenuElemanlari.Location = new System.Drawing.Point(254, 19);
            this.flpMenuElemanlari.Margin = new System.Windows.Forms.Padding(700, 3, 3, 3);
            this.flpMenuElemanlari.Name = "flpMenuElemanlari";
            this.flpMenuElemanlari.Size = new System.Drawing.Size(700, 524);
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
            this.flwpMenu.Size = new System.Drawing.Size(251, 524);
            this.flwpMenu.TabIndex = 0;
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 546);
            this.Controls.Add(this.gbMenü);
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            this.gbMenü.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdGunluk)).EndInit();
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
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dtGrdGunluk;
        private DataGridViewTextBoxColumn urnAdiSiparis;
        private DataGridViewTextBoxColumn urnFiyatSiparis;
    }
}