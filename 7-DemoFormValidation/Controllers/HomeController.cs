using _7_DemoFormValidation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7_DemoFormValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Employe emp = new Employe();
            return View(emp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Exclude = "Photo")] Employe emp, HttpPostedFileBase photo)
        {
            //HttpPostedFileBase : cette classe permetra de telecharger un ficher, ici nootre photo charger par le client
            //Verifier l'extension du fichier photo
            string extension = Path.GetExtension(photo.FileName);
            if (ModelState.IsValid)
            {
                if (extension.Equals(".png") || extension.Equals(".jpg") || extension.Equals(".jpeg"))
                {
                
                    string fileName = emp.UserName + extension; //personaliser le nom de la photo
                    emp.Photo = fileName;
                    string path = Server.MapPath("~/Content/Photos/" + fileName); // /Content/Photos/toto.jpg  avec username toto
                    photo.SaveAs(path);
                }
                else
                {
                    return Content("L'extension de la photo doit etre : .png ou .jpg ou .jpeg");
                }

                //on retourne dans la vue contact le model emp
                return View("Contact", emp);
            }

            return View(emp);
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