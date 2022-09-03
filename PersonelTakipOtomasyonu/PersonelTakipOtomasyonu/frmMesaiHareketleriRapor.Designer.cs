namespace PersonelTakipOtomasyonu
{
    partial class frmMesaiHareketleriRapor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesaiHareketleriRapor));
            this.MesaiRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbPersonel_Takip_OtomasyonDataSet = new PersonelTakipOtomasyonu.dbPersonel_Takip_OtomasyonDataSet();
            this.MesaiRaporTableAdapter = new PersonelTakipOtomasyonu.dbPersonel_Takip_OtomasyonDataSetTableAdapters.MesaiRaporTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.MesaiRaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPersonel_Takip_OtomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MesaiRaporBindingSource
            // 
            this.MesaiRaporBindingSource.DataMember = "MesaiRapor";
            this.MesaiRaporBindingSource.DataSource = this.dbPersonel_Takip_OtomasyonDataSet;
            // 
            // dbPersonel_Takip_OtomasyonDataSet
            // 
            this.dbPersonel_Takip_OtomasyonDataSet.DataSetName = "dbPersonel_Takip_OtomasyonDataSet";
            this.dbPersonel_Takip_OtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MesaiRaporTableAdapter
            // 
            this.MesaiRaporTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MesaiRaporBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonelTakipOtomasyonu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1037, 514);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmMesaiHareketleriRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 514);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMesaiHareketleriRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesai Hareketleri Rapor Sayfası";
            this.Load += new System.EventHandler(this.frmMesaiHareketleriRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MesaiRaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPersonel_Takip_OtomasyonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource MesaiRaporBindingSource;
        private dbPersonel_Takip_OtomasyonDataSet dbPersonel_Takip_OtomasyonDataSet;
        private dbPersonel_Takip_OtomasyonDataSetTableAdapters.MesaiRaporTableAdapter MesaiRaporTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}