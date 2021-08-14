using Api_Login_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Api_Login_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CursoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(CursosModel cursosModel)
        {
            return Created("", cursosModel);
        } 
        [HttpGet]
        public IActionResult Get()
        {            
            var cursosModel = new List<CursosModel>();

         
            cursosModel.Add(new CursosModel
            {
                Usuario ="",
                Nome ="Matemática",
                Descricao = "Matemática"

            });
            return Ok(cursosModel);
        }
    }
}
