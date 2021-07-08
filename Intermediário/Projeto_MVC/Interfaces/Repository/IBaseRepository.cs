using System;
using System.Collections.Generic;

namespace Projeto_MVC.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        public T GetById(Guid id);
        public ICollection<T> GetAll(Guid id);
        public ICollection<T> GetByName(string name);
        public T GetByEmail(string email);

      
        public bool Delet(Guid id);
    }
}
