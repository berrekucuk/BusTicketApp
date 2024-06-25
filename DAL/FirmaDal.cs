using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TourTicketApp.Entities;

namespace TourTicketApp.DAL
{
    public class FirmaDal:IDBDal<Firma>
    {
        //public FirmaDal()  // !!!!! Static de olsa bir kere newlemek gerekiyor. Buradaki 'new'leme ile aşağıdaki 'new'leme aynıdır.
        //{
        //    FirmaListesi = new();
        //}

        /// <summary>
        /// C#'da Static anahtar kelimesi bir sınıfın üyesinin(alan,metot,özellik) nesneye değil, sınıfa ait olduğunu belirtmek için kullanılır. Bu belirli bir sınıfa özgü olan öğelerin herhangi bir nesne oluşturmadan ('new'lemeden, instance almadan) erişilebileceği anlamına gelir.
        /// </summary>
        public static List<Firma> FirmaListesi { get; set; } = new();

        public bool Add(Firma firma)
        {
            // Firma ismi eğer listede varsa ekleme yapmayalım.

            var bulunan = FirmaListesi.FirstOrDefault(x=> x.Ad == firma.Ad);

            if(bulunan == null)
            {
                FirmaListesi.Add(firma);
                return true;
            }
            return false;
        }

        public bool Update(Firma firma)
        {
            //Burada firmadeğişkeni form üzerinden buraya gönderilmiştir.Dolayısı ile bu nesne üzerinde yeni değerleri tutmaktadır.
            // Şimdi biz list içerisinde bulunan nesneyi bularak ilgili tüm alanlarını yeni değerlerle değiştireceğiz.

            var bulunan = FirmaListesi.FirstOrDefault(f=> f.ID == firma.ID);

            if(bulunan != null) //Bulduysa - Güncelle
            {
                bulunan.Ad = firma.Ad;
                bulunan.Telefon = firma.Telefon;
                return true;
            }
            return false;
        }

        public bool Delete(Firma silinecekFirma)
        {
            FirmaListesi.Remove(silinecekFirma);
            return true;
        }

        public List<Firma> GetAll()
        {
            return FirmaListesi;
        }

        public List<Firma> SecilenTipteOtobusuOlanFirmalariDon(OtobusTipi secilenTip)
        {
            #region BirinciYontem
            //List<Firma> secilenler = new List<Firma>();
            //if (FirmaListesi != null) 
            //{
            //    foreach (var firma in FirmaListesi)  //Önce tek tek firmalara bakıyoruz.
            //    {
            //        foreach (var otobus in firma.Otobusler) // Daha  sonra sıradaki firmanın otobüslerinitek tek kontrol ediyoruz.
            //        {
            //            if (otobus.OtobusTipi == secilenTip)
            //            {
            //                secilenler.Add(firma);
            //            }
            //        }
            //    }
            //}
            //return secilenler;

            #endregion

            #region IkinciYontem

            if(FirmaListesi != null)
            {
                List<Firma> secilenFirmalar = FirmaListesi.Where(firma => firma.Otobusler.Any(otobus=> otobus.OtobusTipi == secilenTip)).ToList();
                //Geriye list firma döneceğiz, firmaListesi'nde dön bize öyle firmalar bulki (firma öyleki(=>)) bu firmaların otobuslerinin şöyle özellikleri olsun (any kısmı)

                // Where fonksiyonu, belirli bir koşulu sağlayan öğeleri filtrelemek için kullanılırken,
                // Any fonksiyonu, herhangi bir öğenin belirli bir koşulu sağlayıp  sağlamadığını kontrol eder.

                return secilenFirmalar;            
            }
            else
            {
                return null;
            }
            

            // var otobusler = OtobusDal.OtobusListesi.Where(o=>o.OtobusTipi == secilenTip).ToList(); // Tek bişeye ait özellikleri aradığımızda bu şekilde yazılabilir.
            #endregion

        }

        public List<Otobus> FirmanınIstenenTiptekiOtobusListesi(Firma f, OtobusTipi tip)
        {
            var otobusListesi = f.Otobusler.Where(x => x.OtobusTipi == tip).ToList();
            return otobusListesi;
        } 


    }
}
