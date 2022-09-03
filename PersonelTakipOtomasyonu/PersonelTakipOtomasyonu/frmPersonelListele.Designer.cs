namespace PersonelTakipOtomasyonu
{
    partial class frmPersonelListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboDepartman = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblToplamKayit = new System.Windows.Forms.Label();
            this.lblToplamMaas = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTelefonAra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSoyadAra = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAdAra = new System.Windows.Forms.TextBox();
            this.txtIdAra = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 578);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "E-mail :";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmail.Location = new System.Drawing.Point(187, 575);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 26);
            this.txtEmail.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adres :";
            // 
            // txtAdres
            // 
            this.txtAdres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAdres.Location = new System.Drawing.Point(187, 611);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(147, 87);
            this.txtAdres.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 542);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefon :";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTelefon.Location = new System.Drawing.Point(187, 539);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(147, 26);
            this.txtTelefon.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Soyad :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSoyad.Location = new System.Drawing.Point(187, 503);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(147, 26);
            this.txtSoyad.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad :";
            // 
            // txtAd
            // 
            this.txtAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAd.Location = new System.Drawing.Point(187, 467);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(147, 26);
            this.txtAd.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(442, 540);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 26);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // comboDepartman
            // 
            this.comboDepartman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboDepartman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboDepartman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepartman.FormattingEnabled = true;
            this.comboDepartman.Location = new System.Drawing.Point(442, 470);
            this.comboDepartman.Name = "comboDepartman";
            this.comboDepartman.Size = new System.Drawing.Size(147, 27);
            this.comboDepartman.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(360, 614);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Açıklama :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(354, 546);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Giriş Tarihi :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 509);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Maaş :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAciklama.Location = new System.Drawing.Point(442, 611);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(147, 87);
            this.txtAciklama.TabIndex = 15;
            // 
            // txtMaas
            // 
            this.txtMaas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMaas.Location = new System.Drawing.Point(442, 506);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(100, 26);
            this.txtMaas.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Departman :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "ID :";
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(187, 431);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(147, 26);
            this.txtId.TabIndex = 4;
            // 
            // lblToplamKayit
            // 
            this.lblToplamKayit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblToplamKayit.AutoSize = true;
            this.lblToplamKayit.Location = new System.Drawing.Point(694, 444);
            this.lblToplamKayit.Name = "lblToplamKayit";
            this.lblToplamKayit.Size = new System.Drawing.Size(183, 19);
            this.lblToplamKayit.TabIndex = 32;
            this.lblToplamKayit.Text = "Toplam 85 kayıt listelendi .";
            // 
            // lblToplamMaas
            // 
            this.lblToplamMaas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblToplamMaas.AutoSize = true;
            this.lblToplamMaas.Location = new System.Drawing.Point(694, 470);
            this.lblToplamMaas.Name = "lblToplamMaas";
            this.lblToplamMaas.Size = new System.Drawing.Size(315, 19);
            this.lblToplamMaas.TabIndex = 33;
            this.lblToplamMaas.Text = "Listede toplam 55000,85 TL maaş hesaplandı .";
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCikis.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.ImageIndex = 2;
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(941, 593);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(123, 50);
            this.btnCikis.TabIndex = 18;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "male-user-edit.png");
            this.ımageList1.Images.SetKeyName(1, "male-user-remove.png");
            this.ımageList1.Images.SetKeyName(2, "3094700.png");
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuncelle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageIndex = 0;
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(653, 593);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(123, 50);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageIndex = 1;
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(797, 593);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(123, 50);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtTelefonAra);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtSoyadAra);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtAdAra);
            this.groupBox1.Controls.Add(this.txtIdAra);
            this.groupBox1.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 76);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Arama Paneli";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(772, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 19);
            this.label16.TabIndex = 43;
            this.label16.Text = "Telefon :";
            // 
            // txtTelefonAra
            // 
            this.txtTelefonAra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefonAra.BackColor = System.Drawing.SystemColors.Info;
            this.txtTelefonAra.Location = new System.Drawing.Point(849, 31);
            this.txtTelefonAra.Name = "txtTelefonAra";
            this.txtTelefonAra.Size = new System.Drawing.Size(147, 26);
            this.txtTelefonAra.TabIndex = 3;
            this.txtTelefonAra.TextChanged += new System.EventHandler(this.txtTelefonAra_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(543, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 19);
            this.label15.TabIndex = 41;
            this.label15.Text = "Soyad :";
            // 
            // txtSoyadAra
            // 
            this.txtSoyadAra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoyadAra.BackColor = System.Drawing.SystemColors.Info;
            this.txtSoyadAra.Location = new System.Drawing.Point(612, 31);
            this.txtSoyadAra.Name = "txtSoyadAra";
            this.txtSoyadAra.Size = new System.Drawing.Size(147, 26);
            this.txtSoyadAra.TabIndex = 2;
            this.txtSoyadAra.TextChanged += new System.EventHandler(this.txtSoyadAra_TextChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(337, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 19);
            this.label14.TabIndex = 39;
            this.label14.Text = "Ad :";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(135, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 19);
            this.label13.TabIndex = 39;
            this.label13.Text = "ID :";
            // 
            // txtAdAra
            // 
            this.txtAdAra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAdAra.BackColor = System.Drawing.SystemColors.Info;
            this.txtAdAra.Location = new System.Drawing.Point(383, 31);
            this.txtAdAra.Name = "txtAdAra";
            this.txtAdAra.Size = new System.Drawing.Size(147, 26);
            this.txtAdAra.TabIndex = 1;
            this.txtAdAra.TextChanged += new System.EventHandler(this.txtAdAra_TextChanged);
            // 
            // txtIdAra
            // 
            this.txtIdAra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdAra.BackColor = System.Drawing.SystemColors.Info;
            this.txtIdAra.Location = new System.Drawing.Point(177, 31);
            this.txtIdAra.Name = "txtIdAra";
            this.txtIdAra.Size = new System.Drawing.Size(147, 26);
            this.txtIdAra.TabIndex = 0;
            this.txtIdAra.TextChanged += new System.EventHandler(this.txtIdAra_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(442, 575);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(147, 26);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(353, 581);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 19);
            this.label17.TabIndex = 39;
            this.label17.Text = "Çıkış Tarihi :";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(375, 437);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 19);
            this.label18.TabIndex = 41;
            this.label18.Text = "Durum :";
            // 
            // txtDurum
            // 
            this.txtDurum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDurum.Location = new System.Drawing.Point(442, 434);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(147, 26);
            this.txtDurum.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(680, 443);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 21);
            this.label19.TabIndex = 42;
            this.label19.Text = "!";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(680, 469);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 21);
            this.label20.TabIndex = 43;
            this.label20.Text = "!";
            // 
            // frmPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 710);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lblToplamMaas);
            this.Controls.Add(this.lblToplamKayit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboDepartman);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPersonelListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Arama , Silme ve Güncelleme Sayfası";
            this.Load += new System.EventHandler(this.frmPersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboDepartman;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblToplamKayit;
        private System.Windows.Forms.Label lblToplamMaas;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTelefonAra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSoyadAra;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAdAra;
        private System.Windows.Forms.TextBox txtIdAra;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}