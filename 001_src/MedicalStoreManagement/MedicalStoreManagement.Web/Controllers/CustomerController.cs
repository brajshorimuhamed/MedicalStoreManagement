using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MedicalStoreManagement.Application.Customers;
using MedicalStoreManagement.Application.Products;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Web.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStoreManagement.Web.Controllers
{
    public class CustomerController : Controller
    {
        #region Properties
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly IHostingEnvironment _hostingEnvironment;
        #endregion

        #region Constructor
        public CustomerController(ICustomerService customerService, IProductService productService, IHostingEnvironment hostingEnvironment)
        {
            _customerService = customerService;
            _productService = productService;
            _hostingEnvironment = hostingEnvironment;
        }
        #endregion

        #region View
        // GET: Customer
        public IActionResult Index()
        {
            return View(new CustomerViewModel());
        }

        public async Task<IActionResult> DeleteCustomer(int customerId)
        {
            await _customerService.DeleteCustomer(customerId);
            return RedirectToAction("Index", "Customer");
        }

        public IActionResult AddCustomer()
        {
            var model = new CustomerViewModel();
            model.Products = _productService.GetProducts().Result;
            return View(model);
        }

        public IActionResult Details(CustomerViewModel model, int customerId)
        {
            model.Customers = _customerService.GetCustomersById(customerId).Result;
            model.Products = _productService.GetProducts().Result;
            return View(model);
        }

        public IActionResult EditCustomer(CustomerViewModel model, int customerId)
        {
            model.Customers = _customerService.GetCustomersById(customerId).Result;
            model.Products = _productService.GetProducts().Result;
            return View(model);
        }
        #endregion

        #region Add Customer
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCustomer(CustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Recepts == null)
                {
                    await _customerService.AddCustomer(PrepareCustomerSubmissionModel(model));

                    return RedirectToAction("Index", "Customer");
                    // return View(model);
                }
                
                else
                {
                    await _customerService.AddCustomer(PrepareCustomerSubmissionModel(model));

                    return RedirectToAction("Index", "Customer");
                    //return View(model);
                }
            }

            return View();
        }
        #endregion

        private string UploadFiles(CustomerViewModel model)
        {
            string uniqueFileName = null;

            if (model.Recepts != null)
            {
                string uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "ImageAsset");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Recepts.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Recepts.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        #region Edit Customer
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCustomer(CustomerViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _customerService.UpdateCustomer(PrepareCustomerUpdateSubmissionModel(model));
            return RedirectToAction("Index", "Customer");
            //return View(model);
        }
        #endregion

        #region Private Methods
        private CustomerSubmissionModel PrepareCustomerSubmissionModel(CustomerViewModel model)
        {
            string uniqueFileName = UploadFiles(model);
            return new CustomerSubmissionModel
            {
                Recepts = uniqueFileName,
                ProductID = model.ProductID
            };
        }

        private CustomerUpdateSubmissionModel PrepareCustomerUpdateSubmissionModel(CustomerViewModel model)
        {
            return new CustomerUpdateSubmissionModel
            {
                Id = model.Id,
                Recepts = model.Recepts.ToString(),
                ProductID = model.ProductID
            };
        }
        #endregion
    }
}