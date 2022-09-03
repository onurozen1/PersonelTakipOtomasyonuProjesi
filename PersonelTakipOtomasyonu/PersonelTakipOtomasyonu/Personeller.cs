using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    class Personeller
    {
        int _PersonelID;
        string _Ad;
        string _Soyad;
        string _Telefon;
        string _Adres;
        string _Email;
        int _DepartmanID;
        string _Durum;
        decimal _Maas;
        DateTime _GirisTarihi;
        DateTime _CikisTarihi;
        string _Aciklama;
        DateTime _Tarih;
        string _Islem;

        public int PersonelID { get => _PersonelID; set => _PersonelID = value; }
        public string Ad { get => _Ad; set => _Ad = value; }
        public string Soyad { get => _Soyad; set => _Soyad = value; }
        public string Telefon { get => _Telefon; set => _Telefon = value; }
        public string Adres { get => _Adres; set => _Adres = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public string Durum { get => _Durum; set => _Durum = value; }
        public decimal Maas { get => _Maas; set => _Maas = value; }
        public DateTime GirisTarihi { get => _GirisTarihi; set => _GirisTarihi = value; }
        public DateTime CikisTarihi { get => _CikisTarihi; set => _CikisTarihi = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }
        public DateTime Tarih { get => _Tarih; set => _Tarih = value; }
        public string Islem { get => _Islem; set => _Islem = value; }

        //combobox a bilgileri çekmek için
        public static string sorgu = "Select * From Departmanlar";
        public static string displaymember = "Departman";
        public static string valuemember = "DepartmanID";
        public static DataTable ComboyaKayıtGetir(ComboBox combo)
        {
            DataTable dt = new DataTable();
            VeriTabani.con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sorgu, VeriTabani.con);
            da.Fill(dt);
            combo.DisplayMember = displaymember;
            combo.ValueMember = valuemember;
            combo.DataSource = dt;
            VeriTabani.con.Close();
            return dt;
        }

        //PersonelIslemleri tablosu için.Her yapılan işlemi bu tabloya çekeceğiz.
        public static void PersonelIslemEkle(Personeller p, Kullanicilar k)
        {
            k.KullaniciID = Kullanicilar.kid;
            p.Tarih = DateTime.Now;
            string sorgu = "insert into PersonelIslemleri (KullaniciID,PersonelID,Islem,Aciklama,Tarih) values ('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
            VeriTabani.esg(komut, sorgu);
        }

        //Personeller tablosundaki son id yi çekmek için. (frmPersonelEkle formunda PersonelIslemleri tablosuna personel eklmeyle alakalı)
        public static int PersonelIDGetir(Personeller p)
        {
            VeriTabani.con.Open();
            SqlCommand komut = new SqlCommand("Select IDENT_CURRENT('Personeller') ", VeriTabani.con);
            p.PersonelID = int.Parse(komut.ExecuteScalar().ToString());
            VeriTabani.con.Close();
            return p.PersonelID;
        }
    }
}
