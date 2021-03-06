using MedicalStoreManagement.Application.Interfaces;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Inventories
{
    public class InventoryService : IInventoryService
    {
        private readonly IMedicalStoreDbContext _context;

        public InventoryService(IMedicalStoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddInventory(InventorySubmissionModel model)
        {
            var entity = model.ToEntity();
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _context.Inventories.AddRangeAsync(entity);
            _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteInventory(int inventoryId)
        {
            var entity = await _context.Inventories.FirstOrDefaultAsync(x => x.Id == inventoryId);
            if (entity != null)
            {
                _context.Inventories.Remove(entity);
                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<IList<Inventory>> GetInventories()
        {
            return await _context.Inventories.ToListAsync();
        }

        public async Task<IList<Inventory>> GetInventoriesById(int inventoryId)
        {
            return await _context.Inventories.Where(x => x.Id == inventoryId).ToListAsync();
        }
    }
}
