using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Project.Data;
using MVC_Project.Interfaces.Service;
using MVC_Project.Models;
using System;

namespace MVC_Project.Controllers
{
    public class VendaController : Controller
    {
        private readonly IVendaService _context;
        private readonly IProdutoService _contextProd;
        private readonly MVC_ProjectContext _contextProject;

        public VendaController(IVendaService context, IProdutoService contextProd, MVC_ProjectContext contextProject)
        {
            _context = context;
            _contextProject = contextProject;
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
            var res = _context.GetOne(id);
            if (res != null)
                return View(res);

            return NotFound();
        }

        // GET: Venda/Create
        public IActionResult Create()
        {
            var res = _contextProd.GetAll();
            ViewData["Codigo_Produto"] = new SelectList(res, "Codigo", "Descricao");
            return View();
        }

        // POST: Venda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VendaModel vendaModel)
        {
            if (ModelState.IsValid)
            {
                _context.Create(vendaModel);
                return RedirectToAction(nameof(Index));
            }
            var res = _contextProd.GetAll();
            ViewData["Codigo_Produto"] = new SelectList(res, "Codigo", "Descricao", vendaModel.Codigo_Produto);
            return View(vendaModel);
        }

        // GET: Venda/Edit/5
        public IActionResult Edit(Guid id)
        {
            var res = _context.GetOne(id);
            if (res == null)
                return NotFound();

            var resProd = _contextProd.GetAll();
            ViewData["Codigo_Produto"] = new SelectList(resProd, "Codigo", "Descricao", res.Codigo_Produto);
            return View(res);
        }

        // POST: Venda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, VendaModel vendaModel)
        {
            var resProd = _contextProd.GetAll();
            var res = _context.GetOne(id);

            if (res != null)
            {
                _context.Update(id, vendaModel);               
                return RedirectToAction(nameof(Index));               
            }
            ViewData["Codigo_Produto"] = new SelectList(resProd, "Codigo", "Descricao", vendaModel.Codigo_Produto);

            return View(res);
        }

        // GET: Venda/Delete/5
        public IActionResult Delete(Guid id)
        {
            var res = _context.GetOne(id);
            if (res == null)
            {
                return NotFound();
            }

            return View(res);
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
            var res = _context.GetOne(id);
            if (res != null)
                return true;
            return false;
        }
    }
}
