using Api_Project.Contracts;
using Api_Project.ExtensionMethods;
using Api_Project.Interfaces.Repository;
using Api_Project.Interfaces.Service;
using Api_Project.Models;
using System;
using System.Collections.Generic;

namespace Api_Project.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;
        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }
        public ProdutoModelAdd Create(ProdutoModelAdd model)
        {
            var convert = model.ConvertToProd();
            if (model == null)
                return null;

            _repository.Create(convert);
            return model;
        }

        public bool Delet(Guid codigo)
        {
            var response = GetOne(codigo);
            if (response == null)
                return false;

            _repository.Delet(response);
            return true;
        }

        public IEnumerable<ProdutoModel> GetAll()
        {
            return _repository.GetAll();
        }

        public ProdutoModel GetOne(Guid codigo)
        {
            var response = _repository.GetOne(codigo);
            if (response == null)
                return null;
            return response;
        }

        public ProdutoModel Update(Guid codigo, ProdutoModel model)
        {

            var response = _repository.GetOne(codigo);
            if (response == null)
                return null;

            _repository.Update(model);
            return model;
        }
    }
}
