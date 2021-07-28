
namespace HastaneRandevuSistemi
{
    partial class AnaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiDoktorlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHastalar = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTanım = new System.Windows.Forms.TextBox();
            this.cbxDoktor = new System.Windows.Forms.ComboBox();
            this.cbxHasta = new System.Windows.Forms.ComboBox();
            this.tbxNot = new System.Windows.Forms.TextBox();
            this.dgvRandevu = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDoktorlar,
            this.tsmiHastalar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiDoktorlar
            // 
            this.tsmiDoktorlar.Name = "tsmiDoktorlar";
            this.tsmiDoktorlar.Size = new System.Drawing.Size(68, 20);
            this.tsmiDoktorlar.Text = "Doktorlar";
            this.tsmiDoktorlar.Click += new System.EventHandler(this.tsmiDoktorlar_Click);
            // 
            // tsmiHastalar
            // 
            this.tsmiHastalar.Name = "tsmiHastalar";
            this.tsmiHastalar.Size = new System.Drawing.Size(62, 20);
            this.tsmiHastalar.Text = "Hastalar";
            this.tsmiHastalar.Click += new System.EventHandler(this.tsmiHastalar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Randevu Tarihi: ";
            // 
            // dtpRandevuTarihi
            // 
            this.dtpRandevuTarihi.Location = new System.Drawing.Point(161, 253);
            this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            this.dtpRandevuTarihi.Size = new System.Drawing.Size(176, 20);
            this.dtpRandevuTarihi.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Randevular";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::HastaneRandevuSistemi.Properties.Resources.plus_circle;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(235, 290);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(102, 30);
            this.btnEkle.TabIndex = 34;
            this.btnEkle.Text = "Randevu Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Hasta: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Doktor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Not: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tanım: ";
            // 
            // tbxTanım
            // 
            this.tbxTanım.Location = new System.Drawing.Point(161, 59);
            this.tbxTanım.Name = "tbxTanım";
            this.tbxTanım.Size = new System.Drawing.Size(176, 20);
            this.tbxTanım.TabIndex = 29;
            // 
            // cbxDoktor
            // 
            this.cbxDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDoktor.FormattingEnabled = true;
            this.cbxDoktor.Items.AddRange(new object[] {
            "Kardiyoloji",
            "Kalp-Damar",
            "Beyin",
            "Göz",
            "Fizyoloji",
            "Radyoloji",
            "Pediatri",
            "Çocuk Doğum"});
            this.cbxDoktor.Location = new System.Drawing.Point(161, 189);
            this.cbxDoktor.Name = "cbxDoktor";
            this.cbxDoktor.Size = new System.Drawing.Size(176, 21);
            this.cbxDoktor.TabIndex = 28;
            // 
            // cbxHasta
            // 
            this.cbxHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHasta.FormattingEnabled = true;
            this.cbxHasta.Items.AddRange(new object[] {
            "Kayıtlı hasta bulunamadı"});
            this.cbxHasta.Location = new System.Drawing.Point(161, 220);
            this.cbxHasta.Name = "cbxHasta";
            this.cbxHasta.Size = new System.Drawing.Size(176, 21);
            this.cbxHasta.TabIndex = 27;
            // 
            // tbxNot
            // 
            this.tbxNot.Location = new System.Drawing.Point(161, 89);
            this.tbxNot.Multiline = true;
            this.tbxNot.Name = "tbxNot";
            this.tbxNot.Size = new System.Drawing.Size(176, 94);
            this.tbxNot.TabIndex = 26;
            // 
            // dgvRandevu
            // 
            this.dgvRandevu.AllowUserToAddRows = false;
            this.dgvRandevu.AllowUserToDeleteRows = false;
            this.dgvRandevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRandevu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevu.Location = new System.Drawing.Point(359, 38);
            this.dgvRandevu.MultiSelect = false;
            this.dgvRandevu.Name = "dgvRandevu";
            this.dgvRandevu.ReadOnly = true;
            this.dgvRandevu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevu.Size = new System.Drawing.Size(566, 330);
            this.dgvRandevu.TabIndex = 25;
            this.dgvRandevu.DoubleClick += new System.EventHandler(this.dgvRandevu_DoubleClick);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 372);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpRandevuTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxTanım);
            this.Controls.Add(this.cbxDoktor);
            this.Controls.Add(this.cbxHasta);
            this.Controls.Add(this.tbxNot);
            this.Controls.Add(this.dgvRandevu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "Hastane Randevu Sistemi";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoktorlar;
        private System.Windows.Forms.ToolStripMenuItem tsmiHastalar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTanım;
        private System.Windows.Forms.ComboBox cbxDoktor;
        private System.Windows.Forms.ComboBox cbxHasta;
        private System.Windows.Forms.TextBox tbxNot;
        private System.Windows.Forms.DataGridView dgvRandevu;
    }
}

