using MedicalStoreManagement.Application.Helpers;
using MedicalStoreManagement.Application.Purchases;
using MedicalStoreManagement.Domain.Entities;
using MedicalStoreManagement.Web.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Web.ViewModels
{
    public class PurchaseViewModel : BaseViewModel
    {
        #region Properties
        public IList<Purchase> Purchases { get; set; }
        #endregion

        #region Input
        public int Id { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotaliPurchases { get; set; }
        public int FurnitorID { get; set; }

        public IList<Product> Products { get; set; }

        public IList<Furnitor> Furnitors { get; set; }
        #endregion

        #region Init
        public override void Init()
        {
            if (initialized) return;
            Purchases = HttpContextHelper.Context.RequestServices.GetRequiredService<IPurchaseService>().GetPurchases().Result;
            base.Init();
        }
        #endregion

        #region Load Data
        public void LoadData(int purchaseId)
        {
            try
            {
                var purchase = Purchases.FirstOrDefault(x => x.Id == purchaseId);
                Id = purchase.Id;
                ProductID = purchase.ProductID;
                Quantity = purchase.Quantity;
                Price = purchase.Price;
                FurnitorID = purchase.FurnitorID;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
