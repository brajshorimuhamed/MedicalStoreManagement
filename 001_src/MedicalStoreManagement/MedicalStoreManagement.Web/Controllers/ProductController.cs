using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalStoreManagement.Application.Categories;
using MedicalStoreManagement.Application.Furnitors;
using MedicalStoreManagement.Application.Products;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStoreManagement.Web.Controllers
{
    public class ProductController : Controller
    {
        #region Properties
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IFurnitorService _furnitorService;
        #endregion

        #region Constructor
        public ProductController(IProductService productService, ICategoryService categoryService, IFurnitorService furnitorService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _furnitorService = furnitorService;
        }
        #endregion

        #region View
        // GET: Product
        public IActionResult Index()
        {
            return View(new ProductViewModel());
        }

        public async Task<IActionResult> DeleteProduct(int productId)
        {
            await _productService.DeleteProduct(productId);

            return RedirectToAction("Index", "Product");
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            var model = new ProductViewModel();
            model.Categories = _categoryService.GetCategories().Result;
            model.Furnitors = _furnitorService.GetFurnitors().Result;
            return View(model);
        }

        public IActionResult Details(ProductViewModel model, int productId)
        {
            model.LoadData(productId);
            model.Categories = _categoryService.GetCategories().Result;
            model.Furnitors = _furnitorService.GetFurnitors().Result;
            return View(model);
        }

        public IActionResult EditProduct(ProductViewModel model, int productId)
        {
            model.LoadData(productId);
            model.Categories = _categoryService.GetCategories().Result;
            model.Furnitors = _furnitorService.GetFurnitors().Result;
            return View(model);
        }
        #endregion

        #region Add Product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProduct(ProductViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _productService.AddProduct(PrepareProductSubmissionModel(model));
            return RedirectToAction("Index", "Product");
            //return View(model);
        }
        #endregion

        #region Edit Product
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct(ProductViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _productService.UpdateProduct(PrepareProductUpdateSubmissionModel(model));
            return RedirectToAction("Index", "Product");
            //return View(model);
        }
        #endregion

        #region Private Methods
        private ProductSubmissionModel PrepareProductSubmissionModel(ProductViewModel model)
        {
            return new ProductSubmissionModel
            {
                Product_Name = model.Product_Name,
                Unit = model.Unit,
                PricePerUnit = model.PricePerUnit,
                FurnitorID = model.FurnitorID,
                CompanyName = model.CompanyName,
                CategoryID = model.CategoryID,
                Product_Description = model.Product_Description
            };
        }

        private ProductUpdateSubmissionModel PrepareProductUpdateSubmissionModel(ProductViewModel model)
        {
            return new ProductUpdateSubmissionModel
            {
                Id = model.Id,
                Product_Name = model.Product_Name,
                Unit = model.Unit,
                PricePerUnit = model.PricePerUnit,
                FurnitorID = model.FurnitorID,
                CompanyName = model.CompanyName,
                CategoryID = model.CategoryID,
                Product_Description = model.Product_Description
            };
        }
        #endregion
    }
}