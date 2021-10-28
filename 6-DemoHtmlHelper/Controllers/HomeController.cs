using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_DemoHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //creation d'un ListItem qui seras afficher dans la vue, via un dropdownList(une liste deroulante)
            List<SelectListItem> formations = new List<SelectListItem>(){
                new SelectListItem(){Text="AST.NET", Value="1"},
                new SelectListItem(){Text="Java 2EE", Value="2"},
                new SelectListItem(){Text="Oracle", Value="3"}
            };
            ViewBag.Formations = formations;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult About(string nom)
        {
            ViewBag.Nom = nom;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Bonjour(string nom, string prenom, string poste, int formations)
        {
            List<SelectListItem> lstFormation = new List<SelectListItem>() {
                new SelectListItem(){Text="AST.NET", Value="1"},
                new SelectListItem(){Text="Java 2EE", Value="2"},
                new SelectListItem(){Text="Oracle", Value="3"}
            };

            return Content("Nom: " + nom + " Prenom: " + prenom + " Poste: " + poste + " Formation: " + lstFormation.ElementAt(formations - 1).Text);
        }
    }
}