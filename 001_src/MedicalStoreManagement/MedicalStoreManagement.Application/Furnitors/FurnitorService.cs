using MedicalStoreManagement.Application.Interfaces;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Furnitors
{
    public class FurnitorService : IFurnitorService
    {
        private readonly IMedicalStoreDbContext _context;

        public FurnitorService(IMedicalStoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddFurnitor(FurnitorSubmissionModel model)
        {
            var entity = model.ToEntity();
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _context.Furnitors.AddRangeAsync(entity);
            _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteFurnitor(int furnitorId)
        {
            var entity = await _context.Furnitors.FirstOrDefaultAsync(x => x.Id == furnitorId);
            if (entity != null)
            {
                _context.Furnitors.Remove(entity);
                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<IList<Furnitor>> GetFurnitors()
        {
            return await _context.Furnitors.ToListAsync();
        }

        public async Task<IList<Furnitor>> GetFurnitorsById(int furnitorId)
        {
            return await _context.Furnitors.Where(x => x.Id == furnitorId).ToListAsync();
        }

        public async Task<bool> UpdateFurnitor(FurnitorUpdateSubmissionModel model)
        {
            var entity = await _context.Furnitors.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (entity != null)
            {
                entity.Id = model.Id;
                entity.Furnitor_FirstName = model.Furnitor_FirstName;
                entity.Furnitor_LastName = model.Furnitor_LastName;
                entity.Furnitor_NrPhone = model.Furnitor_NrPhone;
                entity.Furnitor_Email = model.Furnitor_Email;
                entity.Furnitor_Address = model.Furnitor_Address;

                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }
    }
}
