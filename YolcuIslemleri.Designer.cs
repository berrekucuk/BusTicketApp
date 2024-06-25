namespace TourTicketApp
{
    partial class YolcuIslemleri
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
            btnYolcuKaydet = new Button();
            label4 = new Label();
            lstYolcuListesi = new ListBox();
            btnYolcuGuncelle = new Button();
            btnYolcuSil = new Button();
            grpKayıtIslemleri = new GroupBox();
            grpBagaj = new GroupBox();
            rdHayır = new RadioButton();
            rdEvet = new RadioButton();
            grpCinsiyet = new GroupBox();
            rdErkek = new RadioButton();
            rdKadın = new RadioButton();
            label3 = new Label();
            txtYolcuTelefon = new TextBox();
            txtYolcuAdSoyad = new TextBox();
            label2 = new Label();
            txtTC = new TextBox();
            label1 = new Label();
            grpKayıtIslemleri.SuspendLayout();
            grpBagaj.SuspendLayout();
            grpCinsiyet.SuspendLayout();
            SuspendLayout();
            // 
            // btnYolcuKaydet
            // 
            btnYolcuKaydet.Location = new Point(402, 308);
            btnYolcuKaydet.Name = "btnYolcuKaydet";
            btnYolcuKaydet.Size = new Size(148, 47);
            btnYolcuKaydet.TabIndex = 2;
            btnYolcuKaydet.Text = "Yolcu Kaydet";
            btnYolcuKaydet.UseVisualStyleBackColor = true;
            btnYolcuKaydet.Click += btnYolcuKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(268, 18);
            label4.Name = "label4";
            label4.Size = new Size(282, 35);
            label4.TabIndex = 9;
            label4.Text = "Yolcu Kayıt İşlemleri";
            // 
            // lstYolcuListesi
            // 
            lstYolcuListesi.FormattingEnabled = true;
            lstYolcuListesi.ItemHeight = 22;
            lstYolcuListesi.Location = new Point(17, 361);
            lstYolcuListesi.Name = "lstYolcuListesi";
            lstYolcuListesi.Size = new Size(533, 114);
            lstYolcuListesi.TabIndex = 10;
            lstYolcuListesi.SelectedIndexChanged += lstYolcuListesi_SelectedIndexChanged;
            // 
            // btnYolcuGuncelle
            // 
            btnYolcuGuncelle.Location = new Point(248, 308);
            btnYolcuGuncelle.Name = "btnYolcuGuncelle";
            btnYolcuGuncelle.Size = new Size(148, 47);
            btnYolcuGuncelle.TabIndex = 11;
            btnYolcuGuncelle.Text = "Yolcu Güncelle";
            btnYolcuGuncelle.UseVisualStyleBackColor = true;
            btnYolcuGuncelle.Click += btnYolcuGuncelle_Click;
            // 
            // btnYolcuSil
            // 
            btnYolcuSil.Location = new Point(402, 481);
            btnYolcuSil.Name = "btnYolcuSil";
            btnYolcuSil.Size = new Size(148, 47);
            btnYolcuSil.TabIndex = 12;
            btnYolcuSil.Text = "Yolcu Sil";
            btnYolcuSil.UseVisualStyleBackColor = true;
            btnYolcuSil.Click += btnYolcuSil_Click;
            // 
            // grpKayıtIslemleri
            // 
            grpKayıtIslemleri.Controls.Add(grpBagaj);
            grpKayıtIslemleri.Controls.Add(grpCinsiyet);
            grpKayıtIslemleri.Controls.Add(label3);
            grpKayıtIslemleri.Controls.Add(txtYolcuTelefon);
            grpKayıtIslemleri.Controls.Add(txtYolcuAdSoyad);
            grpKayıtIslemleri.Controls.Add(label2);
            grpKayıtIslemleri.Controls.Add(txtTC);
            grpKayıtIslemleri.Controls.Add(label1);
            grpKayıtIslemleri.Location = new Point(12, 56);
            grpKayıtIslemleri.Name = "grpKayıtIslemleri";
            grpKayıtIslemleri.Size = new Size(538, 246);
            grpKayıtIslemleri.TabIndex = 9;
            grpKayıtIslemleri.TabStop = false;
            grpKayıtIslemleri.Text = "Kayıt İşlemleri";
            // 
            // grpBagaj
            // 
            grpBagaj.Controls.Add(rdHayır);
            grpBagaj.Controls.Add(rdEvet);
            grpBagaj.Location = new Point(26, 147);
            grpBagaj.Name = "grpBagaj";
            grpBagaj.Size = new Size(244, 93);
            grpBagaj.TabIndex = 16;
            grpBagaj.TabStop = false;
            grpBagaj.Text = "Bagaj Var Mı?";
            // 
            // rdHayır
            // 
            rdHayır.AutoSize = true;
            rdHayır.Location = new Point(112, 40);
            rdHayır.Name = "rdHayır";
            rdHayır.Size = new Size(76, 26);
            rdHayır.TabIndex = 1;
            rdHayır.TabStop = true;
            rdHayır.Text = "Hayır";
            rdHayır.UseVisualStyleBackColor = true;
            // 
            // rdEvet
            // 
            rdEvet.AutoSize = true;
            rdEvet.Location = new Point(15, 40);
            rdEvet.Name = "rdEvet";
            rdEvet.Size = new Size(67, 26);
            rdEvet.TabIndex = 0;
            rdEvet.TabStop = true;
            rdEvet.Text = "Evet";
            rdEvet.UseVisualStyleBackColor = true;
            // 
            // grpCinsiyet
            // 
            grpCinsiyet.Controls.Add(rdErkek);
            grpCinsiyet.Controls.Add(rdKadın);
            grpCinsiyet.Location = new Point(276, 147);
            grpCinsiyet.Name = "grpCinsiyet";
            grpCinsiyet.Size = new Size(239, 93);
            grpCinsiyet.TabIndex = 15;
            grpCinsiyet.TabStop = false;
            grpCinsiyet.Text = "Cinsiyet";
            // 
            // rdErkek
            // 
            rdErkek.AutoSize = true;
            rdErkek.Location = new Point(122, 40);
            rdErkek.Name = "rdErkek";
            rdErkek.Size = new Size(77, 26);
            rdErkek.TabIndex = 1;
            rdErkek.TabStop = true;
            rdErkek.Text = "Erkek";
            rdErkek.UseVisualStyleBackColor = true;
            // 
            // rdKadın
            // 
            rdKadın.AutoSize = true;
            rdKadın.Location = new Point(15, 40);
            rdKadın.Name = "rdKadın";
            rdKadın.Size = new Size(79, 26);
            rdKadın.TabIndex = 0;
            rdKadın.TabStop = true;
            rdKadın.Text = "Kadın";
            rdKadın.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 108);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 14;
            label3.Text = "Telefon";
            // 
            // txtYolcuTelefon
            // 
            txtYolcuTelefon.Location = new Point(158, 100);
            txtYolcuTelefon.Name = "txtYolcuTelefon";
            txtYolcuTelefon.Size = new Size(374, 30);
            txtYolcuTelefon.TabIndex = 13;
            // 
            // txtYolcuAdSoyad
            // 
            txtYolcuAdSoyad.Location = new Point(158, 64);
            txtYolcuAdSoyad.Name = "txtYolcuAdSoyad";
            txtYolcuAdSoyad.Size = new Size(374, 30);
            txtYolcuAdSoyad.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 72);
            label2.Name = "label2";
            label2.Size = new Size(88, 22);
            label2.TabIndex = 11;
            label2.Text = "Ad Soyad";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(158, 29);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(374, 30);
            txtTC.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 37);
            label1.Name = "label1";
            label1.Size = new Size(124, 22);
            label1.TabIndex = 9;
            label1.Text = "TC Kimlik No";
            // 
            // YolcuIslemleri
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 553);
            Controls.Add(grpKayıtIslemleri);
            Controls.Add(btnYolcuSil);
            Controls.Add(btnYolcuGuncelle);
            Controls.Add(lstYolcuListesi);
            Controls.Add(label4);
            Controls.Add(btnYolcuKaydet);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "YolcuIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YolcuIslemleri";
            grpKayıtIslemleri.ResumeLayout(false);
            grpKayıtIslemleri.PerformLayout();
            grpBagaj.ResumeLayout(false);
            grpBagaj.PerformLayout();
            grpCinsiyet.ResumeLayout(false);
            grpCinsiyet.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnYolcuKaydet;
        private Label label4;
        private ListBox lstYolcuListesi;
        private Button btnYolcuGuncelle;
        private Button btnYolcuSil;
        private GroupBox grpKayıtIslemleri;
        private GroupBox grpBagaj;
        private RadioButton rdHayır;
        private RadioButton rdEvet;
        private GroupBox grpCinsiyet;
        private RadioButton rdErkek;
        private RadioButton rdKadın;
        private Label label3;
        private TextBox txtYolcuTelefon;
        private TextBox txtYolcuAdSoyad;
        private Label label2;
        private TextBox txtTC;
        private Label label1;
    }
}