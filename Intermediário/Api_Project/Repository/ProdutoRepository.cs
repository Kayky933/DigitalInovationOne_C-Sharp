using Api_Project.Data;
using Api_Project.Interfaces.Repository;
using Api_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api_Project.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly Api_ProjectContext _context;

        public ProdutoRepository(Api_ProjectContext context)
        {
            _context = context;
        }
        public void Create(ProdutoModel model)
        {
            _context.ProdutoModel.Add(model);
            Save();
        }

        public void Delet(ProdutoModel model)
        {
            _context.ProdutoModel.Remove(model);
            Save();
        }

        public IEnumerable<ProdutoModel> GetAll()
        {
            return _context.ProdutoModel.ToList();
        }

        public ProdutoModel GetOne(Guid codigo)
        {
            return _context.ProdutoModel.FirstOrDefault(a => a.Codigo == codigo);
        }

        public void Update(ProdutoModel model)
        {
            _context.ProdutoModel.Update(model);
            Save();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
