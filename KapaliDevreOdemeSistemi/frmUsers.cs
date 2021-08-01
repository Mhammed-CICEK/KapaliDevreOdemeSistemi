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
using Common;
using Library;
using Models;
using ServicesLayer;
namespace KapaliDevreOdemeSistemi
{
    public partial class frmUsers : BaseForm
    {
        UsersService us = new UsersService();
        string resimPath;
        DataTable dtList = new DataTable();
        int aramaId;
        public frmUsers()
        {
            InitializeComponent();
            sdsUsersList.Fill();
        }
        public bool GirisKontrolleri()
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text)) //if(txtAdSoyad.Text=="")
                {
                    MessageBox.Show("Ad boş geçilemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtUsersPassword.Text)) //if(txtTelefon.Text=="")
                {
                    MessageBox.Show("Şifre boş geçilemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsersPassword.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txtUsersrePassword.Text)) //if(txtTelefon.Text=="")
                {
                    MessageBox.Show("Lütfen şifreyi tekrar gir boş geçilemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsersrePassword.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtUserSurname.Text)) //if(txtTelefon.Text=="")
                {
                    MessageBox.Show("Soyisim boş geçilemez", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsersrePassword.Focus();
                    return false;
                }
                if (txtUsersPassword.Text != txtUsersPassword.Text) //if(txtTelefon.Text=="")
                {
                    MessageBox.Show("iki şifre aynı olmalıdır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsersrePassword.Focus();
                    return false;
                }
                if (sleuYetkiGoup.EditValue == null) //if(txtTelefon.Text=="")
                {
                    MessageBox.Show("Lütfen bir yetki grubu seçiniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sleuYetkiGoup.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kullanıcı Giriş Kontrolleri İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
                return false;
            }
        }

        private void btnNewRecord_Click_1(object sender, EventArgs e)
        {
            txtUsersrePassword.ReadOnly = false;
            txtUsersPassword.ReadOnly = false;
            ButonYeniKayitDurum();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            ButonIlkDurum();
            cmbUsersSatae.SelectedIndex = 0;
            GridDoldur();
        }
        public void GridDoldur()
        {
            gcMemberList.DataSource = us.ListAllDataTable();
            gvMemberList.Columns[0].Visible = false;
            gvMemberList.Columns[1].Visible = false;
            gvMemberList.Columns[2].Visible = false;
            dtList = us.ListAllDataTable();
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                Users searchUsers = new Users();
                Users findUsers = new Users();
                int kayitSonuc;
                if (!GirisKontrolleri())
                {
                    return;
                }
                searchUsers.KullaniciAdi = txtUsernickName.Text;
                findUsers = us.Find(searchUsers);
                if (findUsers != null)
                {
                    MessageBox.Show("Aynı Kullanıcı Adı sisteme kayıtlı! Lütfen farklı bir kullancı adı deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Users users = new Users();
                users.Aciklama = txtUsersExplataion.Text;
                users.Durum = (byte)cmbUsersSatae.SelectedIndex;
                users.Email = txtUserEmail.Text;
                users.Isim = txtUserName.Text;
                users.KullaniciAdi = txtUsernickName.Text;
                users.Resim = GeneralProcess.imageResize(pbUImage.Image);
                users.Sifre = txtUsersPassword.Text;
                users.Soyisim = txtUserSurname.Text;
                users.Telefon = Convert.ToInt64(GeneralProcess.maskedtextOzelKarakterSil(mtxtUserPhone.Text));
                users.Unvan = txtUTitle.Text;
                users.YetkiGrubuId = (int)sleuYetkiGoup.EditValue;
                kayitSonuc = us.Save(users);
                if (kayitSonuc <= 0)
                {
                    MessageBox.Show("Kullanıcı kayıt edilememiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                GridDoldur();
                MessageBox.Show("Kullanıcı Sisteme Başırılı bir şekilde kaydedilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kullanıcı Ekleme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        protected override void gvMemberList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.RowHandle < 0)
                {
                    return;
                }
                if (dtList.Rows[e.RowHandle]["Resim"].ToString() != "")
                {
                    MemoryStream mem = new MemoryStream((byte[])dtList.Rows[e.RowHandle]["Resim"]);
                    pbUImage.Image = Image.FromStream(mem);
                }
                else
                {
                    pbUImage.Image = global::KapaliDevreOdemeSistemi.Properties.Resources.Student;
                }
                aramaId = Convert.ToInt32(dtList.Rows[e.RowHandle]["Id"]);
                txtUserName.Text = dtList.Rows[e.RowHandle]["Isim"].ToString();
                txtUserSurname.Text = dtList.Rows[e.RowHandle]["Soyisim"].ToString();
                txtUsernickName.Text = dtList.Rows[e.RowHandle]["KullaniciAdi"].ToString();
                sleuYetkiGoup.EditValue = Convert.ToInt32(dtList.Rows[e.RowHandle]["PermissionGruopId"]);
                cmbUsersSatae.SelectedIndex = Convert.ToInt32(dtList.Rows[e.RowHandle]["Durum"]);
                mtxtUserPhone.Text = dtList.Rows[e.RowHandle]["Telefon"].ToString();
                txtUTitle.Text = dtList.Rows[e.RowHandle]["Unvan"].ToString();
                txtUserEmail.Text = dtList.Rows[e.RowHandle]["Email"].ToString();
                txtUsersExplataion.Text = dtList.Rows[e.RowHandle]["Aciklama"].ToString();
                txtUsersPassword.Text = dtList.Rows[e.RowHandle]["Sifre"].ToString();
                txtUsersrePassword.Text = dtList.Rows[e.RowHandle]["Sifre"].ToString();
                txtUsersrePassword.ReadOnly = true;
                txtUsersPassword.ReadOnly = true;
                ButonAramaDurum();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kullanıcı Seçme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        private void btnMUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdMImageLoad.ShowDialog() == DialogResult.OK)
                {
                    pbUImage.Image = Image.FromFile(ofdMImageLoad.FileName);
                    resimPath = ofdMImageLoad.FileName.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kullanıcı Resim Seçnme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                Users searchUsers = new Users();
                Users findUsers = new Users();
                int kayitSonuc;
                if (!GirisKontrolleri())
                {
                    return;
                }
                searchUsers.KullaniciAdi = txtUsernickName.Text;
                searchUsers.Id = aramaId;
                findUsers = us.FindforUpdate(searchUsers);
                if (findUsers != null)
                {
                    MessageBox.Show("Aynı Kullanıcı Adı sisteme kayıtlı! Lütfen farklı bir kullancı adı deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Users users = new Users();
                users.Id = aramaId;
                users.Aciklama = txtUsersExplataion.Text;
                users.Durum = (byte)cmbUsersSatae.SelectedIndex;
                users.Email = txtUserEmail.Text;
                users.Isim = txtUserName.Text;
                users.KullaniciAdi = txtUsernickName.Text;
                users.Resim = GeneralProcess.imageResize(pbUImage.Image);
                users.Sifre = txtUsersPassword.Text;
                users.Soyisim = txtUserSurname.Text;
                users.Telefon = Convert.ToInt64(GeneralProcess.maskedtextOzelKarakterSil(mtxtUserPhone.Text));
                users.Unvan = txtUTitle.Text;
                users.YetkiGrubuId = (int)sleuYetkiGoup.EditValue;

                kayitSonuc = us.Update(users);
                if (kayitSonuc <= 0)
                {
                    MessageBox.Show("Kullanıcı guncellenememiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Kullanıcı Başırılı bir şekilde guncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridDoldur();
                ButonIlkDurum();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kullanıcı Güncelleme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        public void ClearForm()
        {
            txtUserEmail.Clear();
            txtUserName.Clear();
            txtUsernickName.Clear();
            txtUsersExplataion.Clear();
            txtUsersPassword.Clear();
            txtUsersrePassword.Clear();
            txtUserSurname.Clear();
            txtUTitle.Clear();mtxtUserPhone.Clear();
            cmbUsersSatae.SelectedIndex = 0;
            sleuYetkiGoup.EditValue = null;
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                int kayitSonuc;
                if (DialogResult.Yes != MessageBox.Show($"{txtUserName.Text} {txtUserSurname.Text} Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    return;
                }
                kayitSonuc = us.Delete(aramaId);
                if (kayitSonuc < 0)
                {
                    MessageBox.Show($"{txtUserName.Text} {txtUserSurname.Text} Silnememiştir", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                GridDoldur();
                MessageBox.Show($"{txtUserName.Text} {txtUserSurname.Text} Silinmiştir", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Kullanıcı Silme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
    }
}
