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
    public partial class frmPersonelListele : Form
    {
        public frmPersonelListele()
        {
            InitializeComponent();
        }

        void temizle()
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        //datagrid e listelemek için
        void listele()
        {
            string sorgu = "Select Personeller.PersonelID as 'ID',Personeller.Ad,Personeller.Soyad,Personeller.Telefon,Personeller.Adres,Personeller.Email,Departmanlar.Departman,Personeller.Durum,Personeller.Maas as 'Maaş',Personeller.GirisTarihi as 'Giriş Tarihi',Personeller.CikisTarihi as 'Çıkış Tarihi',Personeller.Aciklama as 'Açıklama' from Personeller inner join Departmanlar on Personeller.DepartmanID=Departmanlar.DepartmanID";
            VeriTabani.Listele_Ara(dataGridView1, sorgu);

            //toplam kayıt için
            lblToplamKayit.Text = "Toplam " + (dataGridView1.Rows.Count) + " kayıt listelendi .";
            //toplam maaş için
            decimal toplamMaas = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplamMaas = toplamMaas + decimal.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString());
            }
            lblToplamMaas.Text = "Listede toplam " + toplamMaas.ToString("0.00") + " TL maaş hesaplandı .";
        }
        private void frmPersonelListele_Load(object sender, EventArgs e)
        {
            listele();

            //combobox a departmanları getirmek için
            Personeller.ComboyaKayıtGetir(comboDepartman);
        }

        Kullanicilar k = new Kullanicilar();
        Personeller p = new Personeller();
        //güncelleme 
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                p.PersonelID = int.Parse(txtId.Text);
                p.Ad = txtAd.Text;
                p.Soyad = txtSoyad.Text;
                p.Telefon = txtTelefon.Text;
                p.Adres = txtAdres.Text;
                p.Email = txtEmail.Text;
                p.DepartmanID = int.Parse(comboDepartman.SelectedValue.ToString());
                p.Maas = decimal.Parse(txtMaas.Text);
                p.GirisTarihi = dateTimePicker1.Value;
                p.Aciklama = txtAciklama.Text;

                string sorgu = "update Personeller set Ad='" + p.Ad + "',Soyad='" + p.Soyad + "',Telefon='" + p.Telefon + "',Adres='" + p.Adres + "',Email='" + p.Email + "',DepartmanID='" + p.DepartmanID + "',Maas=@Maas,GirisTarihi=@GirisTarihi,Aciklama='" + p.Aciklama + "' where PersonelID='" + p.PersonelID + "'";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@Maas", SqlDbType.Decimal).Value = p.Maas;
                komut.Parameters.Add("@GirisTarihi", SqlDbType.Date).Value = p.GirisTarihi;
                VeriTabani.esg(komut, sorgu);

                p.Aciklama = "Personel güncellendi .";
                p.Islem = p.PersonelID + " nolu personelin bilgileri değiştirildi .";
                Personeller.PersonelIslemEkle(p, k);//PersonelIslemleri tablosuna ne yapıldını aktarıyor

                MessageBox.Show("Personel bilgileri güncelleme işlemi başarılı .", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz personelin üstüne çift tıklayınız .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        //datagridden verileri çekmek için
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Aktif")
                {
                    txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    txtEmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    comboDepartman.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    txtDurum.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    txtMaas.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    dateTimePicker2.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
                    txtAciklama.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz personelin üstüne çift tıklayınız .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //silme işlemini, tablodaki durumu pasif ve çıkış tarihini güncelleyerek yapıcağız
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                p.PersonelID = int.Parse(txtId.Text);
                p.CikisTarihi = DateTime.Now;

                string sorgu = "update Personeller set Durum='Pasif',CikisTarihi=@CikisTarihi where PersonelID='" + p.PersonelID + "'";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@CikisTarihi", SqlDbType.Date).Value = p.CikisTarihi;
                VeriTabani.esg(komut, sorgu);

                p.Aciklama = "İşten çıkarılma .";
                p.Islem = p.PersonelID + " nolu personel işten çıkarıldı .";
                Personeller.PersonelIslemEkle(p, k);//PersonelIslemleri tablosuna ne yapıldını aktarıyor

                MessageBox.Show("Personel silme işlemi başarılı .", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz personelin üstüne çift tıklayınız .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Personel Id sine göre arama yapmak için
        private void txtIdAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select Personeller.PersonelID as 'ID',Personeller.Ad,Personeller.Soyad,Personeller.Telefon,Personeller.Adres,Personeller.Email,Departmanlar.Departman,Personeller.Durum,Personeller.Maas as 'Maaş',Personeller.GirisTarihi as 'Giriş Tarihi',Personeller.CikisTarihi as 'Çıkış Tarihi',Personeller.Aciklama as 'Açıklama' from Personeller inner join Departmanlar on Personeller.DepartmanID=Departmanlar.DepartmanID and Personeller.PersonelID like '%" + txtIdAra.Text + "%'";
            VeriTabani.Listele_Ara(dataGridView1, sorgu);
        }

        //Personel Adına göre arama yapmak için
        private void txtAdAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select Personeller.PersonelID as 'ID',Personeller.Ad,Personeller.Soyad,Personeller.Telefon,Personeller.Adres,Personeller.Email,Departmanlar.Departman,Personeller.Durum,Personeller.Maas as 'Maaş',Personeller.GirisTarihi as 'Giriş Tarihi',Personeller.CikisTarihi as 'Çıkış Tarihi',Personeller.Aciklama as 'Açıklama' from Personeller inner join Departmanlar on Personeller.DepartmanID=Departmanlar.DepartmanID and Personeller.Ad like '" + txtAdAra.Text + "%'";
            VeriTabani.Listele_Ara(dataGridView1, sorgu);
        }

        //Personel Soyadına göre arama yapmak için
        private void txtSoyadAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select Personeller.PersonelID as 'ID',Personeller.Ad,Personeller.Soyad,Personeller.Telefon,Personeller.Adres,Personeller.Email,Departmanlar.Departman,Personeller.Durum,Personeller.Maas as 'Maaş',Personeller.GirisTarihi as 'Giriş Tarihi',Personeller.CikisTarihi as 'Çıkış Tarihi',Personeller.Aciklama as 'Açıklama' from Personeller inner join Departmanlar on Personeller.DepartmanID=Departmanlar.DepartmanID and Personeller.Soyad like '" + txtSoyadAra.Text + "%'";
            VeriTabani.Listele_Ara(dataGridView1, sorgu);
        }

        //Personel telefonuna göre arama yapmak için
        private void txtTelefonAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "Select Personeller.PersonelID as 'ID',Personeller.Ad,Personeller.Soyad,Personeller.Telefon,Personeller.Adres,Personeller.Email,Departmanlar.Departman,Personeller.Durum,Personeller.Maas as 'Maaş',Personeller.GirisTarihi as 'Giriş Tarihi',Personeller.CikisTarihi as 'Çıkış Tarihi',Personeller.Aciklama as 'Açıklama' from Personeller inner join Departmanlar on Personeller.DepartmanID=Departmanlar.DepartmanID and Personeller.Telefon like '" + txtTelefonAra.Text + "%'";
            VeriTabani.Listele_Ara(dataGridView1, sorgu);
        }
    }
}
