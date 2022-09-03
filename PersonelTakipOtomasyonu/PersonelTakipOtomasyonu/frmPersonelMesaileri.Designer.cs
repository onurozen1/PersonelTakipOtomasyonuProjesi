namespace PersonelTakipOtomasyonu
{
    partial class frmPersonelMesaileri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelMesaileri));
            this.dataGridViewPersoneller = new System.Windows.Forms.DataGridView();
            this.dataGridViewMesailer = new System.Windows.Forms.DataGridView();
            this.lblKayıtSayisi = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMesaiID = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesailer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersoneller
            // 
            this.dataGridViewPersoneller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewPersoneller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersoneller.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPersoneller.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPersoneller.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPersoneller.Name = "dataGridViewPersoneller";
            this.dataGridViewPersoneller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersoneller.Size = new System.Drawing.Size(259, 686);
            this.dataGridViewPersoneller.TabIndex = 0;
            this.dataGridViewPersoneller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPersoneller_CellClick);
            // 
            // dataGridViewMesailer
            // 
            this.dataGridViewMesailer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMesailer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMesailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesailer.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMesailer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMesailer.Location = new System.Drawing.Point(277, 12);
            this.dataGridViewMesailer.Name = "dataGridViewMesailer";
            this.dataGridViewMesailer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMesailer.Size = new System.Drawing.Size(886, 534);
            this.dataGridViewMesailer.TabIndex = 1;
            // 
            // lblKayıtSayisi
            // 
            this.lblKayıtSayisi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblKayıtSayisi.AutoSize = true;
            this.lblKayıtSayisi.Location = new System.Drawing.Point(861, 606);
            this.lblKayıtSayisi.Name = "lblKayıtSayisi";
            this.lblKayıtSayisi.Size = new System.Drawing.Size(183, 19);
            this.lblKayıtSayisi.TabIndex = 2;
            this.lblKayıtSayisi.Text = "Toplam 26 kayıt listelendi .";
            // 
            // lblTutar
            // 
            this.lblTutar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(861, 631);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(269, 19);
            this.lblTutar.TabIndex = 2;
            this.lblTutar.Text = "Toplam mesai ücret tutarı 5400000 TL .";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(850, 605);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 21);
            this.label19.TabIndex = 43;
            this.label19.Text = "!";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(850, 630);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "!";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 602);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Mesai ID Ara :";
            // 
            // txtMesaiID
            // 
            this.txtMesaiID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtMesaiID.BackColor = System.Drawing.SystemColors.Info;
            this.txtMesaiID.Location = new System.Drawing.Point(325, 624);
            this.txtMesaiID.Name = "txtMesaiID";
            this.txtMesaiID.Size = new System.Drawing.Size(138, 26);
            this.txtMesaiID.TabIndex = 46;
            this.txtMesaiID.TextChanged += new System.EventHandler(this.txtMesaiID_TextChanged);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPersonelID.BackColor = System.Drawing.SystemColors.Control;
            this.txtPersonelID.Location = new System.Drawing.Point(496, 624);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(138, 26);
            this.txtPersonelID.TabIndex = 48;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 602);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Personel ID :";
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPersonelAdSoyad.BackColor = System.Drawing.SystemColors.Control;
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(667, 624);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(138, 26);
            this.txtPersonelAdSoyad.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 602);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Persone Ad Soyad :";
            // 
            // frmPersonelMesaileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 710);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMesaiID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblKayıtSayisi);
            this.Controls.Add(this.dataGridViewMesailer);
            this.Controls.Add(this.dataGridViewPersoneller);
            this.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonelMesaileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Mesaileri";
            this.Load += new System.EventHandler(this.frmPersonelMesaileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersoneller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesailer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersoneller;
        private System.Windows.Forms.DataGridView dataGridViewMesailer;
        private System.Windows.Forms.Label lblKayıtSayisi;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMesaiID;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.Label label4;
    }
}