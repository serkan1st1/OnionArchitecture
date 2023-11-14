using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Domain.Primitives;

namespace OnionArchitecture.Domain.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Entity { get; set; }
    }
}
