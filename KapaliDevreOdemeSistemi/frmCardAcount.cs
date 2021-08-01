using Common;
using Models;
using ServicesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapaliDevreOdemeSistemi
{
    public partial class frmCardAcount : BaseForm
    {
        int aramaId;
        int searchKartId;
        MembersServices ms = new MembersServices();
        CardAccountService cas = new CardAccountService();
        DataTable dtList = new DataTable();
        BalanceService bs = new BalanceService();
        public frmCardAcount()
        {
            InitializeComponent();
            ButonIlkDurum();
            GridDoldur();
            try
            {

                sdsMemberList.Fill();
                sdsCardList.Fill();
                cmbAcountType.SelectedIndex = 0;
                cmbState.SelectedIndex = 0;
                deMCAStatringDate.EditValue = DateTime.Now;
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave(error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        public void ClearForm()
        {
            sleuMembersList.Text = "";
            sleuKartNo.Text = "";
            cmbAcountType.SelectedIndex = 0;
            cmbState.SelectedIndex = 0;
            mtxtCardPassword.Clear();
            txtAcountName.Clear();
            cbMCALimitSpending.Checked = false;
            deMCAStatringDate.EditValue = DateTime.Now;
            nudRefreshInterval.Value = 0;
            nudMCAAmountSpend.Value = 0.00m;
            cbMCANegativeBalance.Checked = false;
            cbMCABonus.Checked = false;
            cbMCABonus.Checked = false;
            nudMCABonus.Value = 0;
            gbMCALimit.Enabled = false;
            nudMCABonus.Enabled = false;
            nudMCABonus.Enabled = false;
        }
        public bool GirisKontrolleri()
        {
            try
            {
                if (string.IsNullOrEmpty(sleuMembersList.Text) || sleuMembersList.EditValue == null) //if(txtAdSoyad.Text=="")
                {
                    MessageBox.Show("Bir Üye Seçilmesi gerekir!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sleuMembersList.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(sleuKartNo.Text) || sleuKartNo.EditValue == null)
                {
                    MessageBox.Show("Bir Kart Seçilmesi Gerekir", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sleuKartNo.Focus();
                    return false;

                }
                if (cmbAcountType.SelectedIndex == -1) //if(txtTelefon.Text=="")
                {
                    MessageBox.Show("Lütfen Bir Kart Tipi Seçiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbAcountType.Focus();
                    return false;
                }
                if (cmbAcountType.SelectedIndex == -1) //if(txtTelefon.Text=="")
                {
                    MessageBox.Show("Lütfen Bir Kart Tipi Seçiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbAcountType.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtAcountName.Text))
                {
                    MessageBox.Show("Lütfen Hesap Adi Giriniz", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sleuKartNo.Focus();
                    return false;

                }
                return true;
            }
            catch (Exception error)
            {

                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave(error.Message, (byte)Enums.LogTipi.Hata);

            }
            return false;
        }
        public void GridDoldur()
        {
            try
            {

                gcMemberList.DataSource = cas.ListAllDataTable();
                gvMemberList.Columns["Id"].Visible = false;
                dtList = cas.ListAllDataTable();
            }
            catch (Exception error)
            {

                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave(error.Message, (byte)Enums.LogTipi.Hata);

            }
        }
        protected override void btnNewRecord_Click(object sender, EventArgs e)
        {
            ButonYeniKayitDurum();
        }
        protected override void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                int kayitSonuc;
                if (!GirisKontrolleri())
                {
                    return;
                }
                CardAccount aramaModel = new CardAccount() { KartId = (int)sleuKartNo.EditValue };
                CardAccount bulunanCard = cas.Find(aramaModel);
                if (bulunanCard != null)
                {
                    MessageBox.Show("Daha Önce Aynı Kart No Numarasıyla Kayıt Yapılmış. Aynı Kart Numarasıyla ikinci Kayıt Yapılamaz");
                    return;
                }


                CardAccount ca = new CardAccount()
                {
                    KayıtTarihi = DateTime.Now,
                    HesapId = Convert.ToInt32(sleuMembersList.EditValue),
                    KartId = Convert.ToInt32(sleuKartNo.EditValue),
                    HesapTipi = (byte)cmbAcountType.SelectedIndex,
                    Durum = (byte)cmbState.SelectedIndex,
                    HarcamaLimiti = (float)nudMCAAmountSpend.Value,
                    HesapAdi = txtAcountName.Text,
                    EksiBakiye = (float)nudMCANegativeBalance.Value,
                    BonusOrani = (float)nudMCABonus.Value
                };
                ca.BaslangicTarihi = DateTime.Now;
                ca.YenilemeAraligi = Convert.ToInt32(nudRefreshInterval.Value);

                if (cbMCALimitSpending.Checked == true)
                {
                    ca.LimitiDurumu = 1;
                }
                else
                {
                    ca.LimitiDurumu = 0;
                }
                if (cbMCANegativeBalance.Checked == true)
                {
                    ca.EksiBakiyeDurumu = 1;
                }
                else
                {
                    ca.EksiBakiyeDurumu = 0;
                }
                if (cbMCABonus.Checked == true)
                {
                    ca.BonusDurumu = 1;
                }
                else
                {
                    ca.BonusDurumu = 0;
                }
                if (!string.IsNullOrEmpty(mtxtCardPassword.Text.Replace("_", string.Empty)))
                    ca.KartSifresi = Convert.ToInt32(mtxtCardPassword.Text.Replace("_", string.Empty));
                else
                    ca.KartSifresi = 1234;
                kayitSonuc = cas.Save(ca);
                if (kayitSonuc <= 0)
                {
                    MessageBox.Show($"{txtAcountName} hesap bilgileri kaydedilmemiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                MessageBox.Show($"{txtAcountName.Text} hesap bilgileri başarıyla Kaydedilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridDoldur();
                LogService.LogSave($"{txtAcountName.Text} hesap bilgileri başarıyla Kaydedilmiştir", (byte)Enums.LogTipi.Bilgi);

            }
            catch (Exception error)
            {

                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave(error.Message, (byte)Enums.LogTipi.Hata);

            }
        }
        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc;
                if (!GirisKontrolleri())
                {
                    return;
                }
                CardAccount ca = new CardAccount();


                ca.KayıtTarihi = DateTime.Now;
                ca.HesapId = Convert.ToInt32(sleuMembersList.EditValue);
                ca.KartId = Convert.ToInt32(sleuKartNo.EditValue);
                ca.HesapTipi = (byte)cmbAcountType.SelectedIndex;
                ca.Durum = (byte)cmbState.SelectedIndex;
                ca.BaslangicTarihi = (DateTime)deMCAStatringDate.EditValue;
                ca.YenilemeAraligi = Convert.ToInt32(nudRefreshInterval.Value);
                ca.HarcamaLimiti = (float)nudMCAAmountSpend.Value;
                ca.HesapAdi = txtAcountName.Text;
                ca.EksiBakiye = (float)nudMCANegativeBalance.Value;

                if (string.IsNullOrEmpty(mtxtCardPassword.Text.Replace("_", string.Empty)))
                {
                    ca.KartSifresi = 1234;
                }
                else
                {
                    ca.KartSifresi = Convert.ToInt32(mtxtCardPassword.Text.Replace("_", string.Empty));
                }

                if (cbMCALimitSpending.Checked == true)
                {
                    ca.LimitiDurumu = 1;
                }
                else
                {
                    ca.LimitiDurumu = 0;
                }
                if (cbMCANegativeBalance.Checked == true)
                {
                    ca.EksiBakiyeDurumu = 1;
                }
                else
                {
                    ca.EksiBakiyeDurumu = 0;
                }
                if (cbMCABonus.Checked == true)
                {
                    ca.BonusDurumu = 1;
                }
                else
                {
                    ca.BonusDurumu = 0;
                }
                kayitSonuc = cas.Update(ca);
                if (kayitSonuc <= 0)
                {
                    MessageBox.Show($"{txtAcountName} hesap bilgileri Guncellenmemiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show($"{txtAcountName.Text} hesap bilgileri başarıyla Guncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridDoldur();
                LogService.LogSave($"{txtAcountName.Text} hesap bilgileri başarıyla Guncellenmiştir", (byte)Enums.LogTipi.Hata);
            }
            catch (Exception error)
            {

                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave(error.Message, (byte)Enums.LogTipi.Hata);

            }

        }
        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
                int kayitSonuc;
                Balance searchBalance = new Balance();
                Balance finderBalance = new Balance();
            MessageBox.Show(sleuKartNo.EditValue.ToString());
                searchBalance.KartId = Convert.ToInt32(sleuKartNo.EditValue);
                finderBalance = bs.Find(searchBalance);
                
                    if (!GirisKontrolleri())
                    {
                        return;
                    }
                    if (DialogResult.Yes != MessageBox.Show("Kartı Geri Almak Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        return;
                    }
                if (finderBalance != null)
                {
                    kayitSonuc = cas.Delete(aramaId);
                    if (kayitSonuc <= 0)
                    {
                        MessageBox.Show($"{txtAcountName.Text} hesabına ait {sleuKartNo.Text} kartı silinemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show($"{txtAcountName.Text} hesabına ait {sleuKartNo.Text} kartı silindi.{finderBalance.HarcananBakiye - finderBalance.YuklenenBakiye} ₺ iade edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnFormClear.PerformClick();
                    return;
                }
                kayitSonuc = cas.Delete(aramaId);
                if (kayitSonuc <= 0)
                {
                    MessageBox.Show($"{txtAcountName.Text} hesabına ait {sleuKartNo.Text} kartı silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show($"{txtAcountName.Text} hesabına ait {sleuKartNo.Text} kartı geri alındı.0 ₺ iade edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnFormClear.PerformClick();
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    LogService.LogSave("Kart Geri Alma : " + error.Message, (byte)Enums.LogTipi.Hata);
            //}
        }
        protected override void btnFormClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        protected override void btnReturn_Click(object sender, EventArgs e)
        {
            ClearForm();
            ButonIlkDurum();

        }
        protected override void gvMemberList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {

                aramaId = Convert.ToInt32(dtList.Rows[e.RowHandle]["Id"]);
                searchKartId = Convert.ToInt32(dtList.Rows[e.RowHandle]["KardId"]);
                sleuMembersList.EditValue = dtList.Rows[e.RowHandle]["MemberId"].ToString();
                sleuKartNo.EditValue = dtList.Rows[e.RowHandle]["KardId"].ToString();
                cmbAcountType.SelectedIndex = Convert.ToInt32(dtList.Rows[e.RowHandle]["HesapTipi"]);
                cmbState.SelectedIndex = Convert.ToInt32(dtList.Rows[e.RowHandle]["Durum"]);
                mtxtCardPassword.Text = dtList.Rows[e.RowHandle]["KartSifresi"].ToString();
                txtAcountName.Text = dtList.Rows[e.RowHandle]["HesapAdi"].ToString();
                if (Convert.ToInt32(dtList.Rows[e.RowHandle]["LimitiDurumu"]) == 1)
                {
                    cbMCALimitSpending.Checked = true;
                    gbMCALimit.Enabled = true;
                    deMCAStatringDate.EditValue = (DateTime)dtList.Rows[e.RowHandle]["BaslangicTarihi"];
                    nudMCAAmountSpend.Text = dtList.Rows[e.RowHandle]["HarcamaLimiti"].ToString();
                    nudRefreshInterval.Text = dtList.Rows[e.RowHandle]["YenilemeAraligi"].ToString();
                }
                else
                {
                    cbMCALimitSpending.Checked = false;
                    gbMCALimit.Enabled = false;
                }
                if (Convert.ToInt32(dtList.Rows[e.RowHandle]["EksiBakiyeDurum"]) == 1)
                {
                    cbMCANegativeBalance.Checked = true;
                    nudMCANegativeBalance.Text = dtList.Rows[e.RowHandle]["EksiBakiye"].ToString();
                }
                else
                {
                    cbMCANegativeBalance.Checked = false;
                }
                if (Convert.ToInt32(dtList.Rows[e.RowHandle]["BonusDurum"]) == 1)
                {
                    cbMCABonus.Checked = true;
                    nudMCABonus.Text = dtList.Rows[e.RowHandle]["BonusOrani"].ToString();
                }
                else
                {
                    cbMCANegativeBalance.Checked = false;
                }
                sleuKartNo.Enabled = false;
                sleuMembersList.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave(error.Message, (byte)Enums.LogTipi.Hata);

            }
            ButonAramaDurum();
        }

        private void cbMCALimitSpending_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMCALimitSpending.Checked == true)
            {
                gbMCALimit.Enabled = true;
                return;
            }
            gbMCALimit.Enabled = false;
        }

        private void cbMCANegativeBalance_CheckedChanged(object sender, EventArgs e)
        {

            if (cbMCANegativeBalance.Checked == true)
            {
                nudMCANegativeBalance.Enabled = true;
                return;
            }
            nudMCANegativeBalance.Enabled = false;
        }

        private void cbMCABonus_CheckedChanged(object sender, EventArgs e)
        {

            if (cbMCABonus.Checked == true)
            {
                nudMCABonus.Enabled = true;
                return;
            }
            nudMCABonus.Enabled = false;
        }

    }
}
