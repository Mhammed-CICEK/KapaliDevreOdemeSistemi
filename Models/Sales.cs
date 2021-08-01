using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Sales : CommonPlace
    {
        private int urunId;
        private int accountId;
        private int adet;
        private float satisFiyati;
        private float toplamTutar;
        private int kartId;

        public int UrunId { get => urunId; set => urunId = value; }
        public int AccountId { get => accountId; set => accountId = value; }
        public int Adet { get => adet; set => adet = value; }
        public float SatisFiyati { get => satisFiyati; set => satisFiyati = value; }
        public float ToplamTutar { get => toplamTutar; set => toplamTutar = value; }
        public int KartId { get => kartId; set => kartId = value; }
    }
}
