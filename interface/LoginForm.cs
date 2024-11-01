using Kantot.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kantot
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool AuthenticateUser(string sicilNo, string sifre)
        {
            string query = $"SELECT COUNT(*) FROM calisanlar WHERE sicilno = '{sicilNo}' AND sifre = '{sifre}'";
            DataTable result = DBOperation.veriGetir(query);
            return result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0;
        }

        private void UpdateAdminStatus(string sicilNo)
        {
            string query = $"SELECT adi, soyadi, bakiye, yonetici FROM calisanlar WHERE sicilno = '{sicilNo}'";
            DataTable result = DBOperation.veriGetir(query);

            if (result.Rows.Count > 0)
            {
                KOParameter.sicilno = sicilNo;
                KOParameter.adi = Convert.ToString(result.Rows[0]["adi"]);
                KOParameter.soyadi = Convert.ToString(result.Rows[0]["soyadi"]);
                KOParameter.bakiye = Convert.ToInt32(result.Rows[0]["bakiye"]);
                KOParameter.admin = Convert.ToInt32(result.Rows[0]["yonetici"]);
            }
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string sicilNo = tbSicilNo.Text;
            string sifre = tbSifre.Text;

            if (AuthenticateUser(sicilNo, sifre))
            {
                UpdateAdminStatus(sicilNo);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Geçersiz Sicil No veya Şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Girisle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGirisYap.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
