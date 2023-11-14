using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Repositories.ProductRepositories;
using OnionArchitecture.Persistance.Context;

namespace OnionArchitecture.Persistance.Repositories.ProductRepositories
{
    public sealed class ProductQueryRepository : QueryRepository<Product>, IProductQueryRepository
    {
        public ProductQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
