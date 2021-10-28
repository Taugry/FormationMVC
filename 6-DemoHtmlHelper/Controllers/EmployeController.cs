using _6_DemoHtmlHelper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6_DemoHtmlHelper.Controllers
{
    public class EmployeController : Controller
    {
        // GET: Eploye
        public ActionResult Index()
        {
            List<Departement> deps = new List<Departement>()
            {
                new Departement{DepartementId=1, Nom="Informatique"},
                new Departement{DepartementId=2, Nom="Recherche"},
                new Departement{DepartementId=3, Nom="Developpement"}
            };
            SelectList sl = new SelectList(deps, "DepartementId", "Nom");
            TempData["DepartementId"] = sl;
            TempData.Keep();

            Employe emp = new Employe()
            {
                Id = 1,
                Nom = "Dawan",
                Salaire = 1000,
                IsActif = true,
                Email = "employe@dawan.fr",
                DateEntree = DateTime.Now,
                Type = EmployeType.JUNIOR
            };

            return View(emp);
        }

        [HttpPost]
        public ActionResult Index(Employe emp)
        {
            emp.Nom = "Toto";

            //pour mettre ajour les conetenu du model par une action, ici l'action index, il faut d'abord vider
            //ce que l'on appel le modelstate
            //le ModelState contient l'etat du model
            //le ModelState est utiliser pour valider le formulaire cote serveur
            //ModelState a ddeux objectif : stocker les valeurs soumises au serveur
            //et stocker les erreurs de validations associees a ces valeurs
            //
            ModelState.Clear();
            emp.Nom = "TaTa";

            return View(emp);
        }
    }
}