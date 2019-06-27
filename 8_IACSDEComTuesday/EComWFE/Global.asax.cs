using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BOL;
using BLL;

namespace EComWFE
{
    public class MvcApplication : System.Web.HttpApplication
    {

        //Application life cycle hooks ( event handlers, listeners)
        protected void Application_Start()
        {
            List<Product> products = new List<Product>();
            products = RepoManager.GetAllProducts();
            this.Application["products"] = products;

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        protected void Application_End() {
        }
        protected void Session_Start()
        {

            ShoppingCart theCart = new ShoppingCart();
            this.Session.Add("cart", theCart);

        }
        protected void Session_End()
        {
            this.Session.Abandon();

        }

        protected void Application_AuthenticateRequest()
        {
        }

        protected void Application_Error()
        {

        }

    }
}
