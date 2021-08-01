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
    public partial class frmUserPermision : BaseForm
    {
        PermissionsGroupService pgs = new PermissionsGroupService();
        UsersPermissionsService ups = new UsersPermissionsService();
        string yetkiKodu = "";
        public frmUserPermision()
        {
            InitializeComponent();
            pnlButton.Visible = false;
            gcMemberList.Visible = false;
            sdsPermissionsList.Fill();
            sdsPermissionsGroupList.Fill();
            
        }

        private void btnAddPermissionsGroup_Click(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc = 0;
                PermissionsGroup findPermissionsGroup = new PermissionsGroup();
                PermissionsGroup searchPerimisionsGroup = new PermissionsGroup();
                searchPerimisionsGroup.GrupAdi = txtPermissionsGoupName.Text;
                findPermissionsGroup = pgs.Find(searchPerimisionsGroup);
                if (findPermissionsGroup == null)
                {
                    pgs.Save(searchPerimisionsGroup);
                    sdsPermissionsGroupList.Fill();
                    if (kayitSonuc <= 0)
                    {
                        MessageBox.Show("Yetki Grubu Başarıyla eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    return;
                }
                MessageBox.Show("Daha Önce Aynı isimle yetki grup adi sisteme eklenmiştir. aynı isimle iki adet yetki grubu eklenemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Yetki Grubu Ekleme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

        private void frmUserPermision_Load(object sender, EventArgs e)
        {
           this.permissionsTableAdapter.Fill(this.kapaliDevreOdemeSistemiDataSet.Permissions);
            IlkFormDuzenle();
        }

        private void btnPermissionSave_Click(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc = 0;
                UserPermissions findUsersPermissions = new UserPermissions();
                UserPermissions usersPermissions = new UserPermissions();
                if (sleuPermissinGupList.EditValue == null)
                {
                    MessageBox.Show("Lütfen Ayarlamak istediğiniz yetki grubunu Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                findUsersPermissions = ups.Find((int)sleuPermissinGupList.EditValue);
                if (findUsersPermissions == null)
                {

                    for (int i = 0; i < gvPermissinList.Rows.Count; i++)
                    {
                        yetkiKodu += Convert.ToInt32(gvPermissinList.Rows[i].Cells[colGoruntuluyebilir.Index].Value).ToString();
                        yetkiKodu += Convert.ToInt32(gvPermissinList.Rows[i].Cells[colGuncellebilir.Index].Value).ToString();
                    }

                    usersPermissions.YetkiKodu = yetkiKodu;
                    usersPermissions.YetkiGrubuId = (int)sleuPermissinGupList.EditValue;
                    kayitSonuc = ups.Save(usersPermissions);
                    if (kayitSonuc <= 0)
                    {
                        MessageBox.Show("Yetkiler Ayarlanamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    MessageBox.Show($"{sleuPermissinGupList.SelectedText} Gurbunun Yetkileri Ayarlanmıştır.", "Bİlgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                for (int i = 0; i < gvPermissinList.Rows.Count; i++)
                {
                    yetkiKodu += Convert.ToInt32(gvPermissinList.Rows[i].Cells[colGoruntuluyebilir.Index].Value).ToString();
                    yetkiKodu += Convert.ToInt32(gvPermissinList.Rows[i].Cells[colGuncellebilir.Index].Value).ToString();
                }

                usersPermissions.YetkiKodu = yetkiKodu;
                usersPermissions.YetkiGrubuId = (int)sleuPermissinGupList.EditValue;
                kayitSonuc = ups.Update(usersPermissions);
                if (kayitSonuc <= 0)
                {
                    MessageBox.Show("Yetkiler Ayarlanamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show($"{sleuPermissinGupList.SelectedText} Gurbunun Yetkileri Ayarlanmıştır.", "Bİlgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Yetki Kaydetme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        public void IlkFormDuzenle()
        {
            try
            {
                for (int i = 0; i < gvPermissinList.Rows.Count; i++)
                {
                    gvPermissinList.Rows[i].Cells[colGoruntuluyebilir.Index].Value = false;
                    gvPermissinList.Rows[i].Cells[colGuncellebilir.Index].Value = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Yetki Düzenleme İlk Yükleme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

        private void slePermissinGupList_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                UserPermissions findUsersPermissions;
                if (sleuPermissinGupList.EditValue == null)
                {
                    MessageBox.Show("Lütfen Ayarlamak istediğiniz yetki grubunu Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                findUsersPermissions = ups.Find((int)sleuPermissinGupList.EditValue);
                if (findUsersPermissions == null)
                {
                    MessageBox.Show("Daha önce belirtilen grubun herhangi bir yetki ayarlanması yapılmamıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    IlkFormDuzenle();
                    return;
                }
                for (int i = 0; i < gvPermissinList.Rows.Count; i++)
                {
                    gvPermissinList.Rows[i].Cells[colGoruntuluyebilir.Index].Value = Convert.ToBoolean(Convert.ToInt32(findUsersPermissions.YetkiKodu.Substring(2 * i, 1)));
                    gvPermissinList.Rows[i].Cells[colGuncellebilir.Index].Value = Convert.ToBoolean(Convert.ToInt32(findUsersPermissions.YetkiKodu.Substring(2 * i + 1, 1)));
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Yetki Düzenleme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
    }
}
