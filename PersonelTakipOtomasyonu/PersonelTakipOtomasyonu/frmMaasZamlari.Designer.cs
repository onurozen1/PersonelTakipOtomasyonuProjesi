namespace PersonelTakipOtomasyonu
{
    partial class frmMaasZamlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaasZamlari));
            this.radioYuzde = new System.Windows.Forms.RadioButton();
            this.radioFiyat = new System.Windows.Forms.RadioButton();
            this.txtYuzde = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboPersonel = new System.Windows.Forms.ComboBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOnay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPersonelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioYuzde
            // 
            this.radioYuzde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioYuzde.AutoSize = true;
            this.radioYuzde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioYuzde.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioYuzde.Location = new System.Drawing.Point(140, 36);
            this.radioYuzde.Name = "radioYuzde";
            this.radioYuzde.Size = new System.Drawing.Size(121, 25);
            this.radioYuzde.TabIndex = 0;
            this.radioYuzde.Text = "Yüzdeye Göre";
            this.radioYuzde.UseVisualStyleBackColor = true;
            this.radioYuzde.CheckedChanged += new System.EventHandler(this.radioYuzde_CheckedChanged);
            // 
            // radioFiyat
            // 
            this.radioFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioFiyat.AutoSize = true;
            this.radioFiyat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioFiyat.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioFiyat.Location = new System.Drawing.Point(288, 36);
            this.radioFiyat.Name = "radioFiyat";
            this.radioFiyat.Size = new System.Drawing.Size(105, 25);
            this.radioFiyat.TabIndex = 1;
            this.radioFiyat.Text = "Fiyata Göre";
            this.radioFiyat.UseVisualStyleBackColor = true;
            this.radioFiyat.CheckedChanged += new System.EventHandler(this.radioFiyat_CheckedChanged);
            // 
            // txtYuzde
            // 
            this.txtYuzde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYuzde.Location = new System.Drawing.Point(140, 180);
            this.txtYuzde.Name = "txtYuzde";
            this.txtYuzde.Size = new System.Drawing.Size(221, 26);
            this.txtYuzde.TabIndex = 5;
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
            this.comboAy.Location = new System.Drawing.Point(140, 94);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(121, 27);
            this.comboAy.TabIndex = 2;
            // 
            // comboYil
            // 
            this.comboYil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(288, 94);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(121, 27);
            this.comboYil.TabIndex = 3;
            // 
            // comboPersonel
            // 
            this.comboPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPersonel.FormattingEnabled = true;
            this.comboPersonel.Items.AddRange(new object[] {
            "TÜM PERSONELLER"});
            this.comboPersonel.Location = new System.Drawing.Point(140, 137);
            this.comboPersonel.Name = "comboPersonel";
            this.comboPersonel.Size = new System.Drawing.Size(269, 27);
            this.comboPersonel.TabIndex = 4;
            this.comboPersonel.SelectedIndexChanged += new System.EventHandler(this.comboPersonel_SelectedIndexChanged);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiyat.Location = new System.Drawing.Point(140, 222);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(221, 26);
            this.txtFiyat.TabIndex = 6;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAciklama.Location = new System.Drawing.Point(140, 264);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(974, 335);
            this.txtAciklama.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dönem :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Personel :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yüzde(%) :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fiyat(TL) :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "/";
            // 
            // btnOnay
            // 
            this.btnOnay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnay.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOnay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnay.FlatAppearance.BorderSize = 0;
            this.btnOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnay.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnay.Location = new System.Drawing.Point(415, 627);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(341, 57);
            this.btnOnay.TabIndex = 8;
            this.btnOnay.Text = "Onay";
            this.btnOnay.UseVisualStyleBackColor = false;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Açıklama :";
            // 
            // lblPersonelId
            // 
            this.lblPersonelId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPersonelId.AutoSize = true;
            this.lblPersonelId.Location = new System.Drawing.Point(415, 140);
            this.lblPersonelId.Name = "lblPersonelId";
            this.lblPersonelId.Size = new System.Drawing.Size(18, 19);
            this.lblPersonelId.TabIndex = 8;
            this.lblPersonelId.Text = "0";
            // 
            // frmMaasZamlari
            // 
            this.AcceptButton = this.btnOnay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 710);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPersonelId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.comboPersonel);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtYuzde);
            this.Controls.Add(this.radioFiyat);
            this.Controls.Add(this.radioYuzde);
            this.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMaasZamlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Maaş Zam Sayfası";
            this.Load += new System.EventHandler(this.frmMaasZamlari_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioYuzde;
        private System.Windows.Forms.RadioButton radioFiyat;
        private System.Windows.Forms.TextBox txtYuzde;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboPersonel;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPersonelId;
    }
}