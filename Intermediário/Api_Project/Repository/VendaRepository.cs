
using Api_Project.Data;
using Api_Project.Interfaces.Repository;
using Api_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Api_Project.Repository
{
    public class VendaRepository : IVendaRepository
    {
        public readonly Api_ProjectContext _context;
        public VendaRepository(Api_ProjectContext context)
        {
            _context = context;
        }

        public void Create(VendaModel model)
        {
            _context.VendaModel.Add(model);
            SaveChangesVendaModel();
        }

        public void Delet(VendaModel model)
        {
            _context.VendaModel.Remove(model);
            SaveChangesVendaModel();
        }

        public IEnumerable<VendaModel> GetAll()
        {
            return _context.VendaModel.Include(v => v.Produto).ToList();
        }
        public VendaModel GetOne(Guid codigo)
        {
            return _context.VendaModel.Include(v => v.Produto).FirstOrDefault(m => m.Codigo == codigo);
        }

        public void Update(VendaModel model)
        {
            _context.VendaModel.Update(model);
            SaveChangesVendaModel();
        }
        public void SaveChangesVendaModel()
        {
            _context.SaveChanges();
        }
    }
}
