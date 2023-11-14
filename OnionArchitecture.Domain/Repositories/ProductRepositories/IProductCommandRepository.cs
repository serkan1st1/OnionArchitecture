using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Domain.Repositories.ProductRepositories
{
    public interface IProductCommandRepository : ICommandRepository<Product>
    {
    }
}
