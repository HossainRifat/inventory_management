using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_Management.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            if (Session["username"] == null || Session["role"] == null)
            {
                return RedirectToAction("Index", "Auth");
            }

            return View();
        }
    }
}