
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRapor));
            this.grpBoxGunlukRapor = new System.Windows.Forms.GroupBox();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.dtGrdGunluk = new System.Windows.Forms.DataGridView();
            this.urunAdiGunluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urnFiyatGunluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brnGunRapor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxAylikRapor = new System.Windows.Forms.GroupBox();
            this.dtgrdAylik = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grpBoxGunlukRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdGunluk)).BeginInit();
            this.grpBoxAylikRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdAylik)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxGunlukRapor
            // 
            this.grpBoxGunlukRapor.BackColor = System.Drawing.Color.White;
            this.grpBoxGunlukRapor.Controls.Add(this.btnBack2);
            this.grpBoxGunlukRapor.Controls.Add(this.dtGrdGunluk);
            this.grpBoxGunlukRapor.Controls.Add(this.brnGunRapor);
            this.grpBoxGunlukRapor.Controls.Add(this.label1);
            this.grpBoxGunlukRapor.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpBoxGunlukRapor.Location = new System.Drawing.Point(0, 0);
            this.grpBoxGunlukRapor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxGunlukRapor.Name = "grpBoxGunlukRapor";
            this.grpBoxGunlukRapor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxGunlukRapor.Size = new System.Drawing.Size(808, 827);
            this.grpBoxGunlukRapor.TabIndex = 0;
            this.grpBoxGunlukRapor.TabStop = false;
            // 
            // btnBack2
            // 
            this.btnBack2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack2.BackColor = System.Drawing.Color.Chocolate;
            this.btnBack2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack2.ForeColor = System.Drawing.Color.White;
            this.btnBack2.Location = new System.Drawing.Point(12, 704);
            this.btnBack2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(206, 58);
            this.btnBack2.TabIndex = 17;
            this.btnBack2.Text = "BACK";
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
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
            this.urunAdiGunluk,
            this.urnFiyatGunluk});
            this.dtGrdGunluk.GridColor = System.Drawing.Color.White;
            this.dtGrdGunluk.Location = new System.Drawing.Point(131, 91);
            this.dtGrdGunluk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtGrdGunluk.Name = "dtGrdGunluk";
            this.dtGrdGunluk.RowHeadersVisible = false;
            this.dtGrdGunluk.RowHeadersWidth = 51;
            this.dtGrdGunluk.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtGrdGunluk.RowTemplate.Height = 25;
            this.dtGrdGunluk.Size = new System.Drawing.Size(482, 577);
            this.dtGrdGunluk.TabIndex = 16;
            // 
            // urunAdiGunluk
            // 
            this.urunAdiGunluk.FillWeight = 150F;
            this.urunAdiGunluk.HeaderText = "Ürün Adı";
            this.urunAdiGunluk.MinimumWidth = 6;
            this.urunAdiGunluk.Name = "urunAdiGunluk";
            // 
            // urnFiyatGunluk
            // 
            this.urnFiyatGunluk.HeaderText = "Fiyat";
            this.urnFiyatGunluk.MinimumWidth = 6;
            this.urnFiyatGunluk.Name = "urnFiyatGunluk";
            // 
            // brnGunRapor
            // 
            this.brnGunRapor.BackColor = System.Drawing.Color.Chocolate;
            this.brnGunRapor.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brnGunRapor.ForeColor = System.Drawing.Color.White;
            this.brnGunRapor.Location = new System.Drawing.Point(518, 704);
            this.brnGunRapor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brnGunRapor.Name = "brnGunRapor";
            this.brnGunRapor.Size = new System.Drawing.Size(223, 58);
            this.brnGunRapor.TabIndex = 10;
            this.brnGunRapor.Text = "RAPOR AL";
            this.brnGunRapor.UseVisualStyleBackColor = false;
            this.brnGunRapor.Click += new System.EventHandler(this.brnGunRapor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(790, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Günlük Rapor                                                                     " +
    "                                                                                " +
    "                        ";
            // 
            // grpBoxAylikRapor
            // 
            this.grpBoxAylikRapor.BackColor = System.Drawing.Color.White;
            this.grpBoxAylikRapor.Controls.Add(this.dtgrdAylik);
            this.grpBoxAylikRapor.Controls.Add(this.button2);
            this.grpBoxAylikRapor.Controls.Add(this.label8);
            this.grpBoxAylikRapor.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpBoxAylikRapor.Location = new System.Drawing.Point(814, 0);
            this.grpBoxAylikRapor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxAylikRapor.Name = "grpBoxAylikRapor";
            this.grpBoxAylikRapor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxAylikRapor.Size = new System.Drawing.Size(980, 827);
            this.grpBoxAylikRapor.TabIndex = 10;
            this.grpBoxAylikRapor.TabStop = false;
            this.grpBoxAylikRapor.Text = "                                                                                 " +
    "                  ";
            // 
            // dtgrdAylik
            // 
            this.dtgrdAylik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrdAylik.BackgroundColor = System.Drawing.Color.White;
            this.dtgrdAylik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdAylik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrdAylik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdAylik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dtgrdAylik.GridColor = System.Drawing.Color.White;
            this.dtgrdAylik.Location = new System.Drawing.Point(194, 91);
            this.dtgrdAylik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgrdAylik.Name = "dtgrdAylik";
            this.dtgrdAylik.RowHeadersVisible = false;
            this.dtgrdAylik.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgrdAylik.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrdAylik.RowTemplate.Height = 25;
            this.dtgrdAylik.Size = new System.Drawing.Size(482, 562);
            this.dtgrdAylik.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 150F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Ürün Adı";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fiyat";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(687, 704);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 58);
            this.button2.TabIndex = 11;
            this.button2.Text = "RAPOR AL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Chocolate;
            this.label8.Location = new System.Drawing.Point(7, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(961, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // FrmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1794, 827);
            this.ControlBox = false;
            this.Controls.Add(this.grpBoxAylikRapor);
            this.Controls.Add(this.grpBoxGunlukRapor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRapor";
            this.Text = "Raporlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpBoxGunlukRapor.ResumeLayout(false);
            this.grpBoxGunlukRapor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdGunluk)).EndInit();
            this.grpBoxAylikRapor.ResumeLayout(false);
            this.grpBoxAylikRapor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdAylik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBoxGunlukRapor;
        private Label label1;
        private GroupBox grpBoxAylikRapor;
        private Label label8;
        private Button brnGunRapor;
        private Button button2;
        private DataGridView dtGrdGunluk;
        private Button btnBack2;
        private DataGridViewTextBoxColumn urunAdiGunluk;
        private DataGridViewTextBoxColumn urnFiyatGunluk;
        private DataGridView dtgrdAylik;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}