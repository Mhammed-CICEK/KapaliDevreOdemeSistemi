using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Log
    {
        private int id;
        private DateTime islemTarihi;
        private string detay;
        private byte logTipi;
        private int islemKulId;

        public int Id { get => id; set => id = value; }
        public DateTime IslemTarihi { get => islemTarihi; set => islemTarihi = value; }
        public string Detay { get => detay; set => detay = value; }
        public byte LogTipi { get => logTipi; set => logTipi = value; }
        public int IslemKulId { get => islemKulId; set => islemKulId = value; }
    }
}
