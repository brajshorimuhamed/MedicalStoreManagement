using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalStoreManagement.Application.CustomerPivots;
using MedicalStoreManagement.Application.Products;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStoreManagement.Web.Controllers
{
    public class CustomerPivotController : Controller
    {
        #region Properties
        private readonly ICustomerPivotService _customerPivotService;
        private readonly IProductService _productService;
        #endregion

        #region Constructor
        public CustomerPivotController(ICustomerPivotService customerPivotService, IProductService productService)
        {
            _customerPivotService = customerPivotService;
            _productService = productService;
        }
        #endregion

        #region View
        // GET: CustomerPivot
        public IActionResult Index()
        {
            return View(new CustomerPivotViewModel());
        }

        public IActionResult DeleteCustomerPivot(int customerPivotId)
        {
            _customerPivotService.DeleteCustomerPivot(customerPivotId);

            return RedirectToAction("Index", "CustomerPivot");
        }

        [HttpGet]
        public IActionResult AddCustomerPivot()
        {
            var model = new CustomerPivotViewModel();
            model.Products = _productService.GetProducts().Result;
            return View(model);
        }

        public IActionResult Details(CustomerPivotViewModel model, int customerPivotId)
        {
            model.LoadData(customerPivotId);
            model.Products = _productService.GetProducts().Result;
            return View(model);
        }

        public IActionResult EditUpdate(CustomerPivotViewModel model, int customerPivotId)
        {
            model.LoadData(customerPivotId);
            model.Products = _productService.GetProducts().Result;
            return View(model);
        }
        #endregion

        #region Add CustomerPivot
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCustomerPivot(CustomerPivotViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _customerPivotService.AddCustomerPivot(PrepareCustomerPivotSubmissionModel(model));
            return RedirectToAction("Index", "CustomerPivot");
            // return View(model);
        }
        #endregion

        #region Edit Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUpdate(CustomerPivotViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _customerPivotService.UpdateCustomerPivot(PrepareCustomerPivotUpdateSubmissionModel(model));
            return RedirectToAction("Index", "CustomerPivot");
            // return View(model);
        }
        #endregion

        #region Private Methods
        private CustomerPivotSubmissionModel PrepareCustomerPivotSubmissionModel(CustomerPivotViewModel model)
        {
            return new CustomerPivotSubmissionModel
            {
                Research = model.Research,
                ProductID = model.ProductId,
                ProductStatus = model.ProductStatus
            };
        }

        private CustomerPivotUpdateSubmissionModel PrepareCustomerPivotUpdateSubmissionModel(CustomerPivotViewModel model)
        {
            return new CustomerPivotUpdateSubmissionModel
            {
                Id = model.Id,
                Research = model.Research,
                ProductID = model.ProductId,
                ProductStatus = model.ProductStatus
            };
        }
        #endregion
    }
}