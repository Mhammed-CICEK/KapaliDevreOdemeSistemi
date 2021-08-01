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
    public class StockGroupDAL : ICRUDIslemleri<StockGroup>
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(StockGroup entity)
        {
            string sql = "spStockGroupDelete";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", Enums.usersstate.Silinmiş);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@Id", entity.Id);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public StockGroup Find(int id)
        {
            throw new NotImplementedException();
        }

        public StockGroup Find(StockGroup entity)
        {
            throw new NotImplementedException();
        }

        public List<StockGroup> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<StockGroup> ListAll(StockGroup entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            string sql = "select * from vwStokGroupList";
            return ADOVeritabaniIslemleri.SelectSorgusu(sql, null, Enums.SqlServerKomutTipi.SqlText);

        }

        public DataTable ListAllDataTable(StockGroup entity)
        {
            throw new NotImplementedException();
        }

        public int Save(StockGroup entity)
        {
            string sql = "spStockGroupSave";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", Enums.usersstate.Aktif);
            prm.Add("@KayıtTarihi", DateTime.Now);
            prm.Add("@KaydedenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@StockAdi", entity.StokName);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);

        }

        public int Save(List<StockGroup> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(StockGroup entity)
        {
            string sql = "spStockGroupUpdate";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@StockAdi", entity.StokName);
            prm.Add("@Id", entity.Id);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Update(List<StockGroup> entity)
        {
            throw new NotImplementedException();
        }
    }
}
