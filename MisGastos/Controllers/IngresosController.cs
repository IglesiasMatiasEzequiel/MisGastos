using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MisGastos.Entities;
using MisGastos.Helpers;
using MisGastosRepository;
using MisGastosRepository.Business;

namespace MisGastos.Controllers
{
    public class IngresosController : CommonController
    {
        public ActionResult Ingresos()
        {
            IngresosBusiness ingresosBusiness = new IngresosBusiness();
            MonedasBusiness monedasBusiness = new MonedasBusiness();
            ConceptosIngresoBusiness conceptosIngresoBusiness = new ConceptosIngresoBusiness();

            List<Ingreso> ingresosUsuario = ingresosBusiness.ObtenerIngresosPorUsuario(UsuarioSession.GetIDUsuario).OrderByDescending(it => it.FechaIngreso).ToList();

            ViewBag.ComboMonedas = new SelectList(monedasBusiness.Listar(), "IdMoneda", "Descripcion");
            ViewBag.ComboConceptosIngreso = new SelectList(conceptosIngresoBusiness.Listar(), "IdConceptoIngreso", "Descripcion");

            return View(new M_Ingresos
            {
                Ingresos =  ingresosUsuario
            });
        }

        public ActionResult AltaIngreso(Ingreso nuevoIngreso)
        {
            IngresosBusiness ingresosBusiness = new IngresosBusiness();
            ingresosBusiness.Guardar(nuevoIngreso);

            return RedirectToAction("Ingresos");
        }
    }
}
