using System.Collections.Generic;

namespace Api_Login_Project.Interfaces.Service
{
    public interface IBaseService<T> where T : class
    {
        public T GetOne(int id);
        public IEnumerable<T> GetAll();
        public T GetByEmail(string email);
        public bool Delet(int id);
    }
}
