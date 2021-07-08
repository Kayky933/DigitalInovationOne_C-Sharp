using Projeto_MVC.Data;
using Projeto_MVC.Interfaces.Repository;
using Projeto_MVC.Models;
using Projeto_MVC.ViewModel;
using System;
using System.Collections.Generic;

namespace Projeto_MVC.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Projeto_MVCContext _context;
        public UsuarioRepository(Projeto_MVCContext context)
        {
            _context = context;
        }

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
