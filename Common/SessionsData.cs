using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class SessionsData
    {
        private static int girisYapanKullaniciId;
        private static DateTime girisTarihi;
        private static string yetkiKodu;
        public static int GirisYapanKullaniciId { get => girisYapanKullaniciId; set => girisYapanKullaniciId = value; }
        public static DateTime GirisTarihi { get => girisTarihi; set => girisTarihi = value; }
        public static string YetkiKodu { get => yetkiKodu; set => yetkiKodu = value; }


    }
}
