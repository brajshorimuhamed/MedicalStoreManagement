using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MedicalStoreManagement.Application.Inventories;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Web.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStoreManagement.Web.Controllers
{
    public class InventoryController : Controller
    {
        #region Properties
        private readonly IInventoryService _inventoryService;
        private readonly IHostingEnvironment hostingEnvironment;
        #endregion

        #region Constructor
        public InventoryController(IInventoryService inventoryService, IHostingEnvironment _hostingEnvironment)
        {
            _inventoryService = inventoryService;
            hostingEnvironment = _hostingEnvironment;
        }
        #endregion

        #region View
        public IActionResult Index()
        {
            return View(new InventoryViewModel());
        }

        public async Task<IActionResult> DeleteInventory(int inventoryId)
        {
            await _inventoryService.DeleteInventory(inventoryId);

            return RedirectToAction("ListInventory", "Inventory");
        }
        
        public IActionResult ListInventory()
        {
            return View(new InventoryViewModel());
        }
        
        [HttpGet]
        public IActionResult AddInventory()
        {
            return View();
        }
        #endregion

        #region Add Inventory
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddInventory(InventoryViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _inventoryService.AddInventory(PrepareInventorySubmissionModel(model));
            return RedirectToAction("Index", "Inventory");
            //return View(model);

        }
        #endregion

        private string UploadFiles(InventoryViewModel model)
        {
            string uniqueFileName = null;

            if (model.ImageName != null)
            {
                string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "ImageAsset");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageName.FileName;
                string filePath = Path.Combine(uploadFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageName.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        #region Private Methods
        private InventorySubmissionModel PrepareInventorySubmissionModel(InventoryViewModel model)
        {
            string uniqueFileName = UploadFiles(model);
            return new InventorySubmissionModel
            {
                Inventory_Name = model.Inventory_Name,
                ImageName = uniqueFileName
            };
        }
        #endregion
    }
}