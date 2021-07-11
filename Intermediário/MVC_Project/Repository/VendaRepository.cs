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
            SaveChanges();
        }

        public void Delet(VendaModel model)
        {
            _context.Vendas.Remove(model);
            SaveChanges();
        }

        public ICollection<VendaModel> GetAll()
        {
            return _context.Vendas.ToList();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public VendaModel GetOne(Guid codigo)
        {
            return _context.Vendas.Find(codigo);
        }

        public void Update(VendaModel model)
        {
            throw new NotImplementedException();
        }
    }
}
