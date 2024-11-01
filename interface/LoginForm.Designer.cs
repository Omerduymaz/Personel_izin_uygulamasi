namespace Kantot
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            gBox1 = new GroupBox();
            tbSicilNo = new TextBox();
            gBox2 = new GroupBox();
            tbSifre = new TextBox();
            btnGirisYap = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnCikisYap = new Button();
            pictureBox2 = new PictureBox();
            gBox1.SuspendLayout();
            gBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gBox1
            // 
            gBox1.Controls.Add(tbSicilNo);
            gBox1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox1.ForeColor = Color.FromArgb(0, 0, 64);
            gBox1.Location = new Point(202, 140);
            gBox1.Margin = new Padding(0);
            gBox1.Name = "gBox1";
            gBox1.Padding = new Padding(0);
            gBox1.Size = new Size(330, 65);
            gBox1.TabIndex = 48;
            gBox1.TabStop = false;
            gBox1.Text = "Kullanıcı Adı";
            // 
            // tbSicilNo
            // 
            tbSicilNo.BackColor = Color.White;
            tbSicilNo.Dock = DockStyle.Fill;
            tbSicilNo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            tbSicilNo.Location = new Point(0, 24);
            tbSicilNo.Multiline = true;
            tbSicilNo.Name = "tbSicilNo";
            tbSicilNo.Size = new Size(330, 41);
            tbSicilNo.TabIndex = 5;
            tbSicilNo.KeyDown += Girisle_KeyDown;
            // 
            // gBox2
            // 
            gBox2.Controls.Add(tbSifre);
            gBox2.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gBox2.ForeColor = Color.FromArgb(0, 0, 64);
            gBox2.Location = new Point(202, 208);
            gBox2.Margin = new Padding(0);
            gBox2.Name = "gBox2";
            gBox2.Padding = new Padding(0);
            gBox2.Size = new Size(330, 65);
            gBox2.TabIndex = 49;
            gBox2.TabStop = false;
            gBox2.Text = "Şifre:";
            // 
            // tbSifre
            // 
            tbSifre.BackColor = Color.White;
            tbSifre.Dock = DockStyle.Fill;
            tbSifre.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            tbSifre.Location = new Point(0, 24);
            tbSifre.Multiline = true;
            tbSifre.Name = "tbSifre";
            tbSifre.PasswordChar = '*';
            tbSifre.Size = new Size(330, 41);
            tbSifre.TabIndex = 5;
            tbSifre.KeyDown += Girisle_KeyDown;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(0, 0, 64);
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGirisYap.ForeColor = Color.White;
            btnGirisYap.Location = new Point(202, 279);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(330, 82);
            btnGirisYap.TabIndex = 50;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 100);
            panel1.TabIndex = 51;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(534, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(btnCikisYap);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 413);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 37);
            panel2.TabIndex = 52;
            // 
            // btnCikisYap
            // 
            btnCikisYap.BackColor = Color.Black;
            btnCikisYap.FlatStyle = FlatStyle.Flat;
            btnCikisYap.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikisYap.ForeColor = Color.White;
            btnCikisYap.Location = new Point(477, 2);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(153, 32);
            btnCikisYap.TabIndex = 55;
            btnCikisYap.Text = "Çıkış Yap";
            btnCikisYap.UseVisualStyleBackColor = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 164);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 178);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(633, 450);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnGirisYap);
            Controls.Add(gBox2);
            Controls.Add(gBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            gBox1.ResumeLayout(false);
            gBox1.PerformLayout();
            gBox2.ResumeLayout(false);
            gBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBox1;
        public TextBox tbSicilNo;
        private GroupBox gBox2;
        public TextBox tbSifre;
        private Button btnGirisYap;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnCikisYap;
    }
}