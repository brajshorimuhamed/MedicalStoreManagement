using MedicalStoreManagement.Application.Interfaces;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Sales
{
    public class SaleService : ISaleService
    {
        private readonly IMedicalStoreDbContext _context;

        public SaleService(IMedicalStoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddSales(SaleSubmissionModel model)
        {
            var entity = model.ToEntity();
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _context.Sales.AddRangeAsync(entity);
            _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteSales(int saleId)
        {
            var entity = await _context.Sales.FirstOrDefaultAsync(x => x.Id == saleId);
            if (entity != null)
            {
                _context.Sales.Remove(entity);
                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<IList<Sale>> GetSales()
        {
            var sales = await _context.Sales.Include("Product").ToListAsync();
            await GetSalesCustomer();
            return sales;
        }
        
        public async Task<IList<Sale>> GetSalesCustomer()
        {
            return await _context.Sales.Include("Customer").ToListAsync();
        }

        public async Task<IList<Sale>> GetSalesById(int saleId)
        {
            return await _context.Sales.Where(x => x.Id == saleId).ToListAsync();
        }

        public async Task<bool> UpdateSales(SaleUpdateSubmissionModel model)
        {
            var entity = await _context.Sales.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (entity != null)
            {
                entity.Id = model.Id;
                entity.ProductID = model.ProductID;
                entity.Quantity = model.Quantity;
                entity.Price = model.Price;
                entity.CustomerID = model.CustomerID;

                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }
    }
}