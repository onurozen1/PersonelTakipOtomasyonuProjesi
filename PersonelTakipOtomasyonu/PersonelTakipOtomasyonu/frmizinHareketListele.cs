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
    public partial class frmizinHareketListele : Form
    {
        public frmizinHareketListele()
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
            }
            dateTimeBaslangic.Value = DateTime.Now;
            dateTimeBitis.Value = DateTime.Now;
        }

        void listele()
        {
            string sorgu = "Select i.izinHareketID as 'ID',i.PersonelID as 'Personel ID',i.KullaniciID as 'Kullanıcı ID',tur.izinTuru as 'İzin Türü',i.izinBaslangic as 'İzin Başlangıcı',i.izinBitis as 'İzin Bitişi',i.Islem as 'İşlem',i.Aciklama as 'Açıklama',i.Tarih,i.Saat from izinHareketleri i,izinTurleri tur where i.izinTurID=tur.izinTurID";
            VeriTabani.Listele_Ara(dataGridView1, sorgu);
        }

        private void btnizinTurleri_Click(object sender, EventArgs e)
        {
            frmizinTurleri frm = new frmizinTurleri();
            frm.ShowDialog();
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

        izinler Izin = new izinler();

        private void frmizinHareketListele_Load(object sender, EventArgs e)
        {
            listele();

            Personeller.ComboyaKayıtGetir(comboizinTuru);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtPersonelID.Text == "" || txtPersonelAdSoyad.Text == "" || txtAciklama.Text == "")
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                izinler i = new izinler();
                i.PersonelID = int.Parse(txtPersonelID.Text);
                i.KullaniciID = Kullanicilar.kid;
                i.IzinTurID = int.Parse(comboizinTuru.SelectedValue.ToString());
                i.IzinBaslangic = dateTimeBaslangic.Value;
                i.IzinBitis = dateTimeBitis.Value;
                i.Islem = i.PersonelID + " nolu " + txtPersonelAdSoyad.Text + " için izin kaydı oluşturuldu .";
                i.Aciklama = txtAciklama.Text;
                i.Tarih = DateTime.Now;
                i.Saat = DateTime.Now;

                string sorgu = "insert into izinHareketleri values ('" + i.PersonelID + "','" + i.KullaniciID + "','" + i.IzinTurID + "',@Baslangic,@Bitis,'" + i.Islem + "','" + i.Aciklama + "',@Tarih,@Saat)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@Baslangic", SqlDbType.Date).Value = i.IzinBaslangic;
                komut.Parameters.Add("@Bitis", SqlDbType.Date).Value = i.IzinBitis;
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = i.Tarih;
                komut.Parameters.Add("@Saat", SqlDbType.DateTime).Value = i.Saat;
                VeriTabani.esg(komut, sorgu);

                MessageBox.Show("İzin kaydı oluşturuldu .", "İzin Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtizinHareketID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboizinTuru.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimeBaslangic.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimeBitis.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                izinler i = new izinler();
                i.IzinHareketID = int.Parse(txtizinHareketID.Text);
                i.PersonelID = int.Parse(txtPersonelID.Text);
                i.KullaniciID = Kullanicilar.kid;
                i.IzinTurID = int.Parse(comboizinTuru.SelectedValue.ToString());
                i.IzinBaslangic = dateTimeBaslangic.Value;
                i.IzinBitis = dateTimeBitis.Value;
                i.Islem = i.IzinHareketID + " nolu izin kaydı güncellendi .";
                i.Aciklama = txtAciklama.Text;
                i.Tarih = DateTime.Now;
                i.Saat = DateTime.Now;

                string sorgu = "update izinHareketleri set PersonelID='" + i.PersonelID + "',izinTurID='" + i.IzinTurID + "',izinBaslangic=@Baslangic,izinBitis=@Bitis,Islem='" + i.Islem + "',Aciklama='" + i.Aciklama + "',Tarih=@Tarih,Saat=@Saat where izinHareketID='" + i.IzinHareketID + "'";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@Baslangic", SqlDbType.Date).Value = i.IzinBaslangic;
                komut.Parameters.Add("@Bitis", SqlDbType.Date).Value = i.IzinBitis;
                komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = i.Tarih;
                komut.Parameters.Add("@Saat", SqlDbType.DateTime).Value = i.Saat;
                VeriTabani.esg(komut, sorgu);

                MessageBox.Show("İzin kaydı güncellendi .", "İzin Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                izinler i = new izinler();
                i.IzinHareketID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                string sorgu = "delete from izinHareketleri where izinHareketID='" + i.IzinHareketID + "'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);

                MessageBox.Show("İzin kaydı silindi .", "İzin Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Excele veri aktarma
        private void btnExceleAktar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application uygulama = new Microsoft.Office.Interop.Excel.Application();
            uygulama.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                range.Value2 = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j+2,i+1];
                    range.Value2 = dataGridView1[i, j].Value;
                    sayfa.Columns["E:E"].NumberFormat = "gg.aa.yyyy";
                    sayfa.Columns["F:F"].NumberFormat = "gg.aa.yyyy";
                    sayfa.Columns["I:I"].NumberFormat = "gg.aa.yyyy";
                    sayfa.Columns["J:J"].NumberFormat = "ss:dd:nn";
                }
            }
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            frmizinHareketleriRapor frm = new frmizinHareketleriRapor();
            frm.ShowDialog();
        }
    }
}
