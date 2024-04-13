using Microsoft.AspNetCore.Mvc;

namespace StoringPassword.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if(HttpContext.Session.GetString("LastName") != null
                && HttpContext.Session.GetString("FirstName") != null)
                return View();
            else
                return RedirectToAction("Login", "Account");
        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
    }
}