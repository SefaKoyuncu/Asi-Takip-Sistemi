namespace mühProjesi
{
    partial class DoktorEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.txtBoxGiris = new System.Windows.Forms.Button();
            this.maskedtxtBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(223, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOKTOR GİRİŞ EKRANI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label2.Location = new System.Drawing.Point(111, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label3.Location = new System.Drawing.Point(111, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(302, 240);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(166, 26);
            this.txtBoxSifre.TabIndex = 4;
            this.txtBoxSifre.UseSystemPasswordChar = true;
            // 
            // txtBoxGiris
            // 
            this.txtBoxGiris.BackColor = System.Drawing.Color.PeachPuff;
            this.txtBoxGiris.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxGiris.ForeColor = System.Drawing.Color.IndianRed;
            this.txtBoxGiris.Location = new System.Drawing.Point(271, 289);
            this.txtBoxGiris.Name = "txtBoxGiris";
            this.txtBoxGiris.Size = new System.Drawing.Size(226, 107);
            this.txtBoxGiris.TabIndex = 5;
            this.txtBoxGiris.Text = "GİRİŞ YAP";
            this.txtBoxGiris.UseVisualStyleBackColor = false;
            this.txtBoxGiris.Click += new System.EventHandler(this.txtBoxGiris_Click);
            // 
            // maskedtxtBoxTC
            // 
            this.maskedtxtBoxTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtxtBoxTC.Location = new System.Drawing.Point(302, 154);
            this.maskedtxtBoxTC.Mask = "00000000000";
            this.maskedtxtBoxTC.Name = "maskedtxtBoxTC";
            this.maskedtxtBoxTC.Size = new System.Drawing.Size(166, 26);
            this.maskedtxtBoxTC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(276, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifremi Unuttum";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DoktorEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(753, 477);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedtxtBoxTC);
            this.Controls.Add(this.txtBoxGiris);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DoktorEkrani";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DoktorEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.Button txtBoxGiris;
        private System.Windows.Forms.MaskedTextBox maskedtxtBoxTC;
        private System.Windows.Forms.Label label4;
    }
}