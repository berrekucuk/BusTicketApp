namespace TourTicketApp
{
    partial class GuzergahIslemleri
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
            cmbNereden = new ComboBox();
            cmbNereye = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lstGuzergahListesi = new ListBox();
            btnGuzergahKaydet = new Button();
            btnYerEkle = new Button();
            txtGezilecekYer = new TextBox();
            label3 = new Label();
            lstGezilecekYerler = new ListBox();
            SuspendLayout();
            // 
            // cmbNereden
            // 
            cmbNereden.DropDownHeight = 300;
            cmbNereden.FormattingEnabled = true;
            cmbNereden.IntegralHeight = false;
            cmbNereden.Location = new Point(21, 62);
            cmbNereden.Name = "cmbNereden";
            cmbNereden.Size = new Size(322, 30);
            cmbNereden.TabIndex = 0;
            // 
            // cmbNereye
            // 
            cmbNereye.DropDownHeight = 300;
            cmbNereye.FormattingEnabled = true;
            cmbNereye.IntegralHeight = false;
            cmbNereye.Location = new Point(391, 62);
            cmbNereye.Name = "cmbNereye";
            cmbNereye.Size = new Size(322, 30);
            cmbNereye.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(77, 22);
            label1.TabIndex = 2;
            label1.Text = "Nereden";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 26);
            label2.Name = "label2";
            label2.Size = new Size(67, 22);
            label2.TabIndex = 3;
            label2.Text = "Nereye";
            // 
            // lstGuzergahListesi
            // 
            lstGuzergahListesi.FormattingEnabled = true;
            lstGuzergahListesi.ItemHeight = 22;
            lstGuzergahListesi.Location = new Point(21, 144);
            lstGuzergahListesi.Name = "lstGuzergahListesi";
            lstGuzergahListesi.Size = new Size(692, 114);
            lstGuzergahListesi.TabIndex = 4;
            lstGuzergahListesi.SelectedIndexChanged += lstGuzergahListesi_SelectedIndexChanged;
            // 
            // btnGuzergahKaydet
            // 
            btnGuzergahKaydet.Location = new Point(538, 98);
            btnGuzergahKaydet.Name = "btnGuzergahKaydet";
            btnGuzergahKaydet.Size = new Size(175, 40);
            btnGuzergahKaydet.TabIndex = 5;
            btnGuzergahKaydet.Text = "Güzergah Kaydet";
            btnGuzergahKaydet.UseVisualStyleBackColor = true;
            btnGuzergahKaydet.Click += btnGuzergahKaydet_Click;
            // 
            // btnYerEkle
            // 
            btnYerEkle.Location = new Point(304, 377);
            btnYerEkle.Name = "btnYerEkle";
            btnYerEkle.Size = new Size(154, 45);
            btnYerEkle.TabIndex = 6;
            btnYerEkle.Text = "Yer Ekle";
            btnYerEkle.UseVisualStyleBackColor = true;
            btnYerEkle.Click += btnYerEkle_Click;
            // 
            // txtGezilecekYer
            // 
            txtGezilecekYer.Location = new Point(21, 326);
            txtGezilecekYer.Name = "txtGezilecekYer";
            txtGezilecekYer.Size = new Size(437, 30);
            txtGezilecekYer.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 285);
            label3.Name = "label3";
            label3.Size = new Size(155, 22);
            label3.TabIndex = 8;
            label3.Text = "Gezilecek Yer Adı";
            // 
            // lstGezilecekYerler
            // 
            lstGezilecekYerler.FormattingEnabled = true;
            lstGezilecekYerler.ItemHeight = 22;
            lstGezilecekYerler.Location = new Point(473, 264);
            lstGezilecekYerler.Name = "lstGezilecekYerler";
            lstGezilecekYerler.Size = new Size(240, 158);
            lstGezilecekYerler.TabIndex = 9;
            // 
            // GuzergahIslemleri
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 441);
            Controls.Add(lstGezilecekYerler);
            Controls.Add(label3);
            Controls.Add(txtGezilecekYer);
            Controls.Add(btnYerEkle);
            Controls.Add(btnGuzergahKaydet);
            Controls.Add(lstGuzergahListesi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbNereye);
            Controls.Add(cmbNereden);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "GuzergahIslemleri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GuzergahIslemleri";
            Load += GuzergahIslemleri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbNereden;
        private ComboBox cmbNereye;
        private Label label1;
        private Label label2;
        private ListBox lstGuzergahListesi;
        private Button btnGuzergahKaydet;
        private Button btnYerEkle;
        private TextBox txtGezilecekYer;
        private Label label3;
        private ListBox lstGezilecekYerler;
    }
}