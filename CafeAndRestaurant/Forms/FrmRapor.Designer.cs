
namespace CafeAndRestaurant.Forms
{
    partial class FrmRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRapor));
            this.grpBoxGunlukRapor = new System.Windows.Forms.GroupBox();
            this.dtGrdGunluk = new System.Windows.Forms.DataGridView();
            this.urunAdiGunluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMiktariGunluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urnFiyatGunluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxAylikRapor = new System.Windows.Forms.GroupBox();
            this.dtGrdAylik = new System.Windows.Forms.DataGridView();
            this.urnAdiAylik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urnMiktarAylik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urnFiyatAylik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.grpBoxGunlukRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdGunluk)).BeginInit();
            this.grpBoxAylikRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdAylik)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxGunlukRapor
            // 
            this.grpBoxGunlukRapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.grpBoxGunlukRapor.Controls.Add(this.dtGrdGunluk);
            this.grpBoxGunlukRapor.Controls.Add(this.button1);
            this.grpBoxGunlukRapor.Controls.Add(this.label1);
            this.grpBoxGunlukRapor.Location = new System.Drawing.Point(12, 3);
            this.grpBoxGunlukRapor.Name = "grpBoxGunlukRapor";
            this.grpBoxGunlukRapor.Size = new System.Drawing.Size(473, 507);
            this.grpBoxGunlukRapor.TabIndex = 0;
            this.grpBoxGunlukRapor.TabStop = false;
            // 
            // dtGrdGunluk
            // 
            this.dtGrdGunluk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdGunluk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
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
            this.urunAdiGunluk,
            this.urunMiktariGunluk,
            this.urnFiyatGunluk});
            this.dtGrdGunluk.GridColor = System.Drawing.Color.White;
            this.dtGrdGunluk.Location = new System.Drawing.Point(19, 48);
            this.dtGrdGunluk.Name = "dtGrdGunluk";
            this.dtGrdGunluk.RowHeadersVisible = false;
            this.dtGrdGunluk.RowTemplate.Height = 25;
            this.dtGrdGunluk.Size = new System.Drawing.Size(422, 226);
            this.dtGrdGunluk.TabIndex = 16;
            // 
            // urunAdiGunluk
            // 
            this.urunAdiGunluk.FillWeight = 150F;
            this.urunAdiGunluk.HeaderText = "Ürün Adı";
            this.urunAdiGunluk.Name = "urunAdiGunluk";
            // 
            // urunMiktariGunluk
            // 
            this.urunMiktariGunluk.HeaderText = "Ürün Miktarı";
            this.urunMiktariGunluk.Name = "urunMiktariGunluk";
            // 
            // urnFiyatGunluk
            // 
            this.urnFiyatGunluk.HeaderText = "Fiyat";
            this.urnFiyatGunluk.Name = "urnFiyatGunluk";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.button1.Location = new System.Drawing.Point(385, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Rapor Al";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Günlük Rapor                                                                     " +
    "                                                          ";
            // 
            // grpBoxAylikRapor
            // 
            this.grpBoxAylikRapor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxAylikRapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.grpBoxAylikRapor.Controls.Add(this.dtGrdAylik);
            this.grpBoxAylikRapor.Controls.Add(this.button2);
            this.grpBoxAylikRapor.Controls.Add(this.label8);
            this.grpBoxAylikRapor.Location = new System.Drawing.Point(491, 3);
            this.grpBoxAylikRapor.Name = "grpBoxAylikRapor";
            this.grpBoxAylikRapor.Size = new System.Drawing.Size(473, 507);
            this.grpBoxAylikRapor.TabIndex = 10;
            this.grpBoxAylikRapor.TabStop = false;
            // 
            // dtGrdAylik
            // 
            this.dtGrdAylik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGrdAylik.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.dtGrdAylik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdAylik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrdAylik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdAylik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urnAdiAylik,
            this.urnMiktarAylik,
            this.urnFiyatAylik});
            this.dtGrdAylik.GridColor = System.Drawing.Color.White;
            this.dtGrdAylik.Location = new System.Drawing.Point(21, 48);
            this.dtGrdAylik.Name = "dtGrdAylik";
            this.dtGrdAylik.RowHeadersVisible = false;
            this.dtGrdAylik.RowTemplate.Height = 25;
            this.dtGrdAylik.Size = new System.Drawing.Size(422, 226);
            this.dtGrdAylik.TabIndex = 16;
            // 
            // urnAdiAylik
            // 
            this.urnAdiAylik.FillWeight = 150F;
            this.urnAdiAylik.HeaderText = "Ürün Adı";
            this.urnAdiAylik.Name = "urnAdiAylik";
            // 
            // urnMiktarAylik
            // 
            this.urnMiktarAylik.HeaderText = "Ürün Miktarı";
            this.urnMiktarAylik.Name = "urnMiktarAylik";
            // 
            // urnFiyatAylik
            // 
            this.urnFiyatAylik.HeaderText = "Fiyat";
            this.urnFiyatAylik.Name = "urnFiyatAylik";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.button2.Location = new System.Drawing.Point(385, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Rapor Al";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(448, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Aylık Rapor                                                                      " +
    "                                                         ";
            // 
            // btnBack2
            // 
            this.btnBack2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.btnBack2.Location = new System.Drawing.Point(12, 516);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(110, 27);
            this.btnBack2.TabIndex = 17;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(975, 546);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack2);
            this.Controls.Add(this.grpBoxAylikRapor);
            this.Controls.Add(this.grpBoxGunlukRapor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRapor";
            this.Text = "Raporlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpBoxGunlukRapor.ResumeLayout(false);
            this.grpBoxGunlukRapor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdGunluk)).EndInit();
            this.grpBoxAylikRapor.ResumeLayout(false);
            this.grpBoxAylikRapor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdAylik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBoxGunlukRapor;
        private Label label1;
        private GroupBox grpBoxAylikRapor;
        private Label label8;
        private Button button1;
        private Button button2;
        private DataGridView dtGrdGunluk;
        private DataGridViewTextBoxColumn urunAdiGunluk;
        private DataGridViewTextBoxColumn urunMiktariGunluk;
        private DataGridViewTextBoxColumn urnFiyatGunluk;
        private DataGridView dtGrdAylik;
        private DataGridViewTextBoxColumn urnAdiAylik;
        private DataGridViewTextBoxColumn urnMiktarAylik;
        private DataGridViewTextBoxColumn urnFiyatAylik;
        private Button btnBack2;
    }
}