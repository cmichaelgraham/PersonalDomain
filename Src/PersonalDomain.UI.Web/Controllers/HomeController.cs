using System.Web.Mvc;

namespace PersonalDomain.UI.Web
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
    }
}