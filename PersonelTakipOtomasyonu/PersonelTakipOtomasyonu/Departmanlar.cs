using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    class Departmanlar
    {
        int _DepartmanID;
        string _Departman;
        string _Aciklama;

        public int DepartmanID { get => _DepartmanID; set => _DepartmanID = value; }
        public string Departman { get => _Departman; set => _Departman = value; }
        public string Aciklama { get => _Aciklama; set => _Aciklama = value; }

        //departmanları listview de göstermek için
        public static SqlDataReader DepartmanGetir(ListView lst)
        {
            lst.Items.Clear();
            VeriTabani.con.Open();
            SqlCommand komut = new SqlCommand("Select * From Departmanlar", VeriTabani.con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                ekle.SubItems.Add(dr[2].ToString());
                lst.Items.Add(ekle);
            }
            VeriTabani.con.Close();
            return dr;
        }
    }
}
