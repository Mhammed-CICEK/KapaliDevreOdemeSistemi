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
using System.Xml;

namespace KapaliDevreOdemeSistemi
{
    public partial class frmCardProcess : BaseForm
    {
        CardService cs = new CardService();
        int aramaId;
        DataTable dtCardList=new DataTable();
        public frmCardProcess()
        {
            InitializeComponent();
            GridDoldur();
            ButonIlkDurum();
            cbACKartState.SelectedIndex = 0;
            cbACKartType.SelectedIndex = 0;
        }
        public void ClearForm()
        {
            txtACCardNo.Clear();
            cbACKartState.SelectedIndex = 0;
            cbACKartType.SelectedIndex = 0;
        }
        public bool GirisKontrolleri()
        {

            try
            {
                if (string.IsNullOrEmpty(txtACCardNo.Text)) //if(txtAdSoyad.Text=="")
                {
                    MessageBox.Show("Kart Numarası boş geçilemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtACCardNo.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(cbACKartType.Text)) //if(txtAdSoyad.Text=="")
                {
                    MessageBox.Show("Kart Tipi boş geçilemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbACKartType.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(cbACKartState.Text)) //if(txtTelefon.Text=="")
                {
                    MessageBox.Show("Kart Durumu boş geçilemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbACKartState.Focus();
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

        protected override void btnNewRecord_Click(object sender, EventArgs e)
        {
            ButonYeniKayitDurum();
        }
        protected override void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc;
                Card aramaModel = new Card() { KartNo = txtACCardNo.Text };
                Card bulunanCard = cs.Find(aramaModel);
                if (!GirisKontrolleri())
                {
                    return;
                }
                if (bulunanCard != null)
                {
                    MessageBox.Show("Daha Önce Aynı Kart No Numarasıyla Kayıt Yapılmış. Aynı Kart Numarasıyla ikinci Kayıt Yapılamaz");
                    return;
                }
                Card card = new Card()
                {
                    KayıtTarihi = DateTime.Now,
                    Durum = (byte)cbACKartState.SelectedIndex,
                    KartNo = txtACCardNo.Text,
                    KartTipi = (byte)cbACKartType.SelectedIndex

                };

                kayitSonuc = cs.Save(card);
                if (kayitSonuc > 0)
                {
                    MessageBox.Show($"{txtACCardNo.Text} Nolu Başırıyla Kaydedilmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//değilse başarısız uyarısı verdir
                else
                {
                    MessageBox.Show("Kayıt Başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnFormClear.PerformClick();
                ButonIlkDurum();
                GridDoldur();
                LogService.LogSave($"{txtACCardNo.Text} Nolu Başırıyla Kaydedilmiştir!", (byte)Enums.LogTipi.Bilgi);
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kart Kayıt İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        void GridDoldur()
        {
            gcMemberList.DataSource = cs.ListAllDataTable();
            dtCardList = cs.ListAllDataTable();
            gvMemberList.Columns["Id"].Visible = false;
            gvMemberList.Columns["Durum"].Visible = false;
        }
        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                int kayitSonuc;
                Card aramaModel = new Card()
                {
                    Id = aramaId,
                    KartNo = txtACCardNo.Text
                };
                Card bulunanCard = cs.FindCardNo(aramaModel);
                if (!GirisKontrolleri())
                {
                    return;
                }
                if (bulunanCard != null)
                {
                    MessageBox.Show("Daha Önce Aynı Kart No Numarasıyla Kayıt Yapılmış. Aynı Kart Numarasıyla ikinci Kayıt Yapılamaz");
                    return;
                }
                Card card = new Card()
                {
                    Id = aramaId,
                    KayıtTarihi = DateTime.Now,
                    Durum = (byte)cbACKartState.SelectedIndex,
                    KartNo = txtACCardNo.Text,
                    KartTipi = (byte)cbACKartType.SelectedIndex

                };

                kayitSonuc = cs.Update(card);
                if (kayitSonuc > 0)
                {
                    MessageBox.Show($"{txtACCardNo.Text} Nolu Başırıyla Güncellenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//değilse başarısız uyarısı verdir
                else
                {
                    MessageBox.Show("Kayıt Başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnFormClear.PerformClick();
                ButonIlkDurum();
                GridDoldur();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kart Gücelleme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc;
                if (MessageBox.Show($"{txtACCardNo.Text} Silmek istediğinize eminmisiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    kayitSonuc = cs.Delete(aramaId);

                    if (kayitSonuc <= 0)
                    {
                        MessageBox.Show($"{txtACCardNo.Text} nolu kard silinmemiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MessageBox.Show($"{txtACCardNo.Text} nolu kard başarıyla silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridDoldur();
                }
                LogService.LogSave($"{txtACCardNo.Text} nolu kard başarıyla silinmiştir",(byte)Enums.LogTipi.Bilgi);
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kart Kayıt İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        protected override void btnFormClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        protected override void btnReturn_Click(object sender, EventArgs e)
        {
            btnFormClear.PerformClick();
            btnNewRecord.PerformClick();
        }
      
        protected override void gvMemberList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {

                int satir = e.RowHandle;
                if (satir < 0) return;
                aramaId = Convert.ToInt32(dtCardList.Rows[satir]["Id"]);
                txtACCardNo.Text = dtCardList.Rows[satir]["KartNo"].ToString();
                cbACKartType.SelectedIndex = dtCardList.Rows[satir]["KartTipi"].ToString().Contains("Standart") ? 0 : 1;
                ButonAramaDurum();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kart Seçme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

    }
}
