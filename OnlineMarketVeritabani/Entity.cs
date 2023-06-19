using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class kullanicilar
    {

        public Guid kullanici_id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string eposta { get; set; }
        public string sifre { get; set; }

    }
    public class urunler
    {
        public Guid urun_id { get; set; }
        public string ad { get; set; }
        public string fiyat { get; set; }
        public string stok { get; set; }

    }
    public class siparisler
    {
        public Guid siparis_id { get; set; }
        public string kullanici_id { get; set; }
        public string urun_id { get; set; }
        public string adet { get; set; }
        public string tarih { get; set; }
    }
}