using Microsoft.AspNetCore.Mvc;
using Projeto_MVC.Service;
using System;

namespace Projeto_MVC.Controllers
{
    public class ControllerPai : Controller
    {
        public void Autenticar()
        {
            var autenticacao = SecurityService.Autenticado(HttpContext);
            ViewBag.usuarioId = autenticacao == null ? Guid.Empty : autenticacao.Id;
        }


    }
}