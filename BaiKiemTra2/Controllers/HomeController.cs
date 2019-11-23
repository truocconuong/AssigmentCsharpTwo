using BaiKiemTra2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiKiemTra2.Controllers
{
    public class HomeController : Controller
    {
        private BaiKiemTra2Context db = new BaiKiemTra2Context();
        public ActionResult Index()
        {
            var model = db.Products.ToList();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}