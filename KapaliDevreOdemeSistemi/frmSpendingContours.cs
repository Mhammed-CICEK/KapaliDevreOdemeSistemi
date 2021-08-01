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
    public partial class frmSpendingContours : Form
    {
        BalanceService ts = new BalanceService();
        CardAccountService cas = new CardAccountService();
        CardAccount finderAccount = new CardAccount();
        Balance finderTopUp = new Balance();
        float yukluBakiye = 0;
        float harcananBakiye = 0;
        public frmSpendingContours()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
            cmbBalanceType.SelectedIndex = 0;
            cmbProcessType.SelectedIndex = 0;
        }
        public bool GirisKontrolleri()
        {
            try
            {
                if (sleuKartNo.EditValue == null)
                {
                    MessageBox.Show("Lütfen Kart Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sleuKartNo.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kantur Harcama Giriş İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
                return false;
            }
        }

        private void btnSpendingContour_Click(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc;

                if (!GirisKontrolleri())
                {
                    return;
                }
                Balance balance = new Balance()
                {
                    KartId = (int)sleuKartNo.EditValue,
                    HesapId = (int)finderAccount.HesapId,
                    YuklenenBakiye = yukluBakiye,
                    HarcananBakiye = harcananBakiye + (float)nudTopUp.Value,
                    IslemTipi = (byte)cmbProcessType.SelectedIndex,
                    MiktarTipi = (byte)cmbBalanceType.SelectedIndex,
                    Aciklama = txtExplanation.Text,

                };
                kayitSonuc = ts.Save(balance);
                if (kayitSonuc <= 0)
                {
                    MessageBox.Show($"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartına {nudTopUp.Value.ToString()} ₺ harcanamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInformation.Text = $"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartına {nudTopUp.Value.ToString()} ₺ harcanamadı.";
                    txtInformation.BackColor = Color.Red;
                    return;
                }
                txtInformation.Text = $"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartına {nudTopUp.Value.ToString()} ₺ harcandı.";
                txtInformation.BackColor = Color.Green;
                MessageBox.Show($"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartına {nudTopUp.Value.ToString()} ₺ harcandı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnFormClear.PerformClick();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kantur Harcama : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        public void ClearForm()
        {
            sleuKartNo.EditValue = null;
            txtAccountName.Clear();
            nudBalance.Value = 0;
            cmbBalanceType.SelectedIndex = 0;
            cmbProcessType.SelectedIndex = 0;
            txtExplanation.Clear();
            txtInformation.Clear();
        }
        private void btnFormClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void sleuKartNo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (sleuKartNo.EditValue == null)
                    return;
                finderAccount = cas.Find((int)sleuKartNo.EditValue);
                if (finderAccount == null)
                {
                    MessageBox.Show("Seçilen Kart Numarasına Ait Hesap Bulamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtAccountName.Text = finderAccount.HesapAdi;
                finderTopUp = ts.Find((int)sleuKartNo.EditValue);
                if (finderTopUp != null)
                {
                    nudBalance.Value = (decimal)(finderTopUp.YuklenenBakiye - finderTopUp.HarcananBakiye);
                    yukluBakiye = finderTopUp.YuklenenBakiye;
                    harcananBakiye = finderTopUp.HarcananBakiye;
                }
                if (finderTopUp == null)
                {
                    nudBalance.Value = 0;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kantur Harcama Karta Ait Hesap İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

        private void btnCardRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc;

                if (!GirisKontrolleri())
                {
                    return;
                }
                CardAccount searchCardAccount = new CardAccount()
                {
                    KartId = (int)sleuKartNo.EditValue,
                    HesapId = (int)finderAccount.HesapId,
                };
                if (DialogResult.Yes != MessageBox.Show("Kartı Geri Almak Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    return;
                }
                kayitSonuc = cas.Delete(searchCardAccount);
                if (kayitSonuc <= 0)
                {
                    MessageBox.Show($"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartı geri alınamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInformation.Text = $"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartı geri alınamadı";
                    txtInformation.BackColor = Color.Red;
                    return;
                }
                txtInformation.Text = $"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartı geri alındı.{nudBalance.Value.ToString()} ₺ iade edildi.";
                txtInformation.BackColor = Color.Green;
                MessageBox.Show($"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartı geri alındı.{nudBalance.Value.ToString()} ₺ iade edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnFormClear.PerformClick();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kart Geri Alma : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
    }
}
