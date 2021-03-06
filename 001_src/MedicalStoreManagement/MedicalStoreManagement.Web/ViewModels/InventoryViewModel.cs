using MedicalStoreManagement.Application.Helpers;
using MedicalStoreManagement.Application.Inventories;
using MedicalStoreManagement.Domain.Entities;
using MedicalStoreManagement.Web.ViewModels.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Web.ViewModels
{
    public class InventoryViewModel : BaseViewModel
    {
        #region Properties
        public IList<Inventory> Inventories { get; set; }
        #endregion

        #region Input
        public int Id { get; set; }
        public string Inventory_Name { get; set; }
        public IFormFile ImageName { get; set; }
        #endregion

        #region Init
        public override void Init()
        {
            if (initialized) return;
            Inventories = HttpContextHelper.Context.RequestServices.GetRequiredService<IInventoryService>().GetInventories().Result;
            base.Init();
        }
        #endregion
        
    }
}
