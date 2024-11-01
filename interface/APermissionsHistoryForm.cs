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
    public partial class APermissionsHistoryForm : Form
    {
        public APermissionsHistoryForm()
        {
            InitializeComponent();
            veriDoldur();
        }

        private void veriDoldur()
        {
            string sorgu = "SELECT izingec.sicilno, CONCAT(calisanlar.adi, ' ', calisanlar.soyadi) AS adisoyadi, calisanlar.departman, izintur.turadi, izingec.bastar, izingec.bittar, izingec.aciklama, izingec.izindurumu, izingec.durumnot FROM izingec INNER JOIN calisanlar ON izingec.sicilno = calisanlar.sicilno INNER JOIN izintur ON izingec.tid = izintur.tid where izingec.bittar < CURDATE()";
            dgvProducts.DataSource = DBOperation.veriGetir(sorgu);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchActive_Click(object sender, EventArgs e)
        {
            if (tbSearch.Visible == false)
            {
                tbSearch.Visible = true;
                timerSearchAutoDeactive.Start();
            }
            else if (tbSearch.Visible == true)
            {
                tbSearch.Visible = false;
                tbSearch.Clear();
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgvProducts.DataSource).DefaultView.RowFilter = string.Format("adisoyadi LIKE '%{0}%' OR departman LIKE '%{0}%'", tbSearch.Text);
        }

        private void timerSearchAutoDeactive_Tick(object sender, EventArgs e)
        {
            btnSearchActive.PerformClick();
            timerSearchAutoDeactive.Stop();
        }
    }
}
