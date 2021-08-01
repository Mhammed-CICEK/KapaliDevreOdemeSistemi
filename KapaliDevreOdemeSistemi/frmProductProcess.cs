using Common;
using Library;
using Models;
using ServicesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapaliDevreOdemeSistemi
{
    public partial class frmProductProcess : BaseForm
    {
        int aramaId;
        string resimPath;
        DataTable dtList = new DataTable();
        ProductService ps = new ProductService();
        public frmProductProcess()
        {
            InitializeComponent();
            sdsStokGoupList.Fill();
        }

        private void btnNewRecord_Click_1(object sender, EventArgs e)
        {
            ButonYeniKayitDurum();
        }
        public bool GirisKontrolleri()
        {
            try
            {
                if (string.IsNullOrEmpty(txtPrudoctName.Text))
                {
                    MessageBox.Show("Lütfen Ürün Kodunu Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrudoctName.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtBarkod.Text))
                {
                    MessageBox.Show("Lütfen Ürün Kodunu Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBarkod.Focus();
                    return false;
                }
                if (sleuStokGroupKodu.EditValue == null)
                {
                    MessageBox.Show("Lütfen Stok Grubu Seçiniz ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sleuStokGroupKodu.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Ürün Giriş Kontrolleri İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
                return false;
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc;

                if (!GirisKontrolleri())
                {
                    return;
                }

                Product product = new Product()
                {
                    UrunAdi = txtPrudoctName.Text,
                    Barkod = txtBarkod.Text,
                    UrunIcerigi = txtProductContent.Text,
                    StokGrupId = (int)sleuStokGroupKodu.EditValue,
                    IslemTuru = (byte)cmbProcessType.SelectedIndex,
                    Birim = (byte)cmbUnit.SelectedIndex,
                    Adet = (byte)nudAddPiece.Value,
                    DepoId = (byte)cmbStore.SelectedIndex,
                    Kdv = (float)nudKDV.Value,
                    AlisFiyati = (float)nudPurchasePrice.Value,
                    SatisFiyati = (float)nudSalePrices.Value,
                    ToplamAdet = (int)nudTotalNumber.Value,
                    StokUyariAdedi = (int)nudStockWarningPiece.Value,
                };
                product.Resim = GeneralProcess.imageResize(pbPImage.Image);
                kayitSonuc = ps.Save(product);
                if (kayitSonuc <= 0)
                {
                    MessageBox.Show($"{txtBarkod.Text} {txtPrudoctName.Text} bilgileri kaydedilmemiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"{txtBarkod.Text} {txtPrudoctName.Text} bilgileri başarıyla Kaydedilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridDoldur();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Ürün Kayıt İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        public void GridDoldur()
        {
            gcMemberList.DataSource = ps.ListAllDataTable();
            dtList = ps.ListAllDataTable();
        }
        private void frmProductProcess_Load(object sender, EventArgs e)
        {
            ButonIlkDurum();
            cmbProcessType.SelectedIndex = 0;
            cmbStore.SelectedIndex = 0;
            cmbUnit.SelectedIndex = 0;
            cmbState.SelectedIndex = 0;
            GridDoldur();

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc;

                if (!GirisKontrolleri())
                {
                    return;
                }

                Product product = new Product()
                {
                    Id = aramaId,
                    UrunAdi = txtPrudoctName.Text,
                    Barkod = txtBarkod.Text,
                    UrunIcerigi = txtProductContent.Text,
                    StokGrupId = (int)sleuStokGroupKodu.EditValue,
                    IslemTuru = (byte)cmbProcessType.SelectedIndex,
                    Birim = (byte)cmbUnit.SelectedIndex,
                    Adet = (int)nudAddPiece.Value,
                    DepoId = (byte)cmbStore.SelectedIndex,
                    Kdv = (float)nudKDV.Value,
                    AlisFiyati = (float)nudPurchasePrice.Value,
                    SatisFiyati = (float)nudSalePrices.Value,
                    ToplamAdet = (int)nudTotalNumber.Value,
                    StokUyariAdedi = (int)nudStockWarningPiece.Value,
                };
                product.Resim = GeneralProcess.imageResize(pbPImage.Image);
                kayitSonuc = ps.Update(product);
                if (kayitSonuc <= 0)
                {
                    MessageBox.Show($"{txtBarkod.Text} {txtPrudoctName.Text} bilgileri güncellenmemiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"{txtBarkod.Text} {txtPrudoctName.Text} bilgileri başarıyla güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nudAddPiece.Value = 0;
                GridDoldur();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Ürün Güncelleme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        protected override void gvMemberList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (dtList.Rows[e.RowHandle]["Resim"].ToString() != "")
            {
                MemoryStream mem = new MemoryStream((Byte[])dtList.Rows[e.RowHandle]["Resim"]);
                pbPImage.Image = Image.FromStream(mem);
            }
            else
            {
                pbPImage.Image = global::KapaliDevreOdemeSistemi.Properties.Resources.Student;

            }
            aramaId = Convert.ToInt32(dtList.Rows[e.RowHandle]["id"]);
            txtBarkod.Text = dtList.Rows[e.RowHandle]["Barkod"].ToString();
            txtPrudoctName.Text = dtList.Rows[e.RowHandle]["UrunAdi"].ToString();
            txtProductContent.Text = dtList.Rows[e.RowHandle]["UrunIcerigi"].ToString();
            sleuStokGroupKodu.EditValue = Convert.ToInt32(dtList.Rows[e.RowHandle]["StokId"]);
            cmbProcessType.SelectedIndex = Convert.ToInt32(dtList.Rows[e.RowHandle]["IslemTuru"]);
            cmbUnit.SelectedIndex = Convert.ToInt32(dtList.Rows[e.RowHandle]["Birim"]);
            cmbState.SelectedIndex = Convert.ToInt32(dtList.Rows[e.RowHandle]["Durum"]);
            cmbStore.SelectedIndex = Convert.ToInt32(dtList.Rows[e.RowHandle]["StokGrupId"]);
            nudKDV.Value = Convert.ToDecimal(dtList.Rows[e.RowHandle]["KDV"]);
            nudPurchasePrice.Value = Convert.ToDecimal(dtList.Rows[e.RowHandle]["AlisFiyati"]);
            nudSalePrices.Value = Convert.ToDecimal(dtList.Rows[e.RowHandle]["SatisFiyati"]);
            nudStockWarningPiece.Value = Convert.ToInt32(dtList.Rows[e.RowHandle]["StokUyariAdedi"]);
            nudTotalNumber.Value = Convert.ToInt32(dtList.Rows[e.RowHandle]["ToplamAdet"]);
            ButonAramaDurum();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc;
                Product product = new Product()
                {
                    Id = aramaId
                };
                if (dtList == null && gvMemberList.SelectedRowsCount == 0)
                {
                    MessageBox.Show("Silmek İstediğiniz Ürünü Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes != MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    return;
                }
                kayitSonuc = ps.Delete(product);
                if (kayitSonuc > 0)
                {
                    MessageBox.Show("Silme Başarılı ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridDoldur();
                    return;
                }
                MessageBox.Show("Silme Başarısız ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                LogService.LogSave($"Ürün Silme İşlemi : Silme Başarılı { txtPrudoctName.Text} {txtBarkod.Text}", (byte)Enums.LogTipi.Bilgi);
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Ürün Silme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        public void ClearForm()
        {

            pbPImage.Image = global::KapaliDevreOdemeSistemi.Properties.Resources.urun;
            txtBarkod.Clear();
            txtProductContent.Clear();
            txtProductContent.Clear();
            sleuStokGroupKodu.EditValue = null;
            cmbProcessType.SelectedIndex = 0;
            cmbUnit.SelectedIndex = 0;
            cmbStore.SelectedIndex = 0;
            cmbState.SelectedIndex = 0;
            nudAddPiece.Value = 0;
            nudKDV.Value = 0;
            nudPurchasePrice.Value = 0;
            nudSalePrices.Value = 0;
            nudStockWarningPiece.Value = 0;
            nudTotalNumber.Value = 0;
        }
        private void btnFormClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            btnFormClear.PerformClick();
            ButonIlkDurum();
        }

        private void btnMUploadImage_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (ofdImageLoad.ShowDialog() == DialogResult.OK)
                {
                    pbPImage.Image = Image.FromFile(ofdImageLoad.FileName);
                    resimPath = ofdImageLoad.FileName.ToString();

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Resim Yükleme : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
    }
}
