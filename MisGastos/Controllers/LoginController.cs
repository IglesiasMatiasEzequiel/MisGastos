using System.Web.Mvc;

namespace MisGastos.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}