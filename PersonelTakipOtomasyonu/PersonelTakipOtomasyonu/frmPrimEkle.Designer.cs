namespace PersonelTakipOtomasyonu
{
    partial class frmPrimEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimEkle));
            this.radioKisiyeOzel = new System.Windows.Forms.RadioButton();
            this.radioTumPersoneller = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPrimTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnPrimleriGoster = new System.Windows.Forms.Button();
            this.btnPersonelPrimleri = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioKisiyeOzel
            // 
            this.radioKisiyeOzel.AutoSize = true;
            this.radioKisiyeOzel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioKisiyeOzel.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioKisiyeOzel.Location = new System.Drawing.Point(351, 21);
            this.radioKisiyeOzel.Name = "radioKisiyeOzel";
            this.radioKisiyeOzel.Size = new System.Drawing.Size(134, 25);
            this.radioKisiyeOzel.TabIndex = 2;
            this.radioKisiyeOzel.Text = "Kişiye Özel Prim";
            this.toolTip1.SetToolTip(this.radioKisiyeOzel, "Tablodan prim vermek istediğiniz kişiye çift tıklayınız.");
            this.radioKisiyeOzel.UseVisualStyleBackColor = true;
            // 
            // radioTumPersoneller
            // 
            this.radioTumPersoneller.AutoSize = true;
            this.radioTumPersoneller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioTumPersoneller.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioTumPersoneller.Location = new System.Drawing.Point(623, 21);
            this.radioTumPersoneller.Name = "radioTumPersoneller";
            this.radioTumPersoneller.Size = new System.Drawing.Size(200, 25);
            this.radioTumPersoneller.TabIndex = 3;
            this.radioTumPersoneller.Text = "Tüm Personeller İçin Prim";
            this.toolTip2.SetToolTip(this.radioTumPersoneller, "Tüm personellere prim vermek için tıklayınız.");
            this.radioTumPersoneller.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "/";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dönem :";
            // 
            // comboYil
            // 
            this.comboYil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboYil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(378, 194);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(94, 27);
            this.comboYil.TabIndex = 10;
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
            this.comboAy.Location = new System.Drawing.Point(253, 194);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(94, 27);
            this.comboAy.TabIndex = 9;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPersonelID.Enabled = false;
            this.txtPersonelID.Location = new System.Drawing.Point(253, 104);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(94, 26);
            this.txtPersonelID.TabIndex = 13;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPersonelAdSoyad.Enabled = false;
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(253, 149);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(219, 26);
            this.txtPersonelAdSoyad.TabIndex = 14;
            // 
            // txtPrimTutar
            // 
            this.txtPrimTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPrimTutar.Location = new System.Drawing.Point(628, 101);
            this.txtPrimTutar.Name = "txtPrimTutar";
            this.txtPrimTutar.Size = new System.Drawing.Size(94, 26);
            this.txtPrimTutar.TabIndex = 15;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAciklama.Location = new System.Drawing.Point(628, 146);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(347, 106);
            this.txtAciklama.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Personel Id :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Personel Ad Soyad :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pirim Tutar :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Açıklama :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
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
            this.dataGridView1.Location = new System.Drawing.Point(7, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1138, 313);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(123, 301);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(248, 40);
            this.btnEkle.TabIndex = 24;
            this.btnEkle.Text = "Prim Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnPrimleriGoster
            // 
            this.btnPrimleriGoster.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrimleriGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimleriGoster.FlatAppearance.BorderSize = 0;
            this.btnPrimleriGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimleriGoster.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrimleriGoster.Location = new System.Drawing.Point(450, 301);
            this.btnPrimleriGoster.Name = "btnPrimleriGoster";
            this.btnPrimleriGoster.Size = new System.Drawing.Size(248, 40);
            this.btnPrimleriGoster.TabIndex = 25;
            this.btnPrimleriGoster.Text = "Prim İşlemleri";
            this.btnPrimleriGoster.UseVisualStyleBackColor = false;
            this.btnPrimleriGoster.Click += new System.EventHandler(this.btnPrimleriGoster_Click);
            // 
            // btnPersonelPrimleri
            // 
            this.btnPersonelPrimleri.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPersonelPrimleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelPrimleri.FlatAppearance.BorderSize = 0;
            this.btnPersonelPrimleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelPrimleri.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelPrimleri.Location = new System.Drawing.Point(777, 301);
            this.btnPersonelPrimleri.Name = "btnPersonelPrimleri";
            this.btnPersonelPrimleri.Size = new System.Drawing.Size(248, 40);
            this.btnPersonelPrimleri.TabIndex = 26;
            this.btnPersonelPrimleri.Text = "Personel Primleri";
            this.toolTip3.SetToolTip(this.btnPersonelPrimleri, "Tabloda seçili olduğu personelin primlerini gösterir.");
            this.btnPersonelPrimleri.UseVisualStyleBackColor = false;
            this.btnPersonelPrimleri.Click += new System.EventHandler(this.btnPersonelPrimleri_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Bilgilendirme";
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Bilgilendirme";
            // 
            // toolTip3
            // 
            this.toolTip3.IsBalloon = true;
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip3.ToolTipTitle = "Personel Primleri";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 347);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personeller";
            // 
            // frmPrimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 710);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPersonelPrimleri);
            this.Controls.Add(this.btnPrimleriGoster);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutar);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.radioTumPersoneller);
            this.Controls.Add(this.radioKisiyeOzel);
            this.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrimEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prim Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmPrimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioKisiyeOzel;
        private System.Windows.Forms.RadioButton radioTumPersoneller;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.TextBox txtPrimTutar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnPrimleriGoster;
        private System.Windows.Forms.Button btnPersonelPrimleri;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}