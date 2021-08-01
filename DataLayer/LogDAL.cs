using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Common;
namespace DataLayer
{
    public static class LogDAL
    {
        public static void LogSave(string pDetay, byte plogTipi)
        {
            string sql = "INSERT INTO Log (IslemTarihi,Detay,LogTipi,IslemKulId) VALUES(@IslemTarihi,@Detay,@LogTipi,@IslemKulId)";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@IslemTarihi", DateTime.Now);
            prm.Add("@Detay", pDetay);
            prm.Add("@LogTipi", plogTipi);
            prm.Add("@IslemKulId", SessionsData.GirisYapanKullaniciId);

            ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm);
        }
    }
}
