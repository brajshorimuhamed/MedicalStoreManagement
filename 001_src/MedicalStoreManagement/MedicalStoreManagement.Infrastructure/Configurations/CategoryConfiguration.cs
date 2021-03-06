using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Infrastructure.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Category_Name)
                .HasColumnName("Category_Name")
                .IsRequired();

            builder.Property(x => x.Category_Quantity)
                .HasColumnName("Category_Quantity")
                .HasColumnType("int")
                .IsRequired();

            builder.ToTable("Categories");
        }
    }
}
