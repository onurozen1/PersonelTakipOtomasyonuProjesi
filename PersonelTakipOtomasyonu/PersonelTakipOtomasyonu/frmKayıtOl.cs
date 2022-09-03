using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonelTakipOtomasyonu
{
    public partial class frmKayıtOl : Form
    {
        public frmKayıtOl()
        {
            InitializeComponent();
        }
        void temizle()
        {
            foreach (Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        //yeni kullanıcı eklemek için
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciAd = txtKullaniciAd.Text;
            k.Sifre = txtSifre.Text;
            k.AdSoyad = txtAdSoyad.Text;
            k.Soru = comboSoru.Text;
            k.Cevap = txtCevap.Text;
            k.Tarih = DateTime.Now;
            if (txtKullaniciAd.Text == "" || txtAdSoyad.Text == "" || comboSoru.Text == "" || txtCevap.Text == "" || txtSifre.Text == "" || txtSifreTekrar.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtSifre.Text == txtSifreTekrar.Text)
                {
                    string sorgu = "insert into Kullanicilar (KullaniciAd,Sifre,AdSoyad,Soru,Cevap,Tarih) values ('" + k.KullaniciAd + "','" + k.Sifre + "','" + k.AdSoyad + "','" + k.Soru + "','" + k.Cevap + "',@Tarih)";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = k.Tarih;
                    VeriTabani.esg(komut, sorgu);
                    MessageBox.Show("Tebrikler " + k.AdSoyad + " . Sisteme kaydınız başarıyla oluşturulmuştur .", "Kayıt Ol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
                else
                {
                    MessageBox.Show("Şifreleriniz aynı değil .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }      
        }
    }
}
