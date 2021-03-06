using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Infrastructure.Configurations
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.ProductID)
                .HasColumnName("ProductID")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Quantity)
                .HasColumnName("Quantity")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Price)
                .HasColumnName("Price")
                .IsRequired();

            builder.Property(x => x.CustomerID)
                .HasColumnName("CustomerID")
                .HasColumnType("int")
                .IsRequired();

            RelationshipWithCustomers(builder);

            RelationshipWithProducts(builder);

            builder.ToTable("Sales");
        }

        private void RelationshipWithCustomers(EntityTypeBuilder<Sale> builder)
        {
            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Sales)
                .HasForeignKey(x => x.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void RelationshipWithProducts(EntityTypeBuilder<Sale> builder)
        {
            builder.HasOne(x => x.Product)
                .WithMany(x => x.Sales)
                .HasForeignKey(x => x.ProductID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
