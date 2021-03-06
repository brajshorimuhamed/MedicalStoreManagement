using MedicalStoreManagement.Application.CustomerPivots;
using MedicalStoreManagement.Application.Helpers;
using MedicalStoreManagement.Domain.Entities;
using MedicalStoreManagement.Web.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Web.ViewModels
{
    public class CustomerPivotViewModel : BaseViewModel
    {
        #region Properties
        public IList<CustomerPivot> CustomerPivots { get; set; }
        #endregion

        #region Input
        public int Id { get; set; }
        public string Research { get; set; }
        public int ProductId { get; set; }
        public bool ProductStatus { get; set; }

        public IList<Product> Products { get; set; }
        #endregion

        #region Init
        public override void Init()
        {
            if (initialized) return;
            CustomerPivots = HttpContextHelper.Context.RequestServices.GetRequiredService<ICustomerPivotService>().GetCustomerPivots().Result;
            base.Init();
        }
        #endregion

        #region Load Data
        public void LoadData(int customerPivotId)
        {
            try
            {
                var customerPivot = CustomerPivots.FirstOrDefault(x => x.Id == customerPivotId);
                Id = customerPivot.Id;
                Research = customerPivot.Research;
                ProductId = customerPivot.ProductId;
                ProductStatus = customerPivot.ProductStatus;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
