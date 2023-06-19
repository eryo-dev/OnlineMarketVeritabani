using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMarketVeritabani.UI
{
    public partial class urunler : Form
    {
        public WinFormsApp1.urunler urun { get; set; }
        public urunler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BTNKaydet_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            urun.ad = BTNUAd.Text;
            urun.fiyat = BTNUFiyat.Text;
            urun.stok = BTNUStok.Text;
        }

        private void BTNIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void urunler_Load(object sender, EventArgs e)
        {

        }
    }
}
