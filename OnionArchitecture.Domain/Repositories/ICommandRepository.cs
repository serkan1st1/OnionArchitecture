using OnionArchitecture.Domain.Primitives;

namespace OnionArchitecture.Domain.Repositories
{
    public interface ICommandRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task AddAsync(T entity);
        void Update(T entity);
        Task RemoveByIdAsync(string id);
        void Remove(T entity);
    }
}
