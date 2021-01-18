namespace mühProjesi
{
    partial class genelGirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHastaGirisi = new System.Windows.Forms.Button();
            this.btnDoktorGirisi = new System.Windows.Forms.Button();
            this.btnDepoYetkili = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHastaGirisi
            // 
            this.btnHastaGirisi.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnHastaGirisi.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaGirisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHastaGirisi.Location = new System.Drawing.Point(180, 337);
            this.btnHastaGirisi.Name = "btnHastaGirisi";
            this.btnHastaGirisi.Size = new System.Drawing.Size(397, 316);
            this.btnHastaGirisi.TabIndex = 0;
            this.btnHastaGirisi.Text = "HASTA GİRİŞİ";
            this.btnHastaGirisi.UseVisualStyleBackColor = false;
            this.btnHastaGirisi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDoktorGirisi
            // 
            this.btnDoktorGirisi.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnDoktorGirisi.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGirisi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDoktorGirisi.Location = new System.Drawing.Point(805, 337);
            this.btnDoktorGirisi.Name = "btnDoktorGirisi";
            this.btnDoktorGirisi.Size = new System.Drawing.Size(397, 316);
            this.btnDoktorGirisi.TabIndex = 1;
            this.btnDoktorGirisi.Text = "DOKTOR GİRİŞİ";
            this.btnDoktorGirisi.UseVisualStyleBackColor = false;
            this.btnDoktorGirisi.Click += new System.EventHandler(this.btnDoktorGirisi_Click);
            // 
            // btnDepoYetkili
            // 
            this.btnDepoYetkili.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnDepoYetkili.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepoYetkili.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDepoYetkili.Location = new System.Drawing.Point(1393, 337);
            this.btnDepoYetkili.Name = "btnDepoYetkili";
            this.btnDepoYetkili.Size = new System.Drawing.Size(390, 316);
            this.btnDepoYetkili.TabIndex = 2;
            this.btnDepoYetkili.Text = "AŞI DEPOSU YETKİLİSİ GİRİŞİ";
            this.btnDepoYetkili.UseVisualStyleBackColor = false;
            this.btnDepoYetkili.Click += new System.EventHandler(this.btnDepoYetkili_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(768, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 70);
            this.label1.TabIndex = 3;
            this.label1.Text = "GENEL GİRİŞ EKRANI";
            // 
            // genelGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDepoYetkili);
            this.Controls.Add(this.btnDoktorGirisi);
            this.Controls.Add(this.btnHastaGirisi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "genelGirisEkrani";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaGirisi;
        private System.Windows.Forms.Button btnDoktorGirisi;
        private System.Windows.Forms.Button btnDepoYetkili;
        private System.Windows.Forms.Label label1;
    }
}

