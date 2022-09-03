namespace PersonelTakipOtomasyonu
{
    partial class frmPrimleriGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimleriGoster));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTumPrimleriOde = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtPrimTutar = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrimID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.btnPrimOde = new System.Windows.Forms.Button();
            this.btnPrimGuncelle = new System.Windows.Forms.Button();
            this.btnPrimSil = new System.Windows.Forms.Button();
            this.btnDonemDegistir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.dataGridView1.Size = new System.Drawing.Size(1139, 339);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnTumPrimleriOde
            // 
            this.btnTumPrimleriOde.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTumPrimleriOde.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTumPrimleriOde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTumPrimleriOde.FlatAppearance.BorderSize = 0;
            this.btnTumPrimleriOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumPrimleriOde.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumPrimleriOde.Location = new System.Drawing.Point(97, 603);
            this.btnTumPrimleriOde.Name = "btnTumPrimleriOde";
            this.btnTumPrimleriOde.Size = new System.Drawing.Size(233, 40);
            this.btnTumPrimleriOde.TabIndex = 39;
            this.btnTumPrimleriOde.Text = "Tüm Primleri Öde";
            this.btnTumPrimleriOde.UseVisualStyleBackColor = false;
            this.btnTumPrimleriOde.Click += new System.EventHandler(this.btnTumPrimleriOde_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Açıklama :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Pirim Tutar :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Personel Ad Soyad :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Personel Id :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAciklama.Location = new System.Drawing.Point(641, 489);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(332, 95);
            this.txtAciklama.TabIndex = 34;
            // 
            // txtPrimTutar
            // 
            this.txtPrimTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPrimTutar.Location = new System.Drawing.Point(641, 452);
            this.txtPrimTutar.Name = "txtPrimTutar";
            this.txtPrimTutar.Size = new System.Drawing.Size(109, 26);
            this.txtPrimTutar.TabIndex = 33;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(285, 492);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(233, 26);
            this.txtPersonelAdSoyad.TabIndex = 32;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPersonelID.Location = new System.Drawing.Point(285, 452);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(109, 26);
            this.txtPersonelID.TabIndex = 31;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Prim Id :";
            // 
            // txtPrimID
            // 
            this.txtPrimID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPrimID.Enabled = false;
            this.txtPrimID.Location = new System.Drawing.Point(285, 413);
            this.txtPrimID.Name = "txtPrimID";
            this.txtPrimID.Size = new System.Drawing.Size(109, 26);
            this.txtPrimID.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(714, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "/";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Dönem :";
            // 
            // comboYil
            // 
            this.comboYil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.comboYil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(735, 410);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(67, 27);
            this.comboYil.TabIndex = 45;
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
            this.comboAy.Location = new System.Drawing.Point(641, 410);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(67, 27);
            this.comboAy.TabIndex = 44;
            // 
            // btnPrimOde
            // 
            this.btnPrimOde.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrimOde.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrimOde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimOde.FlatAppearance.BorderSize = 0;
            this.btnPrimOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimOde.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrimOde.Location = new System.Drawing.Point(339, 603);
            this.btnPrimOde.Name = "btnPrimOde";
            this.btnPrimOde.Size = new System.Drawing.Size(233, 40);
            this.btnPrimOde.TabIndex = 48;
            this.btnPrimOde.Text = "Prim Öde";
            this.btnPrimOde.UseVisualStyleBackColor = false;
            this.btnPrimOde.Click += new System.EventHandler(this.btnPrimOde_Click);
            // 
            // btnPrimGuncelle
            // 
            this.btnPrimGuncelle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrimGuncelle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrimGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimGuncelle.FlatAppearance.BorderSize = 0;
            this.btnPrimGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimGuncelle.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrimGuncelle.Location = new System.Drawing.Point(581, 603);
            this.btnPrimGuncelle.Name = "btnPrimGuncelle";
            this.btnPrimGuncelle.Size = new System.Drawing.Size(233, 40);
            this.btnPrimGuncelle.TabIndex = 49;
            this.btnPrimGuncelle.Text = "Prim Güncelle";
            this.btnPrimGuncelle.UseVisualStyleBackColor = false;
            this.btnPrimGuncelle.Click += new System.EventHandler(this.btnPrimGuncelle_Click);
            // 
            // btnPrimSil
            // 
            this.btnPrimSil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrimSil.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrimSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimSil.FlatAppearance.BorderSize = 0;
            this.btnPrimSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimSil.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrimSil.Location = new System.Drawing.Point(823, 603);
            this.btnPrimSil.Name = "btnPrimSil";
            this.btnPrimSil.Size = new System.Drawing.Size(233, 40);
            this.btnPrimSil.TabIndex = 50;
            this.btnPrimSil.Text = "Prim Sil";
            this.toolTip1.SetToolTip(this.btnPrimSil, "Silmek istediğiniz primin üstüne bir kere tıklamanız yeterlidir.");
            this.btnPrimSil.UseVisualStyleBackColor = false;
            this.btnPrimSil.Click += new System.EventHandler(this.btnPrimSil_Click);
            // 
            // btnDonemDegistir
            // 
            this.btnDonemDegistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonemDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnDonemDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDonemDegistir.FlatAppearance.BorderSize = 0;
            this.btnDonemDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonemDegistir.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDonemDegistir.ForeColor = System.Drawing.Color.White;
            this.btnDonemDegistir.Location = new System.Drawing.Point(826, 402);
            this.btnDonemDegistir.Name = "btnDonemDegistir";
            this.btnDonemDegistir.Size = new System.Drawing.Size(87, 44);
            this.btnDonemDegistir.TabIndex = 51;
            this.btnDonemDegistir.Text = "Dönem Değiştir";
            this.btnDonemDegistir.UseVisualStyleBackColor = false;
            this.btnDonemDegistir.Click += new System.EventHandler(this.btnDonemDegistir_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Silme İşlemi";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1151, 370);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primler";
            // 
            // frmPrimleriGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 670);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDonemDegistir);
            this.Controls.Add(this.btnPrimSil);
            this.Controls.Add(this.btnPrimGuncelle);
            this.Controls.Add(this.btnPrimOde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrimID);
            this.Controls.Add(this.btnTumPrimleriOde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutar);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrimleriGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prim İşlemleri Sayfası";
            this.Load += new System.EventHandler(this.frmPrimleriGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTumPrimleriOde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtPrimTutar;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrimID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.Button btnPrimOde;
        private System.Windows.Forms.Button btnPrimGuncelle;
        private System.Windows.Forms.Button btnPrimSil;
        private System.Windows.Forms.Button btnDonemDegistir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}