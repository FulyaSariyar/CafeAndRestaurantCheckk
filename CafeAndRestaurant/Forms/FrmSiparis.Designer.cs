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
            this.gbMenü = new System.Windows.Forms.GroupBox();
            this.btn_SiparisAl = new System.Windows.Forms.Button();
            this.btnAdisyonKapat = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dtGrdSiparis = new System.Windows.Forms.DataGridView();
            this.urnAdiSiparis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urnFiyatSiparis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpMenuElemanlari = new System.Windows.Forms.FlowLayoutPanel();
            this.flwpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.gbMenü.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenü
            // 
            this.gbMenü.AutoSize = true;
            this.gbMenü.BackColor = System.Drawing.Color.Black;
            this.gbMenü.Controls.Add(this.btn_SiparisAl);
            this.gbMenü.Controls.Add(this.btnAdisyonKapat);
            this.gbMenü.Controls.Add(this.lblToplam);
            this.gbMenü.Controls.Add(this.flowLayoutPanel1);
            this.gbMenü.Controls.Add(this.flpMenuElemanlari);
            this.gbMenü.Controls.Add(this.flwpMenu);
            this.gbMenü.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMenü.Location = new System.Drawing.Point(0, 0);
            this.gbMenü.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMenü.Name = "gbMenü";
            this.gbMenü.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMenü.Size = new System.Drawing.Size(1784, 772);
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
            this.btn_SiparisAl.Location = new System.Drawing.Point(1290, 600);
            this.btn_SiparisAl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SiparisAl.Name = "btn_SiparisAl";
            this.btn_SiparisAl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_SiparisAl.Size = new System.Drawing.Size(491, 84);
            this.btn_SiparisAl.TabIndex = 5;
            this.btn_SiparisAl.Text = "SİPARİŞ AL";
            this.btn_SiparisAl.UseVisualStyleBackColor = false;
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
            this.btnAdisyonKapat.Location = new System.Drawing.Point(1290, 684);
            this.btnAdisyonKapat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdisyonKapat.Name = "btnAdisyonKapat";
            this.btnAdisyonKapat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAdisyonKapat.Size = new System.Drawing.Size(491, 84);
            this.btnAdisyonKapat.TabIndex = 4;
            this.btnAdisyonKapat.Text = "YAZDIR";
            this.btnAdisyonKapat.UseVisualStyleBackColor = false;
            this.btnAdisyonKapat.Click += new System.EventHandler(this.btnAdisyonKapat_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Transparent;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.ForeColor = System.Drawing.Color.White;
            this.lblToplam.Location = new System.Drawing.Point(1347, 634);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(29, 20, 3, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(151, 46);
            this.lblToplam.TabIndex = 0;
            this.lblToplam.Text = "TOPLAM";
            this.lblToplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dtGrdSiparis);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1290, 24);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(491, 615);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // dtGrdSiparis
            // 
            this.dtGrdSiparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdSiparis.BackgroundColor = System.Drawing.Color.Black;
            this.dtGrdSiparis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdSiparis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrdSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdSiparis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urnAdiSiparis,
            this.urnFiyatSiparis});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrdSiparis.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrdSiparis.GridColor = System.Drawing.Color.Black;
            this.dtGrdSiparis.Location = new System.Drawing.Point(0, 4);
            this.dtGrdSiparis.Margin = new System.Windows.Forms.Padding(0, 4, 3, 4);
            this.dtGrdSiparis.Name = "dtGrdSiparis";
            this.dtGrdSiparis.RowHeadersVisible = false;
            this.dtGrdSiparis.RowHeadersWidth = 60;
            this.dtGrdSiparis.RowTemplate.Height = 50;
            this.dtGrdSiparis.RowTemplate.ReadOnly = true;
            this.dtGrdSiparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtGrdSiparis.Size = new System.Drawing.Size(494, 520);
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
            this.flpMenuElemanlari.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpMenuElemanlari.Location = new System.Drawing.Point(290, 24);
            this.flpMenuElemanlari.Margin = new System.Windows.Forms.Padding(800, 4, 3, 4);
            this.flpMenuElemanlari.Name = "flpMenuElemanlari";
            this.flpMenuElemanlari.Size = new System.Drawing.Size(1000, 744);
            this.flpMenuElemanlari.TabIndex = 1;
            // 
            // flwpMenu
            // 
            this.flwpMenu.AutoScroll = true;
            this.flwpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flwpMenu.Location = new System.Drawing.Point(3, 24);
            this.flwpMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flwpMenu.Name = "flwpMenu";
            this.flwpMenu.Size = new System.Drawing.Size(287, 744);
            this.flwpMenu.TabIndex = 0;
            // 
            // FrmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1784, 772);
            this.Controls.Add(this.gbMenü);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSiparis";
            this.Text = "FrmSiparis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSiparis_Load);
            this.gbMenü.ResumeLayout(false);
            this.gbMenü.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
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
    }
}