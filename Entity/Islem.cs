namespace EntityFrameworkCore_4_5.Entity
{
    public class Islem
    {
        public int Id { get; set; }

        public int OgrenciId { get; set; }
        public List<Ogrenci>? Ogrencis { get; set; }
        public int KitapId { get; set; }
        public List<Kitap>? Kitaps { get; set; }
        public DateTime KitapAlinmaTarih { get; set; }
        public DateTime KitapVerilisTarih { get; set; }

        
    }
}