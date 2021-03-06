using MedicalStoreManagement.Application.Customers;
using MedicalStoreManagement.Application.Helpers;
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
    public class CustomerViewModel : BaseViewModel
    {
        #region Properties
        public IList<Customer> Customers { get; set; }
        #endregion

        #region Input
        public int Id { get; set; }
        public IFormFile Recepts { get; set; }
        public int ProductID { get; set; }

        public IList<Product> Products { get; set; }
        #endregion

        #region Init
        public override void Init()
        {
            if (initialized) return;
            Customers = HttpContextHelper.Context.RequestServices.GetRequiredService<ICustomerService>().GetCustomers().Result;
            base.Init();
        }
        #endregion

        #region Load Data
        
        #endregion
    }
}
