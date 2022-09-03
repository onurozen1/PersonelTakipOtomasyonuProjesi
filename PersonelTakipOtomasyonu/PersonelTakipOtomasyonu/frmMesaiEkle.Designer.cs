namespace PersonelTakipOtomasyonu
{
    partial class frmMesaiEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesaiEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPersonelAdSoyad = new System.Windows.Forms.ComboBox();
            this.maskedBaslangıcSaat = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.maskedBitisSaat = new System.Windows.Forms.MaskedTextBox();
            this.txtMesaiSaatUcreti = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnMesaiEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(407, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(370, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlangıç Saati :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(401, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bitiş Saati :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(357, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mesai Saat Ücreti :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(428, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tutar :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(417, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dönem :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(407, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Açıklama :";
            // 
            // comboPersonelAdSoyad
            // 
            this.comboPersonelAdSoyad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboPersonelAdSoyad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPersonelAdSoyad.FormattingEnabled = true;
            this.comboPersonelAdSoyad.Location = new System.Drawing.Point(481, 96);
            this.comboPersonelAdSoyad.Name = "comboPersonelAdSoyad";
            this.comboPersonelAdSoyad.Size = new System.Drawing.Size(218, 27);
            this.comboPersonelAdSoyad.TabIndex = 8;
            this.comboPersonelAdSoyad.SelectedIndexChanged += new System.EventHandler(this.comboPersonelAdSoyad_SelectedIndexChanged);
            // 
            // maskedBaslangıcSaat
            // 
            this.maskedBaslangıcSaat.Location = new System.Drawing.Point(624, 151);
            this.maskedBaslangıcSaat.Mask = "00:00";
            this.maskedBaslangıcSaat.Name = "maskedBaslangıcSaat";
            this.maskedBaslangıcSaat.Size = new System.Drawing.Size(75, 26);
            this.maskedBaslangıcSaat.TabIndex = 10;
            this.maskedBaslangıcSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedBaslangıcSaat.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(481, 151);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(128, 26);
            this.dateTimeBaslangic.TabIndex = 11;
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(481, 205);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(128, 26);
            this.dateTimeBitis.TabIndex = 13;
            // 
            // maskedBitisSaat
            // 
            this.maskedBitisSaat.Location = new System.Drawing.Point(624, 205);
            this.maskedBitisSaat.Mask = "00:00";
            this.maskedBitisSaat.Name = "maskedBitisSaat";
            this.maskedBitisSaat.Size = new System.Drawing.Size(75, 26);
            this.maskedBitisSaat.TabIndex = 12;
            this.maskedBitisSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedBitisSaat.ValidatingType = typeof(System.DateTime);
            // 
            // txtMesaiSaatUcreti
            // 
            this.txtMesaiSaatUcreti.Location = new System.Drawing.Point(481, 259);
            this.txtMesaiSaatUcreti.Name = "txtMesaiSaatUcreti";
            this.txtMesaiSaatUcreti.Size = new System.Drawing.Size(128, 26);
            this.txtMesaiSaatUcreti.TabIndex = 14;
            this.txtMesaiSaatUcreti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesaiSaatUcreti.TextChanged += new System.EventHandler(this.txtMesaiSaatUcreti_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(481, 313);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(128, 26);
            this.txtTutar.TabIndex = 15;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // comboAy
            // 
            this.comboAy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboAy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboAy.Location = new System.Drawing.Point(481, 367);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(84, 27);
            this.comboAy.TabIndex = 16;
            // 
            // comboYil
            // 
            this.comboYil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(592, 367);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(84, 27);
            this.comboYil.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(571, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "/";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(481, 422);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(218, 86);
            this.txtAciklama.TabIndex = 19;
            // 
            // btnMesaiEkle
            // 
            this.btnMesaiEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMesaiEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesaiEkle.FlatAppearance.BorderSize = 0;
            this.btnMesaiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesaiEkle.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesaiEkle.Location = new System.Drawing.Point(404, 545);
            this.btnMesaiEkle.Name = "btnMesaiEkle";
            this.btnMesaiEkle.Size = new System.Drawing.Size(336, 57);
            this.btnMesaiEkle.TabIndex = 20;
            this.btnMesaiEkle.Text = "Mesai Ekle";
            this.btnMesaiEkle.UseVisualStyleBackColor = false;
            this.btnMesaiEkle.Click += new System.EventHandler(this.btnMesaiEkle_Click);
            // 
            // frmMesaiEkle
            // 
            this.AcceptButton = this.btnMesaiEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 710);
            this.Controls.Add(this.btnMesaiEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtMesaiSaatUcreti);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.maskedBitisSaat);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.maskedBaslangıcSaat);
            this.Controls.Add(this.comboPersonelAdSoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMesaiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesai Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmMesaiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPersonelAdSoyad;
        private System.Windows.Forms.MaskedTextBox maskedBaslangıcSaat;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.MaskedTextBox maskedBitisSaat;
        private System.Windows.Forms.TextBox txtMesaiSaatUcreti;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnMesaiEkle;
    }
}