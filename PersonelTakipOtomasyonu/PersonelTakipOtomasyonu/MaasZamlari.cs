using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    class MaasZamlari
    {
        #region Zamlar Kapulleme    
        int _ZamID;
        string _Donem;
        int _Personel;
        decimal _Yuzde;
        decimal _Fiyat;
        string _Aciklama;
        DateTime _Tarih;

        public int ZamID { get => _ZamID; set => _ZamID = value; }
        public string Donem { get => _Donem; set => _Donem = value; }
        public int Personel { get => _Personel; set => _Personel = value; }
        public decimal Yuzde { get => _Yuzde; set => _Yuzde = value; }
        public decimal Fiyat { get => _Fiyat; set => _Fiyat = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        #endregion

        //comboboxa personel ad soyad çekmek için
        public static SqlDataReader ComboyaPersonelGetir(ComboBox combo)
        {
            VeriTabani.con.Open();
            SqlCommand komut = new SqlCommand("Select PersonelID,Ad,Soyad From Personeller where Durum='Aktif'", VeriTabani.con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                combo.Items.Add(dr[0] + " - " + dr[1] + " " + dr[2]);
            }
            VeriTabani.con.Close();
            return dr;
        }

        //comboboxtan personel seçildiğinde onun id numarasını getirmek için
        public static SqlDataReader ComboSecilirsePersonelIdGetir(ComboBox cmb, Label lblid)
        {
            VeriTabani.con.Open();
            SqlCommand komut = new SqlCommand("Select PersonelID,Ad,Soyad From Personeller", VeriTabani.con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                if (cmb.SelectedItem.ToString() == dr[0] + " - " + dr[1] + " " + dr[2])
                {
                    lblid.Text = dr[0].ToString();
                }
            }
            VeriTabani.con.Close();
            return dr;
        }
    }
}
