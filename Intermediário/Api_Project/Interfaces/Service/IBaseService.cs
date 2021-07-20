using System;
using System.Collections.Generic;

namespace Api_Project.Interfaces.Service
{
    public interface IBaseService<T> where T : class
    {
        public T GetOne(Guid codigo);
        public IEnumerable<T> GetAll();
        public T Update(Guid codigo, T model);
        public bool Delet(Guid codigo);
    }
}
