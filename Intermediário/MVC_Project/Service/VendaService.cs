﻿using MVC_Project.Interfaces.Repository;
using MVC_Project.Interfaces.Service;
using MVC_Project.Models;
using System;
using System.Collections.Generic;

namespace MVC_Project.Service
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _repository;
        public VendaService(IVendaRepository repository)
        {
            _repository = repository;
        }
        public object Create(VendaModel model)
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

        public ICollection<VendaModel> GetAll()
        {
            return _repository.GetAll();
        }

        public VendaModel GetOne(Guid codigo)
        {
            return _repository.GetOne(codigo);
        }

        public object Update(Guid id, VendaModel model)
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
        private VendaModel ClassConverter(VendaModel vend)
        {
            var venda = _repository.GetOne(vend.Codigo);
            venda.Codigo_Produto = vend.Codigo_Produto;
            venda.Produto = vend.Produto;
            venda.Quantidade = vend.Quantidade;
            return venda;
        }
    }
}
