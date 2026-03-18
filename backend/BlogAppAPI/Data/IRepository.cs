using System.Linq.Expressions;

namespace BlogAppAPI.Data
{
    public interface IRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<List<T>> GetAllData();
        Task<T> GetById(int id);
        void Update(T entity);
        Task DeleteAsync(int id);
        Task SaveChangeAsnc();
        Task<List<T>> GetAllData(Expression<Func<T, bool>> filter);
    }
}
