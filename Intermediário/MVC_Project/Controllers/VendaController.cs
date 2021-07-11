using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Data;
using MVC_Project.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project.Controllers
{
    public class VendaController : Controller
    {
        private readonly MVC_ProjectContext _context;

        public VendaController(MVC_ProjectContext context)
        {
            _context = context;
        }

        // GET: Venda
        public async Task<IActionResult> Index()
        {
            var mVC_ProjectContext = _context.Vendas.Include(v => v.Produto);
            return View(await mVC_ProjectContext.ToListAsync());
        }

        // GET: Venda/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaModel = await _context.Vendas
                .Include(v => v.Produto)
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (vendaModel == null)
            {
                return NotFound();
            }

            return View(vendaModel);
        }

        // GET: Venda/Create
        public IActionResult Create()
        {
            ViewData["Codigo_Produto"] = new SelectList(_context.Produtos, "Codigo", "Descricao");
            return View();
        }

        // POST: Venda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VendaModel vendaModel)
        {
            if (ModelState.IsValid)
            {
                vendaModel.Codigo = Guid.NewGuid();
                _context.Add(vendaModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Codigo_Produto"] = new SelectList(_context.Produtos, "Codigo", "Descricao", vendaModel.Codigo_Produto);
            return View(vendaModel);
        }

        // GET: Venda/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaModel = await _context.Vendas.FindAsync(id);
            if (vendaModel == null)
            {
                return NotFound();
            }
            ViewData["Codigo_Produto"] = new SelectList(_context.Produtos, "Codigo", "Descricao", vendaModel.Codigo_Produto);
            return View(vendaModel);
        }

        // POST: Venda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, VendaModel vendaModel)
        {
            if (id != vendaModel.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendaModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaModelExists(vendaModel.Codigo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Codigo_Produto"] = new SelectList(_context.Produtos, "Codigo", "Descricao", vendaModel.Codigo_Produto);
            return View(vendaModel);
        }

        // GET: Venda/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendaModel = await _context.Vendas
                .Include(v => v.Produto)
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (vendaModel == null)
            {
                return NotFound();
            }

            return View(vendaModel);
        }

        // POST: Venda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var vendaModel = await _context.Vendas.FindAsync(id);
            _context.Vendas.Remove(vendaModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaModelExists(Guid id)
        {
            return _context.Vendas.Any(e => e.Codigo == id);
        }
    }
}
