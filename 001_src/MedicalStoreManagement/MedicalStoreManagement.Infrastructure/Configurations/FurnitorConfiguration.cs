using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Infrastructure.Configurations
{
    public class FurnitorConfiguration : IEntityTypeConfiguration<Furnitor>
    {
        public void Configure(EntityTypeBuilder<Furnitor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Furnitor_FirstName)
                .HasColumnName("Furnitor_FirstName")
                .IsRequired();

            builder.Property(x => x.Furnitor_LastName)
                .HasColumnName("Furnitor_LastName")
                .IsRequired();

            builder.Property(x => x.Furnitor_NrPhone)
                .HasColumnName("Furnitor_NrPhone")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Furnitor_Email)
                .HasColumnName("Furnitor_Email")
                .IsRequired();

            builder.Property(x => x.Furnitor_Address)
                .HasColumnName("Furnitor_Address")
                .IsRequired();

            builder.ToTable("Furnitors");
        }
    }
}