namespace OOPSinav
{
    partial class Form1
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
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pbresim = new System.Windows.Forms.PictureBox();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtIseGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.gbPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.txtresimYol = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstPersonel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).BeginInit();
            this.gbPersonelBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Items.AddRange(new object[] {
            "Yazılım",
            "Sistem",
            "Muhasebe",
            "Eğitim",
            "İdari İşler",
            "OCC",
            "AOCC"});
            this.cmbUnvan.Location = new System.Drawing.Point(577, 83);
            this.cmbUnvan.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(247, 37);
            this.cmbUnvan.TabIndex = 13;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(577, 264);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(247, 44);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(577, 216);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(247, 44);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(577, 168);
            this.btnekle.Margin = new System.Windows.Forms.Padding(2);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(247, 44);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(577, 120);
            this.btnResimSec.Margin = new System.Windows.Forms.Padding(2);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(247, 44);
            this.btnResimSec.TabIndex = 9;
            this.btnResimSec.Text = "Resim Sec";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pbresim
            // 
            this.pbresim.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbresim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbresim.Location = new System.Drawing.Point(828, 49);
            this.pbresim.Margin = new System.Windows.Forms.Padding(2);
            this.pbresim.Name = "pbresim";
            this.pbresim.Size = new System.Drawing.Size(223, 211);
            this.pbresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbresim.TabIndex = 3;
            this.pbresim.TabStop = false;
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Location = new System.Drawing.Point(160, 151);
            this.dtDogumTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtDogumTarihi.MinDate = new System.DateTime(2014, 12, 1, 0, 0, 0, 0);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(268, 35);
            this.dtDogumTarihi.TabIndex = 7;
            // 
            // dtIseGirisTarihi
            // 
            this.dtIseGirisTarihi.Location = new System.Drawing.Point(577, 49);
            this.dtIseGirisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtIseGirisTarihi.MinDate = new System.DateTime(2014, 12, 1, 0, 0, 0, 0);
            this.dtIseGirisTarihi.Name = "dtIseGirisTarihi";
            this.dtIseGirisTarihi.Size = new System.Drawing.Size(247, 35);
            this.dtIseGirisTarihi.TabIndex = 7;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(160, 253);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(268, 35);
            this.txtAdres.TabIndex = 6;
            // 
            // gbPersonelBilgileri
            // 
            this.gbPersonelBilgileri.Controls.Add(this.txtresimYol);
            this.gbPersonelBilgileri.Controls.Add(this.cmbUnvan);
            this.gbPersonelBilgileri.Controls.Add(this.btnSil);
            this.gbPersonelBilgileri.Controls.Add(this.btnGuncelle);
            this.gbPersonelBilgileri.Controls.Add(this.btnekle);
            this.gbPersonelBilgileri.Controls.Add(this.btnResimSec);
            this.gbPersonelBilgileri.Controls.Add(this.pbresim);
            this.gbPersonelBilgileri.Controls.Add(this.dtDogumTarihi);
            this.gbPersonelBilgileri.Controls.Add(this.dtIseGirisTarihi);
            this.gbPersonelBilgileri.Controls.Add(this.txtAdres);
            this.gbPersonelBilgileri.Controls.Add(this.txtEmail);
            this.gbPersonelBilgileri.Controls.Add(this.txtTelefon);
            this.gbPersonelBilgileri.Controls.Add(this.txtSoyad);
            this.gbPersonelBilgileri.Controls.Add(this.txtAd);
            this.gbPersonelBilgileri.Controls.Add(this.txtTcKimlikNo);
            this.gbPersonelBilgileri.Controls.Add(this.label9);
            this.gbPersonelBilgileri.Controls.Add(this.label6);
            this.gbPersonelBilgileri.Controls.Add(this.label5);
            this.gbPersonelBilgileri.Controls.Add(this.label4);
            this.gbPersonelBilgileri.Controls.Add(this.label3);
            this.gbPersonelBilgileri.Controls.Add(this.label2);
            this.gbPersonelBilgileri.Controls.Add(this.label8);
            this.gbPersonelBilgileri.Controls.Add(this.label7);
            this.gbPersonelBilgileri.Controls.Add(this.label1);
            this.gbPersonelBilgileri.Location = new System.Drawing.Point(29, 23);
            this.gbPersonelBilgileri.Margin = new System.Windows.Forms.Padding(2);
            this.gbPersonelBilgileri.Name = "gbPersonelBilgileri";
            this.gbPersonelBilgileri.Padding = new System.Windows.Forms.Padding(2);
            this.gbPersonelBilgileri.Size = new System.Drawing.Size(1077, 331);
            this.gbPersonelBilgileri.TabIndex = 7;
            this.gbPersonelBilgileri.TabStop = false;
            this.gbPersonelBilgileri.Text = "Personel Bilgileri";
            // 
            // txtresimYol
            // 
            this.txtresimYol.Enabled = false;
            this.txtresimYol.Location = new System.Drawing.Point(830, 266);
            this.txtresimYol.Multiline = true;
            this.txtresimYol.Name = "txtresimYol";
            this.txtresimYol.Size = new System.Drawing.Size(221, 42);
            this.txtresimYol.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 219);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 35);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(160, 185);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(268, 35);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(160, 117);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(268, 35);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(160, 83);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(268, 35);
            this.txtAd.TabIndex = 1;
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Location = new System.Drawing.Point(160, 49);
            this.txtTcKimlikNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(268, 35);
            this.txtTcKimlikNo.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 256);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Adres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dogum Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 86);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unvan:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ise Giris tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Telefon";
            this.columnHeader11.Width = 114;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "İşe Giriş Tarihi";
            this.columnHeader10.Width = 153;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Soyad";
            this.columnHeader9.Width = 95;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ad";
            this.columnHeader8.Width = 52;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TC Kimlik No";
            this.columnHeader7.Width = 119;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Email";
            this.columnHeader12.Width = 92;
            // 
            // lstPersonel
            // 
            this.lstPersonel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstPersonel.FullRowSelect = true;
            this.lstPersonel.GridLines = true;
            this.lstPersonel.Location = new System.Drawing.Point(29, 358);
            this.lstPersonel.Margin = new System.Windows.Forms.Padding(2);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(1077, 262);
            this.lstPersonel.TabIndex = 8;
            this.lstPersonel.UseCompatibleStateImageBehavior = false;
            this.lstPersonel.View = System.Windows.Forms.View.Details;
            this.lstPersonel.DoubleClick += new System.EventHandler(this.lstPersonel_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adres";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İşe Giriş Tarihi";
            this.columnHeader2.Width = 143;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ünvan";
            this.columnHeader3.Width = 94;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 643);
            this.Controls.Add(this.gbPersonelBilgileri);
            this.Controls.Add(this.lstPersonel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbresim)).EndInit();
            this.gbPersonelBilgileri.ResumeLayout(false);
            this.gbPersonelBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox pbresim;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.DateTimePicker dtIseGirisTarihi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.GroupBox gbPersonelBilgileri;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView lstPersonel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txtresimYol;
    }
}

