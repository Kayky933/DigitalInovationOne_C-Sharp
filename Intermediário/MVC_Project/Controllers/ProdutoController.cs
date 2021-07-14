using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces.Service;
using MVC_Project.Models;
using System;

namespace MVC_Project.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        // GET: Produto
        public IActionResult Index()
        {
            return View(_service.GetAll());
        }

        // GET: Produto/Details/5
        public IActionResult Details(Guid id)
        {
            var response = _service.GetOne(id);
            if (response != null)
                return View(response);

            return NotFound();
        }

        // GET: Produto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProdutoModel produtoModel)
        {
            if (ModelState.IsValid)
            {
                _service.Create(produtoModel);
                return RedirectToAction(nameof(Index));
            }
            return View(produtoModel);
        }

        // GET: Produto/Edit/5
        public IActionResult Edit(Guid id)
        {
            var response = _service.GetOne(id);
            if (response != null)
                return View(response);

            return NotFound();
        }

        // POST: Produto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, ProdutoModel produtoModel)
        {
            var response = _service.GetOne(id);
            if (response.GetType() != null)
            {
                _service.Update(id, produtoModel);
                return RedirectToAction(nameof(Index));
            }
            return View(response);
        }

        // GET: Produto/Delete/5
        public IActionResult Delete(Guid id)
        {
            var response = _service.GetOne(id);
            if (response != null)
                return View(response);
            return NotFound();
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _service.Delet(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoModelExists(Guid id)
        {
            var response = _service.GetOne(id);
            if (response.GetType() == typeof(ProdutoModel))
                return true;
            return false;

        }
    }
}
