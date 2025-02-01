using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ORM.Mapping;

public class SaleConfiguration : IEntityTypeConfiguration<Sale>
{
    public void Configure(EntityTypeBuilder<Sale> builder)
    {
        builder.ToTable("Sales");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id)
               .HasColumnType("uuid")
               .HasDefaultValueSql("gen_random_uuid()");

        builder.Property(u => u.CustomerId).IsRequired();
        builder.Property(u => u.CustomerName).HasMaxLength(150).IsRequired();

        builder.Property(u => u.BranchId).IsRequired();
        builder.Property(u => u.BranchName).HasMaxLength(150).IsRequired();

        builder.Property(u => u.SaleNumber).ValueGeneratedOnAdd();

        builder.Property(u => u.SaleDate).IsRequired();

        builder.Property(u => u.TotalValue).IsRequired();

        builder.Property(u => u.IsCancelled).IsRequired();
    }
}
