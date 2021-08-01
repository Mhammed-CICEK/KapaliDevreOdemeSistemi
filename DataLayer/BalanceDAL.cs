using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Interfaces;
using System.Data;
using Common;

namespace DataLayer
{
    public class BalanceDAL : ICRUDIslemleri<Balance>
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(Balance entity)
        {
            throw new NotImplementedException();
        }

        public Balance Find(int id)
        {


            string sql = "select Id,KartId,HesapId,HarcananBakiye,YuklenenBakiye from vwTopUpList Where KartId=@KartId";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@KartId", id);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.SqlText);
            Balance topUp = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                topUp = new Balance()
                {
                    Id = (int)dt.Rows[dt.Rows.Count - 1]["Id"],
                    KartId = (int)dt.Rows[dt.Rows.Count - 1]["KartId"],
                    HesapId = (int)dt.Rows[dt.Rows.Count - 1]["HesapId"],
                    YuklenenBakiye = Convert.ToInt64(dt.Rows[dt.Rows.Count - 1]["YuklenenBakiye"]),
                    HarcananBakiye = Convert.ToInt64(dt.Rows[dt.Rows.Count - 1]["HarcananBakiye"])
                };
            }
            return topUp;
        }

        public Balance Find(Balance entity)
        {

            string sql = "select Id,KartId,HesapId,HarcananBakiye,YuklenenBakiye from vwTopUpList Where KartId=@KartId";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@KartId", entity.KartId);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.SqlText);
            Balance topUp = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                topUp = new Balance()
                {
                    Id = (int)dt.Rows[dt.Rows.Count - 1]["Id"],
                    KartId = (int)dt.Rows[dt.Rows.Count - 1]["KartId"],
                    HesapId = (int)dt.Rows[dt.Rows.Count - 1]["HesapId"],
                    YuklenenBakiye = Convert.ToInt64(dt.Rows[dt.Rows.Count - 1]["YuklenenBakiye"]),
                    HarcananBakiye = Convert.ToInt64(dt.Rows[dt.Rows.Count - 1]["HarcananBakiye"])
                };
            }
            return topUp;
        }

        public List<Balance> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Balance> ListAll(Balance entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable(Balance entity)
        {
            throw new NotImplementedException();
        }

        public int Save(Balance entity)
        {
            string sql = "spTopUp";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", entity.Durum);
            prm.Add("@KayitTarihi", DateTime.Now);
            prm.Add("@KaydedenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@KartId", entity.KartId);
            prm.Add("@HesapId", entity.HesapId);
            prm.Add("@YuklenenBakiye", entity.YuklenenBakiye);
            prm.Add("@HarcananBakiye", entity.HarcananBakiye);
            prm.Add("@MiktarTipi", entity.MiktarTipi);
            prm.Add("@IslemTipi", entity.IslemTipi);
            prm.Add("@Aciklama", entity.Aciklama);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Save(List<Balance> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Balance entity)
        {
            throw new NotImplementedException();
        }

        public int Update(List<Balance> entity)
        {
            throw new NotImplementedException();
        }
    }
}
