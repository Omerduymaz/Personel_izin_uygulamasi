namespace Kantot
{
    partial class LeaveRequestForm
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
            tlpControl = new TableLayoutPanel();
            btnIptal = new Button();
            btnIzinAl = new Button();
            gBox4 = new GroupBox();
            cmbIzinTurleri = new ComboBox();
            lblRedStar4 = new Label();
            gBox7 = new GroupBox();
            tbAciklama = new TextBox();
            label1 = new Label();
            gBox1 = new GroupBox();
            tbSicilNo = new TextBox();
            gBox3 = new GroupBox();
            tbSoyadi = new TextBox();
            gBox2 = new GroupBox();
            tbAdi = new TextBox();
            dtpBas = new DateTimePicker();
            gBox5 = new GroupBox();
            gBox6 = new GroupBox();
            dtpBit = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            tlpControl.SuspendLayout();
            gBox4.SuspendLayout();
            gBox7.SuspendLayout();
            gBox1.SuspendLayout();
            gBox3.SuspendLayout();
            gBox2.SuspendLayout();
            gBox5.SuspendLayout();
            gBox6.SuspendLayout();
            SuspendLayout();
            // 
            // tlpControl
            // 
            tlpControl.ColumnCount = 2;
            tlpControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000038F));
            tlpControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpControl.Controls.Add(btnIptal, 0, 0);
            tlpControl.Controls.Add(btnIzinAl, 1, 0);
            tlpControl.Dock = DockStyle.Bottom;
            tlpControl.Location = new Point(0, 747);
            tlpControl.Margin = new Padding(0);
            tlpControl.Name = "tlpControl";
            tlpControl.RowCount = 1;
            tlpControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpControl.Size = new Size(1488, 90);
            tlpControl.TabIndex = 42;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.FromArgb(0, 0, 64);
            btnIptal.Dock = DockStyle.Fill;
            btnIptal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIptal.ForeColor = Color.White;
            btnIptal.Image = Properties.Resources.cancelsales;
            btnIptal.ImageAlign = ContentAlignment.MiddleRight;
            btnIptal.Location = new Point(0, 0);
            btnIptal.Margin = new Padding(0);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(744, 90);
            btnIptal.TabIndex = 46;
            btnIptal.TabStop = false;
            btnIptal.Text = "İptal Et";
            btnIptal.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnIzinAl
            // 
            btnIzinAl.BackColor = Color.FromArgb(0, 0, 64);
            btnIzinAl.Dock = DockStyle.Fill;
            btnIzinAl.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIzinAl.ForeColor = Color.White;
            btnIzinAl.Image = Properties.Resources.deleterow;
            btnIzinAl.ImageAlign = ContentAlignment.MiddleRight;
            btnIzinAl.Location = new Point(744, 0);
            btnIzinAl.Margin = new Padding(0);
            btnIzinAl.Name = "btnIzinAl";
            btnIzinAl.Size = new Size(744, 90);
            btnIzinAl.TabIndex = 45;
            btnIzinAl.TabStop = false;
            btnIzinAl.Text = "İzin Talebi Gönder";
            btnIzinAl.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIzinAl.UseVisualStyleBackColor = false;
            btnIzinAl.Click += btnIzinAl_Click;
            // 
            // gBox4
            // 
            gBox4.Controls.Add(cmbIzinTurleri);
            gBox4.Controls.Add(lblRedStar4);
            gBox4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox4.ForeColor = Color.FromArgb(0, 0, 64);
            gBox4.Location = new Point(599, 151);
            gBox4.Margin = new Padding(0);
            gBox4.Name = "gBox4";
            gBox4.Padding = new Padding(0);
            gBox4.Size = new Size(603, 65);
            gBox4.TabIndex = 45;
            gBox4.TabStop = false;
            gBox4.Text = "İzin Türü:";
            // 
            // cmbIzinTurleri
            // 
            cmbIzinTurleri.BackColor = SystemColors.Window;
            cmbIzinTurleri.Dock = DockStyle.Fill;
            cmbIzinTurleri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIzinTurleri.Font = new Font("Calibri", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbIzinTurleri.FormattingEnabled = true;
            cmbIzinTurleri.IntegralHeight = false;
            cmbIzinTurleri.ItemHeight = 28;
            cmbIzinTurleri.Location = new Point(0, 24);
            cmbIzinTurleri.Margin = new Padding(0);
            cmbIzinTurleri.MaxDropDownItems = 10;
            cmbIzinTurleri.Name = "cmbIzinTurleri";
            cmbIzinTurleri.Size = new Size(603, 36);
            cmbIzinTurleri.TabIndex = 17;
            // 
            // lblRedStar4
            // 
            lblRedStar4.AutoSize = true;
            lblRedStar4.BackColor = Color.Transparent;
            lblRedStar4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblRedStar4.ForeColor = Color.Red;
            lblRedStar4.Location = new Point(580, 0);
            lblRedStar4.Margin = new Padding(0);
            lblRedStar4.Name = "lblRedStar4";
            lblRedStar4.Size = new Size(23, 30);
            lblRedStar4.TabIndex = 18;
            lblRedStar4.Text = "*";
            // 
            // gBox7
            // 
            gBox7.Controls.Add(tbAciklama);
            gBox7.Controls.Add(label1);
            gBox7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox7.ForeColor = Color.FromArgb(0, 0, 64);
            gBox7.Location = new Point(284, 375);
            gBox7.Margin = new Padding(0);
            gBox7.Name = "gBox7";
            gBox7.Padding = new Padding(0);
            gBox7.Size = new Size(918, 250);
            gBox7.TabIndex = 46;
            gBox7.TabStop = false;
            gBox7.Text = "Açıklama:";
            gBox7.Enter += gBox7_Enter;
            // 
            // tbAciklama
            // 
            tbAciklama.Dock = DockStyle.Fill;
            tbAciklama.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tbAciklama.Location = new Point(0, 24);
            tbAciklama.MaxLength = 200;
            tbAciklama.Multiline = true;
            tbAciklama.Name = "tbAciklama";
            tbAciklama.Size = new Size(918, 226);
            tbAciklama.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(895, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(23, 30);
            label1.TabIndex = 19;
            label1.Text = "*";
            // 
            // gBox1
            // 
            gBox1.Controls.Add(tbSicilNo);
            gBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox1.ForeColor = Color.FromArgb(0, 0, 64);
            gBox1.Location = new Point(284, 151);
            gBox1.Margin = new Padding(0);
            gBox1.Name = "gBox1";
            gBox1.Padding = new Padding(0);
            gBox1.Size = new Size(300, 65);
            gBox1.TabIndex = 47;
            gBox1.TabStop = false;
            gBox1.Text = "Sicil No:";
            // 
            // tbSicilNo
            // 
            tbSicilNo.BackColor = Color.White;
            tbSicilNo.Dock = DockStyle.Fill;
            tbSicilNo.Enabled = false;
            tbSicilNo.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tbSicilNo.Location = new Point(0, 24);
            tbSicilNo.Multiline = true;
            tbSicilNo.Name = "tbSicilNo";
            tbSicilNo.Size = new Size(300, 41);
            tbSicilNo.TabIndex = 5;
            // 
            // gBox3
            // 
            gBox3.Controls.Add(tbSoyadi);
            gBox3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox3.ForeColor = Color.FromArgb(0, 0, 64);
            gBox3.Location = new Point(284, 287);
            gBox3.Margin = new Padding(0);
            gBox3.Name = "gBox3";
            gBox3.Padding = new Padding(0);
            gBox3.Size = new Size(300, 65);
            gBox3.TabIndex = 48;
            gBox3.TabStop = false;
            gBox3.Text = "Soyadı:";
            // 
            // tbSoyadi
            // 
            tbSoyadi.BackColor = Color.White;
            tbSoyadi.Dock = DockStyle.Fill;
            tbSoyadi.Enabled = false;
            tbSoyadi.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tbSoyadi.Location = new Point(0, 24);
            tbSoyadi.Multiline = true;
            tbSoyadi.Name = "tbSoyadi";
            tbSoyadi.Size = new Size(300, 41);
            tbSoyadi.TabIndex = 5;
            // 
            // gBox2
            // 
            gBox2.Controls.Add(tbAdi);
            gBox2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox2.ForeColor = Color.FromArgb(0, 0, 64);
            gBox2.Location = new Point(284, 219);
            gBox2.Margin = new Padding(0);
            gBox2.Name = "gBox2";
            gBox2.Padding = new Padding(0);
            gBox2.Size = new Size(300, 65);
            gBox2.TabIndex = 48;
            gBox2.TabStop = false;
            gBox2.Text = "Adı:";
            // 
            // tbAdi
            // 
            tbAdi.BackColor = Color.White;
            tbAdi.Dock = DockStyle.Fill;
            tbAdi.Enabled = false;
            tbAdi.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tbAdi.Location = new Point(0, 24);
            tbAdi.Multiline = true;
            tbAdi.Name = "tbAdi";
            tbAdi.Size = new Size(300, 41);
            tbAdi.TabIndex = 5;
            // 
            // dtpBas
            // 
            dtpBas.CalendarForeColor = Color.FromArgb(0, 0, 64);
            dtpBas.CalendarTitleForeColor = Color.FromArgb(0, 0, 64);
            dtpBas.CustomFormat = "";
            dtpBas.Dock = DockStyle.Fill;
            dtpBas.Location = new Point(0, 24);
            dtpBas.Name = "dtpBas";
            dtpBas.RightToLeft = RightToLeft.No;
            dtpBas.Size = new Size(300, 31);
            dtpBas.TabIndex = 49;
            dtpBas.ValueChanged += dtpBas_ValueChanged;
            // 
            // gBox5
            // 
            gBox5.Controls.Add(dtpBas);
            gBox5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox5.ForeColor = Color.FromArgb(0, 0, 64);
            gBox5.Location = new Point(599, 219);
            gBox5.Margin = new Padding(0);
            gBox5.Name = "gBox5";
            gBox5.Padding = new Padding(0);
            gBox5.Size = new Size(300, 65);
            gBox5.TabIndex = 51;
            gBox5.TabStop = false;
            gBox5.Text = "İzin Başlangıç:";
            // 
            // gBox6
            // 
            gBox6.Controls.Add(dtpBit);
            gBox6.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox6.ForeColor = Color.FromArgb(0, 0, 64);
            gBox6.Location = new Point(902, 219);
            gBox6.Margin = new Padding(0);
            gBox6.Name = "gBox6";
            gBox6.Padding = new Padding(0);
            gBox6.Size = new Size(300, 65);
            gBox6.TabIndex = 52;
            gBox6.TabStop = false;
            gBox6.Text = "İzin Bitiş:";
            // 
            // dtpBit
            // 
            dtpBit.CalendarForeColor = Color.FromArgb(0, 0, 64);
            dtpBit.CalendarTitleForeColor = Color.FromArgb(0, 0, 64);
            dtpBit.CustomFormat = "";
            dtpBit.Dock = DockStyle.Fill;
            dtpBit.Location = new Point(0, 24);
            dtpBit.Name = "dtpBit";
            dtpBit.Size = new Size(300, 31);
            dtpBit.TabIndex = 49;
            dtpBit.ValueChanged += dtpBas_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(599, 319);
            label2.Name = "label2";
            label2.Size = new Size(275, 23);
            label2.TabIndex = 50;
            label2.Text = "İzinli Olunacak Toplam Gün Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(871, 315);
            label3.Name = "label3";
            label3.Size = new Size(20, 28);
            label3.TabIndex = 53;
            label3.Text = "1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1488, 100);
            panel1.TabIndex = 54;
            // 
            // LeaveRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1488, 837);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(gBox6);
            Controls.Add(gBox5);
            Controls.Add(gBox3);
            Controls.Add(gBox2);
            Controls.Add(gBox1);
            Controls.Add(gBox4);
            Controls.Add(tlpControl);
            Controls.Add(gBox7);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LeaveRequestForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            tlpControl.ResumeLayout(false);
            gBox4.ResumeLayout(false);
            gBox4.PerformLayout();
            gBox7.ResumeLayout(false);
            gBox7.PerformLayout();
            gBox1.ResumeLayout(false);
            gBox1.PerformLayout();
            gBox3.ResumeLayout(false);
            gBox3.PerformLayout();
            gBox2.ResumeLayout(false);
            gBox2.PerformLayout();
            gBox5.ResumeLayout(false);
            gBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tlpControl;
        private Button btnIzinAl;
        private Button btnIptal;
        private GroupBox gBox4;
        private ComboBox cmbIzinTurleri;
        private Label lblRedStar4;
        private GroupBox gBox7;
        private TextBox tbAciklama;
        private Label label1;
        private GroupBox gBox1;
        public TextBox tbSicilNo;
        private GroupBox gBox3;
        public TextBox tbSoyadi;
        private GroupBox gBox2;
        public TextBox tbAdi;
        private DateTimePicker dtpBas;
        private GroupBox gBox5;
        private GroupBox gBox6;
        private DateTimePicker dtpBit;
        private Label label2;
        private Label label3;
        private Panel panel1;

        public object StatusStripAligment { get; private set; }
    }
}
