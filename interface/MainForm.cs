using Kantot.Class;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;

namespace Kantot
{
    public partial class MainForm : Form
    {
        public LeaveRequestForm leaveRequest;
        public MyPermissionsForm myPermissions;
        public ALeaveRequestsForm aLeaveRequests;
        public AThoseOnLeaveForm aThoseOnLeave;
        public APermissionsHistoryForm aPermissionsHistory;
        public APermissionTypesForm aPermissionTypes;
        public MainForm()
        {
            InitializeComponent();
            kulbaslat();
            if (KOParameter.admin == 1)
            {
                btnIzinAl.Visible = false;
                btnIzinAl.Enabled = false;
                tsSeparator1.Visible = false;
                btnIzinlerim.Visible = false;
                btnIzinlerim.Enabled = false;
                tsSeparator2.Visible = false;
            }
            else
            {
                btnIzinIstekleri.Visible = false;
                btnIzinIstekleri.Enabled = false;
                tsSeparator3.Visible = false;
                btnIzindeOlanlar.Visible = false;
                btnIzindeOlanlar.Enabled = false;
                tsSeparator4.Visible = false;
                btnIzinlerGecmisi.Visible = false;
                btnIzinlerGecmisi.Enabled = false;
                tsSeparator5.Visible = false;
                btnKategoriler.Visible = false;
                btnKategoriler.Enabled = false;
            }
            tslSicilNo.Text = KOParameter.sicilno;
            tslAdi.Text = KOParameter.adi;
            tslSoyadi.Text = KOParameter.soyadi;
            tslBakiye.Text = Convert.ToString(KOParameter.bakiye);
            tSaatTarih.Start();
        }


        private void kulbaslat() 
        {
            if (KOParameter.admin == 0)
            {
                btnIzinlerim.PerformClick();
            }
            else
            {
                btnIzinIstekleri.PerformClick();
            }
         }




        private void ShowOrActivateForm<T>(ref T form, string formText) where T : Form, new()
        {
            if (form == null || form.IsDisposed)
            {
                form = new T();
                form.Text = formText;
                form.MdiParent = this;
                form.Dock = DockStyle.Fill;
                form.Show();
            }
            else
            {
                form.BringToFront();
            }
            SetButtonColor(form);
        }
        public void SetButtonColor(Form form)
        {
            btnIzinAl.BackColor = (form == leaveRequest) ? Color.LimeGreen : Color.Transparent;
            btnIzinlerim.BackColor = (form == myPermissions) ? Color.LimeGreen : Color.Transparent;
            btnIzinIstekleri.BackColor = (form == aLeaveRequests) ? Color.LimeGreen : Color.Transparent;
            btnIzindeOlanlar.BackColor = (form == aThoseOnLeave) ? Color.LimeGreen : Color.Transparent;
            btnIzinlerGecmisi.BackColor = (form == aPermissionsHistory) ? Color.LimeGreen : Color.Transparent;
            btnKategoriler.BackColor = (form == aPermissionTypes) ? Color.LimeGreen : Color.Transparent;

            if (form != null)
            {
                form.Activated += (sender, e) =>
                {
                    if (sender is LeaveRequestForm)
                    {
                        btnIzinAl.BackColor = Color.LimeGreen;
                        btnIzinlerim.BackColor = Color.Transparent;
                        btnIzinIstekleri.BackColor = Color.Transparent;
                        btnIzindeOlanlar.BackColor = Color.Transparent;
                        btnIzinlerGecmisi.BackColor = Color.Transparent;
                        btnKategoriler.BackColor = Color.Transparent;
                    }
                    else if (sender is MyPermissionsForm)
                    {
                        btnIzinAl.BackColor = Color.Transparent;
                        btnIzinlerim.BackColor = Color.LimeGreen;
                        btnIzinIstekleri.BackColor = Color.Transparent;
                        btnIzindeOlanlar.BackColor = Color.Transparent;
                        btnIzinlerGecmisi.BackColor = Color.Transparent;
                        btnKategoriler.BackColor = Color.Transparent;
                    }
                    else if (sender is ALeaveRequestsForm)
                    {
                        btnIzinAl.BackColor = Color.Transparent;
                        btnIzinlerim.BackColor = Color.Transparent;
                        btnIzinIstekleri.BackColor = Color.LimeGreen;
                        btnIzindeOlanlar.BackColor = Color.Transparent;
                        btnIzinlerGecmisi.BackColor = Color.Transparent;
                        btnKategoriler.BackColor = Color.Transparent;
                    }
                    else if (sender is AThoseOnLeaveForm)
                    {
                        btnIzinAl.BackColor = Color.Transparent;
                        btnIzinlerim.BackColor = Color.Transparent;
                        btnIzinIstekleri.BackColor = Color.Transparent;
                        btnIzindeOlanlar.BackColor = Color.LimeGreen;
                        btnIzinlerGecmisi.BackColor = Color.Transparent;
                        btnKategoriler.BackColor = Color.Transparent;
                    }
                    else if (sender is APermissionsHistoryForm)
                    {
                        btnIzinAl.BackColor = Color.Transparent;
                        btnIzinlerim.BackColor = Color.Transparent;
                        btnIzinIstekleri.BackColor = Color.Transparent;
                        btnIzindeOlanlar.BackColor = Color.Transparent;
                        btnIzinlerGecmisi.BackColor = Color.LimeGreen;
                        btnKategoriler.BackColor = Color.Transparent;
                    }
                    else if (sender is APermissionTypesForm)
                    {
                        btnIzinAl.BackColor = Color.Transparent;
                        btnIzinlerim.BackColor = Color.Transparent;
                        btnIzinIstekleri.BackColor = Color.Transparent;
                        btnIzindeOlanlar.BackColor = Color.Transparent;
                        btnIzinlerGecmisi.BackColor = Color.Transparent;
                        btnKategoriler.BackColor = Color.LimeGreen;
                    }
                };
            }
        }
        private void tSaatTarih_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            tslTarihSaat.Text = currentTime.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void btnIzinAl_Click(object sender, EventArgs e) => ShowOrActivateForm(ref leaveRequest, "İzin Al");

        private void btnIzinlerim_Click(object sender, EventArgs e) => ShowOrActivateForm(ref myPermissions, "İzinlerim");

        private void btnIzinIstekleri_Click(object sender, EventArgs e) => ShowOrActivateForm(ref aLeaveRequests, "İzin İstekleri");

        private void btnIzindeOlanlar_Click(object sender, EventArgs e) => ShowOrActivateForm(ref aThoseOnLeave, "İzinde Olanlar");

        private void btnIzinlerGecmisi_Click(object sender, EventArgs e) => ShowOrActivateForm(ref aPermissionsHistory, "İzinler Geçmişi");

        private void btnKategoriler_Click(object sender, EventArgs e) => ShowOrActivateForm(ref aPermissionTypes, "İzin Kategorileri");

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tüm sayfalar kapatılacaktır. " +
                "Onaylanmayan ve kaydedilmeyenlen değişiklikler iptal edilecektir. " +
                "\nUygulamadan çıkmak istiyor musunuz?", "Uyarı",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }
    }
}