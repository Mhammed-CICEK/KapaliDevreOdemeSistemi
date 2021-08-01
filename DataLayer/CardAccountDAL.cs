using Common;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CardAccountDAL : ICRUDIslemleri<CardAccount>
    {
        public int Delete(int id)
        {
            string sql = "spCardAcountDeletebyId";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", (byte)Enums.usersstate.Silinmiş);
            prm.Add("@Id", id);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Delete(CardAccount entity)
        {
            string sql = "spCardAcountDelete";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", (byte)Enums.usersstate.Silinmiş);
            prm.Add("@KardId", entity.KartId);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public CardAccount FindCardNo(string KartNo)
        {
            string sql = "select * from vwCardAccountList Where KartNo=@KartNo";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@KartNo", KartNo);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.SqlText);
            CardAccount card = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                card = new CardAccount()
                {
                    Id = (int)dt.Rows[0]["Id"],
                    KartId = (int)dt.Rows[0]["KardId"],
                    HesapAdi = dt.Rows[0]["HesapAdi"].ToString(),
                    HesapId = (int)dt.Rows[0]["MemberId"]
                };


            }
            return card;
        }
        public CardAccount Find(int id)
        {

            string sql = "select Id,KardId,HesapAdi from vwCardAccountList Where KardId=@KartId";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@KartId", id);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.SqlText);
            CardAccount card = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                card = new CardAccount()
                {
                    Id = (int)dt.Rows[0]["Id"],
                    KartId = (int)dt.Rows[0]["KardId"],
                    HesapAdi = dt.Rows[0]["HesapAdi"].ToString()
                };


            }
            return card;
        }


        public CardAccount Find(CardAccount entity)
        {
            string sql = "spFindKartNoinAccountforUpdate";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Id", entity.Id);
            prm.Add("@KartId", entity.KartId);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
            CardAccount card = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                card = new CardAccount()
                {
                    Id = (int)dt.Rows[0]["Id"],
                    Durum = (byte)dt.Rows[0]["Durum"],
                    KayıtTarihi = (DateTime)dt.Rows[0]["KayıtTarihi"],
                    KaydedenKulId = (int)dt.Rows[0]["KaydedenKulId"],
                    DegistirenKulId = (int)dt.Rows[0]["DegistirenKulId"],
                    DegistirmeTarihi = (DateTime)dt.Rows[0]["DegistirmeTarihi"],
                    KartId = (int)dt.Rows[0]["KardId"],
                };


            }
            return card;
        }
        public CardAccount FindforUpdate(CardAccount entity)
        {
            string sql = "spFindKartNoinAccount";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@KartId", entity.KartId);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
            CardAccount card = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                card = new CardAccount()
                {
                    Id = (int)dt.Rows[0]["Id"],
                    Durum = (byte)dt.Rows[0]["Durum"],
                    KayıtTarihi = (DateTime)dt.Rows[0]["KayıtTarihi"],
                    KaydedenKulId = (int)dt.Rows[0]["KaydedenKulId"],
                    DegistirenKulId = (int)dt.Rows[0]["DegistirenKulId"],
                    DegistirmeTarihi = (DateTime)dt.Rows[0]["DegistirmeTarihi"],
                    KartId = (int)dt.Rows[0]["KardId"],
                };


            }
            return card;
        }
        public List<CardAccount> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<CardAccount> ListAll(CardAccount entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {

            string sql = "Select * from vwCardAccountList";
            return ADOVeritabaniIslemleri.SelectSorgusu(sql, null, Enums.SqlServerKomutTipi.SqlText);
        }

        public DataTable ListAllDataTable(CardAccount entity)
        {
            throw new NotImplementedException();
        }

        public int Save(CardAccount entity)
        {

            string sql = "spCardAcountSave";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", entity.Durum);
            prm.Add("@KayıtTarihi", DateTime.Now);
            prm.Add("@KaydedenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@MemberId", entity.HesapId);
            prm.Add("@KardId", entity.KartId);
            prm.Add("@HesapTipi", entity.HesapTipi);
            prm.Add("@KartSifresi", entity.KartSifresi);
            prm.Add("@LimitiDurumu", entity.LimitiDurumu);
            prm.Add("@BaslangicTarihi", entity.BaslangicTarihi);
            prm.Add("@YenilemeAraligi", entity.YenilemeAraligi);
            prm.Add("@HarcamaLimiti", entity.HarcamaLimiti);
            prm.Add("@HesapAdi", entity.HesapAdi);
            prm.Add("@EksiBakiyeDurum", entity.EksiBakiyeDurumu);
            prm.Add("@EksiBakiye", entity.EksiBakiye);
            prm.Add("@BonusDurum", entity.BonusDurumu);
            prm.Add("@BonusOrani", entity.BonusOrani);

            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);

        }

        public int Save(List<CardAccount> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(CardAccount entity)
        {
            string sql = "spCardAcountUpdate";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", entity.Durum);
            prm.Add("@Id", entity.Id);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@MemberId", entity.HesapId);
            prm.Add("@KardId", entity.KartId);
            prm.Add("@HesapTipi", entity.HesapTipi);
            prm.Add("@KartSifresi", entity.KartSifresi);
            prm.Add("@LimitiDurumu", entity.LimitiDurumu);
            prm.Add("@BaslangicTarihi", entity.BaslangicTarihi);
            prm.Add("@YenilemeAraligi", entity.YenilemeAraligi);
            prm.Add("@HarcamaLimiti", entity.HarcamaLimiti);
            prm.Add("@HesapAdi", entity.HesapAdi);
            prm.Add("@EksiBakiyeDurum", entity.EksiBakiyeDurumu);
            prm.Add("@EksiBakiye", entity.EksiBakiye);
            prm.Add("@BonusDurum", entity.BonusDurumu);
            prm.Add("@BonusOrani", entity.BonusOrani);

            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Update(List<CardAccount> entity)
        {
            throw new NotImplementedException();
        }
    }
}
