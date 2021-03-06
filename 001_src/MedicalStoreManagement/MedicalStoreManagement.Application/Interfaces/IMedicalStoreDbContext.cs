using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalStoreManagement.Application.Interfaces
{
    public interface IMedicalStoreDbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<CustomerPivot> CustomerPivots { get; set; }
        DbSet<Furnitor> Furnitors { get; set; }
        DbSet<Inventory> Inventories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Purchase> Purchases { get; set; }
        DbSet<Sale> Sales { get; set; }
        DbSet<SalePivot> SalePivots { get; set; }

        int SaveChangesAsync();
    }
}
