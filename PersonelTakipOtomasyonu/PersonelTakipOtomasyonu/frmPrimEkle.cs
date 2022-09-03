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
    public partial class frmPrimEkle : Form
    {
        public frmPrimEkle()
        {
            InitializeComponent();
            radioKisiyeOzel.Checked = true;
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

        private void frmPrimler_Load(object sender, EventArgs e)
        {
            //comboYil a yılları eklemek için
            int yil = DateTime.Now.Year;
            for (int i = yil - 5; i <= yil; i++)
            {
                comboYil.Items.Add(i);
            }

            //personelleri datagride listelemek için
            string sorgu = "Select PersonelID as 'Personel Id',Ad,Soyad,Durum,Maas as 'Maaş',GirisTarihi as 'Giriş Tarihi' From Personeller";
            VeriTabani.Listele_Ara(dataGridView1, sorgu);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Primler p = new Primler();
            p.KullaniciID = Kullanicilar.kid;
            p.Donem = comboAy.Text + "/" + comboYil.Text;
            p.Aciklama = txtAciklama.Text;
            p.Tarih = DateTime.Now;

            if (radioKisiyeOzel.Checked == true)//kişiye özel prim seçiliyse
            {
                if (txtPersonelID.Text == "" || txtPersonelAdSoyad.Text == "" || comboAy.Text == "" || comboYil.Text == "" || txtPrimTutar.Text == "" || txtAciklama.Text == "")
                {
                    MessageBox.Show("Lütfen işlem yapmak istediğiniz personele çift tıklayınız .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    p.PersonelID = int.Parse(txtPersonelID.Text);
                    p.PrimTutar = decimal.Parse(txtPrimTutar.Text);
                    string sorgu = "insert into Primler (KullaniciID,PersonelID,Donem,PrimTutar,Aciklama,Tarih) values ('" + p.KullaniciID + "','" + p.PersonelID + "','" + p.Donem + "',@PrimTutar,'" + p.Aciklama + "',@Tarih)";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.Add("@PrimTutar", SqlDbType.Decimal).Value = p.PrimTutar;
                    komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                    VeriTabani.esg(komut, sorgu);
                    MessageBox.Show(txtPersonelAdSoyad.Text + " adlı personelimize prim ekleme işlemi başarılı .", "Prim Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
            }
            else//tüm personeller için prim seçiliyse
            {
                if (comboAy.Text == "" || comboYil.Text == "" || txtPrimTutar.Text == "" || txtAciklama.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    p.PrimTutar = decimal.Parse(txtPrimTutar.Text);
                    //for döngüsünü kullanarak tüm personelleri aynı anda prim verdik
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        string sorgu = "insert into Primler (KullaniciID,PersonelID,Donem,PrimTutar,Aciklama,Tarih) values ('" + p.KullaniciID + "','" + dataGridView1.Rows[i].Cells[0].Value + "','" + p.Donem + "',@PrimTutar,'" + p.Aciklama + "',@Tarih)";
                        SqlCommand komut = new SqlCommand();
                        komut.Parameters.Add("@PrimTutar", SqlDbType.Decimal).Value = p.PrimTutar;
                        komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = p.Tarih;
                        VeriTabani.esg(komut, sorgu);
                    }
                    MessageBox.Show("Tüm personellere prim ekleme işlemi başarılı .", "Prim Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnPrimleriGoster_Click(object sender, EventArgs e)
        {
            frmPrimleriGoster frm = new frmPrimleriGoster();
            frm.ShowDialog();
        }

        //datagrid de seçili olan personele göre açılan formda o personelin prim bilgileri yazıcak
        private void btnPersonelPrimleri_Click(object sender, EventArgs e)
        {
            frmPersoneleGorePrimler frm = new frmPersoneleGorePrimler();
            frm.txtPersonelID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtPersonelAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string sorgu = "Select PrimID as 'Prim Id',PersonelID as 'Personel Id',Donem as 'Dönem',PrimTutar as 'Prim Tutarı',OdenmeDurumu as 'Ödenme Durumu',Aciklama as 'Açıklama ',Tarih From Primler where PersonelID='" + frm.txtPersonelID.Text + "'";
            VeriTabani.Listele_Ara(frm.dataGridView1, sorgu);
            frm.ShowDialog();
        }
    }
}
