using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Purchases
{
    public interface IPurchaseService
    {
        Task AddPurchase(PurchaseSubmissionModel model);
        Task<IList<Purchase>> GetPurchases();
        Task<IList<Purchase>> GetPurchasesFurnitor();
        Task<IList<Purchase>> GetPurchasesById(int purchaseId);
        Task<bool> DeletePurchase(int purchaseId);
        Task<bool> UpdatePurchase(PurchaseUpdateSubmissionModel model);
    }
}
