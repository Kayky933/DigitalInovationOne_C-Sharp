using Projeto_MVC.Models;
using Projeto_MVC.ViewModel;
using System;

namespace Projeto_MVC.Interfaces.Service
{
    public interface IUsuarioService : IBaseService<UsuarioModel>
    {
        public void Create(UsuarioViewModel model);
        public void Put(Guid id, UsuarioViewModel model);
    }
}
