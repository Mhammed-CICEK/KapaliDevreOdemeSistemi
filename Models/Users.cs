using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Users:CommonPlace
    {
        private int yetkiGrubuId;
        private string kullaniciAdi;
        private string sifre;
        private string isim;
        private string soyisim;
        private string unvan;
        private long telefon;
        private string email;
        private string aciklama;
        private byte[] resim;

        public int YetkiGrubuId { get => yetkiGrubuId; set => yetkiGrubuId = value; }
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Unvan { get => unvan; set => unvan = value; }
        public long Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }
        public byte[] Resim { get => resim; set => resim = value; }
    }
}
