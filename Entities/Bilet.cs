namespace TourTicketApp.Entities
{
    public class Bilet : Base
    {
        public byte KoltukNumarasi { get; set; }
        public DateTime KalkisZamani { get; set; }
        public decimal Ucret { get; set; }
        public Firma Firma { get; set; }
        public Otobus Otobus { get; set; }
        public Yolcu Yolcu { get; set; }
        public Guzergah Guzergah { get; set; }
    }
}