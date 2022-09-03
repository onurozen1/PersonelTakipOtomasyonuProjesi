using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    class Primler
    {
        #region Primler Kapsulleme
        int _PrimID;
        int _KullaniciID;
        int _PersonelID;
        string _Donem;
        decimal _PrimTutar;
        string _OdenmeDurumu;
        string _Aciklama;
        DateTime _Tarih;
        string _Islem;

        public int PrimID { get => _PrimID; set => _PrimID = value; }
        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public decimal PrimTutar { get => _PrimTutar; set => _PrimTutar = value; }
        public string OdenmeDurumu { get => _OdenmeDurumu; set => _OdenmeDurumu = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public string Islem { get => _Islem; set => _Islem = value; }
        #endregion

        //Primleri göster formunda personel id sine göre ad soyad getirmek için
        public static SqlDataReader adSoyadGetir(TextBox txtId,TextBox txtAdSoyad)
        {
            VeriTabani.con.Open();
            SqlCommand komut = new SqlCommand("Select * From Personeller where PersonelID='" + txtId.Text + "'", VeriTabani.con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAdSoyad.Text = dr[1] + " " + dr[2];
            }
            VeriTabani.con.Close();
            return dr;
        }
    }
}
