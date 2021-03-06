using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Sales
{
    public interface ISaleService
    {
        Task AddSales(SaleSubmissionModel model);
        Task<IList<Sale>> GetSales();
        Task<IList<Sale>> GetSalesCustomer();
        Task<IList<Sale>> GetSalesById(int saleId);
        Task<bool> DeleteSales(int saleId);
        Task<bool> UpdateSales(SaleUpdateSubmissionModel model);
    }
}
