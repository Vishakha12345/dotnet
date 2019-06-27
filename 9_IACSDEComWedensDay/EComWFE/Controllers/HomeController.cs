
using System.Web.Mvc;

namespace EComWFE.Controllers
{
    public class HomeController : Controller
    {    //controller is a special kind of class
        //consist of action methods
        //action methods are mapped with HTTP verbs
        //such as GET, POST, PUT, PATCH, DELETE

        // GET: Home
        public ActionResult Index()
        {   string message = "Welcome to ECommerce !";
            return View();
        }

        public ActionResult Products()
        {
            string message = "Welcome to Our product catalog !";
            return View();
        }
        public ActionResult Services()
        {
            string message = "Welcome to our Services !";
            return View();
        }
        public ActionResult Support()
        {
            string message = "Welcome to Support Center !";
            return View();
        }
       
        public ActionResult Aboutus()
        {
            string owner = "Ravi Tambade";
           // string organization = "Transflower";
           // string location = "Pune Satara Road";

            return View();
        }
       //action method

           
        public ActionResult Dashboard()
        {
            return View();
        }

        [Authorize(Users ="ravi")]
        public ActionResult Chart()
        {
            return View();
        }
    }
}