using EntityFrameworkCore_4_5.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCore_4_5.Context.Configuration
{
    public class IslemConfiguration : IEntityTypeConfiguration<Islem>
    {
        public void Configure(EntityTypeBuilder<Islem> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            //Değer girilmezse sqle otomatik olarak bulunduğu  tarih girilicektir
            builder.Property(x => x.KitapAlinmaTarih).HasDefaultValueSql("getdate()");

            //Değer girilmezse sqle otomatik olarak bulunduğu  tarih'e 7 gün ekleyerek  girilicektir
            builder.Property(x => x.KitapVerilisTarih).HasDefaultValueSql("DATEADD(DAY,7,getdate())");
        }
    }
}