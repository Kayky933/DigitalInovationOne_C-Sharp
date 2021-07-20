using Api_Project.Contracts;
using Api_Project.Models;

namespace Api_Project.Interfaces.Service
{
    public interface IVendaService : IBaseService<VendaModel>
    {
        public VendaModelAdd Create(VendaModelAdd model);
    }
}
