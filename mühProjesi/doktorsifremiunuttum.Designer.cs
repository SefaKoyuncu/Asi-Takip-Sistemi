namespace mühProjesi
{
    partial class doktorsifremiunuttum
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
            this.maskedtxtBoxTC = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxIpucu = new System.Windows.Forms.TextBox();
            this.labelIpucu = new System.Windows.Forms.Label();
            this.labelTC = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxsifregir1 = new System.Windows.Forms.TextBox();
            this.textBoxsifregir2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(247, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ŞİFREMİ UNUTTUM";
            // 
            // maskedtxtBoxTC
            // 
            this.maskedtxtBoxTC.Location = new System.Drawing.Point(435, 168);
            this.maskedtxtBoxTC.Mask = "00000000000";
            this.maskedtxtBoxTC.Name = "maskedtxtBoxTC";
            this.maskedtxtBoxTC.Size = new System.Drawing.Size(166, 26);
            this.maskedtxtBoxTC.TabIndex = 11;
            // 
            // txtBoxIpucu
            // 
            this.txtBoxIpucu.Location = new System.Drawing.Point(435, 257);
            this.txtBoxIpucu.Name = "txtBoxIpucu";
            this.txtBoxIpucu.Size = new System.Drawing.Size(166, 26);
            this.txtBoxIpucu.TabIndex = 10;
            this.txtBoxIpucu.UseSystemPasswordChar = true;
            // 
            // labelIpucu
            // 
            this.labelIpucu.AutoSize = true;
            this.labelIpucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIpucu.ForeColor = System.Drawing.Color.PapayaWhip;
            this.labelIpucu.Location = new System.Drawing.Point(222, 254);
            this.labelIpucu.Name = "labelIpucu";
            this.labelIpucu.Size = new System.Drawing.Size(207, 29);
            this.labelIpucu.TabIndex = 9;
            this.labelIpucu.Text = "Hatırlatıcı İpucu :";
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTC.ForeColor = System.Drawing.Color.PapayaWhip;
            this.labelTC.Location = new System.Drawing.Point(222, 168);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(182, 29);
            this.labelTC.TabIndex = 8;
            this.labelTC.Text = "TC Kimlik No :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(315, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 84);
            this.button1.TabIndex = 12;
            this.button1.Text = "TAMAM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxsifregir1
            // 
            this.textBoxsifregir1.Location = new System.Drawing.Point(435, 167);
            this.textBoxsifregir1.Name = "textBoxsifregir1";
            this.textBoxsifregir1.Size = new System.Drawing.Size(166, 26);
            this.textBoxsifregir1.TabIndex = 13;
            this.textBoxsifregir1.Visible = false;
            // 
            // textBoxsifregir2
            // 
            this.textBoxsifregir2.Location = new System.Drawing.Point(435, 258);
            this.textBoxsifregir2.Name = "textBoxsifregir2";
            this.textBoxsifregir2.Size = new System.Drawing.Size(166, 26);
            this.textBoxsifregir2.TabIndex = 14;
            this.textBoxsifregir2.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(512, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 84);
            this.button2.TabIndex = 15;
            this.button2.Text = "KAYDET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // doktorsifremiunuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxsifregir2);
            this.Controls.Add(this.textBoxsifregir1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedtxtBoxTC);
            this.Controls.Add(this.txtBoxIpucu);
            this.Controls.Add(this.labelIpucu);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "doktorsifremiunuttum";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.doktorsifremiunuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedtxtBoxTC;
        private System.Windows.Forms.TextBox txtBoxIpucu;
        private System.Windows.Forms.Label labelIpucu;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxsifregir1;
        private System.Windows.Forms.TextBox textBoxsifregir2;
        private System.Windows.Forms.Button button2;
    }
}