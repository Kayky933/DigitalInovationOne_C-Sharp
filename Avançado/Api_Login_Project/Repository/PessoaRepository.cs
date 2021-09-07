using Api_Login_Project.Data;
using Api_Login_Project.Interfaces.Repository;
using Api_Login_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Api_Login_Project.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly Api_Login_ProjectContext _context;
        public PessoaRepository(Api_Login_ProjectContext context)
        {
            _context = context;
        }

        public void Create(PessoaModel model)
        {
            _context.PessoaModel.Add(model);
            Save();
        }        
        public PessoaModel Login(PessoaModel model)
        {
            return _context.PessoaModel.Where(a => a.Email == model.Email && a.Senha == model.Senha).FirstOrDefault();
        }

        public void Delet(PessoaModel model)
        {
            _context.PessoaModel.Remove(model);
            Save();
        }

        public IEnumerable<PessoaModel> GetAll()
        {
            return _context.PessoaModel.ToList();
        }

        public PessoaModel GetByEmail(string email)
        {
            return _context.PessoaModel.Where(a => a.Email == email).FirstOrDefault();
        }

        public PessoaModel GetBySenha(string senha)
        {
            return _context.PessoaModel.Where(a => a.Senha == senha).FirstOrDefault(a => a.Senha == senha);
        }

        public PessoaModel GetOne(int id)
        {
            return _context.PessoaModel.Find(id);
        }
        private void Save()
        {
            _context.SaveChanges();
        }
    }
}
