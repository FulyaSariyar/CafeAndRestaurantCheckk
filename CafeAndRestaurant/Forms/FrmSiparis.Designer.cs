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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSiparis));
            this.gbMenü = new System.Windows.Forms.GroupBox();
            this.btn_SiparisAl = new System.Windows.Forms.Button();
            this.btnAdisyonKapat = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblToplam = new System.Windows.Forms.Label();
            this.dtGrdSiparis = new System.Windows.Forms.DataGridView();
            this.urnAdiSiparis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urnFiyatSiparis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpMenuElemanlari = new System.Windows.Forms.FlowLayoutPanel();
            this.flwpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gbMenü.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenü
            // 
            this.gbMenü.AutoSize = true;
            this.gbMenü.BackColor = System.Drawing.Color.White;
            this.gbMenü.Controls.Add(this.btn_SiparisAl);
            this.gbMenü.Controls.Add(this.btnAdisyonKapat);
            this.gbMenü.Controls.Add(this.flowLayoutPanel1);
            this.gbMenü.Controls.Add(this.flpMenuElemanlari);
            this.gbMenü.Controls.Add(this.flwpMenu);
            this.gbMenü.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMenü.ForeColor = System.Drawing.Color.Bisque;
            this.gbMenü.Location = new System.Drawing.Point(0, 0);
            this.gbMenü.Name = "gbMenü";
            this.gbMenü.Size = new System.Drawing.Size(1254, 655);
            this.gbMenü.TabIndex = 2;
            this.gbMenü.TabStop = false;
            this.gbMenü.Text = "groupBox1";
            // 
            // btn_SiparisAl
            // 
            this.btn_SiparisAl.AutoEllipsis = true;
            this.btn_SiparisAl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SiparisAl.BackColor = System.Drawing.Color.Chocolate;
            this.btn_SiparisAl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_SiparisAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SiparisAl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btn_SiparisAl.ForeColor = System.Drawing.Color.White;
            this.btn_SiparisAl.Location = new System.Drawing.Point(740, 526);
            this.btn_SiparisAl.Name = "btn_SiparisAl";
            this.btn_SiparisAl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_SiparisAl.Size = new System.Drawing.Size(511, 63);
            this.btn_SiparisAl.TabIndex = 5;
            this.btn_SiparisAl.Text = "SİPARİŞ AL";
            this.btn_SiparisAl.UseVisualStyleBackColor = false;
            this.btn_SiparisAl.Click += new System.EventHandler(this.btn_SiparisAl_Click_1);
            // 
            // btnAdisyonKapat
            // 
            this.btnAdisyonKapat.AutoEllipsis = true;
            this.btnAdisyonKapat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdisyonKapat.BackColor = System.Drawing.Color.Chocolate;
            this.btnAdisyonKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdisyonKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdisyonKapat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAdisyonKapat.ForeColor = System.Drawing.Color.White;
            this.btnAdisyonKapat.Location = new System.Drawing.Point(740, 589);
            this.btnAdisyonKapat.Name = "btnAdisyonKapat";
            this.btnAdisyonKapat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdisyonKapat.Size = new System.Drawing.Size(511, 63);
            this.btnAdisyonKapat.TabIndex = 4;
            this.btnAdisyonKapat.Text = "YAZDIR";
            this.btnAdisyonKapat.UseVisualStyleBackColor = false;
            this.btnAdisyonKapat.Click += new System.EventHandler(this.btnAdisyonKapat_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.lblToplam);
            this.flowLayoutPanel1.Controls.Add(this.dtGrdSiparis);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(740, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(511, 501);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.ForeColor = System.Drawing.Color.Black;
            this.lblToplam.Location = new System.Drawing.Point(25, 15);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(25, 15, 3, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(75, 23);
            this.lblToplam.TabIndex = 0;
            this.lblToplam.Text = "TOPLAM";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dtGrdSiparis);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(756, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(440, 461);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dtGrdSiparis
            // 
            this.dtGrdSiparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdSiparis.BackgroundColor = System.Drawing.Color.White;
            this.dtGrdSiparis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGrdSiparis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGrdSiparis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dtGrdSiparis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrdSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdSiparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urnAdiSiparis,
            this.urnFiyatSiparis});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrdSiparis.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrdSiparis.GridColor = System.Drawing.Color.White;
            this.dtGrdSiparis.Location = new System.Drawing.Point(0, 41);
            this.dtGrdSiparis.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.dtGrdSiparis.Name = "dtGrdSiparis";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdSiparis.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrdSiparis.RowHeadersVisible = false;
            this.dtGrdSiparis.RowHeadersWidth = 60;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dtGrdSiparis.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGrdSiparis.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dtGrdSiparis.RowTemplate.Height = 50;
            this.dtGrdSiparis.RowTemplate.ReadOnly = true;
            this.dtGrdSiparis.Size = new System.Drawing.Size(452, 295);
            this.dtGrdSiparis.TabIndex = 17;
            // 
            // urnAdiSiparis
            // 
            this.urnAdiSiparis.FillWeight = 150F;
            this.urnAdiSiparis.HeaderText = "Sipariş";
            this.urnAdiSiparis.MinimumWidth = 6;
            this.urnAdiSiparis.Name = "urnAdiSiparis";
            // 
            // urnFiyatSiparis
            // 
            this.urnFiyatSiparis.HeaderText = "Fiyat";
            this.urnFiyatSiparis.MinimumWidth = 6;
            this.urnFiyatSiparis.Name = "urnFiyatSiparis";
            // 
            // flpMenuElemanlari
            // 
            this.flpMenuElemanlari.AutoScroll = true;
            this.flpMenuElemanlari.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMenuElemanlari.BackColor = System.Drawing.Color.White;
            this.flpMenuElemanlari.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenuElemanlari.Location = new System.Drawing.Point(254, 19);
            this.flpMenuElemanlari.Margin = new System.Windows.Forms.Padding(700, 3, 3, 3);
            this.flpMenuElemanlari.Name = "flpMenuElemanlari";
            this.flpMenuElemanlari.Size = new System.Drawing.Size(486, 633);
            this.flpMenuElemanlari.TabIndex = 1;
            // 
            // flwpMenu
            // 
            this.flwpMenu.AutoScroll = true;
            this.flwpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwpMenu.Location = new System.Drawing.Point(3, 19);
            this.flwpMenu.Name = "flwpMenu";
            this.flwpMenu.Size = new System.Drawing.Size(251, 633);
            this.flwpMenu.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 655);
            this.Controls.Add(this.gbMenü);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            this.gbMenü.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSiparis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbMenü;
        private FlowLayoutPanel flpMenuElemanlari;
        private FlowLayoutPanel flwpMenu;
        private Label lblToplam;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dtGrdSiparis;
        private DataGridViewTextBoxColumn urnAdiSiparis;
        private DataGridViewTextBoxColumn urnFiyatSiparis;
        private Button btn_SiparisAl;
        private Button btnAdisyonKapat;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}