using Api_Project.Contracts;
using Api_Project.Interfaces.Service;
using Api_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Api_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        private readonly IVendaService _context;

        public VendaController(IVendaService context)
        {
            _context = context;
        }

        // GET: api/Venda
        [HttpGet]
        public ActionResult<IEnumerable<VendaModel>> GetVendaModel()
        {
            return Ok(_context.GetAll());
        }

        // GET: api/Venda/5
        [HttpGet("{id}")]
        public ActionResult<VendaModel> GetVendaModel(Guid id)
        {
            var response = _context.GetOne(id);
            if (response == null)
                return NotFound();

            return response;
        }

        // POST: api/Venda
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<VendaModelAdd> PostVendaModel(VendaModelAdd vendaModel)
        {
            var response = _context.Create(vendaModel);
            if (response == null)
                return BadRequest();

            return Ok(response);
        }

        // DELETE: api/Venda/5
        [HttpDelete("{id}")]
        public IActionResult DeleteVendaModel(Guid id)
        {
            var reponse = _context.Delet(id);
            if (reponse == false)
                return BadRequest();

            return Ok();
        }
    }
}
