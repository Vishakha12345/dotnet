using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

using BLL;


namespace EComWFE.Controllers
{
    public class AccountController : Controller
    {
        //http://localhost:3434/account/login
        // GET: Account
       //
       //Perform Action for incomming GET request
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
       
        public ActionResult Login(string userName, string password,string returnUrl)
        {
            //if(userName =="ravi" && password == "seed")
            // if(AccountManager.Validate(userName, password))


            #region  Invoke asmx web service

            /* ServiceReference1.HelloServiceSoapClient proxy = new ServiceReference1.HelloServiceSoapClient();
             if(proxy.Validate(userName,password))

             { 
                 // return   this.RedirectToAction("index", "products");
                 FormsAuthentication.SetAuthCookie(userName, false);
                 return Redirect(returnUrl ?? Url.Action("Index", "Home"));
             }
             else
             {
                 return View();
             }  

     */

            #endregion

            WCFAuthSVCReference.AuthServiceClient wcfProxy = new WCFAuthSVCReference.AuthServiceClient();

            bool status = false;
            status=wcfProxy.Validate(userName, password);
            if (status)
            {
                // return   this.RedirectToAction("index", "products");
                FormsAuthentication.SetAuthCookie(userName, false);
                return Redirect(returnUrl ?? Url.Action("Index", "Home"));
            }
            else
            {
                return View();
            }
        }


        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public  ActionResult Register(string firstname, string lastname, string email)
        {
            return View();
        }
    }
}