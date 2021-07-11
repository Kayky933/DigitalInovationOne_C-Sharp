using System;
using System.Collections.Generic;

namespace MVC_Project.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        public ICollection<T> GetAll();
        public T GetOne(Guid codigo);
        public void Create(T model);
        public void Update(T model);
        public void Delet(T model);
    }
}
