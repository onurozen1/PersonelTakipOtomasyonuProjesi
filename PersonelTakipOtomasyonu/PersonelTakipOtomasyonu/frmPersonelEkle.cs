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
    public partial class frmPersonelEkle : Form
    {
        public frmPersonelEkle()
        {
            InitializeComponent();
        }

        void temizle()
        {
            dateTimePicker1.Value = DateTime.Now;
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
        private void frmPersonelEkle_Load(object sender, EventArgs e)
        {
            //combobox a departmanları getirmek için
            Personeller.ComboyaKayıtGetir(comboDepartman);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Kullanicilar k = new Kullanicilar();
        Personeller p = new Personeller();
        //ekleme
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtEmail.Text == "" || txtTelefon.Text == "" || txtAdres.Text == "" || txtMaas.Text == "" || txtAciklama.Text == "")
            {
                MessageBox.Show("Lütfen boş bırakılan yerleri doldurunuz .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                p.Ad = txtAd.Text;
                p.Soyad = txtSoyad.Text;
                p.Telefon = txtTelefon.Text;
                p.Adres = txtAdres.Text;
                p.Email = txtEmail.Text;
                p.DepartmanID = int.Parse(comboDepartman.SelectedValue.ToString());
                p.Maas = decimal.Parse(txtMaas.Text);
                p.GirisTarihi = dateTimePicker1.Value;
                p.Aciklama = txtAciklama.Text;

                string sorgu = "insert into Personeller (Ad,Soyad,Telefon,Adres,Email,DepartmanID,Maas,GirisTarihi,Aciklama) values ('" + p.Ad + "','" + p.Soyad + "','" + p.Telefon + "','" + p.Adres + "','" + p.Email + "','" + p.DepartmanID + "',@Maas,@GirisTarihi,'" + p.Aciklama + "')";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@Maas", SqlDbType.Decimal).Value = p.Maas;
                komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi;
                VeriTabani.esg(komut, sorgu);

                Personeller.PersonelIDGetir(p);//metodun içine personelid yi çağırdık
                p.Aciklama = "İşe alındı .";
                p.Islem = p.PersonelID+" nolu yeni personel kaydı oluşturuldu .";
                Personeller.PersonelIslemEkle(p, k);

                MessageBox.Show("Personel bilgileri ekleme işlemi başarılı .", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
        }
    }
}
