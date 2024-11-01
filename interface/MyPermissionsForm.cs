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
    public partial class MyPermissionsForm : Form
    {
        public MyPermissionsForm()
        {
            InitializeComponent();
            veriDoldur();
            timer.Start();
        }
        private void veriDoldur()
        {
            string sorgu = "SELECT CONCAT(izintur.tid, ' - ', izintur.turadi) AS izinturu, izintalepleri.bastar, izintalepleri.bittar, izintalepleri.aciklama FROM izintalepleri INNER JOIN izintur ON izintalepleri.tid = izintur.tid where izintalepleri.sicilno='" + KOParameter.sicilno + "'";
            dgvOnayBekleyen.DataSource = DBOperation.veriGetir(sorgu);
            string sorgu2 = "SELECT CONCAT(izintur.tid, ' - ', izintur.turadi) AS izinturu, izingec.bastar, izingec.bittar, izingec.aciklama, izingec.izindurumu, izingec.durumnot FROM izingec INNER JOIN izintur ON izingec.tid = izintur.tid where izingec.sicilno='" + KOParameter.sicilno + "'";
            dgvIzinGecmis.DataSource = DBOperation.veriGetir(sorgu2);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            veriDoldur();
        }
    }
}
