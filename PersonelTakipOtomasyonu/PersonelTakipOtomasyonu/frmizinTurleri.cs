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
    public partial class frmizinTurleri : Form
    {
        public frmizinTurleri()
        {
            InitializeComponent();
        }

        void temizle()
        {
            txtizinTurID.Clear();
            txtizinTuru.Clear();
        }

        private void frmizinTurleri_Load(object sender, EventArgs e)
        {
            izinler.izinGetir(listView1);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtizinTuru.Text == "")
            {
                MessageBox.Show("Lütfen izin türünü yazınız .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                izinler i = new izinler();
                i.IzinTuru = txtizinTuru.Text;
                string sorgu = "insert into izinTurleri values ('" + i.IzinTuru + "')";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);
                MessageBox.Show("İzin türü kaydı eklendi .", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                izinler.izinGetir(listView1);
                temizle();
            } 
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                izinler i = new izinler();
                i.IzinTurID = int.Parse(txtizinTurID.Text);
                string sorgu = "delete from izinTurleri where izinTurID='" + i.IzinTurID + "'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);
                MessageBox.Show("İzin türü kaydı silindi .", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                izinler.izinGetir(listView1);
                temizle();
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı .", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                izinler i = new izinler();
                i.IzinTurID = int.Parse(txtizinTurID.Text);
                i.IzinTuru = txtizinTuru.Text;
                string sorgu = "update izinTurleri set izinTuru='" + i.IzinTuru + "' where izinTurID='" + i.IzinTurID + "'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);
                MessageBox.Show("İzin türü kaydı güncellendi .", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                izinler.izinGetir(listView1);
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Türü", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtizinTurID.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtizinTuru.Text = listView1.SelectedItems[0].SubItems[1].Text;
        }
    }
}
