using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _1_DemoMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /* 
            * les ligne 16-20 definissent la forme des urls acceptees par l'application
            * on appelle cela une route
            * il peut y avoir plusieur route possibles(plusieur model d'urls sont possibles)
            * 
            * {controller} => par convention si l'url est /X/Y/Z le controleur charge de traiter cette url sera la classe XControler
            * le suffix controler es t ajouter au nom du controler present dans l'url
            * 
            * {action} => c'est le nom d'une methode dans le controleur
            * c'est elle qui vas recevoir les paramtres qui accompagne l'url et appel la couche service pour faire le traitement 
            * 
            * {id} => un paramètre qui sera transmis à l'action. Pour cela l'action devra avoir un paramètre nommé id.
            */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "RouteSomme",
                url: "{controller}/{action}/{nb1}/{nb2}",
                defaults: new { controller = "Home", action = "Index", nb1 = UrlParameter.Optional, nb2 = UrlParameter.Optional }
            );
        }
    }
}
