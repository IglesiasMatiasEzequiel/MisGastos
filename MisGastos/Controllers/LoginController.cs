using MisGastos.Entities;
using System;
using System.Web.Mvc;
using MisGastos.Entities.App;
using MisGastosRepository;
using MisGastosRepository.Business;


namespace MisGastos.Controllers
{
    public class LoginController : CommonController
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            UsuariosBusiness usuariosBusiness = new UsuariosBusiness();

            if (model == null)
            {
                throw new Exception("El modelo es nulo.");
            }

            #region [Región: Validaciones]

            if (string.IsNullOrEmpty(model.Username))
            {
                ModelState.AddModelError("Error", "El nombre de usuario no puede ser vacío.");
            }

            if (string.IsNullOrEmpty(model.Password))
            {
                ModelState.AddModelError("Error", "La contraseña no puede ser vacía.");
            }

            #endregion

            #region [Región: Validación de Usuario/Contraseña]

            if (!string.IsNullOrEmpty(model.Username) && !string.IsNullOrEmpty(model.Password))
            {
                Usuario usuario = usuariosBusiness.ValidarUsuario(model.Username, model.Password);

                if (usuario != null)
                {
                    UsuarioSession = new UsuarioSession
                    {
                        Usuario = usuario,
                        FechaIngreso = DateTime.Now
                    };
                }
                else
                {
                    ModelState.AddModelError("Error", "Usuario inexistente y/o contraseña incorrecta.");
                }
            }

            #endregion

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            
            return View("Login", model);
        }
    }
}