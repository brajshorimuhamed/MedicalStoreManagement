using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Infrastructure.Configurations
{
    public class SalePivotConfiguration : IEntityTypeConfiguration<SalePivot>
    {
        public void Configure(EntityTypeBuilder<SalePivot> builder)
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
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.CustomerPivotId)
                .HasColumnName("CustomerPivotId")
                .HasColumnType("int")
                .IsRequired();

            RelationshipWithProducts(builder);

            RelationshipWithCustomerPivots(builder);

            builder.ToTable("SalePivots");
        }

        private void RelationshipWithCustomerPivots(EntityTypeBuilder<SalePivot> builder)
        {
            builder.HasOne(x => x.CustomerPivot)
                .WithMany(x => x.SalePivots)
                .HasForeignKey(x => x.CustomerPivotId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void RelationshipWithProducts(EntityTypeBuilder<SalePivot> builder)
        {
            builder.HasOne(x => x.Product)
                .WithMany(x => x.SalePivots)
                .HasForeignKey(x => x.ProductID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
