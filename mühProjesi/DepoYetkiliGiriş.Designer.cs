namespace mühProjesi
{
    partial class DepoYetkiliGiriş
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
            this.buttongiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedtxtBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttongiris
            // 
            this.buttongiris.BackColor = System.Drawing.Color.PeachPuff;
            this.buttongiris.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttongiris.ForeColor = System.Drawing.Color.IndianRed;
            this.buttongiris.Location = new System.Drawing.Point(295, 261);
            this.buttongiris.Name = "buttongiris";
            this.buttongiris.Size = new System.Drawing.Size(215, 96);
            this.buttongiris.TabIndex = 29;
            this.buttongiris.Text = "GİRİŞ YAP";
            this.buttongiris.UseVisualStyleBackColor = false;
            this.buttongiris.Click += new System.EventHandler(this.buttongiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(311, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Şifremi Unuttum";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // maskedtxtBoxTC
            // 
            this.maskedtxtBoxTC.Location = new System.Drawing.Point(329, 132);
            this.maskedtxtBoxTC.Mask = "00000000000";
            this.maskedtxtBoxTC.Name = "maskedtxtBoxTC";
            this.maskedtxtBoxTC.Size = new System.Drawing.Size(166, 26);
            this.maskedtxtBoxTC.TabIndex = 27;
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(329, 203);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(166, 26);
            this.txtBoxSifre.TabIndex = 26;
            this.txtBoxSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label3.Location = new System.Drawing.Point(138, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.PapayaWhip;
            this.label2.Location = new System.Drawing.Point(138, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "TC Kimlik No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(119, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "AŞI DEPOSU YETKİLİSİ GİRİŞ EKRANI";
            // 
            // DepoYetkiliGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttongiris);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedtxtBoxTC);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DepoYetkiliGiriş";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DepoYetkiliGiriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttongiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedtxtBoxTC;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}