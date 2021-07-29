using System.Collections.Generic;

namespace Api_Login_Project.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        public T GetOne(int id);
        public IEnumerable<T> GetAll();
        public T GetByEmail(string email);
        public void Create(T model);
        public void Delet(T model);
    }
}
