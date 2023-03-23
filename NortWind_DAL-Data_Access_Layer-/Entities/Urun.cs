using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NortWind_DAL_Data_Access_Layer_.Entities
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int TedarikciID { get; set; }
        public int KategoriID { get; set; }
        public string BirimdekiMiktar { get; set; }
        public decimal BirimFiyati { get; set; }
        public short HedefStokDüzeyi { get; set; }
        public short YeniSatis { get; set; }
        public short EnAzYenidenSatisMiktari { get; set; }
        public bool Sonlandi { get; set; }


    }
}
