using _5_DemoVuesRazo.Models;
using _5_DemoVuesRazo.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5_DemoVuesRazo.Controllers
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
            Employe emp = new Employe() { Id = 1, Nom = "Dawan", Prenom = "Jehann" };
            Produit prod = new Produit() { Id = 1, Prix = 25 };

            ProdEmploye pe = new ProdEmploye();
            pe.produit = prod;
            pe.employe = emp;

            //return View(emp);
            return View(pe);
        }
    }
}