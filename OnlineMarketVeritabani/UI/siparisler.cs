using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;
namespace OnlineMarketVeritabani.UI
{
    public partial class siparisler : Form
    {

        public WinFormsApp1.siparisler sip { get; set; }

        public siparisler()
        {
            InitializeComponent();
        }

        private void siparisler_Load(object sender, EventArgs e)
        {

        }
        private void BTNKaydet_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            sip.kullanici_id = BTNSKullaniciID.Text;
            sip.urun_id = BTNSUrunID.Text;
            sip.adet = BTNSAdet.Text;
            sip.tarih = BTNSTarih.Text;
        }

        private void BTNIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BTNSSiparisID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNSKullaniciID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
