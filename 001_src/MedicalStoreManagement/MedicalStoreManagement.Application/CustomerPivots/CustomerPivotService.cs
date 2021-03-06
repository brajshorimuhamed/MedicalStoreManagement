using MedicalStoreManagement.Application.Interfaces;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.CustomerPivots
{
    public class CustomerPivotService : ICustomerPivotService
    {
        private readonly IMedicalStoreDbContext _context;

        public CustomerPivotService(IMedicalStoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddCustomerPivot(CustomerPivotSubmissionModel model)
        {
            var entity = model.ToEntity();
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _context.CustomerPivots.AddRangeAsync(entity);
            _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteCustomerPivot(int customerPivotId)
        {
            var entity = await _context.CustomerPivots.FirstOrDefaultAsync(x => x.Id == customerPivotId);
            if (entity != null)
            {
                _context.CustomerPivots.Remove(entity);
                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<IList<CustomerPivot>> GetCustomerPivots()
        {
            return await _context.CustomerPivots.Include("Product").ToListAsync();
        }

        public async Task<IList<CustomerPivot>> GetCustomerPivotsById(int customerPivotId)
        {
            return await _context.CustomerPivots.Where(x => x.Id == customerPivotId).ToListAsync();
        }

        public async Task<bool> UpdateCustomerPivot(CustomerPivotUpdateSubmissionModel model)
        {
            var entity = await _context.CustomerPivots.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (entity != null)
            {
                entity.Id = model.Id;
                entity.Research = model.Research;
                entity.ProductId = model.ProductID;
                entity.ProductStatus = model.ProductStatus;

                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }
    }
}
