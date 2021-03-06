using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Infrastructure.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Recepts)
                .HasColumnName("Recepts")
                .IsRequired();

            builder.Property(x => x.ProductId)
                .HasColumnName("ProductId")
                .HasColumnType("int")
                .IsRequired();

            RelationshipWithProducts(builder);

            builder.ToTable("Customers");
        }

        private void RelationshipWithProducts(EntityTypeBuilder<Customer> builder)
        {
            builder.HasOne(x => x.Product)
                .WithMany(x => x.Customers)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
