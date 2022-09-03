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
    public partial class frmPrimleriGoster : Form
    {
        public frmPrimleriGoster()
        {
            InitializeComponent();
        }

        void listele()
        {
            string sorgu = "Select PrimID as 'Prim Id',KullaniciID as 'Kullanıcı Id',PersonelID as 'Personel Id',Donem as 'Dönem',PrimTutar as 'Prim Tutarı',OdenmeDurumu as 'Ödenme Durumu',Aciklama as 'Açıklama ',Tarih From Primler";
            VeriTabani.Listele_Ara(dataGridView1, sorgu);
        }

        void temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            comboAy.SelectedIndex = -1;
            comboYil.SelectedIndex = -1;
        }

        private void frmPrimleriGoster_Load(object sender, EventArgs e)
        {
            int yil = DateTime.Now.Year;
            for (int i = yil - 5; i <= yil; i++)
            {
                comboYil.Items.Add(i);
            }

            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Ödenme durumu -ödenmedi- olanları textboxlara çekiyor
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString() == "Ödenmedi")
            {
                txtPrimID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtPersonelID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtPrimTutar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtAciklama.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
        }

        //Personel Id si ile personelin adını soyadını textboxa çekiyor 
        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.adSoyadGetir(txtPersonelID, txtPersonelAdSoyad);
        }

        //Primler tablosundaki dönemi değiştirmek için
        private void btnDonemDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanicilar k = new Kullanicilar();
                k.KullaniciID = Kullanicilar.kid;
                Primler p = new Primler();
                p.PrimID = int.Parse(txtPrimID.Text);
                p.Donem = comboAy.Text + "/" + comboYil.Text;
                p.PersonelID = int.Parse(txtPersonelID.Text);
                p.Aciklama = "Dönem değiştirildi .";
                p.Tarih = DateTime.Now;
                p.Islem = p.PrimID + " nolu primin dönem bilgisi değişmiştir .";

                string sorgu = "update Primler set Donem='" + p.Donem + "' where PrimID='" + p.PrimID + "'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);

                //PrimHareketleri tablosuna dönemin değiştiğine ait bilgiler çekilir
                string sorgu2 = "insert into PrimHareketleri (KullaniciID,PersonelID,PrimID,Islem,Aciklama,Tarih) values ('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                VeriTabani.esg(komut2, sorgu2);

                MessageBox.Show("İşlem başarılı .", "Dönem Değişikliği", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz primin üstüne çift tıklayınız .", "Prim İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //ödenme durumu -ödenmedi- yazan tüm personelleri -ödendi- olarak günceller   
        private void btnTumPrimleriOde_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tüm ödenmemiş primler ödensin mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sorgu = "update Primler set OdenmeDurumu='Ödendi' where OdenmeDurumu='Ödenmedi'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);

                //ödenmemiş primlerin hepsini yukardaki kodla ödüyoruz sonrasında aşağıda PrimHareketlerine bunları geçiriyoruz
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "Ödenmedi")
                    {
                        Kullanicilar k = new Kullanicilar();
                        k.KullaniciID = Kullanicilar.kid;
                        Primler p = new Primler();
                        p.PrimID = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        p.PersonelID = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                        p.Islem = "Tüm personellerin ödenmemiş primleri ödenmiştir .";
                        p.Aciklama = "Tüm primler .";
                        p.Tarih = DateTime.Now;

                        string sorgu2 = "insert into PrimHareketleri (KullaniciID,PersonelID,PrimID,Islem,Aciklama,Tarih) values ('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
                        SqlCommand komut2 = new SqlCommand();
                        komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                        VeriTabani.esg(komut2, sorgu2);
                    }
                }

                MessageBox.Show("Tüm personellerin primi ödenmiştir .", "Prim Ödendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        //seçtiğimiz kişinin primini ödemek için
        private void btnPrimOde_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanicilar k = new Kullanicilar();
                k.KullaniciID = Kullanicilar.kid;
                Primler p = new Primler();
                p.PrimID = int.Parse(txtPrimID.Text);
                p.PersonelID = int.Parse(txtPersonelID.Text);
                p.Aciklama = txtAciklama.Text;
                p.Tarih = DateTime.Now;
                p.Islem = p.PersonelID + " nolu personel " + txtPersonelAdSoyad.Text + " için ödeme yapıldı .";

                //bu kısım seçili kişinin primini öder 
                string sorgu = "update Primler set OdenmeDurumu='Ödendi' where PrimID='" + p.PrimID + "'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);

                //burası ise PrimHareketleri tablosuna bilgileri çeker
                string sorgu2 = "insert into PrimHareketleri (KullaniciID,PersonelID,PrimID,Islem,Aciklama,Tarih) values ('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                VeriTabani.esg(komut2, sorgu2);

                MessageBox.Show(txtPersonelAdSoyad.Text + " isimli personelin primi ödenmiştir .", "Prim Ödendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz primin üstüne çift tıklayınız .", "Prim İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrimGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanicilar k = new Kullanicilar();
                k.KullaniciID = Kullanicilar.kid;
                Primler p = new Primler();
                p.PrimID = int.Parse(txtPrimID.Text);
                p.PersonelID = int.Parse(txtPersonelID.Text);
                p.PrimTutar = decimal.Parse(txtPrimTutar.Text);
                p.Aciklama = txtAciklama.Text;
                p.Tarih = DateTime.Now;
                p.Islem = p.PrimID + " nolu primin bilgileri değiştirildi .";

                string sorgu = "update Primler set PrimTutar=@PrimTutar,Aciklama='" + p.Aciklama + "' where PrimID='" + p.PrimID + "'";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@PrimTutar", SqlDbType.Decimal).Value = p.PrimTutar;
                VeriTabani.esg(komut, sorgu);

                //prime güncelleme yapıldıktan sonra PrimHareketleri tablosuna çeker
                string sorgu2 = "insert into PrimHareketleri (KullaniciID,PersonelID,PrimID,Islem,Aciklama,Tarih) values ('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
                SqlCommand komut2 = new SqlCommand();
                komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                VeriTabani.esg(komut2, sorgu2);

                MessageBox.Show("İşlem başarılı .", "Prim Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz primin üstüne çift tıklayınız .", "Prim İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrimSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Prim silinsin mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Kullanicilar k = new Kullanicilar();
                    k.KullaniciID = Kullanicilar.kid;
                    Primler p = new Primler();
                    p.PrimID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    p.PersonelID = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    p.Aciklama = "Kayıt silindi .";
                    p.Tarih = DateTime.Now;
                    p.Islem = p.PrimID + " nolu primin bilgileri silindi .";

                    string sorgu = "delete from Primler where PrimID='" + p.PrimID + "'";
                    SqlCommand komut = new SqlCommand();
                    VeriTabani.esg(komut, sorgu);

                    string sorgu2 = "insert into PrimHareketleri (KullaniciID,PersonelID,PrimID,Islem,Aciklama,Tarih) values ('" + k.KullaniciID + "','" + p.PersonelID + "','" + p.PrimID + "','" + p.Islem + "','" + p.Aciklama + "',@Tarih)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                    VeriTabani.esg(komut2, sorgu2);

                    MessageBox.Show("İşlem başarılı .", "Prim Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listele();
                    temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Prim İşlemleri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
