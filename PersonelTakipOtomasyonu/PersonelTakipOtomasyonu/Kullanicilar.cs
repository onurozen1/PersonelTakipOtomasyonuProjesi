using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PersonelTakipOtomasyonu
{
    class Kullanicilar
    {
        int _KullaniciID;
        string _KullaniciAd;
        string _Sifre;
        string _AdSoyad;
        string _Soru;
        string _Cevap;
        DateTime _Tarih;

        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string KullaniciAd { get => _KullaniciAd; set => _KullaniciAd = value; }
        public string Sifre { get => _Sifre; set => _Sifre = value; }
        public string AdSoyad { get => _AdSoyad; set => _AdSoyad = value; }
        public string Soru { get => _Soru; set => _Soru = value; }
        public string Cevap { get => _Cevap; set => _Cevap = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }

        //kullanıcı girişi için
        public static bool durum = false;
        public static int kid = 0;
        public static SqlDataReader KullaniciGirisi(string kullaniciad, string sifre)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciAd = kullaniciad;
            k.Sifre = sifre;
            VeriTabani.con.Open();
            SqlCommand komut = new SqlCommand("Select * From Kullanicilar where KullaniciAd='" + k.KullaniciAd + "' and Sifre='" + k.Sifre + "'", VeriTabani.con);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = true;
                kid = int.Parse(dr[0].ToString());
            }
            else
            {
                durum = false;
            }
            dr.Close();
            VeriTabani.con.Close();
            return dr;
        }
    }
}
