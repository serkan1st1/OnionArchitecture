using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Primitives;
using OnionArchitecture.Domain.Repositories;
using OnionArchitecture.Persistance.Context;

namespace OnionArchitecture.Persistance.Repositories
{
    public class CommandRepository<T> : ICommandRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public CommandRepository(AppDbContext context)
        {
            _context = context;
            Entity = _context.Set<T>();
        }

        public DbSet<T> Entity { get; set; }

        public async Task AddAsync(T entity)
        {
           await Entity.AddAsync(entity);
        }

        public void Remove(T entity)
        {
           Entity.Remove(entity);
        }

        public async Task RemoveByIdAsync(string id)
        {
            T entity = await Entity.FindAsync(id);
            Remove(entity);
        }

        public void Update(T entity)
        {
            Entity.Update(entity);
        }
    }
}
