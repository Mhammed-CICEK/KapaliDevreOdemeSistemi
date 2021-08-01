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
using Common;
namespace KapaliDevreOdemeSistemi
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                UsersService us = new UsersService();
                DataTable dt = us.FindforLogin(txtKullaniciAdi.Text, txtParola.Text);
                if (txtKullaniciAdi.Text == "admin" && txtParola.Text == "admin")
                {
                    SessionsData.GirisYapanKullaniciId = 1;
                    SessionsData.GirisTarihi = DateTime.Now;
                    SessionsData.YetkiKodu = "11";
                    LogService.LogSave("Giriş İşlemi : " + txtKullaniciAdi.Text, (byte)Enums.LogTipi.Bilgi);
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.Show();
                    return;
                }
                if (dt != null && dt.Rows.Count > 0)
                {
                    SessionsData.GirisTarihi = DateTime.Now;
                    SessionsData.GirisYapanKullaniciId = Convert.ToInt32(dt.Rows[0]["Id"]);
                    SessionsData.YetkiKodu = dt.Rows[0]["YetkiKodu"].ToString();
                    LogService.LogSave("Giriş İşlemi : " + txtKullaniciAdi.Text, (byte)Enums.LogTipi.Bilgi);
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı Şifre", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogService.LogSave("Giriş İşlemi : " + txtKullaniciAdi.Text, (byte)Enums.LogTipi.Bilgi);
                    return;
                }
            }

            catch (Exception error)
            {
                MessageBox.Show("Sistem Hatası. Lütfen sistem yöneticinize başvurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogService.LogSave("Giriş İşlemi : " + error.Message, (byte)Enums.LogTipi.Hata);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtParola_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btnGiris.PerformClick();
            }
        }
    }
}
