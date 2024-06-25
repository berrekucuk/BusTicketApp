using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTicketApp.Entities;

namespace TourTicketApp.DAL
{
    public class GuzergahDal : IDBDal<Guzergah>
    {
        public static List<Guzergah> GuzergahListesi { get; set; } = new();
        public bool Add(Guzergah deger)
        {
            var bulunan = GuzergahListesi.FirstOrDefault(g => g.GuzergahAdi == deger.GuzergahAdi);

            if (bulunan == null)
            {
                GuzergahListesi.Add(deger);
                return true;
            }
            return false;    
        }

        public bool Delete(Guzergah deger)
        {
           GuzergahListesi.Remove(deger);
            return true;
        }

        public List<Guzergah> GetAll()
        {
            return GuzergahListesi; 
        }

        public bool Update(Guzergah deger)
        {
            var bulunan = GuzergahListesi.FirstOrDefault(g => g.ID == deger.ID);

            if(bulunan != null)
            {
                bulunan.Kalkis = deger.Kalkis;
                bulunan.Varis = deger.Varis;
                return true;
            } 
            return false;
        }

        public bool GuzergahaYerEkle(Guzergah g, GezilecekYer y)
        {
            g.GezilecekYerler.Add(y);
            return true;
        }

        public List<GezilecekYer> GuzergahtakiYerler(Guzergah g)
        {
            var guzergah = GuzergahListesi.FirstOrDefault(x=> x.Kalkis == g.Kalkis && x.Varis == g.Varis);

            if(guzergah != null)
            {
                return guzergah.GezilecekYerler;
            }
            else
            {
                return null;
            }
        }
    }
}
