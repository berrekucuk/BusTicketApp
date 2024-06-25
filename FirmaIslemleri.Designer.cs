namespace TourTicketApp
{
    partial class FirmaIslemleri
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
            label1 = new Label();
            lstFirmaListesi = new ListBox();
            btnFirmaSil = new Button();
            grpFirmaKayıt = new GroupBox();
            txtFirmaTelefonu = new TextBox();
            label3 = new Label();
            btnFirmaKaydet = new Button();
            txtFirmaAdi = new TextBox();
            label2 = new Label();
            btnFirmaGuncelle = new Button();
            grpFirmaKayıt.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(293, 25);
            label1.Name = "label1";
            label1.Size = new Size(263, 35);
            label1.TabIndex = 0;
            label1.Text = "Firma Kayıt Ekranı";
            // 
            // lstFirmaListesi
            // 
            lstFirmaListesi.FormattingEnabled = true;
            lstFirmaListesi.ItemHeight = 22;
            lstFirmaListesi.Location = new Point(24, 268);
            lstFirmaListesi.Name = "lstFirmaListesi";
            lstFirmaListesi.Size = new Size(532, 114);
            lstFirmaListesi.TabIndex = 6;
            lstFirmaListesi.SelectedIndexChanged += lstFirmaListesi_SelectedIndexChanged;
            // 
            // btnFirmaSil
            // 
            btnFirmaSil.Location = new Point(363, 388);
            btnFirmaSil.Name = "btnFirmaSil";
            btnFirmaSil.Size = new Size(193, 55);
            btnFirmaSil.TabIndex = 7;
            btnFirmaSil.Text = "Firma Sil";
            btnFirmaSil.UseVisualStyleBackColor = true;
            btnFirmaSil.Click += btnFirmaSil_Click;
            // 
            // grpFirmaKayıt
            // 
            grpFirmaKayıt.Controls.Add(btnFirmaGuncelle);
            grpFirmaKayıt.Controls.Add(txtFirmaTelefonu);
            grpFirmaKayıt.Controls.Add(label3);
            grpFirmaKayıt.Controls.Add(btnFirmaKaydet);
            grpFirmaKayıt.Controls.Add(txtFirmaAdi);
            grpFirmaKayıt.Controls.Add(label2);
            grpFirmaKayıt.Location = new Point(12, 63);
            grpFirmaKayıt.Name = "grpFirmaKayıt";
            grpFirmaKayıt.Size = new Size(557, 199);
            grpFirmaKayıt.TabIndex = 8;
            grpFirmaKayıt.TabStop = false;
            grpFirmaKayıt.Text = "Kayıt İşlemleri";
            // 
            // txtFirmaTelefonu
            // 
            txtFirmaTelefonu.Location = new Point(183, 82);
            txtFirmaTelefonu.Name = "txtFirmaTelefonu";
            txtFirmaTelefonu.Size = new Size(361, 30);
            txtFirmaTelefonu.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 90);
            label3.Name = "label3";
            label3.Size = new Size(81, 22);
            label3.TabIndex = 14;
            label3.Text = "Telefon :";
            // 
            // btnFirmaKaydet
            // 
            btnFirmaKaydet.Location = new Point(406, 128);
            btnFirmaKaydet.Name = "btnFirmaKaydet";
            btnFirmaKaydet.Size = new Size(138, 55);
            btnFirmaKaydet.TabIndex = 13;
            btnFirmaKaydet.Text = "Firma Kaydet";
            btnFirmaKaydet.UseVisualStyleBackColor = true;
            btnFirmaKaydet.Click += btnFirmaKaydet_Click;
            // 
            // txtFirmaAdi
            // 
            txtFirmaAdi.Location = new Point(183, 41);
            txtFirmaAdi.Name = "txtFirmaAdi";
            txtFirmaAdi.Size = new Size(361, 30);
            txtFirmaAdi.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(163, 22);
            label2.TabIndex = 11;
            label2.Text = "Firma Adı Giriniz :";
            // 
            // btnFirmaGuncelle
            // 
            btnFirmaGuncelle.Location = new Point(253, 128);
            btnFirmaGuncelle.Name = "btnFirmaGuncelle";
            btnFirmaGuncelle.Size = new Size(147, 55);
            btnFirmaGuncelle.TabIndex = 16;
            btnFirmaGuncelle.Text = "Firma Güncelle";
            btnFirmaGuncelle.UseVisualStyleBackColor = true;
            btnFirmaGuncelle.Click += btnFirmaGuncelle_Click;
            // 
            // FirmaIslemleri
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 469);
            Controls.Add(grpFirmaKayıt);
            Controls.Add(btnFirmaSil);
            Controls.Add(lstFirmaListesi);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FirmaIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FirmaIslemleri";
            grpFirmaKayıt.ResumeLayout(false);
            grpFirmaKayıt.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstFirmaListesi;
        private Button btnFirmaSil;
        private GroupBox grpFirmaKayıt;
        private TextBox txtFirmaTelefonu;
        private Label label3;
        private Button btnFirmaKaydet;
        private TextBox txtFirmaAdi;
        private Label label2;
        private Button btnFirmaGuncelle;
    }
}