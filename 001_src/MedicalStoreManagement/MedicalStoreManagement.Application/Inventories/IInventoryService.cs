using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Application.Inventories
{
    public interface IInventoryService
    {
        Task AddInventory(InventorySubmissionModel model);
        Task<IList<Inventory>> GetInventories();
        Task<IList<Inventory>> GetInventoriesById(int inventoryId);
        Task<bool> DeleteInventory(int inventoryId);
    }
}
