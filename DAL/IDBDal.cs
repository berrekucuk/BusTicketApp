using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourTicketApp.DAL
{
    //Generic : Dışarıdan aldığı tipe göre davranabilir. Interface'imizi generic hale getirmiş olduk.
     interface IDBDal<T> where T : class
    {
        bool Add(T deger);
        bool Update(T deger);
        bool Delete(T deger);
        List<T> GetAll();
    }
}
