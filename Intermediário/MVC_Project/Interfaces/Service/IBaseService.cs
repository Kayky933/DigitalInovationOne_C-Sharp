using System;
using System.Collections.Generic;

namespace MVC_Project.Interfaces.Service
{
    public interface IBaseService<T> where T : class
    {
        public ICollection<T> GetAll();
        public T GetOne(Guid codigo);
        public object Create(T model);
        public object Update(Guid id, T model);
        public bool Delet(Guid model);
    }
}
