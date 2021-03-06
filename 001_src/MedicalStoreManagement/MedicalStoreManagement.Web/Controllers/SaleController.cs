using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalStoreManagement.Application.CustomerPivots;
using MedicalStoreManagement.Application.Customers;
using MedicalStoreManagement.Application.Products;
using MedicalStoreManagement.Application.Sales;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStoreManagement.Web.Controllers
{
    public class SaleController : Controller
    {
        #region Properties
        private readonly ISaleService _saleService;
        private readonly IProductService _productService;
        private readonly ICustomerService _customerService;
        private readonly ICustomerPivotService _customerPivotService;
        #endregion

        #region Constructor
        public SaleController(ISaleService saleService, IProductService productService, ICustomerService customerService, ICustomerPivotService customerPivotService)
        {
            _saleService = saleService;
            _productService = productService;
            _customerService = customerService;
            _customerPivotService = customerPivotService;
        }
        #endregion

        #region View
        // Get: Sale
        public IActionResult Index()
        {
            return View(new SaleViewModel());
        }

        public async Task<IActionResult> DeleteSales(int saleId)
        {
            await _saleService.DeleteSales(saleId);

            return RedirectToAction("Index", "Sale");
        }

        [HttpGet]
        public IActionResult AddSales()
        {
            var model = new SaleViewModel();
            model.Products = _productService.GetProducts().Result;
            model.Customers = _customerService.GetCustomers().Result;
            return View(model);
        }

        public IActionResult Details(SaleViewModel model, int saleId)
        {
            model.LoadData(saleId);
            return View(model);
        }

        [HttpGet]
        public IActionResult EditSales(SaleViewModel model, int saleId)
        {
            model.LoadData(saleId);
            model.Products = _productService.GetProducts().Result;
            model.Customers = _customerService.GetCustomers().Result;
            return View(model);
        }
        #endregion

        #region Add Sales
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSales(SaleViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.CustomerID == 0)
            {
                await _saleService.AddSales(PrepareSaleSubmissionModel(model));

                return RedirectToAction("Index", "Sale");
                //return View(model);
            }
            
            await _saleService.AddSales(PrepareSaleSubmissionModel(model));

            return RedirectToAction("Index", "Sale");
            //return View(model);
        }
        #endregion

        #region Edit Sales
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSales(SaleViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _saleService.UpdateSales(PrepareSaleUpdateSubmissionModel(model));
            return RedirectToAction("Index", "Sale");
            //return View(model);
        }
        #endregion

        #region Private Methods
        private SaleSubmissionModel PrepareSaleSubmissionModel(SaleViewModel model)
        {
            return new SaleSubmissionModel
            {
                ProductID = model.ProductID,
                Quantity = model.Quantity,
                Price = model.Price,
                CustomerID = model.CustomerID
            };
        }

        private SaleUpdateSubmissionModel PrepareSaleUpdateSubmissionModel(SaleViewModel model)
        {
            return new SaleUpdateSubmissionModel
            {
                Id = model.Id,
                ProductID = model.ProductID,
                Quantity = model.Quantity,
                Price = model.Price,
                CustomerID = model.CustomerID
            };
        }
        #endregion
    }
}