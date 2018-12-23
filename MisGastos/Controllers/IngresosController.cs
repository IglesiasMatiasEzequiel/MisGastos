using System.Web.Mvc;

namespace MisGastos.Controllers
{
    public class IngresosController : Controller
    {
        // GET: Ingresos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Ingresos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ingresos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ingresos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ingresos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ingresos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ingresos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ingresos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
