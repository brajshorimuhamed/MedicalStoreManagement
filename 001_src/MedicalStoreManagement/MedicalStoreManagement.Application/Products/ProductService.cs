using MedicalStoreManagement.Application.Interfaces;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Products
{
    public class ProductService : IProductService
    {
        private readonly IMedicalStoreDbContext _context;

        public ProductService(IMedicalStoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddProduct(ProductSubmissionModel model)
        {
            var entity = model.ToEntity();
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _context.Products.AddRangeAsync(entity);
            _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            var entity = await _context.Products.FirstOrDefaultAsync(x => x.Id == productId);
            if (entity != null)
            {
                _context.Products.Remove(entity);
                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<IList<Product>> GetProducts()
        {
            var products = await _context.Products.Include("Furnitor").ToListAsync();
            await GetProductsCategory();
            return products;
        }

        public async Task<IList<Product>> GetProductsById(int productId)
        {
            return await _context.Products.Where(x => x.Id == productId).ToListAsync();
        }

        public async Task<IList<Product>> GetProductsCategory()
        {
            return await _context.Products.Include("Category").ToListAsync();
        }

        public async Task<bool> UpdateProduct(ProductUpdateSubmissionModel model)
        {
            var entity = await _context.Products.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (entity != null)
            {
                entity.Id = model.Id;
                entity.Product_Name = model.Product_Name;
                entity.Unit = model.Unit;
                entity.PricePerUnit = model.PricePerUnit;
                entity.FurnitorID = model.FurnitorID;
                entity.CompanyName = model.CompanyName;
                entity.CategoryID = model.CategoryID;
                entity.Product_Description = model.Product_Description;

                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }
    }
}
