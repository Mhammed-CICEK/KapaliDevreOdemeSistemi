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
    public partial class frmStockGroup : BaseForm
    {
        StockGroupService sgs = new StockGroupService();
        int aramaId;
        DataTable dt = new DataTable(); 
        public frmStockGroup()
        {
            InitializeComponent();
            ButonIlkDurum();
            GridDoldur();
        }
        public void GridDoldur()
        {

            gcMemberList.DataSource = sgs.ListAllDataTable();
            dt = sgs.ListAllDataTable();
        }

        private void btnNewRecord_Click_1(object sender, EventArgs e)
        {
            ButonYeniKayitDurum();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc;
                StockGroup sg = new StockGroup() { StokName = txtStokGroupName.Text, };
                if (string.IsNullOrEmpty(txtStokGroupName.Text))
                {
                    MessageBox.Show("Lütfen Stok Grup Adı Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                kayitSonuc = sgs.Save(sg);
                if (kayitSonuc > 0)
                {
                    MessageBox.Show("Kayıt Başarılı ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridDoldur();
                    return;
                }
                MessageBox.Show("Kayıt Başarısız ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Stok Grubu Ekleme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

            try
            {
                int kayitSonuc;
                StockGroup sg = new StockGroup()
                {
                    Id = aramaId,
                    StokName = txtStokGroupName.Text,
                };
                if (string.IsNullOrEmpty(txtStokGroupName.Text))
                {
                    MessageBox.Show("Lütfen Stok Grup Adı Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                kayitSonuc = sgs.Update(sg);
                if (kayitSonuc > 0)
                {
                    MessageBox.Show("Güncelleme Başarılı ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridDoldur();
                    return;
                }
                MessageBox.Show("Güncelleme Başarısız ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Stok Grubu Güncelleme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }

        }

        protected override void gvMemberList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                aramaId = Convert.ToInt32(dt.Rows[e.RowHandle]["Id"]);
                txtStokGroupName.Text = dt.Rows[e.RowHandle]["Adi"].ToString();
                ButonAramaDurum();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Stok Grubu Seçme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc;
                StockGroup sg = new StockGroup()
                {
                    Id = aramaId,
                };
                if (dt == null && gvMemberList.SelectedRowsCount == 0)
                {
                    MessageBox.Show("silmek İstediğiniz Group Adini Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (DialogResult.Yes != MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    return;
                }
                kayitSonuc = sgs.Delete(sg);
                if (kayitSonuc > 0)
                {
                    MessageBox.Show("Silme Başarılı ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridDoldur();
                    return;
                }
                MessageBox.Show("Silme Başarısız ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Stok Grubu Seçme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

        private void btnFormClear_Click_1(object sender, EventArgs e)
        {
            txtStokGroupName.Clear();
        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            btnFormClear.PerformClick();
            ButonIlkDurum();
        }
    }
}
