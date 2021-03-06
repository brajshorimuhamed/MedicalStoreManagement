using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalStoreManagement.Application.Categories;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStoreManagement.Web.Controllers
{
    public class CategoryController : Controller
    {
        #region Properties
        private readonly ICategoryService _categoryService;
        #endregion

        #region Constructor
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        #endregion

        #region View
        // GET: Category
        public IActionResult Index()
        {
            return View(new CategoryViewModel());
        }

        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            await _categoryService.DeleteCategory(categoryId);

            return RedirectToAction("Index", "Category");
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        public IActionResult Details(CategoryViewModel model, int categoryId)
        {
            model.LoadData(categoryId);
            return View(model);
        }
        #endregion

        #region Add Category
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCategory(CategoryViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _categoryService.AddCategory(PrepareCategorySubmissionModel(model));
            return RedirectToAction("Index", "Category");
            // return View(model);
        }
        #endregion

        #region Private Methods
        private CategorySubmissionModel PrepareCategorySubmissionModel(CategoryViewModel model)
        {
            return new CategorySubmissionModel
            {
                Category_Name = model.Category_Name,
                Category_Quantity = model.Category_Quantity
            };
        }
        #endregion
    }
}