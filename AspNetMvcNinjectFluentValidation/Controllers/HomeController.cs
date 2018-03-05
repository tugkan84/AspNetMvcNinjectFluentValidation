using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcNinjectFluentValidation.Models;

namespace AspNetMvcNinjectFluentValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult GetProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return Json("Hata", JsonRequestBehavior.AllowGet);
            }

            return View();
        }

    }
}