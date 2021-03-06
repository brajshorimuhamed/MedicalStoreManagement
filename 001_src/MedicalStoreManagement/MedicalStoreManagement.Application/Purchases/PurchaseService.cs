using MedicalStoreManagement.Application.Interfaces;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Purchases
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IMedicalStoreDbContext _context;

        public PurchaseService(IMedicalStoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddPurchase(PurchaseSubmissionModel model)
        {
            var entity = model.ToEntity();
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _context.Purchases.AddRangeAsync(entity);
            _context.SaveChangesAsync();
        }

        public async Task<bool> DeletePurchase(int purchaseId)
        {
            var entity = await _context.Purchases.FirstOrDefaultAsync(x => x.Id == purchaseId);
            if (entity != null)
            {
                _context.Purchases.Remove(entity);
                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<IList<Purchase>> GetPurchases()
        {
            var purchases = await _context.Purchases.Include("Product").ToListAsync();
            await GetPurchasesFurnitor();
            return purchases;
        }

        public async Task<IList<Purchase>> GetPurchasesById(int purchaseId)
        {
            return await _context.Purchases.Where(x => x.Id == purchaseId).ToListAsync();
        }

        public async Task<IList<Purchase>> GetPurchasesFurnitor()
        {
            return await _context.Purchases.Include("Furnitor").ToListAsync();
        }

        public async Task<bool> UpdatePurchase(PurchaseUpdateSubmissionModel model)
        {
            var entity = await _context.Purchases.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (entity != null)
            {
                entity.Id = model.Id;
                entity.ProductID = model.ProductID;
                entity.Quantity = model.Quantity;
                entity.Price = model.Price;
                entity.FurnitorID = model.FurnitorID;

                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }
    }
}
