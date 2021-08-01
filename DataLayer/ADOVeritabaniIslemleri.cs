using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Common;

namespace DataLayer
{
    //ADO.NET işlem yapısı

    /// <summary>
    /// ADO.NET işlemlerinde kullanılan class
    /// </summary>
    public class ADOVeritabaniIslemleri
    {
        //Bağlantı
        //Select sorgusu Metodu
        //Insert/UpDate/Delete Metodu

        //Connection String
        private static readonly string baglanti= ConfigurationManager.ConnectionStrings["SqlBaglanti"].ConnectionString;

        /// <summary>
        /// Sql Server Select sorguları için kullanılan metod
        /// </summary>
        /// <param name="sqlSorgusu">Sql Select Cümlesi</param>
        /// <returns></returns>
        public static DataTable SelectSorgusu(
            string sqlSorgusu, 
            Dictionary<string,object> prm=null,
            Enums.SqlServerKomutTipi komutTipi =Enums.SqlServerKomutTipi.SqlText
            )
        {
            DataTable dt = new DataTable();
            //Bağlantı tanımla (connection string)
            SqlConnection con = new SqlConnection(baglanti);
            //Bağnatıyı aç
            con.Open();
            //komut tanımla
            SqlCommand komut = new SqlCommand(sqlSorgusu, con);
            if(komutTipi==Enums.SqlServerKomutTipi.StoredProcedure)
            {
                komut.CommandType = CommandType.StoredProcedure;
            }
            if(prm!=null)
            {
                foreach (var item in prm)
                {
                    komut.Parameters.AddWithValue(item.Key, item.Value);
                }
            }
            //Datadaptörü tanımla
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //data adaptörü çalıştır ve sonucu dt yani datatable içine doldur
            da.Fill(dt);
            //bağlantıyı kapat
            con.Close();
            //datatable'ı yani dt'yi dön            
            return dt;
        }

        /// <summary>
        /// Sql Server INSERT, UPDATE, DELETE işlemleri için kullanılacak metod
        /// </summary>
        /// <param name="sqlSorgusu">Sql Sorgusu</param>
        /// <returns></returns>
        public static int InsertDeleteUpdateSorgusu(
            string sqlSorgusu, 
            Dictionary<string, object> prm = null,
            Enums.SqlServerKomutTipi komutTipi = Enums.SqlServerKomutTipi.SqlText
            )
        {
            int sonuc=0;
            //Bağlantı tanımla (connection string)
            SqlConnection con = new SqlConnection(baglanti);
            //Bağnatıyı aç
            con.Open();
            //Komutu tanımla
            SqlCommand komut = new SqlCommand(sqlSorgusu,con);
            if (komutTipi == Enums.SqlServerKomutTipi.StoredProcedure)
            {
                komut.CommandType = CommandType.StoredProcedure;
            }
            if (prm != null)
            {
                foreach (var item in prm)
                {
                    komut.Parameters.AddWithValue(item.Key, item.Value);
                }
            }
            //Komutu çalıştır
            sonuc = komut.ExecuteNonQuery();
            //bağlantıyı kapat
            con.Close();
            //sonucu dön
            return sonuc;
        }

    }
}
