
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
            this.tsmiRandevular = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoktorlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHastalar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRandevular,
            this.tsmiDoktorlar,
            this.tsmiHastalar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiRandevular
            // 
            this.tsmiRandevular.Name = "tsmiRandevular";
            this.tsmiRandevular.Size = new System.Drawing.Size(78, 20);
            this.tsmiRandevular.Text = "Randevular";
            this.tsmiRandevular.Click += new System.EventHandler(this.tsmiRandevular_Click);
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
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "Hastane Randevu Sistemi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRandevular;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoktorlar;
        private System.Windows.Forms.ToolStripMenuItem tsmiHastalar;
    }
}

