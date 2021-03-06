using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Product_Name)
                .HasColumnName("Product_Name")
                .IsRequired();

            builder.Property(x => x.Unit)
                .HasColumnName("Unit")
                .IsRequired();

            builder.Property(x => x.PricePerUnit)
                .HasColumnName("PricePerUnit")
                .IsRequired();

            builder.Property(x => x.FurnitorID)
                .HasColumnName("FurnitorID")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.CompanyName)
                .HasColumnName("CompanyName")
                .IsRequired();

            builder.Property(x => x.CategoryID)
                .HasColumnName("CategoryID")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Product_Description)
                .HasColumnName("Product_Description")
                .IsRequired();

            RelationshipWithFurnitors(builder);

            RelationshipWithCategories(builder);

            builder.ToTable("Products");
        }

        private void RelationshipWithCategories(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryID)
                .OnDelete(DeleteBehavior.Restrict);
        }

        private void RelationshipWithFurnitors(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(x => x.Furnitor)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.FurnitorID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
