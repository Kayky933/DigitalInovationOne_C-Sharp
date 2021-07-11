using MVC_Project.Data;
using MVC_Project.Interfaces.Repository;
using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Project.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        public readonly MVC_ProjectContext _context;
        public ProdutoRepository(MVC_ProjectContext context)
        {
            _context = context;
        }
        public void Create(ProdutoModel model)
        {
            _context.Produtos.Add(model);
            SaveChanges();
        }

        public void Delet(ProdutoModel model)
        {
            _context.Produtos.Remove(model);
            SaveChanges();
        }

        public ICollection<ProdutoModel> GetAll()
        {
            return _context.Produtos.ToList();
        }

        public void Update(ProdutoModel model)
        {
            _context.Produtos.Update(model);
            SaveChanges();

        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public ProdutoModel GetOne(Guid codigo)
        {
            return _context.Produtos.Find(codigo);
        }
    }
}
