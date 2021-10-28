using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace _4_DemoActionFilter.Filters
{
    public class LogFilter : ActionFilterAttribute
    {
        //creation d'un filte qui vas log les etapes de traitement d'un action du controleur
        //on va logger chaque etaê (methode trace), qui sera ensuite affiche dans le navigateur

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Trace("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Trace("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Trace("OnResultExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Trace("OnResultExecuting", filterContext.RouteData);
        }

        public void Trace(string methodName, RouteData routeData)
        {
            string actionName = null, controllerName = null;

            controllerName = routeData.Values["controller"].ToString();
            actionName = routeData.Values["action"].ToString();

            string str = string.Format("1- Méthode name = {0}, controller Name = {1}, action Name = {2}", methodName, controllerName, actionName);
            System.Diagnostics.Trace.WriteLine(str);

            //le contexte de l'application en cours
            HttpContext.Current.Response.Write("<br/>" + str + "<br/>");
        }
    }
}