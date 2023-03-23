using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NortWind_DAL_Data_Access_Layer_.Entities;

namespace NortWind_DAL_Data_Access_Layer_
{
    public class Kategoriler
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("KategoriListesi",Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
           
        }

        public static bool Ekle(Kategori ktg)
        {
            SqlCommand komut = new SqlCommand("KateoriEkle",Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@kategori",ktg.KategoriAdi);
            komut.Parameters.AddWithValue("@tanim",ktg.Tanim);
            DataTable dt = new DataTable();
            
            return Tools.ExecutenonQery(komut);
        }


    }
}
