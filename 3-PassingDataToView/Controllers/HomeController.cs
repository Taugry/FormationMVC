using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_PassingDataToView.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                ViewData["ID"] = id.Value;
                ViewBag.Id = id.Value;
                TempData["ID"] = id.Value;
            }
            else
            {
                ViewData["ID"] = 0;
                ViewBag.Id = 0;
                TempData["ID"] = 0;
            }
            
            TempData.Keep(); // permet de maintenir le contenu de tempData
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            TempData.Keep();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /*//GET
        public ActionResult Index()
        {
            return View();
        }*/

        [HttpPost]
        public ActionResult Index(string nom)
        {
            ViewBag.Nom = nom;
            return View();
        }
    }
}