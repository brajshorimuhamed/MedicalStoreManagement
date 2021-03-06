using MedicalStoreManagement.Application.Helpers;
using MedicalStoreManagement.Application.Sales;
using MedicalStoreManagement.Domain.Entities;
using MedicalStoreManagement.Web.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Web.ViewModels
{
    public class SaleViewModel : BaseViewModel
    {
        #region Properties
        public IList<Sale> Sales { get; set; }
        #endregion

        #region Input
        public int Id { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotaliSale { get; set; }
        public decimal ProfitSales { get; set; }
        public int CustomerID { get; set; }

        public IList<Product> Products { get; set; }

        public IList<Customer> Customers { get; set; }
        #endregion
        
        #region Init
        public override void Init()
        {
            if (initialized) return;
            Sales = HttpContextHelper.Context.RequestServices.GetRequiredService<ISaleService>().GetSales().Result;
            base.Init();
        }
        #endregion

        #region Load Data
        public void LoadData(int saleId)
        {
            try
            {
                var sale = Sales.FirstOrDefault(x => x.Id == saleId);
                Id = sale.Id;
                ProductID = sale.ProductID;
                Quantity = sale.Quantity;
                Price = sale.Price;
                CustomerID = sale.CustomerID;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
