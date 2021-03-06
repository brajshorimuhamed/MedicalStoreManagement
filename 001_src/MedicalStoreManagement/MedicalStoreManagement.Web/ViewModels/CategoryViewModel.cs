using MedicalStoreManagement.Application.Categories;
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
    public class CategoryViewModel : BaseViewModel
    {
        #region Properties
        public IList<Category> Categories { get; set; }
        #endregion

        #region Input
        public int Id { get; set; }
        public string Category_Name { get; set; }
        public int Category_Quantity { get; set; }
        #endregion

        #region Init
        public override void Init()
        {
            if (initialized) return;
            Categories = HttpContextHelper.Context.RequestServices.GetRequiredService<ICategoryService>().GetCategories().Result;
            base.Init();
        }
        #endregion

        #region Load Data
        public void LoadData(int categoryId)
        {
            try
            {
                var category = Categories.FirstOrDefault(x => x.Id == categoryId);
                Id = category.Id;
                Category_Name = category.Category_Name;
                Category_Quantity = category.Category_Quantity;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
