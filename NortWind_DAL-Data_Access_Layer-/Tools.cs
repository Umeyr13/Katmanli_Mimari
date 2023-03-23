using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace NortWind_DAL_Data_Access_Layer_
{
    public class Tools
    {
        //direk erişim için static yaptık.
        private static SqlConnection _baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti1"].ConnectionString);
        /*****************  Referanslara ve projeye System.Configuration ekledik. Bağlantı metini oraya taşıdık buraya değişken adını yazdık           ********************/

        public static SqlConnection Baglanti //bağlantının başka class tan set edilmesine izin vermiyoruz.
            {//böylece bağlantı bizim belirlediğimiz üzere sabit kalıyor.
            get { return _baglanti; }

            set { }
            
            }

        public static bool ExecutenonQery(SqlCommand komut)
        {
            try
            {
                if (komut.Connection.State != System.Data.ConnectionState.Open)
                {
                    komut.Connection.Open();
                  int sonuc = komut.ExecuteNonQuery();
                    
                    return sonuc > 0 ? true : false;//SATIR doğru ise true değilse  false dön
                  
                }

                //Tools.Baglanti.Open();
                komut.Connection.Close();
                //Tools.Baglanti.Close();
                return false;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                if (komut.Connection.State == System.Data.ConnectionState.Open)
                {
                     komut.Connection.Close();

                }
            }
                     
        }

    }
}
