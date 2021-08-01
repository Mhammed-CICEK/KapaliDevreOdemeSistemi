using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Balance:CommonPlace
    {
        private int kartId;
        private int hesapId;
        private float yuklenenBakiye;
        private float harcananBakiye;
        private byte miktarTipi;
        private byte islemTipi;
        private string aciklama;

        public int KartId { get => kartId; set => kartId = value; }
        public int HesapId { get => hesapId; set => hesapId = value; }
        public float YuklenenBakiye { get => yuklenenBakiye; set => yuklenenBakiye = value; }
        public float HarcananBakiye { get => harcananBakiye; set => harcananBakiye = value; }
        public byte MiktarTipi { get => miktarTipi; set => miktarTipi = value; }
        public byte IslemTipi { get => islemTipi; set => islemTipi = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }
    }
}
