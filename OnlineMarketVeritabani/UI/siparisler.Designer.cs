
namespace OnlineMarketVeritabani.UI
{
    partial class siparisler
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
            this.BTNSAdet = new System.Windows.Forms.TextBox();
            this.BTNSUrunID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNSKullaniciID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNSSiparisID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNSTarih = new System.Windows.Forms.TextBox();
            this.BTNIptal = new System.Windows.Forms.Button();
            this.BTNKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNSAdet
            // 
            this.BTNSAdet.Location = new System.Drawing.Point(86, 98);
            this.BTNSAdet.Name = "BTNSAdet";
            this.BTNSAdet.Size = new System.Drawing.Size(100, 22);
            this.BTNSAdet.TabIndex = 13;
            // 
            // BTNSUrunID
            // 
            this.BTNSUrunID.Location = new System.Drawing.Point(86, 67);
            this.BTNSUrunID.Name = "BTNSUrunID";
            this.BTNSUrunID.Size = new System.Drawing.Size(100, 22);
            this.BTNSUrunID.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ürün ID";
            // 
            // BTNSKullaniciID
            // 
            this.BTNSKullaniciID.Location = new System.Drawing.Point(86, 38);
            this.BTNSKullaniciID.Name = "BTNSKullaniciID";
            this.BTNSKullaniciID.Size = new System.Drawing.Size(100, 22);
            this.BTNSKullaniciID.TabIndex = 9;
            this.BTNSKullaniciID.TextChanged += new System.EventHandler(this.BTNSKullaniciID_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kullanıcı ID";
            // 
            // BTNSSiparisID
            // 
            this.BTNSSiparisID.Location = new System.Drawing.Point(86, 9);
            this.BTNSSiparisID.Name = "BTNSSiparisID";
            this.BTNSSiparisID.Size = new System.Drawing.Size(100, 22);
            this.BTNSSiparisID.TabIndex = 7;
            this.BTNSSiparisID.TextChanged += new System.EventHandler(this.BTNSSiparisID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sipariş ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tarih";
            // 
            // BTNSTarih
            // 
            this.BTNSTarih.Location = new System.Drawing.Point(86, 126);
            this.BTNSTarih.Name = "BTNSTarih";
            this.BTNSTarih.Size = new System.Drawing.Size(100, 22);
            this.BTNSTarih.TabIndex = 13;
            // 
            // BTNIptal
            // 
            this.BTNIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNIptal.Location = new System.Drawing.Point(167, 154);
            this.BTNIptal.Name = "BTNIptal";
            this.BTNIptal.Size = new System.Drawing.Size(75, 23);
            this.BTNIptal.TabIndex = 15;
            this.BTNIptal.Text = "İptal";
            this.BTNIptal.UseVisualStyleBackColor = true;
            // 
            // BTNKaydet
            // 
            this.BTNKaydet.Location = new System.Drawing.Point(86, 154);
            this.BTNKaydet.Name = "BTNKaydet";
            this.BTNKaydet.Size = new System.Drawing.Size(75, 23);
            this.BTNKaydet.TabIndex = 16;
            this.BTNKaydet.Text = "Kaydet";
            this.BTNKaydet.UseVisualStyleBackColor = true;
            this.BTNKaydet.Click += new System.EventHandler(this.BTNKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "format: DD-MM-YYYY";
            // 
            // siparisler
            // 
            this.AcceptButton = this.BTNKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelButton = this.BTNIptal;
            this.ClientSize = new System.Drawing.Size(345, 189);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTNIptal);
            this.Controls.Add(this.BTNKaydet);
            this.Controls.Add(this.BTNSTarih);
            this.Controls.Add(this.BTNSAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNSUrunID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNSKullaniciID);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNSSiparisID);
            this.Controls.Add(this.label1);
            this.Name = "siparisler";
            this.Text = "Siparişler Form";
            this.Load += new System.EventHandler(this.siparisler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BTNSAdet;
        private System.Windows.Forms.TextBox BTNSUrunID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BTNSKullaniciID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BTNSSiparisID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BTNSTarih;
        private System.Windows.Forms.Button BTNIptal;
        private System.Windows.Forms.Button BTNKaydet;
        private System.Windows.Forms.Label label7;
    }
}