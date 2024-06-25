namespace TourTicketApp
{
    partial class OtobusIslemleri
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
            txtPlakaNo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbOtobüsTipi = new ComboBox();
            nmrKapasite = new NumericUpDown();
            grpWifi = new GroupBox();
            rdHayır = new RadioButton();
            rdEvet = new RadioButton();
            btnOtobusKaydet = new Button();
            label4 = new Label();
            lstOtobusListesi = new ListBox();
            label5 = new Label();
            cmbFirma = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nmrKapasite).BeginInit();
            grpWifi.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 156);
            label1.Name = "label1";
            label1.Size = new Size(83, 22);
            label1.TabIndex = 0;
            label1.Text = "Plaka No";
            // 
            // txtPlakaNo
            // 
            txtPlakaNo.Location = new Point(145, 148);
            txtPlakaNo.Name = "txtPlakaNo";
            txtPlakaNo.Size = new Size(393, 30);
            txtPlakaNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 207);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 5;
            label2.Text = "Otobüs Tipi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 202);
            label3.Name = "label3";
            label3.Size = new Size(80, 22);
            label3.TabIndex = 6;
            label3.Text = "Kapasite";
            // 
            // cmbOtobüsTipi
            // 
            cmbOtobüsTipi.FormattingEnabled = true;
            cmbOtobüsTipi.Location = new Point(145, 199);
            cmbOtobüsTipi.Name = "cmbOtobüsTipi";
            cmbOtobüsTipi.Size = new Size(151, 30);
            cmbOtobüsTipi.TabIndex = 8;
            cmbOtobüsTipi.SelectedIndexChanged += cmbOtobüsTipi_SelectedIndexChanged;
            // 
            // nmrKapasite
            // 
            nmrKapasite.Location = new Point(453, 199);
            nmrKapasite.Name = "nmrKapasite";
            nmrKapasite.Size = new Size(85, 30);
            nmrKapasite.TabIndex = 9;
            // 
            // grpWifi
            // 
            grpWifi.Controls.Add(rdHayır);
            grpWifi.Controls.Add(rdEvet);
            grpWifi.Location = new Point(24, 243);
            grpWifi.Name = "grpWifi";
            grpWifi.Size = new Size(222, 66);
            grpWifi.TabIndex = 10;
            grpWifi.TabStop = false;
            grpWifi.Text = "Wifi";
            // 
            // rdHayır
            // 
            rdHayır.AutoSize = true;
            rdHayır.Location = new Point(121, 29);
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
            rdEvet.Location = new Point(16, 29);
            rdEvet.Name = "rdEvet";
            rdEvet.Size = new Size(67, 26);
            rdEvet.TabIndex = 0;
            rdEvet.TabStop = true;
            rdEvet.Text = "Evet";
            rdEvet.UseVisualStyleBackColor = true;
            // 
            // btnOtobusKaydet
            // 
            btnOtobusKaydet.Location = new Point(371, 257);
            btnOtobusKaydet.Name = "btnOtobusKaydet";
            btnOtobusKaydet.Size = new Size(167, 52);
            btnOtobusKaydet.TabIndex = 11;
            btnOtobusKaydet.Text = "Otobüs Kaydet";
            btnOtobusKaydet.UseVisualStyleBackColor = true;
            btnOtobusKaydet.Click += btnOtobusKaydet_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(233, 31);
            label4.Name = "label4";
            label4.Size = new Size(305, 35);
            label4.TabIndex = 12;
            label4.Text = "Otobüs Kayıt İşlemleri";
            // 
            // lstOtobusListesi
            // 
            lstOtobusListesi.FormattingEnabled = true;
            lstOtobusListesi.ItemHeight = 22;
            lstOtobusListesi.Location = new Point(24, 315);
            lstOtobusListesi.Name = "lstOtobusListesi";
            lstOtobusListesi.Size = new Size(514, 114);
            lstOtobusListesi.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 68);
            label5.Name = "label5";
            label5.Size = new Size(131, 22);
            label5.TabIndex = 14;
            label5.Text = "Firma Seçiniz :";
            // 
            // cmbFirma
            // 
            cmbFirma.FormattingEnabled = true;
            cmbFirma.Location = new Point(24, 102);
            cmbFirma.Name = "cmbFirma";
            cmbFirma.Size = new Size(514, 30);
            cmbFirma.TabIndex = 15;
            cmbFirma.SelectedIndexChanged += cmbFirma_SelectedIndexChanged;
            // 
            // OtobusIslemleri
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 469);
            Controls.Add(cmbFirma);
            Controls.Add(label5);
            Controls.Add(lstOtobusListesi);
            Controls.Add(label4);
            Controls.Add(btnOtobusKaydet);
            Controls.Add(grpWifi);
            Controls.Add(nmrKapasite);
            Controls.Add(cmbOtobüsTipi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPlakaNo);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "OtobusIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OtobusIslemleri";
            Load += OtobusIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)nmrKapasite).EndInit();
            grpWifi.ResumeLayout(false);
            grpWifi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPlakaNo;
        private Label label2;
        private Label label3;
        private ComboBox cmbOtobüsTipi;
        private NumericUpDown nmrKapasite;
        private GroupBox grpWifi;
        private RadioButton rdHayır;
        private RadioButton rdEvet;
        private Button btnOtobusKaydet;
        private Label label4;
        private ListBox lstOtobusListesi;
        private Label label5;
        private ComboBox cmbFirma;
    }
}