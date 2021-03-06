using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalStoreManagement.Application.CustomerPivots;
using MedicalStoreManagement.Application.Products;
using MedicalStoreManagement.Application.SalePivots;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStoreManagement.Web.Controllers
{
    public class SalePivotController : Controller
    {
        #region Properties
        private readonly ISalePivotService _salePivotService;
        private readonly IProductService _productService;
        private readonly ICustomerPivotService _customerPivotService;
        #endregion

        #region Constructor
        public SalePivotController(ISalePivotService salePivotService, IProductService productService, ICustomerPivotService customerPivotService)
        {
            _salePivotService = salePivotService;
            _productService = productService;
            _customerPivotService = customerPivotService;
        }
        #endregion

        #region View
        public IActionResult Index()
        {
            return View(new SalePivotViewModel());
        }

        public async Task<IActionResult> DeleteSalePivot(int salePivotId)
        {
            await _salePivotService.DeleteSalePivot(salePivotId);

            return RedirectToAction("Index", "SalePivot");
        }

        [HttpGet]
        public IActionResult AddSalePivot()
        {
            var model = new SalePivotViewModel();
            model.Products = _productService.GetProducts().Result;
            model.CustomerPivots = _customerPivotService.GetCustomerPivots().Result;
            return View(model);
        }

        public IActionResult Details(SalePivotViewModel model, int salePivotId)
        {
            model.LoadData(salePivotId);
            model.Products = _productService.GetProducts().Result;
            model.CustomerPivots = _customerPivotService.GetCustomerPivots().Result;
            return View(model);
        }

        public IActionResult EditSalePivot(SalePivotViewModel model, int salePivotId)
        {
            model.LoadData(salePivotId);
            model.Products = _productService.GetProducts().Result;
            model.CustomerPivots = _customerPivotService.GetCustomerPivots().Result;
            return View(model);
        }
        #endregion

        #region Add SalePivot
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSalePivot(SalePivotViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _salePivotService.AddSalePivot(PrepareSalePivotSubmissionModel(model));
            return RedirectToAction("Index", "SalePivot");
            // return View(model);
        }
        #endregion

        #region Edit CustomerPivot
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSalePivot(SalePivotViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _salePivotService.UpdateSalePivot(PrepareSalePivotUpdateSubmissionModel(model));
            return RedirectToAction("Index", "SalePivot");
            // return View(model);
        }
        #endregion

        #region Private Methods
        private SalePivotSubmissionModel PrepareSalePivotSubmissionModel(SalePivotViewModel model)
        {
            return new SalePivotSubmissionModel
            {
                ProductID = model.ProductID,
                Quantity = model.Quantity,
                Price = model.Price,
                CustomerPivotID = model.CustomerPivotID
            };
        }

        private SalePivotUpdateSubmissionModel PrepareSalePivotUpdateSubmissionModel(SalePivotViewModel model)
        {
            return new SalePivotUpdateSubmissionModel
            {
                Id = model.Id,
                ProductID = model.ProductID,
                Quantity = model.Quantity,
                Price = model.Price,
                CustomerPivotID = model.CustomerPivotID
            };
        }
        #endregion
    }
}