using EntityFrameworkCore_4_5.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore_4_5.Context.Configuration
{
    public class KitapConfiguration : IEntityTypeConfiguration<Kitap>
    {
        public void Configure(EntityTypeBuilder<Kitap> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.KitapAdi).HasMaxLength(50);
            builder.Property(x=>x.KitapAdi).HasDefaultValue("Kitap Adi yok");
            builder.Property(x=>x.SayfaSayisi).HasMaxLength(5);
        }
    }
}