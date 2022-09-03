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
    class izinler : Personeller
    {
        //yapıcı metot
        public izinler()
        {
            izinler.sorgu = "Select * From izinTurleri";
            izinler.displaymember = "izinTuru";
            izinler.valuemember = "izinTurID";
        }

        int _izinHareketID;
        int _izinTurID;
        int _KullaniciID;
        string _izinTuru;
        DateTime _izinBaslangic;
        DateTime _izinBitis;
        DateTime _Saat;

        public int IzinHareketID { get => _izinHareketID; set => _izinHareketID = value; }
        public int IzinTurID { get => _izinTurID; set => _izinTurID = value; }
        public int KullaniciID { get => _KullaniciID; set => _KullaniciID = value; }
        public string IzinTuru { get => _izinTuru; set => _izinTuru = value; }
        public DateTime IzinBaslangic { get => _izinBaslangic; set => _izinBaslangic = value; }
        public DateTime IzinBitis { get => _izinBitis; set => _izinBitis = value; }
        public DateTime Saat { get => _Saat; set => _Saat = value; }

        //izin türlerini listview de göstermek için
        public static SqlDataReader izinGetir(ListView lst)
        {
            lst.Items.Clear();
            VeriTabani.con.Open();
            SqlCommand komut = new SqlCommand("Select * From izinTurleri", VeriTabani.con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                lst.Items.Add(ekle);
            }
            VeriTabani.con.Close();
            return dr;
        }
    }
}
