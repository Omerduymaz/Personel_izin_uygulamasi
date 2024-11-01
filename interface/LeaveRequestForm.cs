using Kantot.Class;
using System.Globalization;
using System.Windows.Forms;

namespace Kantot
{
    public partial class LeaveRequestForm : Form
    {
        public LeaveRequestForm()
        {
            InitializeComponent();
            tbSicilNo.Text = KOParameter.sicilno;
            tbAdi.Text = KOParameter.adi;
            tbSoyadi.Text = KOParameter.soyadi;
            ProductGroupFill();
        }

        private void BoslukKontrol()
        {
            KOParameter.dolumu = true;
            foreach (Control tbox in this.Controls)
                if (tbox is TextBox)
                    if (tbox.Text.Trim() == "")
                    {
                        KOParameter.dolumu = false;
                        break;
                    }
        }

        private void HesaplaGunFarki()
        {
            DateTime baslangicTarihi = dtpBas.Value.Date;
            DateTime bitisTarihi = dtpBit.Value.Date;

            TimeSpan fark = bitisTarihi - baslangicTarihi;
            int gunFarki = (int)fark.TotalDays + 1;
            label3.Text = gunFarki.ToString();
        }

        private void ProductGroupFill()
        {
            string Query = "SELECT tid, turadi FROM izintur WHERE turdurum='Aktif'";
            cmbIzinTurleri.DataSource = DBOperation.veriGetir(Query);
            cmbIzinTurleri.ValueMember = "tid";
            cmbIzinTurleri.DisplayMember = "turadi";
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tamamlanmamış satışlar olabilir. " +
                "\nYine de Ana Menü'ye dönmek istiyor musunuz?", "Uyarı Bu Sayfa Kapatılıyor",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (this.MdiParent is MainForm mainForm)
                {
                    if (this.Text == "Satış 1")
                        mainForm.btnIzinAl.BackColor = Color.Transparent;
                    if (this.Text == "Satış 2")
                        mainForm.btnIzinlerim.BackColor = Color.Transparent;
                    if (this.Text == "Satış 3")
                        mainForm.btnIzinIstekleri.BackColor = Color.Transparent;
                    this.Close();
                }
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzinAl_Click(object sender, EventArgs e)
        {
            if (cmbIzinTurleri.Text != "")
            {
                BoslukKontrol();
                if (KOParameter.dolumu)
                {
                    string Query = "Insert Into izintalepleri (sicilno, tid, bastar, bittar, aciklama) Values (@sicilno, @tid, @bastar, @bittar, @aciklama)";
                    DBOperation.KOCmd.Parameters.Clear();
                    DBOperation.KOCmd.Parameters.AddWithValue("@sicilno", tbSicilNo.Text);
                    DBOperation.KOCmd.Parameters.AddWithValue("@tid", cmbIzinTurleri.SelectedValue);
                    DBOperation.KOCmd.Parameters.AddWithValue("@bastar", dtpBas.Value.Date);
                    DBOperation.KOCmd.Parameters.AddWithValue("@bittar", dtpBit.Value.Date);
                    DBOperation.KOCmd.Parameters.AddWithValue("@aciklama", tbAciklama.Text);

                    DBOperation.KomutCalistir(Query);
                    if (KOParameter.islemDurumu == 1)
                    {
                        MessageBox.Show("İzin talebiniz yöneticiye iletildi", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ürün Grubu Ekleme İşlemi Başarısız \nVeri Alanlarını Kontrol Ediniz", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Eklemek İstediğiniz Grubun Adını Yazın \nVarsa KDV'sini Yazınız", "Bilgi",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtpBas_ValueChanged(object sender, EventArgs e)
        {
            HesaplaGunFarki();
        }

        private void gBox7_Enter(object sender, EventArgs e)
        {

        }
    }
}
