using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTicketApp.Entities
{
    public class Firma : Base
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public List<Otobus> Otobusler { get; set; } = new(); // Firmanın otobüsleri olacağı için bir otobüs sınıfına bağlı bir lis oluşturuldu.

        // Otobüse ait olan biletler burada olacak.

        public override string ToString()
        {
            return $"{Ad}";
        }
    }  
}
