using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Models;
using ServicesLayer;
namespace KapaliDevreOdemeSistemi
{
    public partial class frmBalance : Form
    {
        BalanceService ts = new BalanceService();
        CardAccountService cas = new CardAccountService();
        CardAccount finderAccount = new CardAccount();
        Balance finderTopUp = new Balance();
        float yukluBakiye = 0;
        float harcananBakiye = 0;

        public frmBalance()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
            cmbBalanceType.SelectedIndex = 0;
            cmbProcessType.SelectedIndex = 0;
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
        private void sleuKartNo_EditValueChanged(object sender, EventArgs e)
        {
            if (sleuKartNo.EditValue == null)
                return;
            finderAccount = cas.Find((int)sleuKartNo.EditValue);
            if (finderAccount == null)
            {
                MessageBox.Show("Seçilen Kart Numarasına Ait Hesap Bulmadı.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;            }
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
        public bool GirisKontrolleri()
        {
            if (sleuKartNo.EditValue==null)
            {
                MessageBox.Show("Lütfen Kart Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sleuKartNo.Focus();
                return false;
            }

            return true;
        }
        private void btnTopUp_Click(object sender, EventArgs e)
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
                    HesapId = (int)finderAccount.Id,
                    YuklenenBakiye = yukluBakiye + (float)nudTopUp.Value,
                    HarcananBakiye = harcananBakiye,
                    IslemTipi = (byte)cmbProcessType.SelectedIndex,
                    MiktarTipi = (byte)cmbBalanceType.SelectedIndex,
                    Aciklama = txtExplanation.Text
                };

                kayitSonuc = ts.Save(balance);
                if (kayitSonuc <= 0)
                {
                    MessageBox.Show($"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartına {nudTopUp.Value.ToString()} ₺ yüklenmemiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtInformation.Text = $"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartına {nudTopUp.Value.ToString()} ₺ yüklenmemiştir.";
                    txtInformation.BackColor = Color.Red;
                    return;
                }
                txtInformation.Text = $"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartına {nudTopUp.Value.ToString()} ₺ yüklenmemiştir.";
                txtInformation.BackColor = Color.Green;
                MessageBox.Show($"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartına {nudTopUp.Value.ToString()} ₺ yüklenmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnFormClear.PerformClick();
                LogService.LogSave($"{txtAccountName.Text} hesabına ait {sleuKartNo.Text} kartına {nudTopUp.Value.ToString()} ₺ yüklenmemiştir.", (byte)Enums.LogTipi.Bilgi);
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave(error.ToString(), (byte)Enums.LogTipi.Hata);
            }
        }

        private void btnFormClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
