using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.SalePivots
{
    public interface ISalePivotService
    {
        Task AddSalePivot(SalePivotSubmissionModel model);
        Task<IList<SalePivot>> GetSalePivots();
        Task<IList<SalePivot>> GetSalePivotsCustomerPivot();
        Task<IList<SalePivot>> GetSalePivotsById(int salePivotId);
        Task<bool> DeleteSalePivot(int salePivotId);
        Task<bool> UpdateSalePivot(SalePivotUpdateSubmissionModel model);
    }
}
