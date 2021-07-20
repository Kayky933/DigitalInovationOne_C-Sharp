using System;
using System.Collections.Generic;

namespace Api_Project.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        public T GetOne(Guid codigo);
        public IEnumerable<T> GetAll();
        public void Create(T model);
        public void Update(T model);
        public void Delet(T model);
    }
}
