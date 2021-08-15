using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealsourceMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Customers()
        {
            return View();
        }

        public ActionResult Orders()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Experts()
        {
            return View();
        }
    }
}