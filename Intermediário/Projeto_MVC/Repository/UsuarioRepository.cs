using Projeto_MVC.Data;
using Projeto_MVC.Interfaces.Repository;
using Projeto_MVC.Models;
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

        public void Create(UsuarioModel Model)
        {
            throw new NotImplementedException();
        }

        public bool Delet(Guid id)
        {
            throw new NotImplementedException();
        }

        public ICollection<UsuarioModel> GetAll(Guid Id)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel GetByEmail(string Email)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<UsuarioModel> GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        public void Put(UsuarioModel Model)
        {
            throw new NotImplementedException();
        }
    }
}
