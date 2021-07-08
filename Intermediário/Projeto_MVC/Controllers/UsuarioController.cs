using Microsoft.AspNetCore.Mvc;
using Projeto_MVC.Interfaces.Service;
using Projeto_MVC.ViewModel;
using System;
using System.Threading.Tasks;

namespace Projeto_MVC.Controllers
{
    public class UsuarioController : ControllerPai
    {
        private readonly IUsuarioService _context;

        public UsuarioController(IUsuarioService context)
        {
            _context = context;
        }

        // GET: Usuario
        public Task<IActionResult> Index()
        {
            return View(_context.GetById(ViewBag.usuarioId));
        }

        // GET: Usuario/Details/5
        public IActionResult Details(Guid id)
        {

            var usuarioModel = _context.GetById(id);
            if (usuarioModel == null)
            {
                return NotFound();
            }

            return View(usuarioModel);
        }

        // GET: Usuario/Create
        public IActionResult CreateUsuarioFull()
        {
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUsuarioFull(UsuarioViewModel usuarioModel)
        {

            _context.Create(usuarioModel);
            return View(usuarioModel);
        }

        // GET: Usuario/Edit/5
        public IActionResult Edit(Guid id)
        {
            var usuarioid = _context.GetById(id);


            return View(usuarioid);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, UsuarioViewModel usuarioModel)
        {

            _context.Put(id, usuarioModel);
            return View(usuarioModel);
        }

        // GET: Usuario/Delete/5
        public IActionResult Delete(Guid id)
        {
            var usuarioid = _context.GetById(id);


            return View(usuarioid);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _context.Delet(id);
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioModelExists(Guid id)
        {
            var usuario = _context.GetById(id);
            if (usuario == null)
            {
                return false;
            }
            return true;
        }
    }
}
