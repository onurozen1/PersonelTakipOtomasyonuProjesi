using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipOtomasyonu
{
    public partial class frmKullanicilar : Form
    {
        public frmKullanicilar()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanicilar.KullaniciGirisi(txtKullaniciAd.Text, txtSifre.Text);
            if (Kullanicilar.durum == true)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adınızı ve şifrenizi kontrol ediniz .", "Hatalı Giriş !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //kayıt olmak için
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayıtOl frm = new frmKayıtOl();
            frm.ShowDialog();
        }
    }
}
