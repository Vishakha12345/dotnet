using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BLL;
using BOL;

namespace Crud1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username, string password, string returnurl)
        {
            if (AccountManager.Validate(username, password))
            {
              FormsAuthentication.SetAuthCookie(username, false);
                return Redirect(returnurl ?? Url.Action("Msg", "Home"));
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
        public ActionResult Register(int id,string name,string city,string password,string returnurl)
        {
            if(AccountManager.insert(id,name,city,password))
            {
                return Redirect(returnurl ?? Url.Action("Msg", "Home"));

            }
            else
            {
                return View();
            }


        }
        public ActionResult update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult update(int id,string city,string returnurl)
        {
            if(AccountManager.update(id,city))
            {
                return Redirect(returnurl ?? Url.Action("Msg", "Home"));
            }
            else
            {
                return View();
            }

        }
        public ActionResult delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult delete(int id,string returnurl)
        {
            if(AccountManager.delete(id))
            {
                return Redirect(returnurl ?? Url.Action("Msg", "Home"));
            }
            else
            {
                return View();
            }
        }
        public ActionResult list()
        {
            var clist = AccountManager.getcust();
            this.ViewData["custlist"]=clist;
            return View(clist);
        }
    }
}