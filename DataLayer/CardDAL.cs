using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Interfaces;
using Models;
namespace DataLayer
{
    public class CardDAL : ICRUDIslemleri<Card>
    {

        public int Delete(int id)
        {
            string sql = "spCardDelete";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@id", id);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);

        }

        public int Delete(Card entity)
        {
            throw new NotImplementedException();
        }

        public Card Find(int id)
        {
            throw new NotImplementedException();
        }

        public Card Find(Card entity)
        {
            string sql = "spFindCardNo";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@KartNo", entity.KartNo);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
            Card card = null;
            if (dt!=null && dt.Rows.Count>0)
            {
                card = new Card()
                {
                    Id = (int)dt.Rows[0]["Id"],
                    Durum = (byte)dt.Rows[0]["Durum"],
                    KayıtTarihi =(DateTime)dt.Rows[0]["KayıtTarihi"],
                    KaydedenKulId=(int)dt.Rows[0]["KaydedenKulId"],
                    DegistirenKulId=(int)dt.Rows[0]["DegistirenKulId"],
                    DegistirmeTarihi=(DateTime)dt.Rows[0]["DegistirmeTarihi"],
                    KartNo= dt.Rows[0]["KartNo"].ToString(),
                    KartTipi=(byte)dt.Rows[0]["KartTipi"]

                };
            }
            return card;

        }
        public Card FindCardNo(Card entity)
        {
            string sql = "spFindCardNoForUpdate";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@KartNo", entity.KartNo);
            prm.Add("@Id", entity.Id);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
            Card card = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                card = new Card()
                {
                    Id = (int)dt.Rows[0]["Id"],
                    Durum = (byte)dt.Rows[0]["Durum"],
                    KayıtTarihi = (DateTime)dt.Rows[0]["KayıtTarihi"],
                    KaydedenKulId = (int)dt.Rows[0]["KaydedenKulId"],
                    DegistirenKulId = (int)dt.Rows[0]["DegistirenKulId"],
                    DegistirmeTarihi = (DateTime)dt.Rows[0]["DegistirmeTarihi"],
                    KartNo = dt.Rows[0]["KartNo"].ToString(),
                    KartTipi = (byte)dt.Rows[0]["KartTipi"]

                };
            }
            return card;
        }
        public List<Card> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Card> ListAll(Card entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            string sql = "spCardList";
            return ADOVeritabaniIslemleri.SelectSorgusu(sql, null, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public DataTable ListAllDataTable(Card entity)
        {
            throw new NotImplementedException();
        }

        public int Save(Card entity)
        {
            string sql = "spCardSave";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", entity.Durum);
            prm.Add("@KayıtTarihi", entity.KayıtTarihi);
            prm.Add("@KaydedenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@KartNo", entity.KartNo);
            prm.Add("@KartTipi", entity.KartTipi);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);

        }

        public int Save(List<Card> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Card entity)
        {
            string sql = "spCardsUpdate";
            Dictionary<string, object> prm = new Dictionary<string, object>();

            prm.Add("@id", entity.Id);
            prm.Add("@Durum", entity.Durum);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@KartNo", entity.KartNo);
            prm.Add("@KartTipi", entity.KartTipi);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);

        }

        public int Update(List<Card> entity)
        {
            throw new NotImplementedException();
        }
    }
}
