using Api_Project.Contracts;
using Api_Project.ExtensionMethods;
using Api_Project.Interfaces.Service;
using Api_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Api_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        // GET: api/Produto
        [HttpGet]
        public ActionResult<IEnumerable<ProdutoModel>> GetProdutoModel()
        {
            return Ok(_service.GetAll());
        }

        // GET: api/Produto/5
        [HttpGet("{id}")]
        public ActionResult<ProdutoModel> GetProdutoModel(Guid id)
        {
            var response = _service.GetOne(id);

            if (response == null)
            {
                return NotFound();
            }

            return response;
        }

        // PUT: api/Produto/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutProdutoModel(Guid id, ProdutoModel produtoModel)
        {
            var response = _service.Update(id, produtoModel);
            if (response != null)
                return Ok(response);

            return BadRequest();
        }

        // POST: api/Produto
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<ProdutoModelAdd> PostProdutoModel(ProdutoModelAdd produtoModel)
        {
            
            var response = _service.Create(produtoModel);
            if (response != null)
                return Ok(response);

            return BadRequest();
        }

        // DELETE: api/Produto/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProdutoModel(Guid id)
        {
            var response = _service.Delet(id);
            if (response == false)
                return NotFound();

            return Ok(response);
        }
    }
}
