namespace EntityFrameworkCore_4_5.Entity
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string? OgrenciAd { get; set; }
        public string? OgrenciSoyad { get; set; }
        public char Cinsiyet { get; set; }
        public string? Sinif { get; set; }
    }
}