using Microsoft.AspNetCore.Http;
using Projeto_MVC.Models;
using System;
using System.Security.Claims;

namespace Projeto_MVC.Service
{
    public static class SecurityService
    {
        public static UsuarioModel Autenticado(HttpContext context)
        {
            string email = "";
            var id_usuario = Guid.Empty;
            UsuarioModel res;
            if (context.User.Identity.IsAuthenticated)
            {
                string usuario = context.User.Identity.Name;

                foreach (var item in context.User.Claims)
                {
                    if (item.Type == ClaimTypes.Email)
                        email = item.Value;

                    if (item.Type == ClaimTypes.SerialNumber)
                        id_usuario = Guid.Parse(item.Value);
                }

                res = new UsuarioModel()
                {
                    Nome = usuario,
                    Email = email,
                    Id = id_usuario
                };
                return res;
            }
            return null;
        }
    }
}