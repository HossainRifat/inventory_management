using Inventory_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory_Management.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            User user = new User();
            user.Username = "admin";

            return View(user);
        }

        // POST: Auth
        [HttpPost]
        public ActionResult Login(User user)
        {
            User demoUser = new User();
            demoUser.Username = "admin";
            demoUser.Password = "12345678";
            demoUser.Role = Roles.Admin;

            if(demoUser.Username == user.Username && demoUser.Password == user.Password)
            {
                Session["username"] = demoUser.Username;
                Session["role"] = demoUser.Role;
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.error = "Invalid username or password!";
                return View("Index");
            }
        }

        // GET: Auth
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }

    }
}