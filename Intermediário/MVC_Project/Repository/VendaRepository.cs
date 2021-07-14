
using Microsoft.EntityFrameworkCore;
using MVC_Project.Data;
using MVC_Project.Interfaces.Repository;
using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Project.Repository
{
    public class VendaRepository : IVendaRepository
    {
        public readonly MVC_ProjectContext _context;
        public VendaRepository(MVC_ProjectContext context)
        {
            _context = context;
        }

        public void Create(VendaModel model)
        {
            _context.Vendas.Add(model);
            SaveChangesVenda();
        }

        public void Delet(VendaModel model)
        {
            _context.Vendas.Remove(model);
            SaveChangesVenda();
        }

        public ICollection<VendaModel> GetAll()
        {
            return _context.Vendas.Include(v => v.Produto).ToList();
        }
        public VendaModel GetOne(Guid codigo)
        {
            return _context.Vendas.Include(v => v.Produto).FirstOrDefault(m => m.Codigo == codigo);
        }

        public void Update(VendaModel model)
        {
            _context.Vendas.Update(model);
            SaveChangesVenda();
        }
        public void SaveChangesVenda()
        {
            _context.SaveChanges();
        }

    }
}
