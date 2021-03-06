using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicalStoreManagement.Application.Furnitors;
using MedicalStoreManagement.Domain._DTO;
using MedicalStoreManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStoreManagement.Web.Controllers
{
    public class FurnitorController : Controller
    {
        #region Properties
        private readonly IFurnitorService _furnitorService;
        #endregion

        #region Constructor
        public FurnitorController(IFurnitorService furnitorService)
        {
            _furnitorService = furnitorService;
        }
        #endregion

        #region View
        // GET: Furnitor
        public IActionResult Index()
        {
            return View(new FurnitorViewModel());
        }

        public IActionResult DeleteFurnitor(int furnitorId)
        {
            _furnitorService.DeleteFurnitor(furnitorId);

            return RedirectToAction("Index", "Furnitor");
        }

        [HttpGet]
        public IActionResult AddFurnitor()
        {
            return View();
        }

        public IActionResult Details(FurnitorViewModel model, int furnitorId)
        {
            model.LoadData(furnitorId);
            return View(model);
        }

        public IActionResult EditFurnitor(FurnitorViewModel model, int furnitorId)
        {
            model.LoadData(furnitorId);
            return View(model);
        }
        #endregion

        #region Add Furnitor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddFurnitor(FurnitorViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _furnitorService.AddFurnitor(PrepareFurnitorSubmissionModel(model));
            return RedirectToAction("Index", "Furnitor");
            //return View(model);
        }
        #endregion

        #region Edit Furnitor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditFurnitor(FurnitorViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            await _furnitorService.UpdateFurnitor(PrepareFurnitorUpdateSubmissionModel(model));
            return RedirectToAction("Index", "Furnitor");
            //return View(model);
        }
        #endregion

        #region Private Methods
        private FurnitorSubmissionModel PrepareFurnitorSubmissionModel(FurnitorViewModel model)
        {
            return new FurnitorSubmissionModel
            {
                Furnitor_FirstName = model.Furnitor_FirstName,
                Furnitor_LastName = model.Furnitor_LastName,
                Furnitor_NrPhone = model.Furnitor_NrPhone,
                Furnitor_Email = model.Furnitor_Email,
                Furnitor_Address = model.Furnitor_Address
            };
        }

        private FurnitorUpdateSubmissionModel PrepareFurnitorUpdateSubmissionModel(FurnitorViewModel model)
        {
            return new FurnitorUpdateSubmissionModel
            {
                Id = model.Id,
                Furnitor_FirstName = model.Furnitor_FirstName,
                Furnitor_LastName = model.Furnitor_LastName,
                Furnitor_NrPhone = model.Furnitor_NrPhone,
                Furnitor_Email = model.Furnitor_Email,
                Furnitor_Address = model.Furnitor_Address
            };
        }
        #endregion
    }
}