namespace Kantot
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            btnIzinAl = new ToolStripButton();
            tsSeparator1 = new ToolStripSeparator();
            btnIzinlerim = new ToolStripButton();
            tsSeparator3 = new ToolStripSeparator();
            btnIzinlerGecmisi = new ToolStripButton();
            btnExit = new ToolStripButton();
            tsSeparator6 = new ToolStripSeparator();
            tsSeparator5 = new ToolStripSeparator();
            tsLeftBar = new ToolStrip();
            tsSeparator2 = new ToolStripSeparator();
            btnIzinIstekleri = new ToolStripButton();
            btnIzindeOlanlar = new ToolStripButton();
            tsSeparator4 = new ToolStripSeparator();
            btnKategoriler = new ToolStripButton();
            tsTopBar = new ToolStrip();
            tslSicilNo = new ToolStripLabel();
            tslTarihSaat = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            tslAdi = new ToolStripLabel();
            tslSoyadi = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            tslBakiye = new ToolStripLabel();
            tSaatTarih = new System.Windows.Forms.Timer(components);
            tsLeftBar.SuspendLayout();
            tsTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnIzinAl
            // 
            btnIzinAl.AutoSize = false;
            btnIzinAl.BackColor = Color.Transparent;
            btnIzinAl.BackgroundImageLayout = ImageLayout.None;
            btnIzinAl.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnIzinAl.ForeColor = SystemColors.ControlText;
            btnIzinAl.Image = Properties.Resources.izinal;
            btnIzinAl.ImageAlign = ContentAlignment.MiddleRight;
            btnIzinAl.ImageScaling = ToolStripItemImageScaling.None;
            btnIzinAl.ImageTransparentColor = Color.Magenta;
            btnIzinAl.Name = "btnIzinAl";
            btnIzinAl.Size = new Size(299, 100);
            btnIzinAl.Text = "İzin Al";
            btnIzinAl.Click += btnIzinAl_Click;
            // 
            // tsSeparator1
            // 
            tsSeparator1.BackColor = SystemColors.ControlLight;
            tsSeparator1.Name = "tsSeparator1";
            tsSeparator1.Size = new Size(279, 6);
            // 
            // btnIzinlerim
            // 
            btnIzinlerim.AutoSize = false;
            btnIzinlerim.BackColor = Color.Transparent;
            btnIzinlerim.BackgroundImageLayout = ImageLayout.None;
            btnIzinlerim.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnIzinlerim.Image = Properties.Resources.izinlergecmisi;
            btnIzinlerim.ImageAlign = ContentAlignment.MiddleRight;
            btnIzinlerim.ImageScaling = ToolStripItemImageScaling.None;
            btnIzinlerim.ImageTransparentColor = Color.Magenta;
            btnIzinlerim.Name = "btnIzinlerim";
            btnIzinlerim.RightToLeft = RightToLeft.No;
            btnIzinlerim.Size = new Size(299, 100);
            btnIzinlerim.Text = "İzinlerim";
            btnIzinlerim.Click += btnIzinlerim_Click;
            // 
            // tsSeparator3
            // 
            tsSeparator3.BackColor = SystemColors.ControlLight;
            tsSeparator3.Name = "tsSeparator3";
            tsSeparator3.Size = new Size(279, 6);
            // 
            // btnIzinlerGecmisi
            // 
            btnIzinlerGecmisi.AutoSize = false;
            btnIzinlerGecmisi.BackColor = Color.Transparent;
            btnIzinlerGecmisi.BackgroundImageLayout = ImageLayout.Zoom;
            btnIzinlerGecmisi.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnIzinlerGecmisi.Image = Properties.Resources.izinlergecmisi;
            btnIzinlerGecmisi.ImageAlign = ContentAlignment.MiddleRight;
            btnIzinlerGecmisi.ImageScaling = ToolStripItemImageScaling.None;
            btnIzinlerGecmisi.ImageTransparentColor = Color.Magenta;
            btnIzinlerGecmisi.Name = "btnIzinlerGecmisi";
            btnIzinlerGecmisi.RightToLeft = RightToLeft.No;
            btnIzinlerGecmisi.Size = new Size(299, 100);
            btnIzinlerGecmisi.Text = "İzinler Geçmişi";
            btnIzinlerGecmisi.Click += btnIzinlerGecmisi_Click;
            // 
            // btnExit
            // 
            btnExit.Alignment = ToolStripItemAlignment.Right;
            btnExit.AutoSize = false;
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = Properties.Resources.exit;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(299, 100);
            btnExit.Click += btnExit_Click;
            // 
            // tsSeparator6
            // 
            tsSeparator6.Alignment = ToolStripItemAlignment.Right;
            tsSeparator6.BackColor = SystemColors.ControlLight;
            tsSeparator6.Name = "tsSeparator6";
            tsSeparator6.Size = new Size(279, 6);
            // 
            // tsSeparator5
            // 
            tsSeparator5.BackColor = SystemColors.ControlLight;
            tsSeparator5.Name = "tsSeparator5";
            tsSeparator5.Size = new Size(279, 6);
            // 
            // tsLeftBar
            // 
            tsLeftBar.AutoSize = false;
            tsLeftBar.BackColor = SystemColors.ControlLight;
            tsLeftBar.Dock = DockStyle.Right;
            tsLeftBar.GripMargin = new Padding(0);
            tsLeftBar.GripStyle = ToolStripGripStyle.Hidden;
            tsLeftBar.ImageScalingSize = new Size(24, 24);
            tsLeftBar.Items.AddRange(new ToolStripItem[] { btnIzinAl, tsSeparator1, btnIzinlerim, tsSeparator2, btnIzinIstekleri, tsSeparator3, btnIzindeOlanlar, tsSeparator4, btnIzinlerGecmisi, btnExit, tsSeparator6, tsSeparator5, btnKategoriler });
            tsLeftBar.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            tsLeftBar.Location = new Point(1460, 0);
            tsLeftBar.Name = "tsLeftBar";
            tsLeftBar.Padding = new Padding(10, 5, 10, 0);
            tsLeftBar.RenderMode = ToolStripRenderMode.System;
            tsLeftBar.Size = new Size(300, 990);
            tsLeftBar.TabIndex = 0;
            // 
            // tsSeparator2
            // 
            tsSeparator2.BackColor = SystemColors.ControlLight;
            tsSeparator2.Name = "tsSeparator2";
            tsSeparator2.Size = new Size(279, 6);
            // 
            // btnIzinIstekleri
            // 
            btnIzinIstekleri.AutoSize = false;
            btnIzinIstekleri.BackColor = Color.Transparent;
            btnIzinIstekleri.BackgroundImageLayout = ImageLayout.None;
            btnIzinIstekleri.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnIzinIstekleri.Image = Properties.Resources.askprice;
            btnIzinIstekleri.ImageAlign = ContentAlignment.MiddleRight;
            btnIzinIstekleri.ImageScaling = ToolStripItemImageScaling.None;
            btnIzinIstekleri.ImageTransparentColor = Color.Magenta;
            btnIzinIstekleri.Name = "btnIzinIstekleri";
            btnIzinIstekleri.RightToLeft = RightToLeft.No;
            btnIzinIstekleri.Size = new Size(299, 100);
            btnIzinIstekleri.Text = "İzin İstekleri";
            btnIzinIstekleri.Click += btnIzinIstekleri_Click;
            // 
            // btnIzindeOlanlar
            // 
            btnIzindeOlanlar.AutoSize = false;
            btnIzindeOlanlar.BackColor = Color.Transparent;
            btnIzindeOlanlar.BackgroundImageLayout = ImageLayout.Zoom;
            btnIzindeOlanlar.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnIzindeOlanlar.Image = Properties.Resources.izindeolanlar;
            btnIzindeOlanlar.ImageAlign = ContentAlignment.MiddleRight;
            btnIzindeOlanlar.ImageScaling = ToolStripItemImageScaling.None;
            btnIzindeOlanlar.ImageTransparentColor = Color.Magenta;
            btnIzindeOlanlar.Name = "btnIzindeOlanlar";
            btnIzindeOlanlar.RightToLeft = RightToLeft.No;
            btnIzindeOlanlar.Size = new Size(299, 100);
            btnIzindeOlanlar.Text = "İzinde Olanlar";
            btnIzindeOlanlar.Click += btnIzindeOlanlar_Click;
            // 
            // tsSeparator4
            // 
            tsSeparator4.BackColor = SystemColors.ControlLight;
            tsSeparator4.Name = "tsSeparator4";
            tsSeparator4.Size = new Size(279, 6);
            // 
            // btnKategoriler
            // 
            btnKategoriler.AutoSize = false;
            btnKategoriler.BackColor = Color.Transparent;
            btnKategoriler.BackgroundImageLayout = ImageLayout.Zoom;
            btnKategoriler.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnKategoriler.Image = Properties.Resources.categories;
            btnKategoriler.ImageAlign = ContentAlignment.MiddleRight;
            btnKategoriler.ImageScaling = ToolStripItemImageScaling.None;
            btnKategoriler.ImageTransparentColor = Color.Magenta;
            btnKategoriler.Name = "btnKategoriler";
            btnKategoriler.RightToLeft = RightToLeft.No;
            btnKategoriler.Size = new Size(299, 100);
            btnKategoriler.Text = "Kategoriler";
            btnKategoriler.Click += btnKategoriler_Click;
            // 
            // tsTopBar
            // 
            tsTopBar.AutoSize = false;
            tsTopBar.BackColor = SystemColors.ControlLight;
            tsTopBar.GripMargin = new Padding(0);
            tsTopBar.GripStyle = ToolStripGripStyle.Hidden;
            tsTopBar.ImageScalingSize = new Size(24, 24);
            tsTopBar.Items.AddRange(new ToolStripItem[] { tslSicilNo, tslTarihSaat, toolStripSeparator1, tslAdi, tslSoyadi, toolStripSeparator2, tslBakiye });
            tsTopBar.Location = new Point(0, 0);
            tsTopBar.Name = "tsTopBar";
            tsTopBar.Padding = new Padding(0, 0, 2, 0);
            tsTopBar.RenderMode = ToolStripRenderMode.System;
            tsTopBar.Size = new Size(1460, 30);
            tsTopBar.TabIndex = 2;
            // 
            // tslSicilNo
            // 
            tslSicilNo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tslSicilNo.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tslSicilNo.Margin = new Padding(0, 1, 0, 1);
            tslSicilNo.Name = "tslSicilNo";
            tslSicilNo.Size = new Size(76, 28);
            tslSicilNo.Text = "Sicil No";
            // 
            // tslTarihSaat
            // 
            tslTarihSaat.Alignment = ToolStripItemAlignment.Right;
            tslTarihSaat.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tslTarihSaat.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tslTarihSaat.Margin = new Padding(0, 1, 0, 1);
            tslTarihSaat.Name = "tslTarihSaat";
            tslTarihSaat.Size = new Size(95, 28);
            tslTarihSaat.Text = "Tarih Saat";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 30);
            // 
            // tslAdi
            // 
            tslAdi.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tslAdi.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tslAdi.Margin = new Padding(0, 1, 0, 1);
            tslAdi.Name = "tslAdi";
            tslAdi.Size = new Size(41, 28);
            tslAdi.Text = "Adı";
            // 
            // tslSoyadi
            // 
            tslSoyadi.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tslSoyadi.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tslSoyadi.Margin = new Padding(0, 1, 0, 1);
            tslSoyadi.Name = "tslSoyadi";
            tslSoyadi.Size = new Size(69, 28);
            tslSoyadi.Text = "Soyadı";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 30);
            // 
            // tslBakiye
            // 
            tslBakiye.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tslBakiye.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tslBakiye.Margin = new Padding(0, 1, 0, 1);
            tslBakiye.Name = "tslBakiye";
            tslBakiye.Size = new Size(70, 28);
            tslBakiye.Text = "Bakiye";
            // 
            // tSaatTarih
            // 
            tSaatTarih.Interval = 1000;
            tSaatTarih.Tick += tSaatTarih_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1760, 990);
            ControlBox = false;
            Controls.Add(tsTopBar);
            Controls.Add(tsLeftBar);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kantot - Kantin Hızlı Satış Otomasyonu";
            tsLeftBar.ResumeLayout(false);
            tsLeftBar.PerformLayout();
            tsTopBar.ResumeLayout(false);
            tsTopBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public ToolStripButton btnIzinAl;
        private ToolStripSeparator tsSeparator1;
        public ToolStripButton btnIzinlerim;
        private ToolStripSeparator tsSeparator3;
        private ToolStripButton btnExit;
        private ToolStripSeparator tsSeparator6;
        private ToolStripSeparator tsSeparator5;
        private ToolStrip tsLeftBar;
        private ToolStrip tsTopBar;
        private ToolStripLabel tslTarihSaat;
        private System.Windows.Forms.Timer tSaatTarih;
        public ToolStripButton btnIzinlerGecmisi;
        public ToolStripButton btnIzinIstekleri;
        private ToolStripSeparator tsSeparator2;
        public ToolStripButton btnIzindeOlanlar;
        public ToolStripButton btnKategoriler;
        private ToolStripSeparator tsSeparator4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        public ToolStripLabel tslSicilNo;
        public ToolStripLabel tslAdi;
        public ToolStripLabel tslSoyadi;
        public ToolStripLabel tslBakiye;
    }
}