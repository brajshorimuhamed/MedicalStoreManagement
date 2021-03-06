using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MedicalStoreManagement.Web.Controllers
{
    public class BillingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}