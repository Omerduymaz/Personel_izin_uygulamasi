using Kantot.Class;
using System.Globalization;
using System.Windows.Forms;

namespace Kantot
{
    public partial class APermissionTypesForm : Form
    {

        public APermissionTypesForm()
        {
            InitializeComponent();
            IzinTurleriFill();
            lBoxIzinTurleri.ClearSelected();
        }

        private void IzinTurleriFill()
        {
            string Query = "SELECT CONCAT(tid, ' - ', turadi) AS CombinedColumn, tid FROM izintur where turdurum='Aktif'";
            lBoxIzinTurleri.DataSource = DBOperation.veriGetir(Query);
            lBoxIzinTurleri.ValueMember = "tid";
            lBoxIzinTurleri.DisplayMember = "CombinedColumn";
        }
        private void IzinTurleriPasifFill()
        {
            string Query = "SELECT CONCAT(tid, ' - ', turadi) AS CombinedColumn, tid FROM izintur where turdurum='Pasif'";
            lBoxIzinTurleri.DataSource = DBOperation.veriGetir(Query);
            lBoxIzinTurleri.ValueMember = "tid";
            lBoxIzinTurleri.DisplayMember = "CombinedColumn";
        }

        private void NumericalControl(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsControl(e.KeyChar) & !char.IsDigit(e.KeyChar));
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

        private void EnterBlocking(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void Temizle()
        {
            tbIzınAdı.Clear();
            tbKod.Clear();
        }

        private void cmbDurum_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbDurum.Checked == true)
            {
                IzinTurleriPasifFill();
                cmbDurum.Text = "Aktif Olan Türler";
                tsbtnAktifPasif.Text = "Aktif Et";
            }
            else
            {
                IzinTurleriFill();
                cmbDurum.Text = "Aktif Olmayan Türler";
                tsbtnAktifPasif.Text = "Pasif Et";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (tbIzınAdı.Text != "")
            {
                BoslukKontrol();
                if (KOParameter.dolumu)
                {
                    string GroupName = tbIzınAdı.Text.Trim();
                    GroupName = CultureInfo.CurrentCulture.TextInfo.ToLower(GroupName);
                    GroupName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(GroupName);
                    string Query = "Insert Into izintur (tid,turadi,turdurum) Values (@tid,@turadi,@turdurum)";
                    DBOperation.KOCmd.Parameters.Clear();
                    DBOperation.KOCmd.Parameters.AddWithValue("@tid", string.IsNullOrEmpty(tbKod.Text) ? DBNull.Value : tbKod.Text);
                    DBOperation.KOCmd.Parameters.AddWithValue("@turadi", GroupName);
                    DBOperation.KOCmd.Parameters.AddWithValue("@turdurum", "Aktif");
                    DBOperation.KomutCalistir(Query);
                    if (KOParameter.islemDurumu == 1)
                    {
                        IzinTurleriFill();
                        Temizle();
                        lBoxIzinTurleri.ClearSelected();
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
                tbIzınAdı.Select();
            }
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnAktifPasif_Click(object sender, EventArgs e)
        {
            if (lBoxIzinTurleri.SelectedItems != null)
            {
                if (tsbtnAktifPasif.Text == "Pasif Et")
                {

                    if (KOParameter.dolumu && MessageBox.Show("Bu İzin Türü Pasif Edilecektir.\nİşlemi Onaylıyor musunuz?", "Dikkat",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string komut = "update izintur set turdurum=@turdurum where tid=@tid";
                        DBOperation.KOCmd.Parameters.Clear();
                        DBOperation.KOCmd.Parameters.AddWithValue("@tid", lBoxIzinTurleri.SelectedValue);
                        DBOperation.KOCmd.Parameters.AddWithValue("@turdurum", "Pasif");
                        DBOperation.KomutCalistir(komut);
                        if (KOParameter.islemDurumu >= 1)
                        {
                            MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            IzinTurleriFill();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme İşlemi Başarısız", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                else if (tsbtnAktifPasif.Text == "Aktif Et")
                {
                    if (KOParameter.dolumu && MessageBox.Show("Bu İzin Türü Aktif Edilecektir.\nİşlemi Onaylıyor musunuz?", "Dikkat",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        string komut = "update izintur set turdurum=@turdurum where tid=@tid";
                        DBOperation.KOCmd.Parameters.Clear();
                        DBOperation.KOCmd.Parameters.AddWithValue("@tid", lBoxIzinTurleri.SelectedValue);
                        DBOperation.KOCmd.Parameters.AddWithValue("@turdurum", "Aktif");
                        DBOperation.KomutCalistir(komut);
                        if (KOParameter.islemDurumu >= 1)
                        {
                            MessageBox.Show("Güncelleme İşlemi Başarılı", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            IzinTurleriPasifFill();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme İşlemi Başarısız", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }

        }
    }
}
