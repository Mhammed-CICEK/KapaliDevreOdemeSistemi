using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CardAccount : CommonPlace
    {
        private int hesapId;
        private int kartId;
        private byte hesapTipi;
        private int kartSifresi;
        private byte limitiDurumu;
        private DateTime baslangicTarihi;
        private int yenilemeAraligi;
        private float harcamaLimiti;
        private string hesapAdi;
        private byte eksiBakiyeDurumu;
        private float eksiBakiye;
        private byte bonusDurumu;
        private float bonusOrani;

        public int HesapId { get => hesapId; set => hesapId = value; }
        public int KartId { get => kartId; set => kartId = value; }
        public byte HesapTipi { get => hesapTipi; set => hesapTipi = value; }
        public int KartSifresi { get => kartSifresi; set => kartSifresi = value; }
        public byte LimitiDurumu { get => limitiDurumu; set => limitiDurumu = value; }
        public DateTime BaslangicTarihi { get => baslangicTarihi; set => baslangicTarihi = value; }
        public int YenilemeAraligi { get => yenilemeAraligi; set => yenilemeAraligi = value; }
        public float HarcamaLimiti { get => harcamaLimiti; set => harcamaLimiti = value; }
        public string HesapAdi { get => hesapAdi; set => hesapAdi = value; }
        public byte EksiBakiyeDurumu { get => eksiBakiyeDurumu; set => eksiBakiyeDurumu = value; }
        public float EksiBakiye { get => eksiBakiye; set => eksiBakiye = value; }
        public byte BonusDurumu { get => bonusDurumu; set => bonusDurumu = value; }
        public float BonusOrani { get => bonusOrani; set => bonusOrani = value; }
    }
}
