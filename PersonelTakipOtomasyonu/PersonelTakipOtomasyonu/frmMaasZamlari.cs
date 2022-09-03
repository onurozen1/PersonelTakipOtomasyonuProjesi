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
    public partial class frmMaasZamlari : Form
    {
        public frmMaasZamlari()
        {
            InitializeComponent();
            comboPersonel.SelectedIndex = 0;
            radioYuzde.Checked = true;
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
            comboPersonel.SelectedIndex = 0;
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            Personeller p = new Personeller();
            p.PersonelID = int.Parse(lblPersonelId.Text);
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID = Kullanicilar.kid;
            MaasZamlari m = new MaasZamlari();
            m.Donem = comboAy.Text + "/" + comboYil.Text;
            m.Aciklama = txtAciklama.Text;
            m.Tarih = DateTime.Now;
            m.Personel = int.Parse(lblPersonelId.Text);

            if (radioYuzde.Checked == true)//Yüzde alanı seçliyse 
            {
                if (txtYuzde.Text == "" || comboAy.Text == "" || comboYil.Text == "" || txtAciklama.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    m.Yuzde = decimal.Parse(txtYuzde.Text);
                    if (comboPersonel.SelectedIndex == 0)//personel combobox daki 'TÜM PERSONELLER' seçiliyse
                    {
                        string sorgu = "update Personeller set Maas=Maas+(Maas*@yuzde/100)";
                        SqlCommand komut = new SqlCommand();
                        komut.Parameters.Add("@yuzde", SqlDbType.Decimal).Value = m.Yuzde;
                        VeriTabani.esg(komut, sorgu);
                        MessageBox.Show("Tüm personellerin maaşına %" + m.Yuzde + " zam yapıldı .", "Maaş Zamları", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else//eğer değilse comboboxda seçili personele göre işlem yap
                    {
                        string sorgu = "update Personeller set Maas=Maas+(Maas*@yuzde/100) where PersonelID='" + p.PersonelID + "'";
                        SqlCommand komut = new SqlCommand();
                        komut.Parameters.Add("@yuzde", SqlDbType.Decimal).Value = m.Yuzde;
                        VeriTabani.esg(komut, sorgu);
                        MessageBox.Show(comboPersonel.Text + " isimli personelimizin maaşına %" + m.Yuzde + " zam yapıldı .", "Maaş Zamları", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Yukardaki kodlarda personelin maaşını değiştirdik alttaki kodlarla ise MaasZamlari adlı sql tablosuna verilerimizi ileteceğiz
                    string sorgu2 = "insert into MaasZamlari (KullaniciID,Donem,Personel,Yuzde,Aciklama,Tarih) values ('" + k.KullaniciID + "','" + m.Donem + "','" + p.PersonelID + "',@Yuzde,'" + m.Aciklama + "',@Tarih)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.Add("@Yuzde", SqlDbType.Decimal).Value = m.Yuzde;
                    komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = m.Tarih;
                    VeriTabani.esg(komut2, sorgu2);
                    temizle();
                }
            }
            else//eğer yüzde alanı seçilmese, fiyat alanı seçilmiş oluyor
            {
                if (txtFiyat.Text == "" || comboAy.Text == "" || comboYil.Text == "" || txtAciklama.Text == "")
                {
                    MessageBox.Show("Lütfen boş alanları doldurunuz .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    m.Fiyat = decimal.Parse(txtFiyat.Text);
                    if (comboPersonel.SelectedIndex == 0)//personel combobox daki 'TÜM PERSONELLER' seçiliyse
                    {
                        string sorgu = "update Personeller set Maas=Maas+@fiyat";
                        SqlCommand komut = new SqlCommand();
                        komut.Parameters.Add("@fiyat", SqlDbType.Decimal).Value = m.Fiyat;
                        VeriTabani.esg(komut, sorgu);
                        MessageBox.Show("Tüm personellerin maaşına " + m.Fiyat + " TL zam yapıldı .", "Maaş Zamları", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else//eğer değilse comboboxda seçili personele göre işlem yap
                    {
                        string sorgu = "update Personeller set Maas=Maas+@fiyat where PersonelID='" + p.PersonelID + "'";
                        SqlCommand komut = new SqlCommand();
                        komut.Parameters.Add("@fiyat", SqlDbType.Decimal).Value = m.Fiyat;
                        VeriTabani.esg(komut, sorgu);
                        MessageBox.Show(comboPersonel.Text + " isimli personelimizin maaşına " + m.Fiyat + " TL zam yapıldı .", "Maaş Zamları", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Yukardaki kodlarda personelin maaşını değiştirdik alttaki kodlarla ise MaasZamlari adlı sql tablosuna verilerimizi ileteceğiz
                    string sorgu2 = "insert into MaasZamlari (KullaniciID,Donem,Personel,Fiyat,Aciklama,Tarih) values ('" + k.KullaniciID + "','" + m.Donem + "','" + p.PersonelID + "',@Fiyat,'" + m.Aciklama + "',@Tarih)";
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Parameters.Add("@Fiyat", SqlDbType.Decimal).Value = m.Fiyat;
                    komut2.Parameters.Add("@Tarih", SqlDbType.Date).Value = m.Tarih;
                    VeriTabani.esg(komut2, sorgu2);
                    temizle();
                }
            }
        }

        private void radioYuzde_CheckedChanged(object sender, EventArgs e)
        {
            txtYuzde.Enabled = true;
            txtFiyat.Enabled = false;
        }

        private void radioFiyat_CheckedChanged(object sender, EventArgs e)
        {
            txtFiyat.Enabled = true;
            txtYuzde.Enabled = false;
        }

        private void frmMaasZamlari_Load(object sender, EventArgs e)
        {
            //dönem kısmının yıl alanı için
            int yil = int.Parse(DateTime.Now.Year.ToString());
            for (int i = yil - 5; i <= yil; i++)
            {
                comboYil.Items.Add(i);
            }

            //personel isimlerini combobox a çekmek için
            MaasZamlari.ComboyaPersonelGetir(comboPersonel);
        }

        //combobox seçildiğinde ad soyada göre personel id atıyor
        private void comboPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPersonel.SelectedIndex == 0)
            {
                lblPersonelId.Text = "0";
                return;
            }
            //lblpersonelid ye personellerin ID değerlerini getirmek için
            MaasZamlari.ComboSecilirsePersonelIdGetir(comboPersonel, lblPersonelId);
        }
    }
}
