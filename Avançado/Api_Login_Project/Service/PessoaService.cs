using Api_Login_Project.Contracts;
using Api_Login_Project.ExtensionMethods;
using Api_Login_Project.Interfaces.Repository;
using Api_Login_Project.Interfaces.Service;
using Api_Login_Project.Models;
using System.Collections.Generic;

namespace Api_Login_Project.Service
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _repository;
        public PessoaService(IPessoaRepository repository)
        {
            _repository = repository;
        }

        public PessoaModelContract Create(PessoaModelContract model)
        {
            if (model == null)
                return null;

            var convertModel = model.ConvertPessoa();

            _repository.Create(convertModel);
            return model;
        }

        public bool Delet(int id)
        {
            var model = GetOne(id);
            if (model == null)
                return false;
            _repository.Delet(model);
            return true;
        }

        public IEnumerable<PessoaModel> GetAll()
        {
            return _repository.GetAll();
        }

        public PessoaModel GetByEmail(string email)
        {
            var getEmail = _repository.GetByEmail(email);
            if (getEmail == null)
                return null;
            return getEmail;
        }

        public PessoaModel GetOne(int id)
        {
            return _repository.GetOne(id);
        }

        public PessoaModelContract Login(PessoaModelContract model)
        {
            var pessoa = model.ConvertPessoa();
             var response= _repository.Login(pessoa);
            if (response == null)
                return null;
            return model;
        }
    }
}
