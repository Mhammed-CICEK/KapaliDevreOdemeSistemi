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
    public class ProductDAL : ICRUDIslemleri<Product>
    {
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public int Delete(Product entity)
        {

            string sql = "spProductDelete";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Id", entity.Id);
            prm.Add("@Durum", Enums.usersstate.Silinmiş);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public Product Find(int id)
        {
            throw new NotImplementedException();
        }

        public Product Find(Product entity)
        {

            string sql = "select UrunAdi,SatisFiyati,id,Barkod,Resim,Id from vwProductList Where Barkod=@Barkod";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Barkod", entity.Barkod);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.SqlText);
            Product product = null;
            if (dt != null && dt.Rows.Count > 0)
            {
                product = new Product()
                {
                    UrunAdi = dt.Rows[0]["UrunAdi"].ToString(),
                    Id = (int)dt.Rows[0]["id"],
                    Barkod=dt.Rows[0]["Barkod"].ToString(),
                    SatisFiyati=Convert.ToInt64(dt.Rows[0]["SatisFiyati"]),
                    Resim=(byte[])dt.Rows[0]["Resim"]
                };


            }
            return product;
        }

        public List<Product> ListAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> ListAll(Product entity)
        {
            throw new NotImplementedException();
        }

        public DataTable ListAllDataTable()
        {
            string sql = "select * from vwProductList";
            return ADOVeritabaniIslemleri.SelectSorgusu(sql, null, Enums.SqlServerKomutTipi.SqlText);
        }

        public DataTable ListAllDataTable(Product entity)
        {

            string sql = "select UrunAdi,SatisFiyati,id,Barkod from vwProductList Where Barkod=@Barkod";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Barkod", entity.Barkod);
            DataTable dt = ADOVeritabaniIslemleri.SelectSorgusu(sql, prm, Enums.SqlServerKomutTipi.SqlText);
            
            return dt;
        }

        public int Save(Product entity)
        {
            string sql = "spPrudoctSave";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Durum", entity.Durum);
            prm.Add("@KayitTarihi", DateTime.Now);
            prm.Add("@KaydedenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@Barkod", entity.Barkod);
            prm.Add("@UrunAdi", entity.UrunAdi);
            prm.Add("@UrunIcerigi", entity.UrunIcerigi);
            prm.Add("@StokGrupId", entity.StokGrupId);
            prm.Add("@IslemTuru", entity.IslemTuru);
            prm.Add("@Birim", entity.Birim);
            prm.Add("@DepoId", entity.DepoId);
            prm.Add("@KDV", entity.Kdv);
            prm.Add("@AlisFiyati", entity.AlisFiyati);
            prm.Add("@SatisFiyati", entity.SatisFiyati);
            prm.Add("@ToplamAdet", entity.Adet);
            prm.Add("@StokUyariAdedi", entity.StokUyariAdedi);
            prm.Add("@Resim", entity.Resim);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);

        }

        public int Save(List<Product> entity)
        {
            throw new NotImplementedException();
        }

        public int Update(Product entity)
        {
            string sql = "spPrudoctUpdate";
            Dictionary<string, object> prm = new Dictionary<string, object>();
            prm.Add("@Id", entity.Id);
            prm.Add("@Durum", entity.Durum);
            prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
            prm.Add("@DegistirmeTarihi", DateTime.Now);
            prm.Add("@Barkod", entity.Barkod);
            prm.Add("@UrunAdi", entity.UrunAdi);
            prm.Add("@UrunIcerigi", entity.UrunIcerigi);
            prm.Add("@StokGrupId", entity.StokGrupId);
            prm.Add("@IslemTuru", entity.IslemTuru);
            prm.Add("@Birim", entity.Birim);
            prm.Add("@DepoId", entity.DepoId);
            prm.Add("@KDV", entity.Kdv);
            prm.Add("@AlisFiyati", entity.AlisFiyati);
            prm.Add("@SatisFiyati", entity.SatisFiyati);
            prm.Add("@ToplamAdet", entity.ToplamAdet + entity.Adet);
            prm.Add("@StokUyariAdedi", entity.StokUyariAdedi);
            prm.Add("@Resim", entity.Resim);
            return ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
        }

        public int Update(List<Product> entity)
        {
            int updateSayisi = 0;
            foreach (var item in entity)
            {

                string sql = "spPrudoctUpdateforSale";
                Dictionary<string, object> prm = new Dictionary<string, object>();
                prm.Add("@Id", item.Id);
                prm.Add("@DegistirenKulId", SessionsData.GirisYapanKullaniciId);
                prm.Add("@DegistirmeTarihi", DateTime.Now);
                prm.Add("@ToplamAdet", item.ToplamAdet - item.Adet);

                updateSayisi++;
                ADOVeritabaniIslemleri.InsertDeleteUpdateSorgusu(sql, prm, Enums.SqlServerKomutTipi.StoredProcedure);
            }
            return updateSayisi;
        }
    }
}
