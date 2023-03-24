using EntityFrameworkCore_4_5.Context.Configuration;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore_4_5.Entity
{
    public class KutuphaneContext:DbContext
    {
        public DbSet<Islem>? Islems { get; set; }
        public DbSet<Kitap>? Kitaps { get; set; }
        public DbSet<Ogrenci>? Ogrencis { get; set; }
        public DbSet<Tur>? Turs { get; set; }
        public DbSet<Yazar>? Yazars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreKutuphaneDb;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IslemConfiguration());
            modelBuilder.ApplyConfiguration(new KitapConfiguration());
            modelBuilder.ApplyConfiguration(new OgrenciConfiguration());
            modelBuilder.ApplyConfiguration(new TurConfiguration());
            modelBuilder.ApplyConfiguration(new YazarConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}