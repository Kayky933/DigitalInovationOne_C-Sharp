using Api_Project.Data;
using Api_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendaController : ControllerBase
    {
        private readonly Api_ProjectContext _context;

        public VendaController(Api_ProjectContext context)
        {
            _context = context;
        }

        // GET: api/Venda
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VendaModel>>> GetVendaModel()
        {
            return await _context.VendaModel.ToListAsync();
        }

        // GET: api/Venda/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VendaModel>> GetVendaModel(Guid id)
        {
            var vendaModel = await _context.VendaModel.FindAsync(id);

            if (vendaModel == null)
            {
                return NotFound();
            }

            return vendaModel;
        }

        // PUT: api/Venda/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendaModel(Guid id, VendaModel vendaModel)
        {
            if (id != vendaModel.Codigo)
            {
                return BadRequest();
            }

            _context.Entry(vendaModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendaModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Venda
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VendaModel>> PostVendaModel(VendaModel vendaModel)
        {
            _context.VendaModel.Add(vendaModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVendaModel", new { id = vendaModel.Codigo }, vendaModel);
        }

        // DELETE: api/Venda/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendaModel(Guid id)
        {
            var vendaModel = await _context.VendaModel.FindAsync(id);
            if (vendaModel == null)
            {
                return NotFound();
            }

            _context.VendaModel.Remove(vendaModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VendaModelExists(Guid id)
        {
            return _context.VendaModel.Any(e => e.Codigo == id);
        }
    }
}
