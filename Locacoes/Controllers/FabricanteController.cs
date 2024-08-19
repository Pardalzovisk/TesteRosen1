using Locacoes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Locacoes.Controllers
{
    public class FabricanteController : Controller
        
    {
        private static List<Fabricante> Fabricantes = new List<Fabricante>()
        {
            new Fabricante()
            {
                Id = 1,
                Nome = "BYD",
                Pais = "China"
            },
            new Fabricante()
            {
                Id=2,
                Nome = "Volvo",
                Pais = "Alemanha"
            }
        };
        // GET: FabricanteController
        public ActionResult Index()
        {
            return View(Fabricantes);
        }

        // GET: FabricanteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FabricanteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FabricanteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FabricanteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FabricanteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FabricanteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FabricanteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
