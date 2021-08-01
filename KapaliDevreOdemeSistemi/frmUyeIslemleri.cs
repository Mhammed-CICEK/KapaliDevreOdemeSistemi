using Common;
using Library;
using Models;
using ServicesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapaliDevreOdemeSistemi
{
    public partial class frmUyeIslemleri : BaseForm
    {

        Members member = new Members();
        MembersServices ms = new MembersServices();
        DataTable dtList = new DataTable();
        int aramaId;
        string resimPath;
        public frmUyeIslemleri()
        {
            InitializeComponent();
            ButonIlkDurum();
            GridDoldur();
        }
        
        public void GridDoldur()
        {
            try
            {
                gcMemberList.DataSource = ms.ListAllDataTable();
                dtList = ms.ListAllDataTable();
                gvMemberList.Columns["id"].Visible = false;
                gvMemberList.Columns["Durum"].Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Üye Liste Yenileme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        protected override void btnNewRecord_Click(object sender, EventArgs e)
        {
            ButonYeniKayitDurum();
        }
        public bool GirisKontrolleri()
        {
            try
            {
                if (string.IsNullOrEmpty(txtMName.Text)) //if(txtAdSoyad.Text=="")
                {
                    MessageBox.Show("Ad Soyad boş geçilemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMName.Focus();
                    return false;
                }
                if (mtxtMKimlikNo.Text.Replace("_", "").Length < 11)
                {
                    MessageBox.Show("Tc Kimlik 11 Hane Olmalıdır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtMKimlikNo.Focus();
                    return false;

                }
                if (string.IsNullOrEmpty(txtMPassword.Text)) //if(txtTelefon.Text=="")
                {
                    MessageBox.Show("Şifre boş geçilemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMPassword.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Üye Giriş Kontrolleri İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
                return false;
            }
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
                Members aramaModel = new Members()
                {
                    KimlikNo = Convert.ToInt64(GeneralProcess.maskedtextOzelKarakterSil(mtxtMKimlikNo.Text))
                };
                var findMember = ms.Find(aramaModel);
                if (findMember != null) //kayıt bulunduysa
                {
                    MessageBox.Show(mtxtMKimlikNo.Text + " Tc Numarası daha önceden kayıtlıdır", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Members member = new Members()
                {
                    KayıtTarihi = DateTime.Now,
                    Isim = txtMName.Text,
                    Soyisim = txtMSurname.Text,
                    KimlikNo = Convert.ToInt64(GeneralProcess.maskedtextOzelKarakterSil(mtxtMKimlikNo.Text)),
                    DogumYeri = txtMPlaceBirth.Text,
                    DogumTarihi = Convert.ToDateTime(deDateBirth.Text),
                    EvTel = Convert.ToInt64(GeneralProcess.maskedtextOzelKarakterSil(mtxtMHomePhone.Text)),
                    Gsm = Convert.ToInt64(GeneralProcess.maskedtextOzelKarakterSil(mtxtMGsm.Text)),
                    Eposta = txtMEPosta.Text,
                    Durum = (byte)cbState.SelectedIndex,
                    Sifre = txtMPassword.Text,
                    Meslek = txtMJop.Text,
                    Ulke = txtMGoverment.Text,
                    Sehir = txtMCity.Text,
                    IkametAdresi = txtMAdress.Text,
                    UyelikTarihi = Convert.ToDateTime(deMemberDate.Text),
                    UyelikBitisTarihi = Convert.ToDateTime(deMemberFinishDate.Text)
                };
                member.Resim = GeneralProcess.imageResize(pbMImage.Image);
                kayitSonuc = ms.Save(member);
                if (kayitSonuc <= 0)
                {
                    MessageBox.Show($"{txtMName.Text} {txtMSurname.Text} bilgileri kaydedilmemiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"{txtMName.Text} {txtMSurname.Text} bilgileri başarıyla Kaydedilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridDoldur();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Üye Ekleme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        protected override void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GirisKontrolleri())
                {
                    return;
                }
                Members aramaModel = new Members()
                {
                    Id = aramaId,
                    KimlikNo = Convert.ToInt64(GeneralProcess.maskedtextOzelKarakterSil(mtxtMKimlikNo.Text))
                };
                var findMember = ms.FindTcNo(aramaModel);
                if (findMember != null) //kayıt bulunduysa
                {
                    MessageBox.Show(mtxtMKimlikNo.Text + " Tc Numarası daha önceden kayıtlıdır", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Members member = new Members()
                {
                    Id = aramaId,
                    KayıtTarihi = DateTime.Now,
                    Isim = txtMName.Text,
                    Soyisim = txtMSurname.Text,
                    KimlikNo = Convert.ToInt64(GeneralProcess.maskedtextOzelKarakterSil(mtxtMKimlikNo.Text)),
                    DogumYeri = txtMPlaceBirth.Text,
                    DogumTarihi = Convert.ToDateTime(deDateBirth.Text),
                    EvTel = Convert.ToInt64(GeneralProcess.maskedtextOzelKarakterSil(mtxtMHomePhone.Text)),
                    Gsm = Convert.ToInt64(GeneralProcess.maskedtextOzelKarakterSil(mtxtMGsm.Text)),
                    Eposta = txtMEPosta.Text,
                    Durum = (byte)cbState.SelectedIndex,
                    Sifre = txtMPassword.Text,
                    Meslek = txtMJop.Text,
                    Ulke = txtMGoverment.Text,
                    Sehir = txtMCity.Text,
                    IkametAdresi = txtMAdress.Text,
                    UyelikTarihi = Convert.ToDateTime(deMemberDate.Text),
                    UyelikBitisTarihi = Convert.ToDateTime(deMemberFinishDate.Text),
                    Resim = GeneralProcess.imageResize(pbMImage.Image)

                };
                int updateSonuc = ms.Update(member);
                if (updateSonuc <= 0)
                {
                    MessageBox.Show($"{txtMName.Text} {txtMSurname.Text} bilgileri güncellenmemiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                GridDoldur();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Üye Güncelleme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        protected override void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var cevap = MessageBox.Show(mtxtMKimlikNo.Text + " Kullanıcı kaydı silinecektir. Emin misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {
                    int sonuc = ms.Delete(aramaId);
                    if (sonuc > 0)
                    {
                        GridDoldur();
                        gbData.Enabled = false;
                        ButonIlkDurum();
                        MessageBox.Show("Silme Başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Silme Başarısız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Üye Silme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }
        protected override void btnFormClear_Click(object sender, EventArgs e)
        {
            FormClear();
            GridDoldur();
        }
        public void FormClear()
        {
            txtMName.Clear();
            txtMSurname.Clear();// btnGuncelletxtTelefon.Text ="";            
            txtMAdress.Clear();// btnGuncelletxtTelefon.Text ="";            
            txtMCity.Clear();// btnGuncelletxtTelefon.Text ="";            
            txtMEPosta.Clear();// btnGuncelletxtTelefon.Text ="";            
            txtMGoverment.Clear();// btnGuncelletxtTelefon.Text ="";            
            txtMJop.Clear();// btnGuncelletxtTelefon.Text ="";
            mtxtMGsm.Clear();
            mtxtMHomePhone.Clear();
            mtxtMKimlikNo.Clear();
            deMemberDate.EditValue = DateTime.Now;
            deDateBirth.EditValue = DateTime.Now;
            deMemberFinishDate.EditValue = DateTime.Now;
            cbState.SelectedIndex = 0;
        }
        protected override void btnReturn_Click(object sender, EventArgs e)
        {
            FormClear();
            ButonIlkDurum();
            GridDoldur();
        }
        protected override void gvMemberList_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (dtList.Rows[e.RowHandle]["Resim"].ToString() != "")
                {
                    MemoryStream mem = new MemoryStream((Byte[])dtList.Rows[e.RowHandle]["Resim"]);
                    pbMImage.Image = Image.FromStream(mem);
                }
                else
                {
                    pbMImage.Image = global::KapaliDevreOdemeSistemi.Properties.Resources.Student;
                }
                aramaId = Convert.ToInt32(dtList.Rows[e.RowHandle]["id"]);
                txtMName.Text = dtList.Rows[e.RowHandle]["Isim"].ToString();
                txtMSurname.Text = dtList.Rows[e.RowHandle]["Soyisim"].ToString();
                mtxtMKimlikNo.Text = dtList.Rows[e.RowHandle]["KimlikNo"].ToString();
                txtMPlaceBirth.Text = dtList.Rows[e.RowHandle]["DogumYeri"].ToString();
                deDateBirth.Text = dtList.Rows[e.RowHandle]["DogumTarihi"].ToString();
                mtxtMHomePhone.Text = dtList.Rows[e.RowHandle]["EvTel"].ToString();
                mtxtMGsm.Text = dtList.Rows[e.RowHandle]["Gsm"].ToString();
                cbState.SelectedIndex = Convert.ToInt32(dtList.Rows[e.RowHandle]["Durum"].ToString());
                mtxtMKimlikNo.Text = dtList.Rows[e.RowHandle]["KimlikNo"].ToString();
                txtMEPosta.Text = dtList.Rows[e.RowHandle]["Eposta"].ToString();
                txtMPassword.Text = dtList.Rows[e.RowHandle]["Sifre"].ToString();
                txtMJop.Text = dtList.Rows[e.RowHandle]["Meslek"].ToString();
                txtMGoverment.Text = dtList.Rows[e.RowHandle]["Ulke"].ToString();
                txtMCity.Text = dtList.Rows[e.RowHandle]["Sehir"].ToString();
                txtMAdress.Text = dtList.Rows[e.RowHandle]["IkametAdresi"].ToString();
                deMemberDate.Text = dtList.Rows[e.RowHandle]["UyelikTarihi"].ToString();
                deMemberFinishDate.Text = dtList.Rows[e.RowHandle]["UyelikBitisTarihi"].ToString();
                ButonAramaDurum();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Üye Seçme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

        private void btnMUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdMImageLoad.ShowDialog() == DialogResult.OK)
                {
                    pbMImage.Image = Image.FromFile(ofdMImageLoad.FileName);
                    resimPath = ofdMImageLoad.FileName.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Üye REsim Seçme İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

        private void frmUyeIslemleri_Load(object sender, EventArgs e)
        {
            FormClear();
        }
    }
}
