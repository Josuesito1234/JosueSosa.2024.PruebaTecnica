using JosueSosa._2024.PruebaTecnica.BL;
using JosueSosa._2024.PruebaTecnica.EN;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JosueSosa._2024.PruebaTecnica.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: CategoriaController
        public async Task<ActionResult> Index()
        {
            var prod = await CategoriaBL.GetAll();
            return View(prod);
        }

        // GET: CategoriaController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var prod = await CategoriaBL.GetById(id);
            return View(prod);
        }

        // GET: CategoriaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Categoria Categoria)
        {
            if (ModelState.IsValid)
            {
                var prod = await CategoriaBL.Create(Categoria);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: CategoriaController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var prod = await CategoriaBL.GetById(id);
            return View(prod);
        }

        // POST: CategoriaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Categoria Categoria)
        {
            try
            {
                var prod = await CategoriaBL.Update(Categoria);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriaController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var prod = await CategoriaBL.GetById(id);
            return View(prod);
        }

        // POST: CategoriaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Categoria Categoria)
        {
            try
            {
                var prod = await CategoriaBL.Delete(Categoria);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}   

