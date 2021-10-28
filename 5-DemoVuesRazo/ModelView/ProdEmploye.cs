using _5_DemoVuesRazo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5_DemoVuesRazo.ModelView
{
    public class ProdEmploye
    {
        public Employe employe { get; set; }
        public Produit produit { get; set; }
    }
}