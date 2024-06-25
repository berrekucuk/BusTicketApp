namespace TourTicketApp.Entities
{
    public class Guzergah:Base
    {
        public string Kalkis { get; set; }
        public string Varis { get; set; }
        public string GuzergahAdi  //Dışarıdan bişey almaması için 'set' özelliğini kaldırıyoruz.
        { 
            get // GuzergahAdı propety'i dışarıdan çağırıldığında kalkış ve Varış isimleri dönmesini sağladık. 
            {
                return $"{Kalkis} - {Varis}";
            } 
        }

        public List<GezilecekYer> GezilecekYerler { get; set; } = new();

        public override string ToString()
        {
            return GuzergahAdi;
        }
    }
}