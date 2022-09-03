using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace PersonelTakipOtomasyonu
{
    class VeriTabani
    {
        public static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PersonelTakipOtomasyonu.Properties.Settings.dbPersonel_Takip_OtomasyonConnectionString"].ConnectionString);

        //ekleme silme güncelleme için
        public static void esg(SqlCommand komut, string sorgu)
        {
            con.Open();
            komut.Connection = con;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            con.Close();
        }

        //listeleme ve arama işlemleri için
        public static DataTable Listele_Ara(DataGridView gridview, string sorgu)
        {
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter dr = new SqlDataAdapter(sorgu, con);
            dr.Fill(dt);
            gridview.DataSource = dt;
            con.Close();
            return dt;
        }
    }
}
