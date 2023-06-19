
namespace OnlineMarketVeritabani.UI
{
    partial class urunler
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
            this.BTNUAd = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNUUrunID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BTNUFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTNUStok = new System.Windows.Forms.TextBox();
            this.BTNKaydet = new System.Windows.Forms.Button();
            this.BTNIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BTNUAd
            // 
            this.BTNUAd.Location = new System.Drawing.Point(77, 9);
            this.BTNUAd.Name = "BTNUAd";
            this.BTNUAd.Size = new System.Drawing.Size(100, 22);
            this.BTNUAd.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün ID";
            // 
            // BTNUUrunID
            // 
            this.BTNUUrunID.Location = new System.Drawing.Point(77, 38);
            this.BTNUUrunID.Name = "BTNUUrunID";
            this.BTNUUrunID.Size = new System.Drawing.Size(100, 22);
            this.BTNUUrunID.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fiyat";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BTNUFiyat
            // 
            this.BTNUFiyat.Location = new System.Drawing.Point(77, 67);
            this.BTNUFiyat.Name = "BTNUFiyat";
            this.BTNUFiyat.Size = new System.Drawing.Size(100, 22);
            this.BTNUFiyat.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Stok";
            // 
            // BTNUStok
            // 
            this.BTNUStok.Location = new System.Drawing.Point(77, 98);
            this.BTNUStok.Name = "BTNUStok";
            this.BTNUStok.Size = new System.Drawing.Size(100, 22);
            this.BTNUStok.TabIndex = 5;
            // 
            // BTNKaydet
            // 
            this.BTNKaydet.Location = new System.Drawing.Point(77, 126);
            this.BTNKaydet.Name = "BTNKaydet";
            this.BTNKaydet.Size = new System.Drawing.Size(75, 23);
            this.BTNKaydet.TabIndex = 6;
            this.BTNKaydet.Text = "Kaydet";
            this.BTNKaydet.UseVisualStyleBackColor = true;
            this.BTNKaydet.Click += new System.EventHandler(this.BTNKaydet_Click);
            // 
            // BTNIptal
            // 
            this.BTNIptal.Location = new System.Drawing.Point(158, 126);
            this.BTNIptal.Name = "BTNIptal";
            this.BTNIptal.Size = new System.Drawing.Size(75, 23);
            this.BTNIptal.TabIndex = 6;
            this.BTNIptal.Text = "İptal";
            this.BTNIptal.UseVisualStyleBackColor = true;
            this.BTNIptal.Click += new System.EventHandler(this.BTNIptal_Click);
            // 
            // urunler
            // 
            this.AcceptButton = this.BTNKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelButton = this.BTNIptal;
            this.ClientSize = new System.Drawing.Size(282, 163);
            this.Controls.Add(this.BTNIptal);
            this.Controls.Add(this.BTNKaydet);
            this.Controls.Add(this.BTNUStok);
            this.Controls.Add(this.BTNUFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTNUUrunID);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTNUAd);
            this.Controls.Add(this.label1);
            this.Name = "urunler";
            this.Text = "Ürünler Form";
            this.Load += new System.EventHandler(this.urunler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BTNUAd;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BTNUUrunID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BTNUFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BTNUStok;
        private System.Windows.Forms.Button BTNKaydet;
        private System.Windows.Forms.Button BTNIptal;
    }
}