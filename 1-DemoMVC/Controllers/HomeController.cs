using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1_DemoMVC.Controllers
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

        public ActionResult Somme(int nb1, int nb2)
        {
            int result = nb1 + nb2;
            //ViewBag permet de transferer des données du controleir vers la vue
            //ces données ne sont pas inclus dans le model
            ViewBag.Somme = result;
            return View();
            
        }
    }
}