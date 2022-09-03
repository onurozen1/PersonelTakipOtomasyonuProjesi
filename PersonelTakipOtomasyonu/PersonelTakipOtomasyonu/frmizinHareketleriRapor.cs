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
    public partial class frmizinHareketleriRapor : Form
    {
        public frmizinHareketleriRapor()
        {
            InitializeComponent();
        }

        private void frmizinHareketleriRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbPersonel_Takip_OtomasyonDataSet.izinRapor' table. You can move, or remove it, as needed.
            this.izinRaporTableAdapter.izinRapor(this.dbPersonel_Takip_OtomasyonDataSet.izinRapor);

            this.reportViewer1.RefreshReport();
        }
    }
}
