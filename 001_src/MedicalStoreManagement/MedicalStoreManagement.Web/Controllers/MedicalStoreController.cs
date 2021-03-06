using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStoreManagement.Web.Controllers
{
    public class MedicalStoreController : Controller
    {
        #region Constructor
        public MedicalStoreController()
        {

        }
        #endregion

        #region View
        // Get: MedicalStore
        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated) return RedirectToAction("Login", "Account");

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        #endregion
    }
}