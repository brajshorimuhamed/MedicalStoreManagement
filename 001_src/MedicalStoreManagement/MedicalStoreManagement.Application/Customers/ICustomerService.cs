using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Customers
{
    public interface ICustomerService
    {
        Task AddCustomer(CustomerSubmissionModel model);
        Task<IList<Customer>> GetCustomers();
        Task<IList<Customer>> GetCustomersById(int customerId);
        Task<bool> DeleteCustomer(int customerId);
        Task<bool> UpdateCustomer(CustomerUpdateSubmissionModel model);
    }
}
