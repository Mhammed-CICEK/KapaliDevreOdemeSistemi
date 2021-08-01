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
    public class SalesDAL : ICRUDIslemleri<Sales>
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(Sales entity)
        {
            throw new NotImplementedException();
        }

        public Sales Find(int id)
        {
            throw new NotImplementedException();
        }

        public Sales Find(Sales entity)
        {
            throw new NotImplementedException();
        }

        public List<Sales> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Sales> ListAll(Sales entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable(Sales entity)
        {
            throw new NotImplementedException();
        }

        public int Save(Sales entity)
        {
            throw new NotImplementedException();
        }

        public int Save(List<Sales> entity)
        {
            string sql = "spSalesSave";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            int kayitAdedi = 0;
            foreach (var item in entity)
            {
                prm.Clear();
                prm.Add("@Durum", Enums.usersstate.Aktif);
                prm.Add("@KayitTarihi", DateTime.Now);
                prm.Add("@KaydedenKulId", SessionsData.GirisYapanKullaniciId);
                prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
                prm.Add("@DegistirmeTarihi", DateTime.Now);
                prm.Add("@UrunId", item.UrunId);
                prm.Add("@AccountId", item.AccountId);
                prm.Add("@KartId", item.KartId);
                prm.Add("@Adet", item.Adet);
                prm.Add("@SatisFiyati", item.SatisFiyati);
                prm.Add("@ToplamTutar", item.ToplamTutar);
                kayitAdedi++;
                ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
            }
            return kayitAdedi;
        }

        public int Update(Sales entity)
        {
            throw new NotImplementedException();
        }

        public int Update(List<Sales> entity)
        {
            throw new NotImplementedException();
        }
    }
}
