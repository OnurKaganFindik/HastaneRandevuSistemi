
namespace HastaneRandevuSistemi
{
    partial class Doktorlar
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.cbxBolum = new System.Windows.Forms.ComboBox();
            this.cbxUzmanlik = new System.Windows.Forms.ComboBox();
            this.tbxUnvan = new System.Windows.Forms.TextBox();
            this.dgvDoktorlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktorlar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::HastaneRandevuSistemi.Properties.Resources.plus_circle;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(250, 143);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(74, 30);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Kayıt Et";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Uzmanlık Alanı: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bölüm: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Unvan: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Adı: ";
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(148, 12);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(176, 20);
            this.tbxAd.TabIndex = 15;
            this.tbxAd.TextChanged += new System.EventHandler(this.tbxAd_TextChanged);
            // 
            // cbxBolum
            // 
            this.cbxBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBolum.FormattingEnabled = true;
            this.cbxBolum.Items.AddRange(new object[] {
            "Kardiyoloji",
            "Kalp-Damar",
            "Beyin",
            "Göz",
            "Fizyoloji",
            "Radyoloji",
            "Pediatri",
            "Çocuk Doğum"});
            this.cbxBolum.Location = new System.Drawing.Point(148, 74);
            this.cbxBolum.Name = "cbxBolum";
            this.cbxBolum.Size = new System.Drawing.Size(176, 21);
            this.cbxBolum.TabIndex = 14;
            // 
            // cbxUzmanlik
            // 
            this.cbxUzmanlik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUzmanlik.FormattingEnabled = true;
            this.cbxUzmanlik.Items.AddRange(new object[] {
            "Kardiyoloji",
            "Kalp-Damar",
            "Beyin",
            "Göz",
            "Fizyoloji",
            "Radyoloji",
            "Pediatri",
            "Çocuk Doğum"});
            this.cbxUzmanlik.Location = new System.Drawing.Point(148, 109);
            this.cbxUzmanlik.Name = "cbxUzmanlik";
            this.cbxUzmanlik.Size = new System.Drawing.Size(176, 21);
            this.cbxUzmanlik.TabIndex = 13;
            // 
            // tbxUnvan
            // 
            this.tbxUnvan.Location = new System.Drawing.Point(148, 42);
            this.tbxUnvan.Name = "tbxUnvan";
            this.tbxUnvan.Size = new System.Drawing.Size(176, 20);
            this.tbxUnvan.TabIndex = 12;
            // 
            // dgvDoktorlar
            // 
            this.dgvDoktorlar.AllowUserToAddRows = false;
            this.dgvDoktorlar.AllowUserToDeleteRows = false;
            this.dgvDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoktorlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoktorlar.Location = new System.Drawing.Point(357, 12);
            this.dgvDoktorlar.MultiSelect = false;
            this.dgvDoktorlar.Name = "dgvDoktorlar";
            this.dgvDoktorlar.ReadOnly = true;
            this.dgvDoktorlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoktorlar.Size = new System.Drawing.Size(650, 316);
            this.dgvDoktorlar.TabIndex = 11;
            this.dgvDoktorlar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoktorlar_CellMouseClick);
            // 
            // Doktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 348);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAd);
            this.Controls.Add(this.cbxBolum);
            this.Controls.Add(this.cbxUzmanlik);
            this.Controls.Add(this.tbxUnvan);
            this.Controls.Add(this.dgvDoktorlar);
            this.Name = "Doktorlar";
            this.Text = "Doktorlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Doktorlar_FormClosing);
            this.Load += new System.EventHandler(this.Doktorlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoktorlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.ComboBox cbxBolum;
        private System.Windows.Forms.ComboBox cbxUzmanlik;
        private System.Windows.Forms.TextBox tbxUnvan;
        private System.Windows.Forms.DataGridView dgvDoktorlar;
    }
}