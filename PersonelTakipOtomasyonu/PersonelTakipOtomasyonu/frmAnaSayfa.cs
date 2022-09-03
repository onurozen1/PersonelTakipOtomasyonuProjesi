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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        void formGetir(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }

        private void btnDepartmanlar_Click(object sender, EventArgs e)
        {
            frmDepartmanlar frm = new frmDepartmanlar();
            formGetir(frm, panelFormlar);
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm = new frmPersonelEkle();
            formGetir(frm, panelFormlar);
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            frmPersonelListele frm = new frmPersonelListele();
            formGetir(frm, panelFormlar);
        }

        private void btnMaasZamlari_Click(object sender, EventArgs e)
        {
            frmMaasZamlari frm = new frmMaasZamlari();
            formGetir(frm, panelFormlar);
        }

        private void btnPrimler_Click(object sender, EventArgs e)
        {
            frmPrimEkle frm = new frmPrimEkle();
            formGetir(frm, panelFormlar);
        }

        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            frmMesaiEkle frm = new frmMesaiEkle();
            formGetir(frm, panelFormlar);
        }

        private void btnMesaiIslemleri_Click(object sender, EventArgs e)
        {
            frmMesailer frm = new frmMesailer();
            formGetir(frm, panelFormlar);
        }

        private void btnizinHareketleri_Click(object sender, EventArgs e)
        {
            frmizinHareketListele frm = new frmizinHareketListele();
            formGetir(frm, panelFormlar);
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            frmKullanicilar frm = new frmKullanicilar();
            frm.ShowDialog();
            panelButonlar.Width = 64;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelButonlar.Width == 186)
            {
                panelButonlar.Width = 64;
                btnMenu.Location = new Point(0, 13);
                btnMenu.ImageIndex = 7;
            }
            else
            {
                panelButonlar.Width = 186;
                btnMenu.Location = new Point(121, 13);
                btnMenu.ImageIndex = 9;
            }
        }
    }
}
