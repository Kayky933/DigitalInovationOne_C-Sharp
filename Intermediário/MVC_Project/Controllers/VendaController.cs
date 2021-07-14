using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Project.Interfaces.Service;
using MVC_Project.Models;
using System;

namespace MVC_Project.Controllers
{
    public class VendaController : Controller
    {
        private readonly IVendaService _context;
        private readonly IProdutoService _contextProd;

        public VendaController(IVendaService context, IProdutoService contextProd)
        {
            _context = context;
            _contextProd = contextProd;
        }

        // GET: Venda
        public IActionResult Index()
        {
            return View(_context.GetAll());
        }

        // GET: Venda/Details/5
        public IActionResult Details(Guid id)
        {
            var response = _context.GetOne(id);
            if (response != null)
                return View(response);

            return NotFound();
        }

        // GET: Venda/Create
        public IActionResult Create()
        {
            var response = _contextProd.GetAll();
            ViewData["Codigo_Produto"] = new SelectList(response, "Codigo", "Descricao");
            return View();
        }

        // POST: Venda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VendaModel vendaModel)
        {
            var response = _context.Create(vendaModel);
            if (response != null)
            {
                return RedirectToAction(nameof(Index));
            }
            var responseProd = _contextProd.GetAll();
            ViewData["Codigo_Produto"] = new SelectList(responseProd, "Codigo", "Descricao", vendaModel.Codigo_Produto);
            ViewBag.EstoqueSemProd = $"Esse produto não tem {vendaModel.Quantidade} unidades disponíveis";
            return View(vendaModel);
        }

        // GET: Venda/Edit/5
        public IActionResult Edit(Guid id)
        {
            var response = _context.GetOne(id);
            if (response == null)
                return NotFound();

            var responseProd = _contextProd.GetAll();
            ViewData["Codigo_Produto"] = new SelectList(responseProd, "Codigo", "Descricao", response.Codigo_Produto);
            return View(response);
        }

        // POST: Venda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, VendaModel vendaModel)
        {
            var responseProd = _contextProd.GetAll();
            var response = _context.Update(id, vendaModel);

            if (response != null)
                return RedirectToAction(nameof(Index));

            ViewData["Codigo_Produto"] = new SelectList(responseProd, "Codigo", "Descricao", vendaModel.Codigo_Produto);
            ViewBag.EstoqueSemProd = $"Esse produto não tem {vendaModel.Quantidade} unidades disponíveis";
            return View(response);
        }

        // GET: Venda/Delete/5
        public IActionResult Delete(Guid id)
        {
            var response = _context.GetOne(id);
            if (response == null)
            {
                return NotFound();
            }

            return View(response);
        }

        // POST: Venda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _context.Delet(id);
            return RedirectToAction(nameof(Index));
        }

        private bool VendaModelExists(Guid id)
        {
            var response = _context.GetOne(id);
            if (response != null)
                return true;
            return false;
        }
    }
}
