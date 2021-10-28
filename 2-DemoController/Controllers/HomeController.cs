using _2_DemoController.Models;
using _2_DemoController.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _2_DemoController.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // 1- une action peut retourner une autre vue
            //return View("Contact");

            // 2- elle permet d'envoyer au client un ordre de redirection vers l'url qui est
            // dans le parametres de la methode
            //return Redirect("/Home/Index");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            // 3- en utilisant la methode RedirectToAction, l'action about retourne
            // un type RedirectToRouteResult
            //return RedirectToAction("Index", "Test", new { nom = "Dawan", prenom = "Jehan" });

            return View();
            //return RedirectToRoute("ContactDetails"); // 4
            //return File(Server.MapPath("~/Demo.txt"), "test/plain", "test.txt"); // 5
        }

        public ActionResult Contact()
        {
            //6 la mathode content retoure un type contentresult
            // elle se sontente de rendre une chaine de caractere a l'aide de la methode content
            //return Content("Ceci est le contenu de l'action");

            //7 on peut retourner une autre chaine de caractere de type xml en prenant une autre surcharge
            //return Content("<personne><nom>Dawan</nom><prenom>Jehann</prenom></personne>", "text/xml", Encoding.UTF8);

            //8 la methode JavaScript qui retourne un type javascriptresult elle renvoie un code javascript au client
            //return JavaScript("alert('Test de la methode return JavaScriptResult')");

            //9 la methode Json retoure un type jsonresult au client
            //Personne p = new Personne { Nom = "Dawan", Prenom = "Jehann" };
            //return Json(p, JsonRequestBehavior.AllowGet);

            // 10 pour telecharger le fichier JSON on fait appel a la methode file
            /*string str = MyJsonTools.ToJson<Personne>(p);
            byte[] contenu = Encoding.UTF8.GetBytes(str);
            return File(contenu, "Application/Json", "Personne.json");*/

            // 11 la methode qui retourene u type hhtpstatusCoderesult
            //return HttpNotFound();

            //12 on peut initialiser une nouvelle instance de la classe httpstatuscoderesult
            // a l'aide d'un code stauts (code http) et d'une description de l'etat
            //return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Mauvaise requette");

            //13 httpunhautorizerresult
            //return new HttpUnauthorizedResult();
            
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}