using MisGastos.Entities;
using System;
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
        public ActionResult Login(LoginModel model)
        {
            if (model == null)
            {
                throw new Exception("El modelo es nulo.");
            }

            if (string.IsNullOrEmpty(model.Username))
            {
                ModelState.AddModelError("Error", "El nombre de usuario no puede ser vacío.");
            }

            if (string.IsNullOrEmpty(model.Password))
            {
                ModelState.AddModelError("Error", "La contraseña no puede ser vacía.");
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Login", model);
            }
        }
    }
}