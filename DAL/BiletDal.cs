using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTicketApp.Entities;

namespace TourTicketApp.DAL
{    
    public class BiletDal : IDBDal<Bilet>
    {
        public static List<Bilet> BiletListesi { get; set; } = new();
        public bool Add(Bilet deger)
        {
            //Aynı tarihte yolcuya ait başa bir bilet var mı kontrol ediyoruz.
            var bilet = BiletListesi.FirstOrDefault(x => x.Yolcu == deger.Yolcu && x.KalkisZamani == deger.KalkisZamani);

            if(bilet == null) // Yoksa yeni bilet almasına izin veriyoruz.
            {
                BiletListesi.Add(deger);
                return true;
            }
            return false;
        }

        public bool Delete(Bilet deger)
        {
            return true;
        }

        public List<Bilet> GetAll()
        {
            return BiletListesi;
        }

        public bool Update(Bilet deger)
        {
            return true;
        }
    }
}
