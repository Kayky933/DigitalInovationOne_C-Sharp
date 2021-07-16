using Api_Project.Contracts;
using Api_Project.Models;

namespace Api_Project.Interfaces.Service
{
    public interface IProdutoService : IBaseService<ProdutoModel>
    {
        public ProdutoModelAdd Create(ProdutoModelAdd model);
    }
}
