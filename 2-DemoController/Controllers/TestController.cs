using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_DemoController.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string Index(string nom, string prenom)
        {
            // on put cree une action avec un result de type string
            return "Nom : " + nom +" Prenom : " + prenom;
        }
    }
}