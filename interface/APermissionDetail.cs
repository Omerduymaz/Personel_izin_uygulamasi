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
    public partial class APermissionDetail : Form
    {
        public APermissionDetail(string SicilNo, string AdSoyad, string Departman, string IzinTuru, string BasTar, string BitTar, string Aciklama)
        {
            InitializeComponent();

            tbSicilNo.Text = SicilNo;
            tbAdi.Text = AdSoyad;
            tbDepartman.Text = Departman;
            tbTuru.Text = IzinTuru;
            tbBasTar.Text = BasTar;
            tbBitTar.Text = BitTar;
            tbAciklama.Text = Aciklama;
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
