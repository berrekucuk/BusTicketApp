namespace BusTicketApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            oPERASYONToolStripMenuItem = new ToolStripMenuItem();
            firmaİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            yolcuİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            otobüsİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            güzergahİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            biletİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { oPERASYONToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 40);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // oPERASYONToolStripMenuItem
            // 
            oPERASYONToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { firmaİşlemleriToolStripMenuItem, yolcuİşlemleriToolStripMenuItem, otobüsİşlemleriToolStripMenuItem, güzergahİşlemleriToolStripMenuItem, biletİşlemleriToolStripMenuItem });
            oPERASYONToolStripMenuItem.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            oPERASYONToolStripMenuItem.Name = "oPERASYONToolStripMenuItem";
            oPERASYONToolStripMenuItem.Size = new Size(206, 36);
            oPERASYONToolStripMenuItem.Text = "OPERASYON";
            // 
            // firmaİşlemleriToolStripMenuItem
            // 
            firmaİşlemleriToolStripMenuItem.Name = "firmaİşlemleriToolStripMenuItem";
            firmaİşlemleriToolStripMenuItem.Size = new Size(330, 36);
            firmaİşlemleriToolStripMenuItem.Text = "Firma İşlemleri";
            firmaİşlemleriToolStripMenuItem.Click += firmaİşlemleriToolStripMenuItem_Click;
            // 
            // yolcuİşlemleriToolStripMenuItem
            // 
            yolcuİşlemleriToolStripMenuItem.Name = "yolcuİşlemleriToolStripMenuItem";
            yolcuİşlemleriToolStripMenuItem.Size = new Size(330, 36);
            yolcuİşlemleriToolStripMenuItem.Text = "Yolcu İşlemleri";
            yolcuİşlemleriToolStripMenuItem.Click += yolcuİşlemleriToolStripMenuItem_Click;
            // 
            // otobüsİşlemleriToolStripMenuItem
            // 
            otobüsİşlemleriToolStripMenuItem.Name = "otobüsİşlemleriToolStripMenuItem";
            otobüsİşlemleriToolStripMenuItem.Size = new Size(330, 36);
            otobüsİşlemleriToolStripMenuItem.Text = "Otobüs İşlemleri";
            otobüsİşlemleriToolStripMenuItem.Click += otobüsİşlemleriToolStripMenuItem_Click;
            // 
            // güzergahİşlemleriToolStripMenuItem
            // 
            güzergahİşlemleriToolStripMenuItem.Name = "güzergahİşlemleriToolStripMenuItem";
            güzergahİşlemleriToolStripMenuItem.Size = new Size(330, 36);
            güzergahİşlemleriToolStripMenuItem.Text = "Güzergah İşlemleri";
            güzergahİşlemleriToolStripMenuItem.Click += güzergahİşlemleriToolStripMenuItem_Click;
            // 
            // biletİşlemleriToolStripMenuItem
            // 
            biletİşlemleriToolStripMenuItem.Name = "biletİşlemleriToolStripMenuItem";
            biletİşlemleriToolStripMenuItem.Size = new Size(330, 36);
            biletİşlemleriToolStripMenuItem.Text = "Bilet İşlemleri";
            biletİşlemleriToolStripMenuItem.Click += biletİşlemleriToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 535);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem oPERASYONToolStripMenuItem;
        private ToolStripMenuItem firmaİşlemleriToolStripMenuItem;
        private ToolStripMenuItem yolcuİşlemleriToolStripMenuItem;
        private ToolStripMenuItem otobüsİşlemleriToolStripMenuItem;
        private ToolStripMenuItem biletİşlemleriToolStripMenuItem;
        private ToolStripMenuItem güzergahİşlemleriToolStripMenuItem;
    }
}
