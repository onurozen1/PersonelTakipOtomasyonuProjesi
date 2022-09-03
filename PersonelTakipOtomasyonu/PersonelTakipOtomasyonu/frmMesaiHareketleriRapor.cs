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
    public partial class frmMesaiHareketleriRapor : Form
    {
        public frmMesaiHareketleriRapor()
        {
            InitializeComponent();
        }

        private void frmMesaiHareketleriRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbPersonel_Takip_OtomasyonDataSet.MesaiRapor' table. You can move, or remove it, as needed.
            this.MesaiRaporTableAdapter.mesaiRapor(this.dbPersonel_Takip_OtomasyonDataSet.MesaiRapor);

            this.reportViewer1.RefreshReport();
        }
    }
}
