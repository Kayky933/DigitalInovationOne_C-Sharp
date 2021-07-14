using MVC_Project.Interfaces.Repository;
using MVC_Project.Interfaces.Service;
using MVC_Project.Models;
using System;
using System.Collections.Generic;

namespace MVC_Project.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public object Create(ProdutoModel model)
        {
            _repository.Create(model);
            return model;
        }

        public bool Delet(Guid model)
        {
            var res = _repository.GetOne(model);
            _repository.Delet(res);
            return true;
        }

        public ICollection<ProdutoModel> GetAll()
        {
            return _repository.GetAll();
        }

        public ProdutoModel GetOne(Guid codigo)
        {
            return _repository.GetOne(codigo);
        }

        public object Update(Guid id, ProdutoModel model)
        {
            var res = _repository.GetOne(id);
            if (res != null)
            {
                var convertedClass = ClassConverter(model);

                _repository.Update(convertedClass);
                return res;
            }
            return null;

        }
        private ProdutoModel ClassConverter(ProdutoModel prod)
        {
            var produto = _repository.GetOne(prod.Codigo);
            produto.Descricao = prod.Descricao;
            produto.Estoque = prod.Estoque;
            produto.Valor = prod.Valor;
            return produto;
        }
    }
}
