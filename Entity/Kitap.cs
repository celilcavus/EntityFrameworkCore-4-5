namespace EntityFrameworkCore_4_5.Entity
{
    public class Kitap
    {
        public int Id { get; set; }
        public int IslemId { get; set; }
        public Islem? Islem { get; set; }
        public string? KitapAdi { get; set; }
        public int TurId { get; set; }
        public List<Tur>? Turs { get; set; }
        public int SayfaSayisi { get; set; }
        public short Puan { get; set; }
        public int YazarId { get; set; }
        public Yazar? Yazar { get; set; }
    }   
}