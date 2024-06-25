using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTicketApp.Entities
{
    public abstract class Base
    {
        //Bu sınıfın code tarafında instance alınamaması için (yani new'lenmemesi için) abstract olarak işaretledik.
        public string ID { get; } = Guid.NewGuid().ToString();

    }
}
