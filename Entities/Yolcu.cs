using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTicketApp.Entities
{
    public class Yolcu(string tc, string adsoyad) : Base // TC, Ad,Soyad olmadan yolcu oluşturulmaması için primary costructor oluşturuyoruz
    {
        public string TCKimlikNo { get; set; } = tc;
        public string AdSoyad { get; set; } = adsoyad;        
        public bool BagajVarMi { get; set; }
        public string Telefon { get; set; }
        public Cinsiyet Cinsiyet { get; set; }

        public List<Bilet> Biletler { get; set; }

        public override string ToString()
        {
            return $"{TCKimlikNo} - {AdSoyad}";
        }
    }
}
