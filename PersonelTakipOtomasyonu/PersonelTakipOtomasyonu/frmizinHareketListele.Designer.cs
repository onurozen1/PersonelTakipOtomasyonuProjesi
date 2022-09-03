namespace PersonelTakipOtomasyonu
{
    partial class frmizinHareketListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmizinHareketListele));
            this.btnizinTurleri = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtizinHareketID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.comboizinTuru = new System.Windows.Forms.ComboBox();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExceleAktar = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnizinTurleri
            // 
            this.btnizinTurleri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnizinTurleri.BackColor = System.Drawing.Color.Gainsboro;
            this.btnizinTurleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnizinTurleri.FlatAppearance.BorderSize = 0;
            this.btnizinTurleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnizinTurleri.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnizinTurleri.Location = new System.Drawing.Point(43, 639);
            this.btnizinTurleri.Name = "btnizinTurleri";
            this.btnizinTurleri.Size = new System.Drawing.Size(160, 38);
            this.btnizinTurleri.TabIndex = 1;
            this.btnizinTurleri.Text = "İzin Türleri";
            this.btnizinTurleri.UseVisualStyleBackColor = false;
            this.btnizinTurleri.Click += new System.EventHandler(this.btnizinTurleri_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGuncelle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(592, 639);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(160, 38);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(409, 639);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(160, 38);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.toolTip1.SetToolTip(this.btnSil, "Silmek istediğiniz kayıda tıklayınız .");
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(226, 639);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(160, 38);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtizinHareketID
            // 
            this.txtizinHareketID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtizinHareketID.Enabled = false;
            this.txtizinHareketID.Location = new System.Drawing.Point(253, 453);
            this.txtizinHareketID.Name = "txtizinHareketID";
            this.txtizinHareketID.Size = new System.Drawing.Size(89, 26);
            this.txtizinHareketID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "İzin Hareket ID :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Personel ID :";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPersonelID.Location = new System.Drawing.Point(253, 496);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(89, 26);
            this.txtPersonelID.TabIndex = 8;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Personel Ad Soyad :";
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPersonelAdSoyad.Enabled = false;
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(253, 539);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(170, 26);
            this.txtPersonelAdSoyad.TabIndex = 10;
            // 
            // comboizinTuru
            // 
            this.comboizinTuru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboizinTuru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboizinTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboizinTuru.FormattingEnabled = true;
            this.comboizinTuru.Location = new System.Drawing.Point(540, 452);
            this.comboizinTuru.Name = "comboizinTuru";
            this.comboizinTuru.Size = new System.Drawing.Size(170, 27);
            this.comboizinTuru.TabIndex = 12;
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimeBaslangic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(540, 496);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(125, 26);
            this.dateTimeBaslangic.TabIndex = 13;
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimeBitis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(540, 539);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(125, 26);
            this.dateTimeBitis.TabIndex = 14;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAciklama.Location = new System.Drawing.Point(837, 452);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(170, 91);
            this.txtAciklama.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "İzin Türü :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Başlangıç :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Bitiş :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(755, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Açıklama :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 398);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Silme İşlemi";
            // 
            // btnExceleAktar
            // 
            this.btnExceleAktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnExceleAktar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExceleAktar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExceleAktar.FlatAppearance.BorderSize = 0;
            this.btnExceleAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExceleAktar.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExceleAktar.Location = new System.Drawing.Point(775, 639);
            this.btnExceleAktar.Name = "btnExceleAktar";
            this.btnExceleAktar.Size = new System.Drawing.Size(160, 38);
            this.btnExceleAktar.TabIndex = 21;
            this.btnExceleAktar.Text = "Excel";
            this.btnExceleAktar.UseVisualStyleBackColor = false;
            this.btnExceleAktar.Click += new System.EventHandler(this.btnExceleAktar_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRapor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRapor.FlatAppearance.BorderSize = 0;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.Location = new System.Drawing.Point(958, 639);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(160, 38);
            this.btnRapor.TabIndex = 22;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // frmizinHareketListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 710);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnExceleAktar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.comboizinTuru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtizinHareketID);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnizinTurleri);
            this.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmizinHareketListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Hareketleri Sayfası";
            this.Load += new System.EventHandler(this.frmizinHareketListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnizinTurleri;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtizinHareketID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.ComboBox comboizinTuru;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnExceleAktar;
        private System.Windows.Forms.Button btnRapor;
    }
}