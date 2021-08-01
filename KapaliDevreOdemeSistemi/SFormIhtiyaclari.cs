using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;

namespace KapaliDevreOdemeSistemi
{
    class SFormIhtiyaclari
    {
        #region Standart Form İhtiyaçları

        #region Buttonlar
        private Button btnYeniKayit = new Button();
        private Button btnKaydet = new Button();
        private Button btnGuncelle = new Button();
        private Button btnSil = new Button();
        private Button btnAra = new Button();
        private Button btnFormuTemizle = new Button();
        private Button btnVazgec = new Button();
        private GroupBox grpAnaBilgiler = new GroupBox();

        public Button BtnYeniKayıt { get => btnYeniKayit; set => btnYeniKayit = value; }
        public Button BtnKaydet { get => btnKaydet; set => btnKaydet = value; }
        public Button BtnGuncelle { get => btnGuncelle; set => btnGuncelle = value; }
        public Button BtnSil { get => btnSil; set => btnSil = value; }
        public Button BtnAra { get => btnAra; set => btnAra = value; }
        public Button BtnFormuTemizle { get => btnFormuTemizle; set => btnFormuTemizle = value; }
        public Button BtnVazgec { get => btnVazgec; set => btnVazgec = value; }
        public GroupBox GrpAnaBilgiler { get => grpAnaBilgiler; set => grpAnaBilgiler = value; }
        #endregion
        #region TextBoxlar
        private TextBox textBox1 = new TextBox();
        private TextBox textBox2 = new TextBox();
        private TextBox textBox3 = new TextBox();
        private TextBox textBox4 = new TextBox();
        private TextBox textBox5 = new TextBox();
        private TextBox textBox6 = new TextBox();
        private TextBox textBox7 = new TextBox();
        private TextBox textBox8 = new TextBox();
        private TextBox textBox9 = new TextBox();
        private MaskedTextBox maskedText = new MaskedTextBox();
        private MaskedTextBox maskedText1 = new MaskedTextBox();
        private MaskedTextBox maskedText2 = new MaskedTextBox();
        private DateEdit dateEdit = new DateEdit();
        private DateEdit dateEdit1 = new DateEdit();
        private DateEdit dateEdit2 = new DateEdit();
        private System.Windows.Forms.ComboBox comboBox = new System.Windows.Forms.ComboBox(); 
        private System.Windows.Forms.ComboBox comboBox1 = new System.Windows.Forms.ComboBox(); 
        private System.Windows.Forms.ComboBox comboBox2 = new System.Windows.Forms.ComboBox(); 
        public TextBox TextBox1 { get => textBox1; set => textBox1 = value; }
        public TextBox TextBox2 { get => textBox2; set => textBox2 = value; }
        public TextBox TextBox3 { get => textBox3; set => textBox3 = value; }
        public TextBox TextBox4 { get => textBox4; set => textBox4 = value; }
        public TextBox TextBox5 { get => textBox5; set => textBox5 = value; }
        public TextBox TextBox6 { get => textBox6; set => textBox6 = value; }
        public TextBox TextBox7 { get => textBox7; set => textBox7 = value; }
        public MaskedTextBox MaskedText { get => maskedText; set => maskedText = value; }
        public MaskedTextBox MaskedText1 { get => maskedText1; set => maskedText1 = value; }
        public MaskedTextBox MaskedText2 { get => maskedText2; set => maskedText2 = value; }
        public DateEdit DateEdit { get => dateEdit; set => dateEdit = value; }
        public DateEdit DateEdit1 { get => dateEdit1; set => dateEdit1 = value; }
        public DateEdit DateEdit2 { get => dateEdit2; set => dateEdit2 = value; }
        public System.Windows.Forms.ComboBox ComboBox { get => comboBox; set => comboBox = value; }
        public System.Windows.Forms.ComboBox ComboBox1 { get => comboBox1; set => comboBox1 = value; }
        public System.Windows.Forms.ComboBox ComboBox2 { get => comboBox2; set => comboBox2 = value; }
        public TextBox TextBox8 { get => textBox8; set => textBox8 = value; }
        public TextBox TextBox9 { get => textBox9; set => textBox9 = value; }
        #endregion

        public bool GirisKontrolleri(TextBox txtAdSoyad, MaskedTextBox txtTcKimlikNo, TextBox txtPassword)
        {
            if (string.IsNullOrEmpty(txtAdSoyad.Text)) //if(txtAdSoyad.Text=="")
            {
                MessageBox.Show("Ad Soyad boş geçilemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdSoyad.Focus();
                return false;
            }
            if (txtTcKimlikNo.Text.Replace("_", "").Length < 11)
            {
                MessageBox.Show("Tc Kimlik 11 Hane Olmalıdır!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTcKimlikNo.Focus();
                return false;

            }
            if (string.IsNullOrEmpty(txtPassword.Text)) //if(txtTelefon.Text=="")
            {
                MessageBox.Show("Şifre boş geçilemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            return true;
        }
        public bool GirisKontrolleri(TextBox txtACCardNo, System.Windows.Forms.ComboBox cbACState, System.Windows.Forms.ComboBox cbACKartType)
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
                txtACCardNo.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbACState.Text)) //if(txtTelefon.Text=="")
            {
                MessageBox.Show("Kart Durumu boş geçilemez!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbACState.Focus();
                return false;
            }
            return true;
        }
        public void FormuTemizle()
        {
            TextBox1.Clear();
            TextBox2.Clear();// btnGuncelletxtTelefon.Text ="";            
            TextBox3.Clear();// btnGuncelletxtTelefon.Text ="";            
            TextBox4.Clear();// btnGuncelletxtTelefon.Text ="";            
            TextBox5.Clear();// btnGuncelletxtTelefon.Text ="";            
            TextBox6.Clear();// btnGuncelletxtTelefon.Text ="";            
            TextBox7.Clear();// btnGuncelletxtTelefon.Text ="";
            MaskedText.Clear();
            MaskedText1.Clear();
            MaskedText2.Clear();
            DateEdit.Text = "";
            DateEdit1.Text = "";
            DateEdit2.Text = "";
            comboBox.SelectedIndex = -1;
            ComboBox1.SelectedIndex = -1;
            ComboBox2.SelectedIndex = -1;
        }
        //Buton Durumları

        public void ButonIlkDurum()
        {
            btnYeniKayit.Enabled = true;
            BtnKaydet.Enabled = false;
            BtnGuncelle.Enabled = false;
            BtnSil.Enabled = false;
            BtnAra.Enabled = true;
            BtnFormuTemizle.Enabled = false;
            BtnVazgec.Enabled = false;
            GrpAnaBilgiler.Enabled = false;
            
        }
        public void ButonYeniKayitDurum()
        {
            btnYeniKayit.Enabled = false;
            BtnKaydet.Enabled = true;
            BtnGuncelle.Enabled = false;
            BtnSil.Enabled = false;
            BtnAra.Enabled = false;
            BtnFormuTemizle.Enabled = true;
            BtnVazgec.Enabled = true;
            grpAnaBilgiler.Enabled = true;
        }
        public void ButonAramaDurum()
        {
            btnYeniKayit.Enabled = false;
            BtnKaydet.Enabled = false;
            BtnGuncelle.Enabled = true;
            BtnSil.Enabled = true;
            BtnAra.Enabled = true;
            BtnFormuTemizle.Enabled = true;
            BtnVazgec.Enabled = true;
            grpAnaBilgiler.Enabled = true;
        }

        #endregion Standart Form İhtiyaçları
    }
}
