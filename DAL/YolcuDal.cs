using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTicketApp.Entities;

namespace TourTicketApp.DAL
{
    public class YolcuDal : IDBDal<Yolcu>
    {
        public static List<Yolcu> YolcuListesi { get; set; } = new();
        public bool Add(Yolcu deger)
        {
            var bulunan = YolcuListesi.FirstOrDefault(x => x.TCKimlikNo == deger.TCKimlikNo);

            if(bulunan == null)
            {
                YolcuListesi.Add(deger);
                return true;
            }
            return false;
        }

        public bool Delete(Yolcu deger)
        {
            YolcuListesi.Remove(deger);
            return true;
        }

        public List<Yolcu> GetAll()
        {
            return YolcuListesi;
        }

        public bool Update(Yolcu deger)
        {
            var yolcu = YolcuListesi.FirstOrDefault(x => x.TCKimlikNo == deger.TCKimlikNo);

            if(yolcu != null)
            {
                yolcu.BagajVarMi = deger.BagajVarMi;
                yolcu.TCKimlikNo = deger.TCKimlikNo;
                yolcu.AdSoyad = deger.AdSoyad;
                yolcu.Cinsiyet = deger.Cinsiyet;
                yolcu.Telefon = deger.Telefon;
                yolcu.Biletler = deger.Biletler;
                return true;
            }
            return false;
        }
    }
}
