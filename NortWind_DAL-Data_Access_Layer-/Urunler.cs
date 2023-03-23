using NortWind_DAL_Data_Access_Layer_.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortWind_DAL_Data_Access_Layer_
{
    public class Urunler
    {
        public static DataTable listele()
        {

            SqlDataAdapter adp = new SqlDataAdapter("UrunGetir",Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);  // dt ye veriyi doldur.
            return dt;    // Dolu tabloyu gönderiyor.
            
        }

        public static bool UrunEkle(Urun urn)
        {
            SqlCommand komut = new SqlCommand("UrunEkle",Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@urunadi",urn.UrunAdi);
            komut.Parameters.AddWithValue("@birimFiyat", urn.BirimFiyati);
            komut.Parameters.AddWithValue("@HedefStokdüzeyi", urn.HedefStokDüzeyi);
            komut.Parameters.AddWithValue("@katId",urn.KategoriID);
            komut.Parameters.AddWithValue("@tedId",urn.TedarikciID);
            
            return Tools.ExecutenonQery(komut);
            /*  Tools.Baglanti.Open();
            komut.ExecuteNonQuery();
            Tools.Baglanti.Close();*/
        }
        public static bool UrunSil(int id)
        {
            SqlCommand komut = new SqlCommand("UrunSil",Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure ;
            komut.Parameters.AddWithValue("@urunid",id);

            return Tools.ExecutenonQery(komut);
        }

        public static bool  UrunGuncelle(int id)
        {
            return true;
        }
    }
}
