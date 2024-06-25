using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTicketApp.Entities;

namespace TourTicketApp.DAL
{
    public class OtobusDal : IDBDal<Otobus>
    {
        public static List<Otobus> OtobusListesi { get; set; } = new(); // !!!!! Static de olsa bir kere newlemek gerekiyor.
        public bool Add(Otobus deger)
        {
            var varmi = OtobusListesi.FirstOrDefault(o=> o.Plaka == deger.Plaka);

            if(varmi== null)
            {
                OtobusListesi.Add(deger);   
                return true;
            }
            return false;
        }

        public bool Delete(Otobus deger)
        {
            OtobusListesi.Remove(deger);
            return true;
        }

        public List<Otobus> GetAll()
        {
           return OtobusListesi;
        }

        public bool Update(Otobus deger)
        {
           var otobus = OtobusListesi.FirstOrDefault(x=> x.ID == deger.ID);

            if(otobus != null)
            {
                otobus.OtobusTipi = deger.OtobusTipi;
                otobus.Wifi = deger.Wifi;
                otobus.KoltukSayisi = deger.KoltukSayisi;
                otobus.Plaka = deger.Plaka;
                otobus.Firma = deger.Firma;
                return true;
            }
            return false;
        }

        public bool FirmayaOtobusAta(Firma f, Otobus o)
        {
            f.Otobusler.Add(o);
            return true;
        }
    }
}
