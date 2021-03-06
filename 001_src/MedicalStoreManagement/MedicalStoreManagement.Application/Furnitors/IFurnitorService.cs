using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Furnitors
{
    public interface IFurnitorService
    {
        Task AddFurnitor(FurnitorSubmissionModel model);
        Task<IList<Furnitor>> GetFurnitors();
        Task<IList<Furnitor>> GetFurnitorsById(int furnitorId);
        Task<bool> DeleteFurnitor(int furnitorId);
        Task<bool> UpdateFurnitor(FurnitorUpdateSubmissionModel model);
    }
}
