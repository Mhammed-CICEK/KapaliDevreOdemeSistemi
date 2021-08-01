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
    public class UsersDAL : ICRUDIslemleri<Users>
    {
        public int Delete(int id)
        {
            string sql = "spUsersDelete";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Id", id);
            prm.Add("@Durum", Enums.usersstate.Silinmiş);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        public Users Find(int id)
        {
            throw new NotImplementedException();
        }

        public Users Find(Users entity)
        {
            string sql = "Select * from Users Where KullaniciAdi=@KullaniciAdi";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@KullaniciAdi", entity.KullaniciAdi);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.SqlText);
            Users users = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                users = new Users()
                {
                    Id = (int)dt.Rows[0]["Id"],
                    KullaniciAdi = dt.Rows[0]["KullaniciAdi"].ToString()
                };


            }
            return users;
        }
        public Users FindforUpdate(Users entity)
        {
            string sql = "Select * from Users Where KullaniciAdi=@KullaniciAdi AND Id<>@Id";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@KullaniciAdi", entity.KullaniciAdi);
            prm.Add("@Id", entity.Id);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.SqlText);
            Users users = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                users = new Users()
                {
                    Id = (int)dt.Rows[0]["Id"],
                    KullaniciAdi = dt.Rows[0]["KullaniciAdi"].ToString()
                };


            }
            return users;
        }

        public List<Users> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Users> ListAll(Users entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            string sql = "select * from vwUsersList";
            return ADOVeritabaniIslemleri.SelectSorgusu(sql, null, Enums.SqlServerKomutTipi.SqlText);
        }

        public DataTable ListAllDataTable(Users entity)
        {
            throw new NotImplementedException();
        }
        public DataTable FindforLogin(string kullaniciAdi, string sifre)
        {
            string sql = "select * from vwUsersListforLogin Where KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@KullaniciAdi", kullaniciAdi);
            prm.Add("@Sifre", sifre);
            return ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.SqlText);
        }

        public int Save(Users entity)
        {
            string sql = "spUsersSave";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", entity.Durum);
            prm.Add("@KayitTarihi", DateTime.Now);
            prm.Add("@KaydedenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@YetkiGrubuId", entity.YetkiGrubuId);
            prm.Add("@KullaniciAdi", entity.KullaniciAdi);
            prm.Add("@Sifre", entity.Sifre);
            prm.Add("@Isim", entity.Isim);
            prm.Add("@Soyisim", entity.Soyisim);
            prm.Add("@Unvan", entity.Unvan);
            prm.Add("@Telefon", entity.Telefon);
            prm.Add("@Email", entity.Email);
            prm.Add("@Aciklama", entity.Aciklama);
            prm.Add("@Resim", entity.Resim);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Save(List<Users> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Users entity)
        {
            string sql = "spUsersUpdate";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Id", entity.Id);
            prm.Add("@Durum", entity.Durum);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@YetkiGrubuId", entity.YetkiGrubuId);
            prm.Add("@KullaniciAdi", entity.KullaniciAdi);
            prm.Add("@Sifre", entity.Sifre);
            prm.Add("@Isim", entity.Isim);
            prm.Add("@Soyisim", entity.Soyisim);
            prm.Add("@Unvan", entity.Unvan);
            prm.Add("@Telefon", entity.Telefon);
            prm.Add("@Email", entity.Email);
            prm.Add("@Aciklama", entity.Aciklama);
            prm.Add("@Resim", entity.Resim);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Update(List<Users> entity)
        {
            throw new NotImplementedException();
        }
    }
}
