using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inventory_Management.Models;
using Inventory_Management.ViewModels;

namespace Inventory_Management.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            if (Session["username"] == null || Session["role"] == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            User user = new User();
            DashboardViewModel dashboardData = new DashboardViewModel();
            dashboardData.UserList = user.UserList();

            ViewBag.module = "Dashboard";
            ViewBag.subModule = "Dashboard";
            ViewBag.moduleURL = Url.Action("Index", "Dashboard");
            //ViewBag.btnText = "Add New";
            //ViewBag.btnURL = Url.Action("Create", "Dashboard");
            //ViewBag.btnType = "create";

            return View(dashboardData);
        }

    }
}