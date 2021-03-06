using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Infrastructure.Configurations
{
    public class CustomerPivotConfiguration : IEntityTypeConfiguration<CustomerPivot>
    {
        public void Configure(EntityTypeBuilder<CustomerPivot> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Research)
                .HasColumnName("Research")
                .IsRequired();

            builder.Property(x => x.ProductId)
                .HasColumnName("ProductId")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.ProductStatus)
                .HasColumnName("ProductStatus")
                .IsRequired();

            RelationshipWithProducts(builder);

            builder.ToTable("CustomerPivots");
        }

        private void RelationshipWithProducts(EntityTypeBuilder<CustomerPivot> builder)
        {
            builder.HasOne(x => x.Product)
                .WithMany(x => x.CustomerPivots)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
