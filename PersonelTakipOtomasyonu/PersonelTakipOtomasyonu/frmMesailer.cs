using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class frmMesailer : Form
    {
        public frmMesailer()
        {
            InitializeComponent();
        }

        void temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
            comboAy.SelectedIndex = -1;
            comboYil.SelectedIndex = -1;
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
        }

        void listele()
        {
            string sorgu = "Select * From Mesailer";
            VeriTabani.Listele_Ara(dataGridView1, sorgu);
        }

        private void frmMesailer_Load(object sender, EventArgs e)
        {
            listele();

            int yil = DateTime.Now.Year;
            for (int i = yil - 5; i <= yil; i++)
            {
                comboYil.Items.Add(i);
            }
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            if (txtPersonelID.Text == "")
            {
                txtPersonelAdSoyad.Text = "";
            }
            else
            {
                Primler.adSoyadGetir(txtPersonelID, txtPersonelAdSoyad);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Ödenmedi")
            {
                txtMesaiID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPersonelID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtMesaiSaatUcreti.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

                string baslangic = dataGridView1.CurrentRow.Cells[3].Value.ToString();//tablodaki başlangıç değerini bir baslangic adında değişkene atatık
                string bitis = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                string ayyil = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                //substring metodu ile texti isteğimize göre ayırdık 
                dateTimeBaslangic.Text = baslangic.Substring(0, 9);
                maskedBaslangıcSaat.Text = baslangic.Substring(10);

                dateTimeBitis.Text = bitis.Substring(0, 9);
                maskedBitisSaat.Text = bitis.Substring(10);

                // ayyil da '/' bu işareti indexof metodu ile aradık sonrasında substringle texti isteğimize göre ayırdık
                int say = ayyil.IndexOf("/");
                comboAy.Text = ayyil.Substring(0, say);
                comboYil.Text = ayyil.Substring(say + 1);
            }
        }

        private void txtMesaiSaatUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic = dateTimeBaslangic.Text + " " + maskedBaslangıcSaat.Text;
                string bitis = dateTimeBitis.Text + " " + maskedBitisSaat.Text;
                TimeSpan saatFarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double mSaatUcreti = double.Parse(txtMesaiSaatUcreti.Text);
                double tutar = saatFarki.TotalHours * mSaatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch
            {

            }
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnPersonelMesaileri_Click(object sender, EventArgs e)
        {
            frmPersonelMesaileri frm = new frmPersonelMesaileri();
            frm.ShowDialog();
        }

        private void btnTumMesaileriOde_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tüm personellerin ödenmeyen mesai ücretleri ödensin mi ?", "Mesai Ödeme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Kullanicilar k = new Kullanicilar();
                Personeller p = new Personeller();
                Mesailer m = new Mesailer();

                string sorgu = "update Mesailer set OdenmeDurumu='Ödendi' where OdenmeDurumu='Ödenmedi'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);

                //tüm personellerin mesai ödemelerini MesaiHareketleri tablosuna çeker
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "Ödenmedi")
                    {
                        p.PersonelID = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        m.MesaiID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        m.Islem = m.MesaiID + " nolu mesai kaydı için ödeme yapıldı .";
                        m.Aciklama = "Tüm mesailer ödendi .";
                        MesaiHareketleriEkle(k, m, p);
                    }
                }

                listele();
                temizle();
            }
        }


        //mesai hareketleri tablosuna verileri aktarmak için
        void MesaiHareketleriEkle(Kullanicilar k, Mesailer m, Personeller p)
        {
            k.KullaniciID = Kullanicilar.kid;
            m.Tarih = DateTime.Now;

            string sorgu = "insert into MesaiHareketleri values ('" + k.KullaniciID + "','" + p.PersonelID + "','" + m.MesaiID + "','" + m.Islem + "','" + m.Aciklama + "',@Tarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = m.Tarih;
            VeriTabani.esg(komut, sorgu);
        }

        private void btnMesaiOde_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanicilar k = new Kullanicilar();
                Personeller p = new Personeller();
                Mesailer m = new Mesailer();
                m.MesaiID = int.Parse(txtMesaiID.Text);

                string sorgu = "update Mesailer set OdenmeDurumu='Ödendi' where MesaiID='" + m.MesaiID + "'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);

                //MesaiHareketleri tablosu için
                p.PersonelID = int.Parse(txtPersonelID.Text);
                m.Islem = m.MesaiID + " nolu mesai kaydı için ödeme yapıldı .";
                m.Aciklama = "Mesai Ödeme";
                MesaiHareketleriEkle(k, m, p);

                MessageBox.Show(m.MesaiID + " nolu mesai ücreti ödenmiştir .", "Mesai Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz mesaiye çift tıklayınız .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMesaiSil_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanicilar k = new Kullanicilar();
                Personeller p = new Personeller();
                Mesailer m = new Mesailer();
                m.MesaiID = int.Parse(txtMesaiID.Text);

                string sorgu = "delete from Mesailer where MesaiID='" + m.MesaiID + "'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);

                //MesaiHareketleri tablosu için
                p.PersonelID = int.Parse(txtPersonelID.Text);
                m.Islem = m.MesaiID + " nolu mesai kaydı silinmiştir .";
                m.Aciklama = "Mesai Silme";
                MesaiHareketleriEkle(k, m, p);

                MessageBox.Show(m.MesaiID + " nolu mesai kaydı silinmiştir .", "Mesai Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanicilar k = new Kullanicilar();
                Personeller p = new Personeller();
                p.PersonelID = int.Parse(txtPersonelID.Text);
                Mesailer m = new Mesailer();
                m.MesaiID = int.Parse(txtMesaiID.Text);
                m.BaslangicSaati = dateTimeBaslangic.Text + " " + maskedBaslangıcSaat.Text;
                m.BitisSaati = dateTimeBitis.Text + " " + maskedBitisSaat.Text;
                m.MesaiSaatUcreti = decimal.Parse(txtMesaiSaatUcreti.Text);
                m.Tutar = decimal.Parse(txtTutar.Text);
                m.Donem = comboAy.Text + "/" + comboYil.Text;
                m.Aciklama = txtAciklama.Text;

                string sorgu = "update Mesailer set PersonelID='" + p.PersonelID + "',BaslangicSaati='" + m.BaslangicSaati + "',BitisSaati='" + m.BitisSaati + "',MesaiSaatUcreti=@MesaiSaatUcreti,Tutar=@Tutar,Donem='" + m.Donem + "',Aciklama='" + m.Aciklama + "' where MesaiID='" + m.MesaiID + "'";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@MesaiSaatUcreti", SqlDbType.Decimal).Value = m.MesaiSaatUcreti;
                komut.Parameters.Add("@Tutar", SqlDbType.Decimal).Value = m.Tutar;
                VeriTabani.esg(komut, sorgu);

                //MesaiHareketleri tablosu için
                m.Islem = m.MesaiID + " nolu mesai kaydı güncellenmiştir .";
                m.Aciklama = "Mesai Güncelleme";
                MesaiHareketleriEkle(k, m, p);

                MessageBox.Show(m.MesaiID + " nolu mesai kaydı güncellenmiştir .", "Mesai Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz mesaiye çift tıklayınız .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmMesaiHareketleriRapor frm = new frmMesaiHareketleriRapor();
            frm.ShowDialog();
        }
    }
}
