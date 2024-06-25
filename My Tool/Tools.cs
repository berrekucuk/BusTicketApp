using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourTicketApp.DAL;
using TourTicketApp.Entities;

namespace TourTicketApp.My_Tool
{
    public static class Tools
    {
        public static string[] TurkiyeIlleri = 
        {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Isparta",
            "Mersin",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"
        };

        public static void VerileriGetir()
        {
            Firma f = new Firma()
            {
                Ad = "Techsist Turizm A.Ş.",
                Telefon = "5067893467"
            };

            Otobus o1 = new Otobus()
            {
                Firma=f,
                KoltukSayisi = 45,
                OtobusTipi=OtobusTipi.İkiartıİki,
                Plaka = "34GZF345",
                Wifi=true
            };

            Otobus o2 = new Otobus()
            {
                Firma = f,
                KoltukSayisi = 45,
                OtobusTipi = OtobusTipi.İkiartıİki,
                Plaka = "34ABC457",
                Wifi = true
            };

            f.Otobusler = [o1,o2];
            OtobusDal.OtobusListesi = [o1, o2];

            FirmaDal.FirmaListesi.Add(f);

            Yolcu y1 = new Yolcu("23345678556", "Ayşe Yılmaz")
            {
                BagajVarMi = true,
                Cinsiyet =Cinsiyet.Kadın,
                Telefon = "5068976677"
            };
            Yolcu y2 = new Yolcu("56689675334", "Caner Tekin")
            {
                BagajVarMi = true,
                Cinsiyet = Cinsiyet.Erkek,
                Telefon = "5068976677"
            };

            YolcuDal.YolcuListesi = [y1, y2];

            Guzergah g = new Guzergah()
            {
                Kalkis="İstanbul",
                Varis="Ankara",
                GezilecekYerler= new List<GezilecekYer>()
                {
                    new GezilecekYer(){YerAdi = "Kebapçı Mustafa"},
                    new GezilecekYer(){YerAdi =  "Anıtkabir"}
                }
            };

            GuzergahDal.GuzergahListesi= [g];
        }

    }
}
