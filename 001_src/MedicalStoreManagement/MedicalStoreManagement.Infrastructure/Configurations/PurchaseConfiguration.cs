using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Infrastructure.Configurations
{
    public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
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

            builder.Property(x => x.FurnitorID)
                .HasColumnName("FurnitorID")
                .HasColumnType("int")
                .IsRequired();

            RelationshipWithProducts(builder);

            RelationshipWithFurnitors(builder);

            builder.ToTable("Purchases");
        }

        private void RelationshipWithProducts(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasOne(x => x.Product)
                .WithMany(x => x.Purchases)
                .HasForeignKey(x => x.ProductID)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void RelationshipWithFurnitors(EntityTypeBuilder<Purchase> builder)
        {
            builder.HasOne(x => x.Furnitor)
                .WithMany(x => x.Purchases)
                .HasForeignKey(x => x.FurnitorID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
