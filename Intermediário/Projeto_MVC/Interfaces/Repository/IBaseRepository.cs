using System;
using System.Collections.Generic;

namespace Projeto_MVC.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        public T GetById(Guid Id);
        public ICollection<T> GetAll(Guid Id);
        public ICollection<T> GetByName(string Name);
        public T GetByEmail(string Email);

        public void Create(T Model);
        public void Put(T Model);
        public bool Delet(Guid id);
    }
}
