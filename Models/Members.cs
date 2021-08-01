using System;
using System.Linq;

namespace Models
{
    public class Members : CommonPlace
    {
        private string isim;
        private string soyisim;
        private long kimlikNo;
        private string dogumYeri;
        private DateTime dogumTarihi;
        private long evTel;
        private long gsm;
        private string eposta;
        private string sifre;
        private string meslek;
        private string ulke;
        private string sehir;
        private string ikametAdresi;
        private DateTime uyelikTarihi;
        private DateTime uyelikBitisTarihi;
        private byte[] resim;
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public long KimlikNo { get => kimlikNo; set => kimlikNo = value; }
        public string DogumYeri { get => dogumYeri; set => dogumYeri = value; }
        public DateTime DogumTarihi { get => dogumTarihi; set => dogumTarihi = value; }
        public long EvTel { get => evTel; set => evTel = value; }
        public long Gsm { get => gsm; set => gsm = value; }
        public string Eposta { get => eposta; set => eposta = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public string Meslek { get => meslek; set => meslek = value; }
        public string Ulke { get => ulke; set => ulke = value; }
        public string Sehir { get => sehir; set => sehir = value; }
        public string IkametAdresi { get => ikametAdresi; set => ikametAdresi = value; }
        public DateTime UyelikTarihi { get => uyelikTarihi; set => uyelikTarihi = value; }
        public DateTime UyelikBitisTarihi { get => uyelikBitisTarihi; set => uyelikBitisTarihi = value; }
        public byte[] Resim { get => resim; set => resim = value; }
    }
}
