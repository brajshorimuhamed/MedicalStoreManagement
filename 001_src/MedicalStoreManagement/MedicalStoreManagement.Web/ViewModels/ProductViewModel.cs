using MedicalStoreManagement.Application.Helpers;
using MedicalStoreManagement.Application.Products;
using MedicalStoreManagement.Domain.Entities;
using MedicalStoreManagement.Web.ViewModels.Base;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStoreManagement.Web.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        #region Properties
        public IList<Product> Products { get; set; }
        #endregion

        #region Input
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public string Unit { get; set; }
        public string PricePerUnit { get; set; }
        public int FurnitorID { get; set; }
        public string CompanyName { get; set; }
        public int CategoryID { get; set; }
        public string Product_Description { get; set; }

        public IList<Furnitor> Furnitors { get; set; }

        public IList<Category> Categories { get; set; }
        #endregion

        #region Init
        public override void Init()
        {
            if (initialized) return;
            Products = HttpContextHelper.Context.RequestServices.GetRequiredService<IProductService>().GetProducts().Result;
            base.Init();
        }
        #endregion

        #region Load Data
        public void LoadData(int productId)
        {
            try
            {
                var product = Products.FirstOrDefault(x => x.Id == productId);
                Id = product.Id;
                Product_Name = product.Product_Name;
                Unit = product.Unit;
                PricePerUnit = product.PricePerUnit;
                FurnitorID = product.FurnitorID;
                CompanyName = product.CompanyName;
                CategoryID = product.CategoryID;
                Product_Description = product.Product_Description;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
