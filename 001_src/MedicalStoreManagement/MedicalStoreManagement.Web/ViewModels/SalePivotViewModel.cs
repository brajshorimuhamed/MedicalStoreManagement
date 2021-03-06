using MedicalStoreManagement.Application.Helpers;
using MedicalStoreManagement.Application.SalePivots;
using MedicalStoreManagement.Domain.Entities;
using MedicalStoreManagement.Web.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Web.ViewModels
{
    public class SalePivotViewModel : BaseViewModel
    {
        #region Properties
        public IList<SalePivot> SalePivots { get; set; }
        #endregion

        #region Input
        public int Id { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotaliSales { get; set; }
        public int CustomerPivotID { get; set; }

        public IList<Product> Products { get; set; }

        public IList<CustomerPivot> CustomerPivots { get; set; }
        #endregion

        #region Init
        public override void Init()
        {
            if (initialized) return;
            SalePivots = HttpContextHelper.Context.RequestServices.GetRequiredService<ISalePivotService>().GetSalePivots().Result;
            base.Init();
        }
        #endregion

        #region Load Data
        public void LoadData(int salePivotId)
        {
            try
            {
                var salePivot = SalePivots.FirstOrDefault(x => x.Id == salePivotId);
                Id = salePivot.Id;
                ProductID = salePivot.ProductID;
                Quantity = salePivot.Quantity;
                Price = salePivot.Price;
                CustomerPivotID = salePivot.CustomerPivotId;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
