using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMarketVeritabani.UI;

namespace OnlineMarketVeritabani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OnlineMarketVeritabani.UI.Form2 kullanicilar = new Form2()
            {
                Text = "Kullanici Ekle",
                kullanicilar = new WinFormsApp1.kullanicilar { kullanici_id = Guid.NewGuid(), }
            };
            var sonuc = kullanicilar.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BL.BLogic.KullaniciEkle(kullanicilar.kullanicilar);
                if (b)
                {
                    DataSet ds = BL.BLogic.KullaniciGetir("");
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OnlineMarketVeritabani.UI.siparisler siparisler = new siparisler()
            {
                Text = "Sipariş Ekle",
                sip = new WinFormsApp1.siparisler { siparis_id = Guid.NewGuid(), }
            };
            var sonuc = siparisler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                BL.BLogic.SiparisEkle(siparisler.sip);
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OnlineMarketVeritabani.UI.urunler urunler = new urunler()
            {
                Text = "Ürün Ekle",
                urun = new WinFormsApp1.urunler { urun_id = Guid.NewGuid(), }
            };
            var sonuc = urunler.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BL.BLogic.UrunEkle(urunler.urun);
                if (b)
                {
                    DataSet ds = BL.BLogic.UrunGetir("");
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DataSet ds = BL.BLogic.KullaniciGetir(toolStripTextBox1.Text);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DataSet ds = BL.BLogic.UrunGetir(toolStripTextBox2.Text);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DataSet ds = BL.BLogic.SiparisGetir(toolStripTextBox3.Text);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
