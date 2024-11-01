using Kantot.Class;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;

namespace Kantot
{
    public partial class ALeaveRequestsForm : Form
    {

        public ALeaveRequestsForm()
        {
            InitializeComponent();
            veriDoldur();
        }
        string onaydurumu;

        private void veriDoldur()
        {
            string sorgu = "SELECT izintalepleri.id, izintalepleri.sicilno, CONCAT(calisanlar.adi, ' ', calisanlar.soyadi) AS adisoyadi, calisanlar.departman, izintur.turadi, izintalepleri.bastar, izintalepleri.bittar, izintalepleri.aciklama FROM izintalepleri INNER JOIN calisanlar ON izintalepleri.sicilno = calisanlar.sicilno INNER JOIN izintur ON izintalepleri.tid = izintur.tid";
            dgvProducts.DataSource = DBOperation.veriGetir(sorgu);
        }


        private void dgvProducts_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            onaydurumu = "Onaylandı";
            OnaylaReddet();
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            onaydurumu = "Reddedildi";
            OnaylaReddet();
        }

        private void OnaylaReddet()
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                string referans = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
                string sorgu = "Select id, sicilno, tid, bastar, bittar, aciklama from izintalepleri Where id='" + referans + "'";
                DataTable TabloAdiTablo = DBOperation.veriGetir(sorgu);

                string Query = "Insert Into izingec (sicilno, tid, bastar, bittar, aciklama, izindurumu, durumnot) Values (@sicilno, @tid, @bastar, @bittar, @aciklama, @izindurumu, @durumnot)";
                DBOperation.KOCmd.Parameters.Clear();
                DBOperation.KOCmd.Parameters.AddWithValue("@sicilno", TabloAdiTablo.Rows[0].ItemArray[1].ToString());
                DBOperation.KOCmd.Parameters.AddWithValue("@tid", TabloAdiTablo.Rows[0].ItemArray[2].ToString());
                DBOperation.KOCmd.Parameters.AddWithValue("@bastar", Convert.ToDateTime(TabloAdiTablo.Rows[0].ItemArray[3]));
                DBOperation.KOCmd.Parameters.AddWithValue("@bittar", Convert.ToDateTime(TabloAdiTablo.Rows[0].ItemArray[4]));
                DBOperation.KOCmd.Parameters.AddWithValue("@aciklama", TabloAdiTablo.Rows[0].ItemArray[5].ToString());
                DBOperation.KOCmd.Parameters.AddWithValue("@izindurumu", onaydurumu);
                DBOperation.KOCmd.Parameters.AddWithValue("@durumnot", onaydurumu);
                DBOperation.KomutCalistir(Query);
                if (KOParameter.islemDurumu == 1)
                {
                    Query = "Delete from izintalepleri Where id='" + referans + "'";
                    DBOperation.KOCmd.Parameters.Clear();
                    DBOperation.KomutCalistir(Query);
                    if (KOParameter.islemDurumu == 1)
                    {
                        veriDoldur();
                    }

                }
                else
                {
                    MessageBox.Show("Ürün Grubu Ekleme İşlemi Başarısız \nVeri Alanlarını Kontrol Ediniz", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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

        private void btnMainMenu_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetayGoster_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                string SicilNo = selectedRow.Cells[0].Value.ToString();
                string AdSoyad = selectedRow.Cells[1].Value.ToString();
                string Departman = selectedRow.Cells[2].Value.ToString();
                string IzinTuru = selectedRow.Cells[3].Value.ToString();
                string BasTar = selectedRow.Cells[4].Value.ToString();
                string BitTar = selectedRow.Cells[5].Value.ToString();
                string Aciklama = selectedRow.Cells[6].Value.ToString();
                APermissionDetail detailForm = new APermissionDetail(SicilNo, AdSoyad, Departman, IzinTuru, BasTar, BitTar, Aciklama);
                detailForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
