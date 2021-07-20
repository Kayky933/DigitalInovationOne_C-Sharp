using Api_Project.Contracts;
using Api_Project.ExtensionMethods;
using Api_Project.Interfaces.Repository;
using Api_Project.Interfaces.Service;
using Api_Project.Models;
using System;
using System.Collections.Generic;

namespace Api_Project.Service
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _repository;
        private readonly IProdutoRepository _produtoRepository;
        public VendaService(IVendaRepository repository, IProdutoRepository produtoRepository)
        {
            _repository = repository;
            _produtoRepository = produtoRepository;
        }
        public object Create(VendaModel model)
        {
            var estoque = _produtoRepository.GetOne(model.Codigo_Produto);
            var quantidadeEstoque = estoque.Estoque -= model.Quantidade;
            if (quantidadeEstoque <= 0)
                return null;
            _repository.Create(model);
            return model;
        }

        public VendaModelAdd Create(VendaModelAdd model)
        {
            var convert = model.ConvertToVenda();
            if (model == null)
                return null;

            _repository.Create(convert);
            return model;
        }

        public bool Delet(Guid model)
        {
            var response = _repository.GetOne(model);
            _repository.Delet(response);
            return true;
        }

        public IEnumerable<VendaModel> GetAll()
        {
            return _repository.GetAll();
        }

        public VendaModel GetOne(Guid codigo)
        {
            return _repository.GetOne(codigo);
        }

        public VendaModel Update(Guid id, VendaModel model)
        {
            var response = _repository.GetOne(id);

            var estoque = _produtoRepository.GetOne(model.Codigo_Produto);
            var quantidadeEstoque = estoque.Estoque -= model.Quantidade;
            if (quantidadeEstoque <= 0)
                return null;

            var convertedClass = ClassConverter(model);

            _repository.Update(convertedClass);
            return response;


        }

        private VendaModel ClassConverter(VendaModel vend)
        {
            var venda = _repository.GetOne(vend.Codigo);
            venda.Quantidade = vend.Quantidade;
            return venda;
        }
    }
}
