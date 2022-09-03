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
    public partial class frmPersonelMesaileri : Form
    {
        public frmPersonelMesaileri()
        {
            InitializeComponent();
        }

        void seciliPersoneleGoreBilgiGetirme()
        {
            txtPersonelID.Text = dataGridViewPersoneller.CurrentRow.Cells[0].Value.ToString();
            string sorgu = "Select * From Mesailer where PersonelID='" + txtPersonelID.Text + "'";
            VeriTabani.Listele_Ara(dataGridViewMesailer, sorgu);

            lblKayıtSayisi.Text = "Toplam " + (dataGridViewMesailer.Rows.Count - 1) + " kayıt listelendi .";//personele göre kayıt sayısı

            decimal tutar = 0;//personele göre ücret tutarı
            for (int i = 0; i < dataGridViewMesailer.Rows.Count - 1; i++)
            {
                tutar = tutar + decimal.Parse(dataGridViewMesailer.Rows[i].Cells[6].Value.ToString());
            }
            lblTutar.Text = "Toplam mesai ücret tutarı " + tutar.ToString("0.00") + " TL .";
        }

        private void frmPersonelMesaileri_Load(object sender, EventArgs e)
        {
            string sorgu = "Select PersonelID as 'Personel Id',Ad,Soyad From Personeller where Durum='Aktif'";
            VeriTabani.Listele_Ara(dataGridViewPersoneller, sorgu);

            seciliPersoneleGoreBilgiGetirme();
        }

        private void dataGridViewPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seciliPersoneleGoreBilgiGetirme();
        }

        private void txtMesaiID_TextChanged(object sender, EventArgs e)
        {
            if (txtMesaiID.Text == "")
            {
                string sorgu2 = "Select * From Mesailer where PersonelID='" + txtPersonelID.Text + "'";
                VeriTabani.Listele_Ara(dataGridViewMesailer, sorgu2);
            }
            else
            {
                string sorgu = "Select * From Mesailer where MesaiID like '" + txtMesaiID.Text + "%'";
                VeriTabani.Listele_Ara(dataGridViewMesailer, sorgu);
            }
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.adSoyadGetir(txtPersonelID, txtPersonelAdSoyad);
        }
    }
}
