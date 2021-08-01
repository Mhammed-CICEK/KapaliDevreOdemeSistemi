using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product : CommonPlace
    {
        private string barkod;
        private string urunAdi;
        private string urunIcerigi;
        private int stokGrupId;
        private byte islemTuru;
        private byte birim;
        private int adet;
        private byte depoId;
        private float kdv;
        private float alisFiyati;
        private float satisFiyati;
        private int toplamAdet;
        private int stokUyariAdedi;
        private byte[] resim;

        public string Barkod { get => barkod; set => barkod = value; }
        public string UrunAdi { get => urunAdi; set => urunAdi = value; }
        public string UrunIcerigi { get => urunIcerigi; set => urunIcerigi = value; }
        public int StokGrupId { get => stokGrupId; set => stokGrupId = value; }
        public byte IslemTuru { get => islemTuru; set => islemTuru = value; }
        public byte Birim { get => birim; set => birim = value; }
        public int Adet { get => adet; set => adet = value; }
        public byte DepoId { get => depoId; set => depoId = value; }
        public float Kdv { get => kdv; set => kdv = value; }
        public float AlisFiyati { get => alisFiyati; set => alisFiyati = value; }
        public float SatisFiyati { get => satisFiyati; set => satisFiyati = value; }
        public int ToplamAdet { get => toplamAdet; set => toplamAdet = value; }
        public int StokUyariAdedi { get => stokUyariAdedi; set => stokUyariAdedi = value; }
        public byte[] Resim { get => resim; set => resim = value; }
    }
}
