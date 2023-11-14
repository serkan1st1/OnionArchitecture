using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Domain.Repositories.OrderRepositories
{
    public interface IOrderCommandRepository :ICommandRepository<Order>
    {
    }
}
