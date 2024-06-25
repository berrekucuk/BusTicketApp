using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTicketApp.Entities
{
    public class Otobus:Base
    {
        public string Plaka { get; set; }
        public int KoltukSayisi { get; set; }
        public bool Wifi { get; set; }
        public Firma Firma { get; set; }
        public OtobusTipi OtobusTipi { get; set; }

        public override string ToString()
        {
            return $"{Plaka} - {Firma.Ad} - {KoltukSayisi}";
        }

    }
}
