
namespace OnlineMarketVeritabani.UI
{
    partial class Form2
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
            this.BTNKSifre = new System.Windows.Forms.TextBox();
            this.BTNKEPosta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNKSoyad = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNKAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNIptal = new System.Windows.Forms.Button();
            this.BTNKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNKSifre
            // 
            this.BTNKSifre.Location = new System.Drawing.Point(76, 104);
            this.BTNKSifre.Name = "BTNKSifre";
            this.BTNKSifre.Size = new System.Drawing.Size(100, 22);
            this.BTNKSifre.TabIndex = 13;
            // 
            // BTNKEPosta
            // 
            this.BTNKEPosta.Location = new System.Drawing.Point(76, 73);
            this.BTNKEPosta.Name = "BTNKEPosta";
            this.BTNKEPosta.Size = new System.Drawing.Size(100, 22);
            this.BTNKEPosta.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-Posta";
            // 
            // BTNKSoyad
            // 
            this.BTNKSoyad.Location = new System.Drawing.Point(76, 44);
            this.BTNKSoyad.Name = "BTNKSoyad";
            this.BTNKSoyad.Size = new System.Drawing.Size(100, 22);
            this.BTNKSoyad.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Soyad";
            // 
            // BTNKAd
            // 
            this.BTNKAd.Location = new System.Drawing.Point(76, 15);
            this.BTNKAd.Name = "BTNKAd";
            this.BTNKAd.Size = new System.Drawing.Size(100, 22);
            this.BTNKAd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad";
            // 
            // BTNIptal
            // 
            this.BTNIptal.Location = new System.Drawing.Point(157, 132);
            this.BTNIptal.Name = "BTNIptal";
            this.BTNIptal.Size = new System.Drawing.Size(75, 23);
            this.BTNIptal.TabIndex = 15;
            this.BTNIptal.Text = "İptal";
            this.BTNIptal.UseVisualStyleBackColor = true;
            this.BTNIptal.Click += new System.EventHandler(this.BTNIptal_Click);
            // 
            // BTNKaydet
            // 
            this.BTNKaydet.Location = new System.Drawing.Point(76, 132);
            this.BTNKaydet.Name = "BTNKaydet";
            this.BTNKaydet.Size = new System.Drawing.Size(75, 23);
            this.BTNKaydet.TabIndex = 16;
            this.BTNKaydet.Text = "Kaydet";
            this.BTNKaydet.UseVisualStyleBackColor = true;
            this.BTNKaydet.Click += new System.EventHandler(this.BTNKaydet_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.BTNKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelButton = this.BTNIptal;
            this.ClientSize = new System.Drawing.Size(282, 163);
            this.Controls.Add(this.BTNIptal);
            this.Controls.Add(this.BTNKaydet);
            this.Controls.Add(this.BTNKSifre);
            this.Controls.Add(this.BTNKEPosta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNKSoyad);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNKAd);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Kullanıcılar Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BTNKSifre;
        private System.Windows.Forms.TextBox BTNKEPosta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BTNKSoyad;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BTNKAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNIptal;
        private System.Windows.Forms.Button BTNKaydet;
    }
}