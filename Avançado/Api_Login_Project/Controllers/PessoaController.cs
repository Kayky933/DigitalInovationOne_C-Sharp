using Api_Login_Project.Contracts;
using Api_Login_Project.Filter;
using Api_Login_Project.Interfaces.Service;
using Api_Login_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api_Login_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _service;

        public PessoaController(IPessoaService service)
        {
            _service = service;
        }
        // GET: api/Produto
        [HttpGet]
        public ActionResult<IEnumerable<PessoaModel>> GetProdutoModel()
        {
            return Ok(_service.GetAll());
        }
        // POST: api/Pessoa
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Route("Registrar")]
        [HttpPost]
        [ValidationModel]
        public ActionResult<PessoaModelContract> PostPessoaModel(PessoaModelContract pessoaModel)
        {
            var response = _service.Create(pessoaModel);
            if (response == null)
                return BadRequest();
            return Ok(response);
        }
      
        // DELETE: api/Pessoa/5
        [HttpDelete("{id}")]
        public IActionResult DeletePessoaModel(int id)
        {
            var response = _service.Delet(id);
            if (!response)
                return BadRequest();

            return Ok(response);
        }
    }
}
