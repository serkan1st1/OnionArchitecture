using OnionArchitecture.Domain.Primitives;
using System.Linq.Expressions;

namespace OnionArchitecture.Domain.Repositories
{
    public interface IQueryRepository<T>: IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T,bool>> expression);
        Task<T> GetFirstExpiression(Expression<Func<T, bool>> expression);
        Task<T> GetFirstById(string id);
    }
}
