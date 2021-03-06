using MedicalStoreManagement.Application.Interfaces;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly IMedicalStoreDbContext _context;

        public CategoryService(IMedicalStoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddCategory(CategorySubmissionModel model)
        {
            var entity = model.ToEntity();
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _context.Categories.AddRangeAsync(entity);
            _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteCategory(int categoryId)
        {
            var entity = await _context.Categories.FirstOrDefaultAsync(x => x.Id == categoryId);
            if (entity != null)
            {
                _context.Categories.Remove(entity);
                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<IList<Category>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<IList<Category>> GetCategoriesById(int categoryId)
        {
            return await _context.Categories.Where(x => x.Id == categoryId).ToListAsync();
        }
    }
}
