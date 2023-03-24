using EntityFrameworkCore_4_5.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore_4_5.Context.Configuration
{
    public class OgrenciConfiguration : IEntityTypeConfiguration<Ogrenci>
    {
        public void Configure(EntityTypeBuilder<Ogrenci> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.OgrenciAd).HasMaxLength(30).IsRequired();
            builder.Property(x=>x.OgrenciSoyad).HasMaxLength(30).IsRequired();
        }
    }
}