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
    public class PermissionsGroupDAL : ICRUDIslemleri<PermissionsGroup>
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(PermissionsGroup entity)
        {
            throw new NotImplementedException();
        }

        public PermissionsGroup Find(int id)
        {
            throw new NotImplementedException();
        }

        public PermissionsGroup Find(PermissionsGroup entity)
        {
            PermissionsGroup pg = null;
            string sql = "select PermissionGruopId,GrupAdi from PermisionGroup Where GrupAdi=@GrupAdi";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@GrupAdi", entity.GrupAdi);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.SqlText);
            if (dt != null && dt.Rows.Count > 0)
            {
                pg = new PermissionsGroup()
                {
                    Id = (int)dt.Rows[0]["PermissionGruopId"],
                    GrupAdi= dt.Rows[0]["GrupAdi"].ToString()
                };


            }
            return pg;
        }

        public List<PermissionsGroup> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<PermissionsGroup> ListAll(PermissionsGroup entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable(PermissionsGroup entity)
        {
            throw new NotImplementedException();
        }

        public int Save(PermissionsGroup entity)
        {

            string sql = "spPermissionsGoupSave";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", entity.Durum);
            prm.Add("@KayitTarihi", DateTime.Now);
            prm.Add("@KaydedenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@GrupAdi", entity.GrupAdi);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Save(List<PermissionsGroup> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(PermissionsGroup entity)
        {
            throw new NotImplementedException();
        }

        public int Update(List<PermissionsGroup> entity)
        {
            throw new NotImplementedException();
        }
    }
}
