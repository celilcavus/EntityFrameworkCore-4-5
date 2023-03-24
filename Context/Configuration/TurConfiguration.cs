using EntityFrameworkCore_4_5.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore_4_5.Context.Configuration
{
    public class TurConfiguration : IEntityTypeConfiguration<Tur>
    {
        public void Configure(EntityTypeBuilder<Tur> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            
            builder.Property(x=>x.TurAdi).IsRequired().HasMaxLength(30);
        }
    }
}