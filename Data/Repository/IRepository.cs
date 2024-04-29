using System.Linq.Expressions;


namespace Data.Repository
{
    public interface IRepository<T> where T : class
    {
        Task Create(T entity);
        Task<List<T>> GetAll(Expression<Func<T, bool>>? filtro = null);
        Task<T>Get(Expression<Func<T,bool>> filtro = null, bool tracked = true);
        Task Remove(T entidad);
        Task Save();
    }
}
