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
    public partial class frmDepartmanlar : Form
    {
        public frmDepartmanlar()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txtId.Clear();
            txtDepartman.Clear();
            txtAciklama.Clear();
        }
        private void frmDepartmanlar_Load(object sender, EventArgs e)
        {
            //departnanları listview de göstermek için
            Departmanlar.DepartmanGetir(listView1);
        }

        //ekleme
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAciklama.Text == "" || txtDepartman.Text == "")
            {
                MessageBox.Show("Departman veya açıklama kısmını giriniz .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Departmanlar d = new Departmanlar();
                d.Departman = txtDepartman.Text;
                d.Aciklama = txtAciklama.Text;
                string sorgu = "insert into Departmanlar (Departman,Aciklama) values ('" + d.Departman + "','" + d.Aciklama + "')";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);
                MessageBox.Show("Ekleme işlemi başarılı .", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Departmanlar.DepartmanGetir(listView1);
                temizle();
            }
        }

        //güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Departmanlar d = new Departmanlar();
                d.DepartmanID = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                d.Departman = txtDepartman.Text;
                d.Aciklama = txtAciklama.Text;
                string sorgu = "update Departmanlar set Departman='" + d.Departman + "',Aciklama='" + d.Aciklama + "' where DepartmanID='" + d.DepartmanID + "'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);
                MessageBox.Show("Güncelleme işlemi başarılı .", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Departmanlar.DepartmanGetir(listView1);
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istedeğiniz kayıtı seçiniz .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //    try
            //    {
            //        Departmanlar d = new Departmanlar();
            //        d.DepartmanID = Convert.ToInt32(txtId.Text);
            //        d.Departman = txtDepartman.Text;
            //        d.Aciklama = txtAciklama.Text;
            //        string sorgu = "update Departmanlar set Departman='" + d.Departman + "',Aciklama='" + d.Aciklama + "' where DepartmanID='" + d.DepartmanID + "'";
            //        SqlCommand komut = new SqlCommand();
            //        VeriTabani.esg(komut, sorgu);
            //        MessageBox.Show("Güncelleme işlemi başarılı .", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        Departmanlar.DepartmanGetir(listView1);
            //        temizle();
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Lütfen ID değerinizi doğru girdiğinizi kontrol ediniz .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
        }

        //silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Departmanlar d = new Departmanlar();
                d.DepartmanID = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                string sorgu = "Delete From Departmanlar where DepartmanID='" + d.DepartmanID + "'";
                SqlCommand komut = new SqlCommand();
                VeriTabani.esg(komut, sorgu);
                MessageBox.Show("Silme işlemi başarılı .", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Departmanlar.DepartmanGetir(listView1);
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen sileceğiniz kayıtı seçiniz .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //listview den textboxlara veri çekme
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtDepartman.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
