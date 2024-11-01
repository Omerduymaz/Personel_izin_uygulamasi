namespace Kantot
{
    partial class APermissionTypesForm
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
            gBox2 = new GroupBox();
            tbKod = new TextBox();
            gBox1 = new GroupBox();
            tbIzınAdı = new TextBox();
            btnTurnBack = new Button();
            btnEkle = new Button();
            lBoxIzinTurleri = new ListBox();
            cmbDurum = new CheckBox();
            cmsAktifPasif = new ContextMenuStrip(components);
            tsbtnAktifPasif = new ToolStripMenuItem();
            gBox2.SuspendLayout();
            gBox1.SuspendLayout();
            cmsAktifPasif.SuspendLayout();
            SuspendLayout();
            // 
            // gBox2
            // 
            gBox2.Controls.Add(tbKod);
            gBox2.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox2.Location = new Point(276, 150);
            gBox2.Margin = new Padding(0);
            gBox2.Name = "gBox2";
            gBox2.Padding = new Padding(0);
            gBox2.Size = new Size(140, 75);
            gBox2.TabIndex = 3;
            gBox2.TabStop = false;
            gBox2.Text = "KOD:";
            // 
            // tbKod
            // 
            tbKod.Dock = DockStyle.Fill;
            tbKod.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbKod.Location = new Point(0, 26);
            tbKod.Multiline = true;
            tbKod.Name = "tbKod";
            tbKod.Size = new Size(140, 49);
            tbKod.TabIndex = 4;
            tbKod.TextAlign = HorizontalAlignment.Right;
            tbKod.WordWrap = false;
            tbKod.KeyDown += EnterBlocking;
            tbKod.KeyPress += NumericalControl;
            // 
            // gBox1
            // 
            gBox1.Controls.Add(tbIzınAdı);
            gBox1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox1.Location = new Point(422, 150);
            gBox1.Margin = new Padding(0);
            gBox1.Name = "gBox1";
            gBox1.Padding = new Padding(0);
            gBox1.Size = new Size(750, 75);
            gBox1.TabIndex = 1;
            gBox1.TabStop = false;
            gBox1.Text = "İzin Türü:";
            // 
            // tbIzınAdı
            // 
            tbIzınAdı.BackColor = Color.White;
            tbIzınAdı.Dock = DockStyle.Fill;
            tbIzınAdı.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            tbIzınAdı.Location = new Point(0, 26);
            tbIzınAdı.Multiline = true;
            tbIzınAdı.Name = "tbIzınAdı";
            tbIzınAdı.Size = new Size(750, 49);
            tbIzınAdı.TabIndex = 2;
            tbIzınAdı.WordWrap = false;
            tbIzınAdı.KeyDown += EnterBlocking;
            // 
            // btnTurnBack
            // 
            btnTurnBack.BackColor = Color.IndianRed;
            btnTurnBack.FlatAppearance.BorderColor = Color.IndianRed;
            btnTurnBack.FlatStyle = FlatStyle.Flat;
            btnTurnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnTurnBack.Image = Properties.Resources.turnback;
            btnTurnBack.Location = new Point(276, 537);
            btnTurnBack.Name = "btnTurnBack";
            btnTurnBack.Size = new Size(140, 90);
            btnTurnBack.TabIndex = 8;
            btnTurnBack.Text = "Geri Dön (ESC)";
            btnTurnBack.TextImageRelation = TextImageRelation.ImageAboveText;
            btnTurnBack.UseVisualStyleBackColor = false;
            btnTurnBack.Click += btnTurnBack_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(0, 0, 64);
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Calibri", 14F, FontStyle.Bold);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(276, 231);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(140, 80);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle (ENTER)";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lBoxIzinTurleri
            // 
            lBoxIzinTurleri.ContextMenuStrip = cmsAktifPasif;
            lBoxIzinTurleri.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            lBoxIzinTurleri.FormattingEnabled = true;
            lBoxIzinTurleri.ItemHeight = 28;
            lBoxIzinTurleri.Location = new Point(422, 231);
            lBoxIzinTurleri.Name = "lBoxIzinTurleri";
            lBoxIzinTurleri.Size = new Size(750, 396);
            lBoxIzinTurleri.TabIndex = 5;
            // 
            // cmbDurum
            // 
            cmbDurum.Appearance = Appearance.Button;
            cmbDurum.BackColor = Color.FromArgb(0, 0, 64);
            cmbDurum.FlatStyle = FlatStyle.Flat;
            cmbDurum.Font = new Font("Calibri", 14F, FontStyle.Bold);
            cmbDurum.ForeColor = Color.White;
            cmbDurum.Location = new Point(276, 414);
            cmbDurum.Margin = new Padding(0);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(140, 120);
            cmbDurum.TabIndex = 9;
            cmbDurum.Text = "Aktif Olmayan Türler";
            cmbDurum.TextAlign = ContentAlignment.MiddleCenter;
            cmbDurum.UseVisualStyleBackColor = false;
            cmbDurum.CheckedChanged += cmbDurum_CheckedChanged;
            // 
            // cmsAktifPasif
            // 
            cmsAktifPasif.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            cmsAktifPasif.Items.AddRange(new ToolStripItem[] { tsbtnAktifPasif });
            cmsAktifPasif.Name = "cmsAktifPasif";
            cmsAktifPasif.Size = new Size(181, 56);
            // 
            // tsbtnAktifPasif
            // 
            tsbtnAktifPasif.Name = "tsbtnAktifPasif";
            tsbtnAktifPasif.Size = new Size(180, 30);
            tsbtnAktifPasif.Text = "Pasif Et";
            tsbtnAktifPasif.Click += tsbtnAktifPasif_Click;
            // 
            // APermissionTypesForm
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1488, 837);
            ControlBox = false;
            Controls.Add(cmbDurum);
            Controls.Add(lBoxIzinTurleri);
            Controls.Add(btnEkle);
            Controls.Add(gBox2);
            Controls.Add(gBox1);
            Controls.Add(btnTurnBack);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "APermissionTypesForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "İzin Türleri";
            gBox2.ResumeLayout(false);
            gBox2.PerformLayout();
            gBox1.ResumeLayout(false);
            gBox1.PerformLayout();
            cmsAktifPasif.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBox2;
        private TextBox tbKod;
        private GroupBox gBox1;
        private TextBox tbIzınAdı;
        private Button btnTurnBack;
        private Button btnDurumGuncelle;
        private Button btnEkle;
        private ListBox lBoxIzinTurleri;
        private CheckBox cmbDurum;
        private ContextMenuStrip cmsAktifPasif;
        private ToolStripMenuItem tsbtnAktifPasif;
    }
}