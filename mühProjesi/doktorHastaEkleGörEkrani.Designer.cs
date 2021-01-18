namespace mühProjesi
{
    partial class doktorHastaEkleGörEkrani
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedtxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.btnsilustu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnekleustu = new System.Windows.Forms.Button();
            this.btnguncelleustu = new System.Windows.Forms.Button();
            this.richtxtBoxAdres = new System.Windows.Forms.RichTextBox();
            this.txtBoxMeslek = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSıl = new System.Windows.Forms.Button();
            this.txtBoxYas = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedtxtBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAsiStok = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.maskedtxtTarih);
            this.groupBox1.Controls.Add(this.btnsilustu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnekleustu);
            this.groupBox1.Controls.Add(this.btnguncelleustu);
            this.groupBox1.Controls.Add(this.richtxtBoxAdres);
            this.groupBox1.Controls.Add(this.txtBoxMeslek);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSıl);
            this.groupBox1.Controls.Add(this.txtBoxYas);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxAdSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.maskedtxtBoxTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskedtxtTarih
            // 
            this.maskedtxtTarih.Location = new System.Drawing.Point(606, 151);
            this.maskedtxtTarih.Mask = "00/00/0000";
            this.maskedtxtTarih.Name = "maskedtxtTarih";
            this.maskedtxtTarih.Size = new System.Drawing.Size(170, 35);
            this.maskedtxtTarih.TabIndex = 20;
            this.maskedtxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // btnsilustu
            // 
            this.btnsilustu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsilustu.Location = new System.Drawing.Point(532, 355);
            this.btnsilustu.Name = "btnsilustu";
            this.btnsilustu.Size = new System.Drawing.Size(155, 68);
            this.btnsilustu.TabIndex = 19;
            this.btnsilustu.Text = "SİL";
            this.btnsilustu.UseVisualStyleBackColor = true;
            this.btnsilustu.Click += new System.EventHandler(this.btnsilustu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(419, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Aşılanma Tarihi : ";
            // 
            // btnekleustu
            // 
            this.btnekleustu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekleustu.Location = new System.Drawing.Point(335, 355);
            this.btnekleustu.Name = "btnekleustu";
            this.btnekleustu.Size = new System.Drawing.Size(155, 68);
            this.btnekleustu.TabIndex = 18;
            this.btnekleustu.Text = "EKLE";
            this.btnekleustu.UseVisualStyleBackColor = true;
            this.btnekleustu.Click += new System.EventHandler(this.btnekleustu_Click);
            // 
            // btnguncelleustu
            // 
            this.btnguncelleustu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelleustu.Location = new System.Drawing.Point(146, 355);
            this.btnguncelleustu.Name = "btnguncelleustu";
            this.btnguncelleustu.Size = new System.Drawing.Size(155, 68);
            this.btnguncelleustu.TabIndex = 17;
            this.btnguncelleustu.Text = "GÜNCELLE";
            this.btnguncelleustu.UseVisualStyleBackColor = true;
            this.btnguncelleustu.Click += new System.EventHandler(this.btnguncelleustu_Click);
            // 
            // richtxtBoxAdres
            // 
            this.richtxtBoxAdres.Location = new System.Drawing.Point(205, 145);
            this.richtxtBoxAdres.Name = "richtxtBoxAdres";
            this.richtxtBoxAdres.Size = new System.Drawing.Size(170, 164);
            this.richtxtBoxAdres.TabIndex = 16;
            this.richtxtBoxAdres.Text = "";
            // 
            // txtBoxMeslek
            // 
            this.txtBoxMeslek.Location = new System.Drawing.Point(606, 86);
            this.txtBoxMeslek.Name = "txtBoxMeslek";
            this.txtBoxMeslek.Size = new System.Drawing.Size(170, 35);
            this.txtBoxMeslek.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(335, 355);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(155, 68);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(419, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Meslek : ";
            // 
            // btnSıl
            // 
            this.btnSıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıl.Location = new System.Drawing.Point(532, 355);
            this.btnSıl.Name = "btnSıl";
            this.btnSıl.Size = new System.Drawing.Size(155, 68);
            this.btnSıl.TabIndex = 15;
            this.btnSıl.Text = "SİL";
            this.btnSıl.UseVisualStyleBackColor = true;
            this.btnSıl.Click += new System.EventHandler(this.btnSıl_Click);
            // 
            // txtBoxYas
            // 
            this.txtBoxYas.Location = new System.Drawing.Point(606, 31);
            this.txtBoxYas.Name = "txtBoxYas";
            this.txtBoxYas.Size = new System.Drawing.Size(170, 35);
            this.txtBoxYas.TabIndex = 7;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(146, 355);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(155, 68);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(419, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yaş : ";
            // 
            // txtBoxAdSoyad
            // 
            this.txtBoxAdSoyad.Location = new System.Drawing.Point(205, 92);
            this.txtBoxAdSoyad.Name = "txtBoxAdSoyad";
            this.txtBoxAdSoyad.Size = new System.Drawing.Size(170, 35);
            this.txtBoxAdSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(18, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adres : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(18, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad Soyad : ";
            // 
            // maskedtxtBoxTC
            // 
            this.maskedtxtBoxTC.Location = new System.Drawing.Point(205, 41);
            this.maskedtxtBoxTC.Mask = "00000000000";
            this.maskedtxtBoxTC.Name = "maskedtxtBoxTC";
            this.maskedtxtBoxTC.Size = new System.Drawing.Size(170, 35);
            this.maskedtxtBoxTC.TabIndex = 2;
            this.maskedtxtBoxTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Linen;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblAsiStok);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Brown;
            this.groupBox2.Location = new System.Drawing.Point(836, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 305);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aşı Bilgisi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(123, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 57);
            this.button1.TabIndex = 14;
            this.button1.Text = "STOK GETİR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAsiStok
            // 
            this.lblAsiStok.AutoSize = true;
            this.lblAsiStok.ForeColor = System.Drawing.Color.Black;
            this.lblAsiStok.Location = new System.Drawing.Point(250, 92);
            this.lblAsiStok.Name = "lblAsiStok";
            this.lblAsiStok.Size = new System.Drawing.Size(0, 26);
            this.lblAsiStok.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(31, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Aşı Stok Durumu : ";
            // 
            // doktorHastaEkleGörEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1243, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "doktorHastaEkleGörEkrani";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.doktorHastaEkleGörEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedtxtBoxTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtBoxMeslek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxYas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAsiStok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSıl;
        private System.Windows.Forms.RichTextBox richtxtBoxAdres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsilustu;
        private System.Windows.Forms.Button btnekleustu;
        private System.Windows.Forms.Button btnguncelleustu;
        private System.Windows.Forms.MaskedTextBox maskedtxtTarih;
        private System.Windows.Forms.Label label6;
    }
}