using Projeto_MVC.Models;
using Projeto_MVC.ViewModel;
using System;

namespace Projeto_MVC.Interfaces.Repository
{
    public interface IUsuarioRepository : IBaseRepository<UsuarioModel>
    {
        public void Create(UsuarioViewModel model);
        public void Put(Guid id,UsuarioViewModel model);
    }
}
