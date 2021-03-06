using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalStoreManagement.Application.Furnitors;
using MedicalStoreManagement.Application.Products;
using MedicalStoreManagement.Application.Purchases;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStoreManagement.Web.Controllers
{
    public class PurchaseController : Controller
    {
        #region Properties
        private readonly IPurchaseService _purchaseService;
        private readonly IProductService _productService;
        private readonly IFurnitorService _furnitorService;
        #endregion

        #region Constructor
        public PurchaseController(IPurchaseService purchaseService, IProductService productService, IFurnitorService furnitorService)
        {
            _purchaseService = purchaseService;
            _productService = productService;
            _furnitorService = furnitorService;
        }
        #endregion

        #region View
        // GET: Purchase
        public IActionResult Index()
        {
            return View(new PurchaseViewModel());
        }

        public async Task<IActionResult> DeletePurchase(int purchaseId)
        {
            await _purchaseService.DeletePurchase(purchaseId);

            return RedirectToAction("Index", "Purchase");
        }

        public IActionResult AddPurchase()
        {
            var model = new PurchaseViewModel();
            model.Products = _productService.GetProducts().Result;
            model.Furnitors = _furnitorService.GetFurnitors().Result;
            return View(model);
        }

        public IActionResult Details(PurchaseViewModel model, int purchaseId)
        {
            model.LoadData(purchaseId);
            model.Products = _productService.GetProducts().Result;
            model.Furnitors = _furnitorService.GetFurnitors().Result;
            return View(model);
        }

        public IActionResult EditPurchase(PurchaseViewModel model, int purchaseId)
        {
            model.LoadData(purchaseId);
            model.Products = _productService.GetProducts().Result;
            model.Furnitors = _furnitorService.GetFurnitors().Result;
            return View(model);
        }
        #endregion

        #region Add Purchase
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPurchase(PurchaseViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _purchaseService.AddPurchase(PreparePurchaseSubmissionModel(model));
            return RedirectToAction("Index", "Purchase");
            //return View(model);
        }
        #endregion

        #region Edit Purchase
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPurchase(PurchaseViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _purchaseService.UpdatePurchase(PreparePurchaseUpdateSubmissionModel(model));
            return RedirectToAction("Index", "Purchase");
            //return View(model);
        }
        #endregion

        #region Private Methods
        private PurchaseSubmissionModel PreparePurchaseSubmissionModel(PurchaseViewModel model)
        {
            return new PurchaseSubmissionModel
            {
                ProductID = model.ProductID,
                Quantity = model.Quantity,
                Price = model.Price,
                FurnitorID = model.FurnitorID
            };
        }

        private PurchaseUpdateSubmissionModel PreparePurchaseUpdateSubmissionModel(PurchaseViewModel model)
        {
            return new PurchaseUpdateSubmissionModel
            {
                Id = model.Id,
                ProductID = model.ProductID,
                Quantity = model.Quantity,
                Price = model.Price,
                FurnitorID = model.FurnitorID
            };
        }
        #endregion
    }
}