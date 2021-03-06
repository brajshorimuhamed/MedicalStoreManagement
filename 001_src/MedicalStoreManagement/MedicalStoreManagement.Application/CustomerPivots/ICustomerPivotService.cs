using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.CustomerPivots
{
    public interface ICustomerPivotService
    {
        Task AddCustomerPivot(CustomerPivotSubmissionModel model);
        Task<IList<CustomerPivot>> GetCustomerPivots();
        Task<IList<CustomerPivot>> GetCustomerPivotsById(int customerPivotId);
        Task<bool> DeleteCustomerPivot(int customerPivotId);
        Task<bool> UpdateCustomerPivot(CustomerPivotUpdateSubmissionModel model);
    }
}
