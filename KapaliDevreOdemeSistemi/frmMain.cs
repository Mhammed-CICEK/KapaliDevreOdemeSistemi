using DevExpress.DataAccess.Sql;
using DevExpress.XtraTab;
using Models;
using ServicesLayer;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Common;
namespace KapaliDevreOdemeSistemi
{
    public partial class frmMain : Form
    {
        int tapSayisi = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private bool MDIFormAcikmi(string formAdi)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == formAdi)
                {
                    return true;
                }
            }
            return false;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmHosGeldinizi frmWel = new frmHosGeldinizi();
            if (!MDIFormAcikmi("frmWel"))
            {
                frmWel.MdiParent = this;
                frmWel.Text = "Hoş Geldiniz.";
                frmWel.Name = "frmWel";
                frmWel.Show();
                return;
            }
            if (SessionsData.GirisYapanKullaniciId == 1)
            {
                return;
            }
                yetkiAyarları();

        }
        public void yetkiAyarları()
        {
            try
            {
                btnAddCardAcount.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(0, 1)));
                btnAddPeriyotTerminalPrice.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(2, 1)));
                btnAddMembers.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(4, 1)));
                btnAddCard.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(6, 1)));
                btnSpendingContours.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(8, 1)));
                btnBillProduct.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(10, 1)));
                btnAddEndProduct.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(12, 1)));
                btnAddEndProductStock.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(14, 1)));
                //btnSalesScreenByProductionSelection.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(16, 1)));
                btnProductStokGroup.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(18, 1)));
                btnTopUp.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(20, 1)));
                btnAddMembersAcount.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(22, 1)));
                //btnAddMembers.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(24, 1)));
                btnAddWorkPlace.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(26, 1)));
                btnAddProject.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(28, 1)));
                //btnDiscount.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(30, 1)));
                btnAcountSummaryReport.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(32, 1)));
                btnMamulDetayReport.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(34, 1)));
                btnMamulSummaryReport.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(36, 1)));
                btnMembersReport.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(38, 1)));
                btnStockReport.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(40, 1)));
                btnAcountDetayReport.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(42, 1)));
                btnDaySummaryProcessReport.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(44, 1)));
                btnSettings.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(46, 1)));
                btnAddProduct.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(48, 1)));
                btnProductSalesDisplay.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(50, 1)));
                btnSalesScreenByProductionSelection.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(52, 1)));
                btnDiscount.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(54, 1)));
                btnAddTerminal.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(56, 1)));
                btnProcessCancelled.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(58, 1)));
                btnUsersFormPermissions.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(60, 1)));
                btnAddUsers.Enabled = Convert.ToBoolean(Convert.ToInt32(SessionsData.YetkiKodu.Substring(60, 1)));
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Yetki Ayarlama : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

        private void btnAddMembers_Click(object sender, EventArgs e)
        {
            frmUyeIslemleri frmMProcess = new frmUyeIslemleri();
            frmMProcess.Text = "Üye İşlemleri";
            OpenFrom(frmMProcess);
        }

        private void xtmmProcessPages_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            tapSayisi--;
            if (tapSayisi == 1)
            {
                xtmmProcessPages.ClosePageButtonShowMode = ClosePageButtonShowMode.Default;
            }
        }

        private void xtmmProcessPages_PageAdded(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {

            tapSayisi++;
            if (tapSayisi == 1)
            {
                xtmmProcessPages.ClosePageButtonShowMode = ClosePageButtonShowMode.Default;
                return;
            }
            xtmmProcessPages.ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
        }

        private void btnAddCard_Click(object sender, EventArgs e)
        {
            frmCardProcess frmCProcess = new frmCardProcess();
            frmCProcess.Text = "Kart İşlemleri";
            OpenFrom(frmCProcess);
        }
        void OpenFrom(Form openedForm)
        {
            try
            {

                bool state = false;
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text == openedForm.Text)
                    {
                        state = true;
                        item.Activate();
                    }
                }
                if (!state)
                {
                    openedForm.MdiParent = this;
                    openedForm.Show();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave(openedForm.Text + " Form Yükleme : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

        private void btnAddCardAcount_Click(object sender, EventArgs e)
        {

            frmCardAcount frmCAcount = new frmCardAcount();
            frmCAcount.Text = "Kart Hesap Tanımı";
            OpenFrom(frmCAcount);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProductProcess frmProduct = new frmProductProcess();
            frmProduct.Text = "Ürün Tanımı";
            OpenFrom(frmProduct);
        }

        private void btnAddEndProductCatogy_Click(object sender, EventArgs e)
        {

            frmStockGroup frmStock = new frmStockGroup();
            frmStock.Text = "Stok Grup Tanımı";
            OpenFrom(frmStock);
        }

        private void btnTopUp_Click(object sender, EventArgs e)
        {
            frmBalance frmTopUp = new frmBalance();
            frmTopUp.Text = "Bakiye Yükleme";
            OpenFrom(frmTopUp);
        }

        private void btnSpendingContours_Click(object sender, EventArgs e)
        {
            frmSpendingContours frmSpendingContours = new frmSpendingContours();
            frmSpendingContours.Text = "Kontür Harcama";
            OpenFrom(frmSpendingContours);
        }

        private void btnProductSalesDisplay_Click(object sender, EventArgs e)
        {
            frmSalesPrudoct frmsalesPrudoct = new frmSalesPrudoct();
            frmsalesPrudoct.Text = "Ürün Satış Ekranı";
            OpenFrom(frmsalesPrudoct);
        }

        private void btnUsersFormPermissions_Click(object sender, EventArgs e)
        {

            frmUserPermision frmuserPermision = new frmUserPermision();
            frmuserPermision.Text = "Kullanıcı Form İzinleri";
            OpenFrom(frmuserPermision);
        }

        private void btnAddUsers_Click(object sender, EventArgs e)
        {

            frmUsers frmuser = new frmUsers();
            frmuser.Text = "Kullanıcı Tanımlama Ekranı";
            OpenFrom(frmuser);
        }
    }
}
