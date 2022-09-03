namespace PersonelTakipOtomasyonu
{
    partial class frmMesailer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMesailer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.maskedBitisSaat = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.maskedBaslangıcSaat = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtMesaiSaatUcreti = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtMesaiID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTumMesaileriOde = new System.Windows.Forms.Button();
            this.btnMesaiOde = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnMesaiSil = new System.Windows.Forms.Button();
            this.btnPersonelMesaileri = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRapor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1139, 374);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(494, 507);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(117, 26);
            this.dateTimeBitis.TabIndex = 19;
            // 
            // maskedBitisSaat
            // 
            this.maskedBitisSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.maskedBitisSaat.Location = new System.Drawing.Point(617, 507);
            this.maskedBitisSaat.Mask = "00:00";
            this.maskedBitisSaat.Name = "maskedBitisSaat";
            this.maskedBitisSaat.Size = new System.Drawing.Size(52, 26);
            this.maskedBitisSaat.TabIndex = 18;
            this.maskedBitisSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedBitisSaat.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(494, 453);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(117, 26);
            this.dateTimeBaslangic.TabIndex = 17;
            // 
            // maskedBaslangıcSaat
            // 
            this.maskedBaslangıcSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.maskedBaslangıcSaat.Location = new System.Drawing.Point(617, 453);
            this.maskedBaslangıcSaat.Mask = "00:00";
            this.maskedBaslangıcSaat.Name = "maskedBaslangıcSaat";
            this.maskedBaslangıcSaat.Size = new System.Drawing.Size(52, 26);
            this.maskedBaslangıcSaat.TabIndex = 16;
            this.maskedBaslangıcSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedBaslangıcSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(491, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Bitiş Saati :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(491, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Başlangıç Saati :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAciklama.Location = new System.Drawing.Point(732, 566);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(203, 74);
            this.txtAciklama.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(574, 569);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "/";
            // 
            // comboYil
            // 
            this.comboYil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboYil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(592, 565);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(77, 27);
            this.comboYil.TabIndex = 27;
            // 
            // comboAy
            // 
            this.comboAy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.comboAy.Location = new System.Drawing.Point(494, 566);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(77, 27);
            this.comboAy.TabIndex = 26;
            // 
            // txtTutar
            // 
            this.txtTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTutar.Location = new System.Drawing.Point(732, 507);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(115, 26);
            this.txtTutar.TabIndex = 25;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // txtMesaiSaatUcreti
            // 
            this.txtMesaiSaatUcreti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMesaiSaatUcreti.Location = new System.Drawing.Point(732, 453);
            this.txtMesaiSaatUcreti.Name = "txtMesaiSaatUcreti";
            this.txtMesaiSaatUcreti.Size = new System.Drawing.Size(115, 26);
            this.txtMesaiSaatUcreti.TabIndex = 24;
            this.txtMesaiSaatUcreti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesaiSaatUcreti.TextChanged += new System.EventHandler(this.txtMesaiSaatUcreti_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(729, 545);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Açıklama :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(491, 545);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Dönem :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(729, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tutar :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(729, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mesai Saat Ücreti :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(252, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Personel ID :";
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPersonelID.Location = new System.Drawing.Point(255, 511);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(175, 26);
            this.txtPersonelID.TabIndex = 32;
            this.txtPersonelID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // txtMesaiID
            // 
            this.txtMesaiID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMesaiID.Enabled = false;
            this.txtMesaiID.Location = new System.Drawing.Point(255, 453);
            this.txtMesaiID.Name = "txtMesaiID";
            this.txtMesaiID.Size = new System.Drawing.Size(175, 26);
            this.txtMesaiID.TabIndex = 34;
            this.txtMesaiID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(252, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mesai ID :";
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPersonelAdSoyad.Enabled = false;
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(255, 569);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(175, 26);
            this.txtPersonelAdSoyad.TabIndex = 36;
            this.txtPersonelAdSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(252, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 18);
            this.label10.TabIndex = 35;
            this.label10.Text = "Personel Ad Soyad :";
            // 
            // btnTumMesaileriOde
            // 
            this.btnTumMesaileriOde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnTumMesaileriOde.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTumMesaileriOde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTumMesaileriOde.FlatAppearance.BorderSize = 0;
            this.btnTumMesaileriOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumMesaileriOde.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumMesaileriOde.Location = new System.Drawing.Point(56, 663);
            this.btnTumMesaileriOde.Name = "btnTumMesaileriOde";
            this.btnTumMesaileriOde.Size = new System.Drawing.Size(160, 35);
            this.btnTumMesaileriOde.TabIndex = 37;
            this.btnTumMesaileriOde.Text = "Tüm Mesaileri Öde";
            this.btnTumMesaileriOde.UseVisualStyleBackColor = false;
            this.btnTumMesaileriOde.Click += new System.EventHandler(this.btnTumMesaileriOde_Click);
            // 
            // btnMesaiOde
            // 
            this.btnMesaiOde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnMesaiOde.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMesaiOde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesaiOde.FlatAppearance.BorderSize = 0;
            this.btnMesaiOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesaiOde.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesaiOde.Location = new System.Drawing.Point(238, 663);
            this.btnMesaiOde.Name = "btnMesaiOde";
            this.btnMesaiOde.Size = new System.Drawing.Size(160, 35);
            this.btnMesaiOde.TabIndex = 38;
            this.btnMesaiOde.Text = "Mesai Öde";
            this.btnMesaiOde.UseVisualStyleBackColor = false;
            this.btnMesaiOde.Click += new System.EventHandler(this.btnMesaiOde_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnGuncelle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(420, 663);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(160, 35);
            this.btnGuncelle.TabIndex = 39;
            this.btnGuncelle.Text = "Mesai Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnMesaiSil
            // 
            this.btnMesaiSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnMesaiSil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMesaiSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesaiSil.FlatAppearance.BorderSize = 0;
            this.btnMesaiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesaiSil.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesaiSil.Location = new System.Drawing.Point(602, 663);
            this.btnMesaiSil.Name = "btnMesaiSil";
            this.btnMesaiSil.Size = new System.Drawing.Size(160, 35);
            this.btnMesaiSil.TabIndex = 40;
            this.btnMesaiSil.Text = "Mesai Sil";
            this.btnMesaiSil.UseVisualStyleBackColor = false;
            this.btnMesaiSil.Click += new System.EventHandler(this.btnMesaiSil_Click);
            // 
            // btnPersonelMesaileri
            // 
            this.btnPersonelMesaileri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPersonelMesaileri.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPersonelMesaileri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelMesaileri.FlatAppearance.BorderSize = 0;
            this.btnPersonelMesaileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelMesaileri.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelMesaileri.Location = new System.Drawing.Point(784, 663);
            this.btnPersonelMesaileri.Name = "btnPersonelMesaileri";
            this.btnPersonelMesaileri.Size = new System.Drawing.Size(160, 35);
            this.btnPersonelMesaileri.TabIndex = 41;
            this.btnPersonelMesaileri.Text = "Personel Mesaileri";
            this.btnPersonelMesaileri.UseVisualStyleBackColor = false;
            this.btnPersonelMesaileri.Click += new System.EventHandler(this.btnPersonelMesaileri_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 405);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesailer";
            // 
            // btnRapor
            // 
            this.btnRapor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRapor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRapor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRapor.FlatAppearance.BorderSize = 0;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.Location = new System.Drawing.Point(966, 663);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(160, 35);
            this.btnRapor.TabIndex = 43;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // frmMesailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 710);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPersonelMesaileri);
            this.Controls.Add(this.btnMesaiSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnMesaiOde);
            this.Controls.Add(this.btnTumMesaileriOde);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMesaiID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtMesaiSaatUcreti);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.maskedBitisSaat);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.maskedBaslangıcSaat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMesailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesai İşlemleri Sayfası";
            this.Load += new System.EventHandler(this.frmMesailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.MaskedTextBox maskedBitisSaat;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.MaskedTextBox maskedBaslangıcSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtMesaiSaatUcreti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtMesaiID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTumMesaileriOde;
        private System.Windows.Forms.Button btnMesaiOde;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnMesaiSil;
        private System.Windows.Forms.Button btnPersonelMesaileri;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRapor;
    }
}