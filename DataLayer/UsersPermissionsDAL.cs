using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataLayer;
using Interfaces;
using System.Data;
using Common;

namespace DataLayer
{
    public class UsersPermissionsDAL : ICRUDIslemleri<UserPermissions>
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(UserPermissions entity)
        {
            throw new NotImplementedException();
        }

        public UserPermissions Find(int id)
        {
            UserPermissions ug = null;
            string sql = "select * from vwUsersPermission Where YetkiGrubuId=@YetkiGrubuId";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@YetkiGrubuId", id);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.SqlText);
            if (dt != null && dt.Rows.Count > 0)
            {
                ug = new UserPermissions()
                {
                    Id = (int)dt.Rows[0]["PermissionGruopId"],
                    Durum = (byte)dt.Rows[0]["Durum"],
                    KayıtTarihi= (DateTime)dt.Rows[0]["KayitTarihi"],
                    KaydedenKulId= (int)dt.Rows[0]["KaydedenKulId"],
                    DegistirenKulId= (int)dt.Rows[0]["DegistirenKulId"],
                    DegistirmeTarihi = (DateTime)dt.Rows[0]["DegistirmeTarihi"],
                    YetkiKodu=dt.Rows[0]["YetkiKodu"].ToString()
                };


            }
            return ug;
        }

        public UserPermissions Find(UserPermissions entity)
        {
            throw new NotImplementedException();
        }

        public List<UserPermissions> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<UserPermissions> ListAll(UserPermissions entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable(UserPermissions entity)
        {
            throw new NotImplementedException();
        }

        public int Save(UserPermissions entity)
        {
            string sql = "spUserPermissionsSave";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", entity.Durum);
            prm.Add("@KayitTarihi", DateTime.Now);
            prm.Add("@KaydedenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@YetkiGrubuId", entity.YetkiGrubuId);
            prm.Add("@YetkiKodu", entity.YetkiKodu);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Save(List<UserPermissions> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(UserPermissions entity)
        {
            string sql = "spUserPermissionsUpdate";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", entity.Durum);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@YetkiGrubuId", entity.YetkiGrubuId);
            prm.Add("@YetkiKodu", entity.YetkiKodu);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Update(List<UserPermissions> entity)
        {
            throw new NotImplementedException();
        }
    }
}
