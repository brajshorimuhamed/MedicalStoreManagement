using MedicalStoreManagement.Application.Interfaces;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly IMedicalStoreDbContext _context;

        public CustomerService(IMedicalStoreDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddCustomer(CustomerSubmissionModel model)
        {
            var entity = model.ToEntity();
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            await _context.Customers.AddRangeAsync(entity);
            _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteCustomer(int customerId)
        {
            var entity = await _context.Customers.FirstOrDefaultAsync(x => x.Id == customerId);
            if (entity != null)
            {
                _context.Customers.Remove(entity);
                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }

        public async Task<IList<Customer>> GetCustomers()
        {
            return await _context.Customers.Include("Product").ToListAsync();
        }

        public async Task<IList<Customer>> GetCustomersById(int customerId)
        {
            return await _context.Customers.Where(x => x.Id == customerId).ToListAsync();
        }

        public async Task<bool> UpdateCustomer(CustomerUpdateSubmissionModel model)
        {
            var entity = await _context.Customers.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (entity != null)
            {
                entity.Id = model.Id;
                entity.Recepts = model.Recepts;
                entity.ProductId = model.ProductID;

                return _context.SaveChangesAsync() > 0;
            }

            return false;
        }
    }
}
