using _4_DemoActionFilter.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace _4_DemoActionFilter.Controllers
{
    //2- 
    //[Authorize]
    public class HomeController : Controller
    {
        //3 - permet d'authoriser l'acces a des user non auth a des actions individulles
        //[AllowAnonymous]
        //4- ce filtre cache la sortie d'une action du controleur pendan t un certain temp
        //[OutputCache(Duration = 10)] // mise en cache du serveur pendant 10 seconde
        public ActionResult Index()
        {
            TempData["heure"] = DateTime.Now.ToLongTimeString();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(true)] // a true par defaut le framework prend en compte les attaque XSS
        public ActionResult Index(string demo)
        {
            ViewBag.Demo = demo;
            return View();
        }

        //1 - ce filtre gere les cas d'auhtorisation
        //[Authorize] //accesssible uniquement pour les user connecter
        [LogFilter]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //5- si l'action contact genere une erreur - ma page erreur globale sera afficher(error.cshtml)
        [HandleError]
        public ActionResult Contact()
        {
            throw new Exception("mon exxception");
            //return View();
        }
    }
}