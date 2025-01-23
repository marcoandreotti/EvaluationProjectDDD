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

        builder.Property(u => u.SaleNumber).ValueGeneratedOnAdd();

        builder.Property(u => u.SaleDate).IsRequired();

        builder.HasOne(e => e.Customer)
               .WithOne()
               .HasForeignKey<Customer>(e => e.Id)
               .IsRequired();

        builder.Property(u => u.TotalValue).IsRequired();

        builder.HasOne(e => e.Branch)
               .WithOne()
               .HasForeignKey<Branch>(e => e.Id)
               .IsRequired();


        builder.Property(u => u.IsCancelled).IsRequired();
    }
}
