using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Primitives;
using OnionArchitecture.Domain.Repositories;
using OnionArchitecture.Persistance.Context;
using System.Linq.Expressions;

namespace OnionArchitecture.Persistance.Repositories
{
    public class QueryRepository<T> : IQueryRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public QueryRepository(AppDbContext context)
        {
            _context = context;
            Entity = _context.Set<T>();
        }

        public DbSet<T> Entity { get; set; }

        public IQueryable<T> GetAll()
        {
            return Entity.AsQueryable();
        }

        public async Task<T> GetFirstById(string id)
        {
            return await Entity.FindAsync(id);
        }

        public async Task<T> GetFirstExpiression(Expression<Func<T, bool>> expression)
        {
            return await Entity.FirstOrDefaultAsync(expression);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression)
        {   
            return Entity.Where(expression);
        }
    }
}
