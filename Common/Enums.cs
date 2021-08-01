using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Enums
    {
        public enum usersstate
        {
            Aktif,
            Pasif,
            Silinmiş
        }
        public enum SqlServerKomutTipi
        {
            SqlText,
            StoredProcedure
        }
        public enum KullaniciTİpi
        {
            Yonetici=1,
            KantinCalisani=2,
            Moderator=3,
            Members=4
        }
        public enum LogTipi
        {
            Hata=1,
            Bilgi=2
        }
    }

}
