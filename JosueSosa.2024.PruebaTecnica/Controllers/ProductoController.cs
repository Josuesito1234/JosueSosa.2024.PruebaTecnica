using JosueSosa._2024.PruebaTecnica.BL;
using JosueSosa._2024.PruebaTecnica.EN;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace JosueSosa._2024.PruebaTecnica.Controllers
{
    public class ProductoController : Controller
    {
        // GET: ProductoController
        public async Task<ActionResult> Index()
        {
            var prod = await ProductoBL.GetAll();
            return View(prod);
        }

        // GET: ProductoController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var prod = await ProductoBL.GetById(id);
            return View(prod);
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Producto producto)
        {
            try
            {
                var response = await ProductoBL.Create(producto);
                
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
            
        }
        

        // GET: ProductoController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var prod = await ProductoBL.GetById(id);
            return View(prod);
        }

        // POST: ProductoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Producto producto)
        {
            try
            {
                var prod = await ProductoBL.Update(producto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductoController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var prod = await ProductoBL.GetById(id);
            return View(prod);
        }

        // POST: ProductoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Producto producto)
        {
            try
            {
                var prod = await ProductoBL.Delete(producto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
