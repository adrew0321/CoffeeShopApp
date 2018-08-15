using DailyLab21.Models;
using System.Web.Mvc;


namespace DailyLab21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult SignUp()
        {
            return View();
        }

        public ActionResult AddUser(UserInfo newUser)
        {
            //*To Do*: Validation
            if (ModelState.IsValid)
            {
                //*To Do*: Send the data to the DB

                //*To DO*: Confirmation or send to Index Page
                ViewBag.confirmation = "Thank you for signing up " + newUser.FirstName;

                return View("Confirmation");
            }
            else
            {
                return View("Error");

            }

        }
    }
}