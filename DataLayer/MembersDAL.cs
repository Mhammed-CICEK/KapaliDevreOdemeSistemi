using Common;
using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataLayer
{
    public class MembersDAL : ICRUDIslemleri<Members>
    {
        public int Delete(int id)
        {
            string sql = "spMembersDelete";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@id", id);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Delete(Members entity)
        {
            throw new NotImplementedException();
        }

        public Members Find(int id)
        {
            Members members = null;
            string sql = "select * from vwMembersList where id=@Id";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Id", id);

            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.SqlText);
            if (dt != null && dt.Rows.Count > 0)
            {
                members = new Members()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["id"]),
                    Isim = dt.Rows[0]["Isim"].ToString(),
                    Soyisim = dt.Rows[0]["Soyisim"].ToString(),
                    KimlikNo = Convert.ToInt64(dt.Rows[0]["KimlikNo"]),
                    DogumYeri = dt.Rows[0]["DogumYeri"].ToString(),
                    DogumTarihi = Convert.ToDateTime(dt.Rows[0]["DogumTarihi"]),
                    EvTel = Convert.ToInt64(dt.Rows[0]["EvTel"]),
                    Gsm = Convert.ToInt64(dt.Rows[0]["Gsm"]),
                    Eposta = dt.Rows[0]["Eposta"].ToString(),
                    Sifre = dt.Rows[0]["Sifre"].ToString(),
                    Meslek = dt.Rows[0]["Meslek"].ToString(),
                    Ulke = dt.Rows[0]["Ulke"].ToString(),
                    Sehir = dt.Rows[0]["Sehir"].ToString(),
                    IkametAdresi = dt.Rows[0]["IkametAdresi"].ToString(),
                    UyelikTarihi = Convert.ToDateTime(dt.Rows[0]["UyelikTarihi"]),
                    UyelikBitisTarihi = Convert.ToDateTime(dt.Rows[0]["UyelikBitisTarihi"])
                };
            }
            return members;
        }

        public DataTable FindTcNo(long tcKimlikNo)
        {
            throw new NotImplementedException();
        }
        public Members Find(Members entity)
        {
            Members members = null;
            string sql = "spMembersTcKimlikKontrol";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@KimlikNo", entity.KimlikNo);

            DataTable dt= ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
            if (dt!=null && dt.Rows.Count>0)
            {
                members = new Members()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["id"]),
                    Isim = dt.Rows[0]["Isim"].ToString(),
                    Soyisim = dt.Rows[0]["Soyisim"].ToString(),
                    KimlikNo = Convert.ToInt64(dt.Rows[0]["KimlikNo"]),
                    DogumYeri = dt.Rows[0]["DogumYeri"].ToString(),
                    DogumTarihi = Convert.ToDateTime(dt.Rows[0]["DogumTarihi"]),
                    EvTel = Convert.ToInt64(dt.Rows[0]["EvTel"]),
                    Gsm = Convert.ToInt64(dt.Rows[0]["Gsm"]),
                    Eposta = dt.Rows[0]["Eposta"].ToString(),
                    Sifre = dt.Rows[0]["Sifre"].ToString(),
                    Meslek = dt.Rows[0]["Meslek"].ToString(),
                    Ulke = dt.Rows[0]["Ulke"].ToString(),
                    Sehir = dt.Rows[0]["Sehir"].ToString(),
                    IkametAdresi = dt.Rows[0]["IkametAdresi"].ToString(),
                    UyelikTarihi = Convert.ToDateTime(dt.Rows[0]["UyelikTarihi"]),
                    UyelikBitisTarihi = Convert.ToDateTime(dt.Rows[0]["UyelikBitisTarihi"])
                };
            }
            return members;
        }
        public Members FindTcNo(Members entity)
        {
            Members members = null;
            string sql = "spMembersTcKimlikKontrolforUpdate";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@id", entity.Id); 
            prm.Add("@KimlikNo", entity.KimlikNo);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
            if (dt != null && dt.Rows.Count > 0)
            {
                members = new Members()
                {
                    Id = Convert.ToInt32(dt.Rows[0]["id"]),
                    Isim = dt.Rows[0]["Isim"].ToString(),
                    Soyisim = dt.Rows[0]["Soyisim"].ToString(),
                    KimlikNo = Convert.ToInt64(dt.Rows[0]["KimlikNo"]),
                    DogumYeri = dt.Rows[0]["DogumYeri"].ToString(),
                    DogumTarihi = Convert.ToDateTime(dt.Rows[0]["DogumTarihi"]),
                    EvTel = Convert.ToInt64(dt.Rows[0]["EvTel"]),
                    Gsm = Convert.ToInt64(dt.Rows[0]["Gsm"]),
                    Eposta = dt.Rows[0]["Eposta"].ToString(),
                    Sifre = dt.Rows[0]["Sifre"].ToString(),
                    Meslek = dt.Rows[0]["Meslek"].ToString(),
                    Ulke = dt.Rows[0]["Ulke"].ToString(),
                    Sehir = dt.Rows[0]["Sehir"].ToString(),
                    IkametAdresi = dt.Rows[0]["IkametAdresi"].ToString(),
                    UyelikTarihi = Convert.ToDateTime(dt.Rows[0]["UyelikTarihi"]),
                    UyelikBitisTarihi = Convert.ToDateTime(dt.Rows[0]["UyelikBitisTarihi"])
                };
            }
            return members;
           }

        public List<Members> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Members> ListAll(Members entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            string sql = "select * from vwMembersList";
            return ADOVeritabaniIslemleri.SelectSorgusu(sql, null, Enums.SqlServerKomutTipi.SqlText);
        }

        public DataTable ListAllDataTable(Members entity)
        {
            throw new NotImplementedException();
        }

        public int Save(Members entity)
        {

            string sql = "spMembersSave";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", entity.Durum);
            prm.Add("@KayıtTarihi", entity.KayıtTarihi);
            prm.Add("@KaydedenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@Isim", entity.Isim);
            prm.Add("@Soyisim", entity.Soyisim);
            prm.Add("@KimlikNo", entity.KimlikNo);
            prm.Add("@DogumYeri", entity.DogumYeri);
            prm.Add("@DogumTarihi", entity.DogumTarihi);
            prm.Add("@EvTel", entity.EvTel);
            prm.Add("@Gsm", entity.Gsm);
            prm.Add("@Eposta", entity.Eposta);
            prm.Add("@Sifre", entity.Sifre);
            prm.Add("@Meslek", entity.Meslek);
            prm.Add("@Ulke", entity.Ulke);
            prm.Add("@Sehir", entity.Sehir);
            prm.Add("@IkametAdresi", entity.IkametAdresi);
            prm.Add("@UyelikTarihi", entity.UyelikTarihi);
            prm.Add("@UyelikBitisTarihi", entity.UyelikBitisTarihi);
            prm.Add("@Resim", entity.Resim);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Save(List<Members> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Members entity)
        {
            string sql = "spMembersUpdate";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", entity.Durum);
            prm.Add("@id", entity.Id);
            prm.Add("@KayıtTarihi", entity.KayıtTarihi);
            prm.Add("@KaydedenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@Isim", entity.Isim);
            prm.Add("@Soyisim", entity.Soyisim);
            prm.Add("@KimlikNo", entity.KimlikNo);
            prm.Add("@DogumYeri", entity.DogumYeri);
            prm.Add("@DogumTarihi", entity.DogumTarihi);
            prm.Add("@EvTel", entity.EvTel);
            prm.Add("@Gsm", entity.Gsm);
            prm.Add("@Eposta", entity.Eposta);
            prm.Add("@Sifre", entity.Sifre);
            prm.Add("@Meslek", entity.Meslek);
            prm.Add("@Ulke", entity.Ulke);
            prm.Add("@Sehir", entity.Sehir);
            prm.Add("@IkametAdresi", entity.IkametAdresi);
            prm.Add("@UyelikTarihi", entity.UyelikTarihi);
            prm.Add("@UyelikBitisTarihi", entity.UyelikBitisTarihi);
            prm.Add("@Resim", entity.Resim);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Update(List<Members> entity)
        {
            throw new NotImplementedException();
        }
    }
}
