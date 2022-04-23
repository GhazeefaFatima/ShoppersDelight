using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Api.Application.Presistance
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(string tablename, int id);
        Task<IEnumerable<T>> GetAll(string tablename);
        Task<T> Add(T entity);
        Task<bool> Exists(int id);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
