using EntityFrameworkCore_4_5.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore_4_5.Context.Configuration
{
    public class YazarConfiguration : IEntityTypeConfiguration<Yazar>
    {
        public void Configure(EntityTypeBuilder<Yazar> builder)
        {
                builder.HasKey(x=>x.Id);
                builder.Property(x=>x.Id).UseIdentityColumn();

                builder.Property(x=>x.YazarAdi).IsRequired().HasMaxLength(20);
                builder.Property(x=>x.YazarSoyadi).IsRequired().HasMaxLength(20);
        }
    }
}