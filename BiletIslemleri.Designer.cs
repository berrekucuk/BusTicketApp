namespace TourTicketApp
{
    partial class BiletIslemleri
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
            dgwBiletListesi = new DataGridView();
            grpBiletOlustur = new GroupBox();
            label8 = new Label();
            dtTarih = new DateTimePicker();
            txtKoltukNo = new TextBox();
            txtBiletUcreti = new TextBox();
            label7 = new Label();
            label5 = new Label();
            btnBiletiOlustur = new Button();
            btnListeyiTemizle = new Button();
            btnListedenCikar = new Button();
            btnListeyeEkle = new Button();
            lstSecilenGezilecekYerler = new ListBox();
            label6 = new Label();
            lstTumGezilecekYerler = new ListBox();
            cmbNereye = new ComboBox();
            cmbNereden = new ComboBox();
            lblNereye = new Label();
            label4 = new Label();
            txtOtobusPlaka = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cmbYolcu = new ComboBox();
            cmbOtobusTipi = new ComboBox();
            cmbFirma = new ComboBox();
            label1 = new Label();
            lblMesaj = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwBiletListesi).BeginInit();
            grpBiletOlustur.SuspendLayout();
            SuspendLayout();
            // 
            // dgwBiletListesi
            // 
            dgwBiletListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgwBiletListesi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgwBiletListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwBiletListesi.Location = new Point(7, 410);
            dgwBiletListesi.Name = "dgwBiletListesi";
            dgwBiletListesi.RowHeadersWidth = 51;
            dgwBiletListesi.Size = new Size(1076, 159);
            dgwBiletListesi.TabIndex = 4;
            // 
            // grpBiletOlustur
            // 
            grpBiletOlustur.Controls.Add(label8);
            grpBiletOlustur.Controls.Add(dtTarih);
            grpBiletOlustur.Controls.Add(txtKoltukNo);
            grpBiletOlustur.Controls.Add(txtBiletUcreti);
            grpBiletOlustur.Controls.Add(label7);
            grpBiletOlustur.Controls.Add(label5);
            grpBiletOlustur.Controls.Add(btnBiletiOlustur);
            grpBiletOlustur.Controls.Add(btnListeyiTemizle);
            grpBiletOlustur.Controls.Add(btnListedenCikar);
            grpBiletOlustur.Controls.Add(btnListeyeEkle);
            grpBiletOlustur.Controls.Add(lstSecilenGezilecekYerler);
            grpBiletOlustur.Controls.Add(label6);
            grpBiletOlustur.Controls.Add(lstTumGezilecekYerler);
            grpBiletOlustur.Controls.Add(cmbNereye);
            grpBiletOlustur.Controls.Add(cmbNereden);
            grpBiletOlustur.Controls.Add(lblNereye);
            grpBiletOlustur.Controls.Add(label4);
            grpBiletOlustur.Controls.Add(txtOtobusPlaka);
            grpBiletOlustur.Controls.Add(label3);
            grpBiletOlustur.Controls.Add(label2);
            grpBiletOlustur.Controls.Add(cmbYolcu);
            grpBiletOlustur.Controls.Add(cmbOtobusTipi);
            grpBiletOlustur.Controls.Add(cmbFirma);
            grpBiletOlustur.Controls.Add(label1);
            grpBiletOlustur.Location = new Point(7, 52);
            grpBiletOlustur.Name = "grpBiletOlustur";
            grpBiletOlustur.Size = new Size(1076, 352);
            grpBiletOlustur.TabIndex = 3;
            grpBiletOlustur.TabStop = false;
            grpBiletOlustur.Text = "Bilet Oluşturma Ekranı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 226);
            label8.Name = "label8";
            label8.Size = new Size(63, 22);
            label8.TabIndex = 23;
            label8.Text = "Tarih :";
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(262, 220);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(355, 30);
            dtTarih.TabIndex = 22;
            
            // 
            // txtKoltukNo
            // 
            txtKoltukNo.Location = new Point(262, 184);
            txtKoltukNo.Name = "txtKoltukNo";
            txtKoltukNo.Size = new Size(355, 30);
            txtKoltukNo.TabIndex = 21;
            // 
            // txtBiletUcreti
            // 
            txtBiletUcreti.Location = new Point(262, 148);
            txtBiletUcreti.Name = "txtBiletUcreti";
            txtBiletUcreti.Size = new Size(355, 30);
            txtBiletUcreti.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 192);
            label7.Name = "label7";
            label7.Size = new Size(103, 22);
            label7.TabIndex = 19;
            label7.Text = "Koltuk No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 156);
            label5.Name = "label5";
            label5.Size = new Size(115, 22);
            label5.TabIndex = 18;
            label5.Text = "Bilet Ücreti :";
            // 
            // btnBiletiOlustur
            // 
            btnBiletiOlustur.Location = new Point(886, 297);
            btnBiletiOlustur.Name = "btnBiletiOlustur";
            btnBiletiOlustur.Size = new Size(168, 37);
            btnBiletiOlustur.TabIndex = 17;
            btnBiletiOlustur.Text = "Bilet Oluştur";
            btnBiletiOlustur.UseVisualStyleBackColor = true;
            btnBiletiOlustur.Click += btnBiletiOlustur_Click;
            // 
            // btnListeyiTemizle
            // 
            btnListeyiTemizle.Location = new Point(809, 208);
            btnListeyiTemizle.Name = "btnListeyiTemizle";
            btnListeyiTemizle.Size = new Size(75, 30);
            btnListeyiTemizle.TabIndex = 16;
            btnListeyiTemizle.Text = "X";
            btnListeyiTemizle.UseVisualStyleBackColor = true;
            btnListeyiTemizle.Click += btnListeyiTemizle_Click;
            // 
            // btnListedenCikar
            // 
            btnListedenCikar.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnListedenCikar.Location = new Point(809, 163);
            btnListedenCikar.Name = "btnListedenCikar";
            btnListedenCikar.Size = new Size(75, 30);
            btnListedenCikar.TabIndex = 15;
            btnListedenCikar.Text = "<<";
            btnListedenCikar.UseVisualStyleBackColor = true;
            btnListedenCikar.Click += btnListedenCikar_Click;
            // 
            // btnListeyeEkle
            // 
            btnListeyeEkle.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnListeyeEkle.Location = new Point(809, 116);
            btnListeyeEkle.Name = "btnListeyeEkle";
            btnListeyeEkle.Size = new Size(75, 30);
            btnListeyeEkle.TabIndex = 14;
            btnListeyeEkle.Text = ">>";
            btnListeyeEkle.UseVisualStyleBackColor = true;
            btnListeyeEkle.Click += btnListeyeEkle_Click;
            // 
            // lstSecilenGezilecekYerler
            // 
            lstSecilenGezilecekYerler.FormattingEnabled = true;
            lstSecilenGezilecekYerler.ItemHeight = 22;
            lstSecilenGezilecekYerler.Location = new Point(904, 77);
            lstSecilenGezilecekYerler.Name = "lstSecilenGezilecekYerler";
            lstSecilenGezilecekYerler.Size = new Size(150, 202);
            lstSecilenGezilecekYerler.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(777, 41);
            label6.Name = "label6";
            label6.Size = new Size(143, 22);
            label6.TabIndex = 12;
            label6.Text = "Gezilecek Yerler";
            // 
            // lstTumGezilecekYerler
            // 
            lstTumGezilecekYerler.FormattingEnabled = true;
            lstTumGezilecekYerler.ItemHeight = 22;
            lstTumGezilecekYerler.Location = new Point(640, 77);
            lstTumGezilecekYerler.Name = "lstTumGezilecekYerler";
            lstTumGezilecekYerler.Size = new Size(150, 202);
            lstTumGezilecekYerler.TabIndex = 11;
            // 
            // cmbNereye
            // 
            cmbNereye.DropDownHeight = 300;
            cmbNereye.FormattingEnabled = true;
            cmbNereye.IntegralHeight = false;
            cmbNereye.Location = new Point(304, 297);
            cmbNereye.Name = "cmbNereye";
            cmbNereye.Size = new Size(313, 30);
            cmbNereye.TabIndex = 10;
            cmbNereye.Visible = false;
            cmbNereye.SelectedIndexChanged += cmbNereye_SelectedIndexChanged;
            // 
            // cmbNereden
            // 
            cmbNereden.DropDownHeight = 300;
            cmbNereden.FormattingEnabled = true;
            cmbNereden.IntegralHeight = false;
            cmbNereden.Location = new Point(26, 297);
            cmbNereden.Name = "cmbNereden";
            cmbNereden.Size = new Size(272, 30);
            cmbNereden.TabIndex = 9;
            cmbNereden.SelectedIndexChanged += cmbNereden_SelectedIndexChanged;
            // 
            // lblNereye
            // 
            lblNereye.AutoSize = true;
            lblNereye.Location = new Point(304, 272);
            lblNereye.Name = "lblNereye";
            lblNereye.Size = new Size(67, 22);
            lblNereye.TabIndex = 8;
            lblNereye.Text = "Nereye";
            lblNereye.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 272);
            label4.Name = "label4";
            label4.Size = new Size(77, 22);
            label4.TabIndex = 7;
            label4.Text = "Nereden";
            // 
            // txtOtobusPlaka
            // 
            txtOtobusPlaka.Location = new Point(381, 77);
            txtOtobusPlaka.Name = "txtOtobusPlaka";
            txtOtobusPlaka.ReadOnly = true;
            txtOtobusPlaka.Size = new Size(236, 30);
            txtOtobusPlaka.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 49);
            label3.Name = "label3";
            label3.Size = new Size(130, 22);
            label3.TabIndex = 5;
            label3.Text = "Yolcu Seçiniz :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 85);
            label2.Name = "label2";
            label2.Size = new Size(179, 22);
            label2.TabIndex = 4;
            label2.Text = "Otobüs Tipi Seçiniz :";
            // 
            // cmbYolcu
            // 
            cmbYolcu.FormattingEnabled = true;
            cmbYolcu.Location = new Point(262, 41);
            cmbYolcu.Name = "cmbYolcu";
            cmbYolcu.Size = new Size(355, 30);
            cmbYolcu.TabIndex = 3;
            cmbYolcu.SelectedIndexChanged += cmbYolcu_SelectedIndexChanged;
            // 
            // cmbOtobusTipi
            // 
            cmbOtobusTipi.FormattingEnabled = true;
            cmbOtobusTipi.Location = new Point(262, 77);
            cmbOtobusTipi.Name = "cmbOtobusTipi";
            cmbOtobusTipi.Size = new Size(113, 30);
            cmbOtobusTipi.TabIndex = 2;
            cmbOtobusTipi.SelectedIndexChanged += cmbOtobusTipi_SelectedIndexChanged;
            // 
            // cmbFirma
            // 
            cmbFirma.FormattingEnabled = true;
            cmbFirma.Location = new Point(262, 113);
            cmbFirma.Name = "cmbFirma";
            cmbFirma.Size = new Size(355, 30);
            cmbFirma.TabIndex = 1;
            cmbFirma.SelectedIndexChanged += cmbFirma_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 121);
            label1.Name = "label1";
            label1.Size = new Size(222, 22);
            label1.TabIndex = 0;
            label1.Text = "Otobüs Firmasını Seçiniz :";
            // 
            // lblMesaj
            // 
            lblMesaj.BackColor = SystemColors.ActiveCaption;
            lblMesaj.Location = new Point(7, 9);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(1077, 40);
            lblMesaj.TabIndex = 18;
            lblMesaj.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BiletIslemleri
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 581);
            Controls.Add(lblMesaj);
            Controls.Add(dgwBiletListesi);
            Controls.Add(grpBiletOlustur);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BiletIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BiletIslemleri";
            Load += BiletIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dgwBiletListesi).EndInit();
            grpBiletOlustur.ResumeLayout(false);
            grpBiletOlustur.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwBiletListesi;
        private GroupBox grpBiletOlustur;
        private Button btnBiletiOlustur;
        private Button btnListeyiTemizle;
        private Button btnListedenCikar;
        private Button btnListeyeEkle;
        private ListBox lstSecilenGezilecekYerler;
        private Label label6;
        private ListBox lstTumGezilecekYerler;
        private ComboBox cmbNereye;
        private ComboBox cmbNereden;
        private Label lblNereye;
        private Label label4;
        private TextBox txtOtobusPlaka;
        private Label label3;
        private Label label2;
        private ComboBox cmbYolcu;
        private ComboBox cmbOtobusTipi;
        private ComboBox cmbFirma;
        private Label label1;
        private Label lblMesaj;
        private Label label8;
        private DateTimePicker dtTarih;
        private TextBox txtKoltukNo;
        private TextBox txtBiletUcreti;
        private Label label7;
        private Label label5;
    }
}