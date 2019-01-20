using System.Web.Mvc;
using MisGastos.Entities.App;

namespace MisGastos.Controllers
{
    public abstract class CommonController : Controller
    {
        public UsuarioSession UsuarioSession
        {
            get => System.Web.HttpContext.Current.Session["UsuarioSession"] as UsuarioSession;
            set => System.Web.HttpContext.Current.Session["UsuarioSession"] = value;
        }
    }
}
