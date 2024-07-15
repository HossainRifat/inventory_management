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
        public ActionResult Login()
        {
            User user = new User();
            user.Username = "admin";

            ViewBag.subModule = "Login";

            return View(user);
        }

        // POST: Auth
        [HttpPost]
        //use FormCollection
        public ActionResult Login(User user)
        {

            User loggedUser = new User();
            loggedUser = user.Login(user.Username, user.Password);

            if (loggedUser != null)
            {
                Session["username"] = loggedUser.Username;
                Session["userid"] = loggedUser.Id;
                Session["role"] = loggedUser.Role;

                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.subModule = "Login";
                ViewBag.Error = "Invalid Username or Password";
                return View(user);
            }

        }

        // GET: Auth
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

    }
}