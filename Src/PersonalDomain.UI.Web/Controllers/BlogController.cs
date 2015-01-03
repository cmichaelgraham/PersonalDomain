using System.Web.Mvc;

namespace PersonalDomain.UI.Web
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "James Chadwick";
            return View();
        }
    }
}