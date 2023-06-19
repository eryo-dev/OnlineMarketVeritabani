using OnlineMarketVeritabani.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMarketVeritabani.BL
{
    public static class BLogic
    {
        public static bool SiparisEkle(WinFormsApp1.siparisler s)
        {
                try
                {
                    int res = DataLayer.SiparisEkle(s);
                    return (res > 1);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
        }
        public static bool KullaniciEkle(WinFormsApp1.kullanicilar k)
        {
            try
            {
                int res = DataLayer.KullaniciEkle(k);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool UrunEkle(WinFormsApp1.urunler u)
        {
            try
            {
                int res = DataLayer.UrunEkle(u);
                return (res > 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        internal static DataSet KullaniciGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.KullaniciGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.UrunGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        internal static DataSet SiparisGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.SiparisGetir(filtre);
                return ds;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
