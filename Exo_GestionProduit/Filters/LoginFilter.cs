using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Exo_GestionProduit.Filters
{
    public class LoginFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Session["user_id"] == null)
            {
                filterContext.HttpContext.Response.Redirect("~/Login/Index");
            }
        }
    }
}