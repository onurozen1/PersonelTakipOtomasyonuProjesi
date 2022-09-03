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
    public partial class frmMesaiEkle : Form
    {
        public frmMesaiEkle()
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
                if(item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
            comboAy.SelectedIndex = -1;
            comboYil.SelectedIndex = -1;       
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
        }

        private void frmMesaiEkle_Load(object sender, EventArgs e)
        {
            int yil = DateTime.Now.Year;
            for (int i = yil - 5; i <= yil; i++)
            {
                comboYil.Items.Add(i);
            }

            //comboya personellerin ad soyadını çekmek için
            MaasZamlari.ComboyaPersonelGetir(comboPersonelAdSoyad);
        }

        Label lblid;
        private void comboPersonelAdSoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combodan personel seçildiğinde oluşturduğumuz label a personelin id si aktarılacak
            lblid = new Label();
            MaasZamlari.ComboSecilirsePersonelIdGetir(comboPersonelAdSoyad, lblid);
        }

        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            if (comboPersonelAdSoyad.Text == "" || maskedBaslangıcSaat.MaskFull == false || maskedBitisSaat.MaskFull == false || txtMesaiSaatUcreti.Text == "" || txtTutar.Text == "" || comboAy.Text == "" || comboYil.Text == "" || txtAciklama.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Kullanicilar k = new Kullanicilar();
                k.KullaniciID = Kullanicilar.kid;
                Personeller p = new Personeller();
                p.PersonelID = int.Parse(lblid.Text);
                Mesailer m = new Mesailer();
                m.BaslangicSaati = dateTimeBaslangic.Text + " " + maskedBaslangıcSaat.Text;
                m.BitisSaati = dateTimeBitis.Text + " " + maskedBitisSaat.Text;
                m.MesaiSaatUcreti = decimal.Parse(txtMesaiSaatUcreti.Text);
                m.Tutar = decimal.Parse(txtTutar.Text);
                m.Donem = comboAy.Text + "/" + comboYil.Text;
                m.Aciklama = txtAciklama.Text;
                m.Tarih = DateTime.Now;

                string sorgu = "insert into Mesailer (KullaniciID,PersonelID,BaslangicSaati,BitisSaati,MesaiSaatUcreti,Tutar,Donem,Aciklama,Tarih) values ('" + k.KullaniciID + "','" + p.PersonelID + "','" + m.BaslangicSaati + "','" + m.BitisSaati + "',@MesaiSaatUcreti,@Tutar,'" + m.Donem + "','" + m.Aciklama + "',@Tarih)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@MesaiSaatUcreti", SqlDbType.Decimal).Value = m.MesaiSaatUcreti;
                komut.Parameters.Add("@Tutar", SqlDbType.Decimal).Value = m.Tutar;
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = m.Tarih;
                VeriTabani.esg(komut, sorgu);
                MessageBox.Show(comboPersonelAdSoyad.Text + " personelinin mesai bilgileri eklendi .", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Mesai saat ücretini girince başlangıç zamanından bitiş zamanına kadar kaç saat çalışıldığını hesaplar sonra saatlik ücrete göre otomatik o tutarı yazdırır
        private void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic = dateTimeBaslangic.Text + " " + maskedBaslangıcSaat.Text;
                string bitis = dateTimeBitis.Text + " " + maskedBitisSaat.Text;
                TimeSpan saatFarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic); //aradaki saat farkını bulmak için
                double MSaatUcreti = double.Parse(txtMesaiSaatUcreti.Text);
                double tutar = saatFarki.TotalHours * MSaatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch
            {
               
            }
        }
    }
}
