using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCUserRole.WebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin;
using Owin;

namespace MVCUserRole.WebMVC.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        public ActionResult Index()
        {
            UserController u = new UserController();
            
            if (User.Identity.IsAuthenticated)
            {
                if (!u.isAdminUser())
                    {
                    return RedirectToAction("Index", "Home");
                    }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            ApplicationDbContext context = new ApplicationDbContext();

            var Roles = context.Roles.ToList();
            return View(Roles);
        }
    }
}