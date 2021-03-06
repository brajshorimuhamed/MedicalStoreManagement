using MedicalStoreManagement.Application.Interfaces;
using MedicalStoreManagement.Domain.Entities;
using MedicalStoreManagement.Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Infrastructure
{
    public class MedicalStoreDbContext : IdentityDbContext<User, Role, string>, IMedicalStoreDbContext
    {
        public MedicalStoreDbContext(DbContextOptions<MedicalStoreDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerPivot> CustomerPivots { get; set; }
        public DbSet<Furnitor> Furnitors { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalePivot> SalePivots { get; set; }

        public DbSet<IdentityUserRole<string>> IdentityUserRoles { get; set; }

        public DbSet<IdentityUserClaim<string>> IdentityUserClaims { get; set; }

        public int SaveChangesAsync()
        {
            return SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerPivotConfiguration());
            modelBuilder.ApplyConfiguration(new FurnitorConfiguration());
            modelBuilder.ApplyConfiguration(new InventoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new PurchaseConfiguration());
            modelBuilder.ApplyConfiguration(new SaleConfiguration());

            MedicalStoreDbInitializer.Initialize(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
