namespace Kantot
{
    partial class APermissionDetail
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
            panel1 = new Panel();
            tbAdi = new TextBox();
            gBox2 = new GroupBox();
            tbSicilNo = new TextBox();
            gBox1 = new GroupBox();
            tbAciklama = new TextBox();
            gBox7 = new GroupBox();
            btnGeriDon = new Button();
            tlpControl = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tbTuru = new TextBox();
            groupBox2 = new GroupBox();
            tbBasTar = new TextBox();
            groupBox3 = new GroupBox();
            tbBitTar = new TextBox();
            groupBox4 = new GroupBox();
            tbDepartman = new TextBox();
            gBox2.SuspendLayout();
            gBox1.SuspendLayout();
            gBox7.SuspendLayout();
            tlpControl.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1488, 100);
            panel1.TabIndex = 65;
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
            tbAdi.Size = new Size(500, 41);
            tbAdi.TabIndex = 5;
            // 
            // gBox2
            // 
            gBox2.Controls.Add(tbAdi);
            gBox2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox2.ForeColor = Color.FromArgb(0, 0, 64);
            gBox2.Location = new Point(284, 287);
            gBox2.Margin = new Padding(0);
            gBox2.Name = "gBox2";
            gBox2.Padding = new Padding(0);
            gBox2.Size = new Size(500, 65);
            gBox2.TabIndex = 59;
            gBox2.TabStop = false;
            gBox2.Text = "Adı Soyadı:";
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
            tbSicilNo.Size = new Size(309, 41);
            tbSicilNo.TabIndex = 5;
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
            gBox1.Size = new Size(309, 65);
            gBox1.TabIndex = 58;
            gBox1.TabStop = false;
            gBox1.Text = "Sicil No:";
            // 
            // tbAciklama
            // 
            tbAciklama.Dock = DockStyle.Fill;
            tbAciklama.Enabled = false;
            tbAciklama.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tbAciklama.Location = new Point(0, 24);
            tbAciklama.MaxLength = 200;
            tbAciklama.Multiline = true;
            tbAciklama.Name = "tbAciklama";
            tbAciklama.Size = new Size(918, 226);
            tbAciklama.TabIndex = 12;
            // 
            // gBox7
            // 
            gBox7.Controls.Add(tbAciklama);
            gBox7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox7.ForeColor = Color.FromArgb(0, 0, 64);
            gBox7.Location = new Point(284, 375);
            gBox7.Margin = new Padding(0);
            gBox7.Name = "gBox7";
            gBox7.Padding = new Padding(0);
            gBox7.Size = new Size(918, 250);
            gBox7.TabIndex = 57;
            gBox7.TabStop = false;
            gBox7.Text = "Açıklama:";
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.FromArgb(0, 0, 64);
            btnGeriDon.Dock = DockStyle.Fill;
            btnGeriDon.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriDon.ForeColor = Color.White;
            btnGeriDon.Image = Properties.Resources.turnback;
            btnGeriDon.ImageAlign = ContentAlignment.MiddleRight;
            btnGeriDon.Location = new Point(0, 0);
            btnGeriDon.Margin = new Padding(0);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(1488, 90);
            btnGeriDon.TabIndex = 46;
            btnGeriDon.TabStop = false;
            btnGeriDon.Text = "  Geri Dön";
            btnGeriDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // tlpControl
            // 
            tlpControl.ColumnCount = 1;
            tlpControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpControl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpControl.Controls.Add(btnGeriDon, 0, 0);
            tlpControl.Dock = DockStyle.Bottom;
            tlpControl.Location = new Point(0, 747);
            tlpControl.Margin = new Padding(0);
            tlpControl.Name = "tlpControl";
            tlpControl.RowCount = 1;
            tlpControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpControl.Size = new Size(1488, 90);
            tlpControl.TabIndex = 55;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbTuru);
            groupBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(0, 0, 64);
            groupBox1.Location = new Point(596, 151);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(603, 65);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "İzin Türü:";
            // 
            // tbTuru
            // 
            tbTuru.BackColor = Color.White;
            tbTuru.Dock = DockStyle.Fill;
            tbTuru.Enabled = false;
            tbTuru.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tbTuru.Location = new Point(0, 24);
            tbTuru.Multiline = true;
            tbTuru.Name = "tbTuru";
            tbTuru.Size = new Size(603, 41);
            tbTuru.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbBasTar);
            groupBox2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(0, 0, 64);
            groupBox2.Location = new Point(365, 222);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(0);
            groupBox2.Size = new Size(340, 65);
            groupBox2.TabIndex = 67;
            groupBox2.TabStop = false;
            groupBox2.Text = "Başlangıç Tarihi:";
            // 
            // tbBasTar
            // 
            tbBasTar.BackColor = Color.White;
            tbBasTar.Dock = DockStyle.Fill;
            tbBasTar.Enabled = false;
            tbBasTar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tbBasTar.Location = new Point(0, 24);
            tbBasTar.Multiline = true;
            tbBasTar.Name = "tbBasTar";
            tbBasTar.Size = new Size(340, 41);
            tbBasTar.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbBitTar);
            groupBox3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.FromArgb(0, 0, 64);
            groupBox3.Location = new Point(749, 222);
            groupBox3.Margin = new Padding(0);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(0);
            groupBox3.Size = new Size(340, 65);
            groupBox3.TabIndex = 67;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bitiş Tarihi:";
            // 
            // tbBitTar
            // 
            tbBitTar.BackColor = Color.White;
            tbBitTar.Dock = DockStyle.Fill;
            tbBitTar.Enabled = false;
            tbBitTar.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tbBitTar.Location = new Point(0, 24);
            tbBitTar.Multiline = true;
            tbBitTar.Name = "tbBitTar";
            tbBitTar.Size = new Size(340, 41);
            tbBitTar.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tbDepartman);
            groupBox4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.ForeColor = Color.FromArgb(0, 0, 64);
            groupBox4.Location = new Point(787, 287);
            groupBox4.Margin = new Padding(0);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(0);
            groupBox4.Size = new Size(412, 65);
            groupBox4.TabIndex = 68;
            groupBox4.TabStop = false;
            groupBox4.Text = "Departman:";
            // 
            // tbDepartman
            // 
            tbDepartman.BackColor = Color.White;
            tbDepartman.Dock = DockStyle.Fill;
            tbDepartman.Enabled = false;
            tbDepartman.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tbDepartman.Location = new Point(0, 24);
            tbDepartman.Multiline = true;
            tbDepartman.Name = "tbDepartman";
            tbDepartman.Size = new Size(412, 41);
            tbDepartman.TabIndex = 5;
            // 
            // APermissionDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1488, 837);
            ControlBox = false;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(gBox2);
            Controls.Add(gBox1);
            Controls.Add(gBox7);
            Controls.Add(tlpControl);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "APermissionDetail";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            gBox2.ResumeLayout(false);
            gBox2.PerformLayout();
            gBox1.ResumeLayout(false);
            gBox1.PerformLayout();
            gBox7.ResumeLayout(false);
            gBox7.PerformLayout();
            tlpControl.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public TextBox tbAdi;
        private GroupBox gBox2;
        public TextBox tbSicilNo;
        private GroupBox gBox1;
        private TextBox tbAciklama;
        private GroupBox gBox7;
        private Button btnGeriDon;
        private TableLayoutPanel tlpControl;
        private GroupBox groupBox1;
        public TextBox tbTuru;
        private GroupBox groupBox2;
        public TextBox tbBasTar;
        private GroupBox groupBox3;
        public TextBox tbBitTar;
        private GroupBox groupBox4;
        public TextBox tbDepartman;
    }
}