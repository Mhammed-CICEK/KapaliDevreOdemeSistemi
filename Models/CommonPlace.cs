using System;
using System.Linq;

namespace Models
{
    public class CommonPlace
    {
        private int id;
        private byte durum;
        private DateTime kayıtTarihi;
        private int kaydedenKulId;
        private int degistirenKulId;
        private DateTime degistirmeTarihi;

        public int Id { get => id; set => id = value; }
        public byte Durum { get => durum; set => durum = value; }
        public DateTime KayıtTarihi { get => kayıtTarihi; set => kayıtTarihi = value; }
        public int KaydedenKulId { get => kaydedenKulId; set => kaydedenKulId = value; }
        public int DegistirenKulId { get => degistirenKulId; set => degistirenKulId = value; }
        public DateTime DegistirmeTarihi { get => degistirmeTarihi; set => degistirmeTarihi = value; }
    }
}
