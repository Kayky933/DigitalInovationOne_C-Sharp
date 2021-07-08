using Projeto_MVC.Interfaces.Service;
using Projeto_MVC.Models;
using Projeto_MVC.ViewModel;
using System;
using System.Collections.Generic;

namespace Projeto_MVC.Service
{
    public class UsuarioService : IUsuarioService
    {
        public void Create(UsuarioViewModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delet(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<UsuarioModel> GetAll(Guid id)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<UsuarioModel> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void Put(Guid id, UsuarioViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
