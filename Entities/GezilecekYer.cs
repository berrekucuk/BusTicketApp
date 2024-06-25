using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTicketApp.Entities
{
    public class GezilecekYer:Base
    {
        public string YerAdi { get; set; }

        public override string ToString()
        {
            return YerAdi.ToUpper();
        }
    }
}
