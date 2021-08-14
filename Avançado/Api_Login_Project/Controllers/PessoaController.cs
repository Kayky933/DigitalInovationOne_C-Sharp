using Api_Login_Project.Contracts;
using Api_Login_Project.Filter;
using Api_Login_Project.Interfaces.Service;
using Api_Login_Project.Models;
using Api_Login_Project.Security;
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
        public IActionResult GetProdutoModel()
        {
            return Ok(_service.GetAll());
        }
        [Route("Logar")]
        [HttpPost]
        [ValidationModel]
        public IActionResult Login(PessoaModelContract pessoaModel)
        {
            var response = _service.Login(pessoaModel);
            if (response == null)
                return NotFound();

            var pessoaToken = _service.GetByEmail(pessoaModel.Email);

            var token = SecurityConfig.ConfigureSecurity(pessoaToken);
            return Ok(new
            {
                Token = token,
                Email = pessoaToken.Email
            });
        }
        // POST: api/Pessoa
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Route("Registrar")]
        [HttpPost]
        [ValidationModel]
        public IActionResult PostPessoaModel(PessoaModelContract pessoaModel)
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
