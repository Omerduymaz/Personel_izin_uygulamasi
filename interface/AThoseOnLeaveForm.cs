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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Kantot
{
    public partial class AThoseOnLeaveForm : Form
    {
        public AThoseOnLeaveForm()
        {
            InitializeComponent();
            veriDoldur();
        }

        private void veriDoldur()
        {
            string sorgu = "SELECT izingec.sicilno, CONCAT(calisanlar.adi, ' ', calisanlar.soyadi) AS adisoyadi, calisanlar.departman, izintur.turadi, izingec.bastar, izingec.bittar, izingec.aciklama FROM izingec INNER JOIN calisanlar ON izingec.sicilno = calisanlar.sicilno INNER JOIN izintur ON izingec.tid = izintur.tid where izingec.bastar <= CURDATE() and izingec.bittar >= CURDATE() and izingec.izindurumu='Onaylandı';";
            dgvProducts.DataSource = DBOperation.veriGetir(sorgu);
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

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

        }

    }
}
