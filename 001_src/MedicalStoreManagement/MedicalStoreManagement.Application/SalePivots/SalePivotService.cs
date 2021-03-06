using MedicalStoreManagement.Application.Interfaces;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.SalePivots
{
    public class SalePivotService : ISalePivotService
    {
        private readonly IMedicalStoreDbContext _context;

        public SalePivotService(IMedicalStoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddSalePivot(SalePivotSubmissionModel model)
        {
            var entity = model.ToEntity();
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _context.SalePivots.AddRangeAsync(entity);
            _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteSalePivot(int salePivotId)
        {
            var entity = await _context.SalePivots.FirstOrDefaultAsync(x => x.Id == salePivotId);
            if (entity != null)
            {
                _context.SalePivots.Remove(entity);

                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<IList<SalePivot>> GetSalePivots()
        {
            var salePivots = await _context.SalePivots.Include("Product").ToListAsync();
            await GetSalePivotsCustomerPivot();
            return salePivots;
        }

        public async Task<IList<SalePivot>> GetSalePivotsById(int salePivotId)
        {
            return await _context.SalePivots.Where(x => x.Id == salePivotId).ToListAsync();
        }

        public async Task<IList<SalePivot>> GetSalePivotsCustomerPivot()
        {
            return await _context.SalePivots.Include("CustomerPivot").ToListAsync();
        }

        public async Task<bool> UpdateSalePivot(SalePivotUpdateSubmissionModel model)
        {
            var entity = await _context.SalePivots.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (entity != null)
            {
                entity.Id = model.Id;
                entity.ProductID = model.ProductID;
                entity.Quantity = model.Quantity;
                entity.Price = model.Price;
                entity.CustomerPivotId = model.CustomerPivotID;

                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }
    }
}
