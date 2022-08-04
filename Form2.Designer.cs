namespace SiteEmlakProgrami
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSite = new System.Windows.Forms.ComboBox();
            this.cbxSatisDurum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxOda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxMetre = new System.Windows.Forms.TextBox();
            this.tbxFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxNotlar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxAdSoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxBlok = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxDaire = new System.Windows.Forms.TextBox();
            this.btnZambak = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGul = new System.Windows.Forms.Button();
            this.btnMenekse = new System.Windows.Forms.Button();
            this.btnPapatya = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSatKira = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMetre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBlok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotlar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(97, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gayrimenkul Bilgiler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Site:";
            // 
            // cbxSite
            // 
            this.cbxSite.FormattingEnabled = true;
            this.cbxSite.Items.AddRange(new object[] {
            "Zambak Sitesi",
            "Papatya Sitesi",
            "Gül Sitesi",
            "Menekşe Sitesi"});
            this.cbxSite.Location = new System.Drawing.Point(160, 82);
            this.cbxSite.Name = "cbxSite";
            this.cbxSite.Size = new System.Drawing.Size(189, 24);
            this.cbxSite.TabIndex = 2;
            this.cbxSite.SelectedIndexChanged += new System.EventHandler(this.cbxSite_SelectedIndexChanged);
            // 
            // cbxSatisDurum
            // 
            this.cbxSatisDurum.FormattingEnabled = true;
            this.cbxSatisDurum.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.cbxSatisDurum.Location = new System.Drawing.Point(160, 131);
            this.cbxSatisDurum.Name = "cbxSatisDurum";
            this.cbxSatisDurum.Size = new System.Drawing.Size(189, 24);
            this.cbxSatisDurum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(48, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sat/Kira:";
            // 
            // cbxOda
            // 
            this.cbxOda.FormattingEnabled = true;
            this.cbxOda.Items.AddRange(new object[] {
            "1+1",
            "2+1",
            "3+1",
            "4+1"});
            this.cbxOda.Location = new System.Drawing.Point(160, 181);
            this.cbxOda.Name = "cbxOda";
            this.cbxOda.Size = new System.Drawing.Size(189, 24);
            this.cbxOda.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(48, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Oda Sayisi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(48, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Metrekare:";
            // 
            // tbxMetre
            // 
            this.tbxMetre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxMetre.Location = new System.Drawing.Point(160, 231);
            this.tbxMetre.Name = "tbxMetre";
            this.tbxMetre.Size = new System.Drawing.Size(189, 22);
            this.tbxMetre.TabIndex = 8;
            // 
            // tbxFiyat
            // 
            this.tbxFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxFiyat.Location = new System.Drawing.Point(160, 283);
            this.tbxFiyat.Name = "tbxFiyat";
            this.tbxFiyat.Size = new System.Drawing.Size(189, 22);
            this.tbxFiyat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(48, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fiyat:";
            // 
            // tbxNotlar
            // 
            this.tbxNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxNotlar.Location = new System.Drawing.Point(523, 210);
            this.tbxNotlar.Multiline = true;
            this.tbxNotlar.Name = "tbxNotlar";
            this.tbxNotlar.Size = new System.Drawing.Size(189, 115);
            this.tbxNotlar.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(418, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Notlar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(502, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "İletişim Bilgileri";
            // 
            // tbxAdSoyad
            // 
            this.tbxAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdSoyad.Location = new System.Drawing.Point(523, 80);
            this.tbxAdSoyad.Name = "tbxAdSoyad";
            this.tbxAdSoyad.Size = new System.Drawing.Size(189, 22);
            this.tbxAdSoyad.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(418, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ad Soyad:";
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTelefon.Location = new System.Drawing.Point(523, 148);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(189, 22);
            this.tbxTelefon.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(418, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(46, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Blok:";
            // 
            // cbxBlok
            // 
            this.cbxBlok.FormattingEnabled = true;
            this.cbxBlok.Items.AddRange(new object[] {
            "A Blok",
            "B Blok",
            "C Blok",
            "D Blok"});
            this.cbxBlok.Location = new System.Drawing.Point(113, 340);
            this.cbxBlok.Name = "cbxBlok";
            this.cbxBlok.Size = new System.Drawing.Size(83, 24);
            this.cbxBlok.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(205, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Daire No:";
            // 
            // tbxDaire
            // 
            this.tbxDaire.Location = new System.Drawing.Point(301, 340);
            this.tbxDaire.Name = "tbxDaire";
            this.tbxDaire.Size = new System.Drawing.Size(88, 22);
            this.tbxDaire.TabIndex = 21;
            // 
            // btnZambak
            // 
            this.btnZambak.BackColor = System.Drawing.Color.Thistle;
            this.btnZambak.Location = new System.Drawing.Point(962, 52);
            this.btnZambak.Name = "btnZambak";
            this.btnZambak.Size = new System.Drawing.Size(101, 91);
            this.btnZambak.TabIndex = 22;
            this.btnZambak.Text = "Zambak";
            this.btnZambak.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(991, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "site";
            // 
            // btnGul
            // 
            this.btnGul.BackColor = System.Drawing.Color.Thistle;
            this.btnGul.Location = new System.Drawing.Point(855, 149);
            this.btnGul.Name = "btnGul";
            this.btnGul.Size = new System.Drawing.Size(101, 91);
            this.btnGul.TabIndex = 24;
            this.btnGul.Text = "Gül";
            this.btnGul.UseVisualStyleBackColor = false;
            // 
            // btnMenekse
            // 
            this.btnMenekse.BackColor = System.Drawing.Color.Thistle;
            this.btnMenekse.Location = new System.Drawing.Point(962, 249);
            this.btnMenekse.Name = "btnMenekse";
            this.btnMenekse.Size = new System.Drawing.Size(101, 91);
            this.btnMenekse.TabIndex = 25;
            this.btnMenekse.Text = "Menekşe";
            this.btnMenekse.UseVisualStyleBackColor = false;
            // 
            // btnPapatya
            // 
            this.btnPapatya.BackColor = System.Drawing.Color.Thistle;
            this.btnPapatya.Location = new System.Drawing.Point(1070, 149);
            this.btnPapatya.Name = "btnPapatya";
            this.btnPapatya.Size = new System.Drawing.Size(101, 91);
            this.btnPapatya.TabIndex = 26;
            this.btnPapatya.Text = "Papatya";
            this.btnPapatya.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colSite,
            this.colSatKira,
            this.colOda,
            this.colMetre,
            this.colFiyat,
            this.colBlok,
            this.colNo,
            this.colAdSoyad,
            this.colTelefon,
            this.colNotlar});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 459);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1141, 235);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            // 
            // colSite
            // 
            this.colSite.Text = "Site";
            this.colSite.Width = 96;
            // 
            // colSatKira
            // 
            this.colSatKira.Text = "SatKira";
            this.colSatKira.Width = 116;
            // 
            // colOda
            // 
            this.colOda.Text = "Oda";
            this.colOda.Width = 83;
            // 
            // colMetre
            // 
            this.colMetre.Text = "Metrekare";
            this.colMetre.Width = 122;
            // 
            // colFiyat
            // 
            this.colFiyat.Text = "Fiyat";
            this.colFiyat.Width = 83;
            // 
            // colBlok
            // 
            this.colBlok.Text = "Blok";
            this.colBlok.Width = 83;
            // 
            // colNo
            // 
            this.colNo.Text = "No";
            this.colNo.Width = 71;
            // 
            // colAdSoyad
            // 
            this.colAdSoyad.Text = "Ad Soyad";
            this.colAdSoyad.Width = 140;
            // 
            // colTelefon
            // 
            this.colTelefon.Text = "Telefon";
            this.colTelefon.Width = 131;
            // 
            // colNotlar
            // 
            this.colNotlar.Text = "Notlar";
            this.colNotlar.Width = 132;
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.Plum;
            this.btnGoster.Location = new System.Drawing.Point(67, 405);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(169, 48);
            this.btnGoster.TabIndex = 28;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Plum;
            this.btnKaydet.Location = new System.Drawing.Point(343, 405);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(169, 48);
            this.btnKaydet.TabIndex = 29;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Plum;
            this.btnSil.Location = new System.Drawing.Point(644, 405);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(169, 48);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.Plum;
            this.btnDuzenle.Location = new System.Drawing.Point(917, 405);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(169, 48);
            this.btnDuzenle.TabIndex = 31;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1206, 717);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnPapatya);
            this.Controls.Add(this.btnMenekse);
            this.Controls.Add(this.btnGul);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnZambak);
            this.Controls.Add(this.tbxDaire);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbxBlok);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxTelefon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxAdSoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxNotlar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxFiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxMetre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxOda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxSatisDurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form2";
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSite;
        private System.Windows.Forms.ComboBox cbxSatisDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxOda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxMetre;
        private System.Windows.Forms.TextBox tbxFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxNotlar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxAdSoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxBlok;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxDaire;
        private System.Windows.Forms.Button btnZambak;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnGul;
        private System.Windows.Forms.Button btnMenekse;
        private System.Windows.Forms.Button btnPapatya;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colSite;
        private System.Windows.Forms.ColumnHeader colSatKira;
        private System.Windows.Forms.ColumnHeader colOda;
        private System.Windows.Forms.ColumnHeader colMetre;
        private System.Windows.Forms.ColumnHeader colFiyat;
        private System.Windows.Forms.ColumnHeader colBlok;
        private System.Windows.Forms.ColumnHeader colNo;
        private System.Windows.Forms.ColumnHeader colAdSoyad;
        private System.Windows.Forms.ColumnHeader colTelefon;
        private System.Windows.Forms.ColumnHeader colNotlar;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
    }
}