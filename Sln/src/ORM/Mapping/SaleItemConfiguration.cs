using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ORM.Mapping;

public class SaleItemConfiguration : IEntityTypeConfiguration<SaleItem>
{
    public void Configure(EntityTypeBuilder<SaleItem> builder)
    {
        builder.ToTable("SaleItems");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id)
               .HasColumnType("uuid")
               .HasDefaultValueSql("gen_random_uuid()");

        builder.HasOne(p => p.Sale)
               .WithMany(p => p.Items)
               .HasForeignKey(p => p.SaleId)
               .IsRequired(false);

        builder.HasOne(e => e.Product).WithOne().HasForeignKey<Product>(e => e.Id);

        builder.Property(u => u.Quantity).IsRequired();

        builder.Property(u => u.UnitPrice).IsRequired();

        builder.Property(u => u.Discount).IsRequired();
    }
}
