using OnionArchitecture.Application.Features.Orders.Commands.CreateOrderCommand;

namespace OnionArchitecture.Application.Services
{
    public interface IOrderService
    {
        Task CreateOrder(CreateOrderCommand request);
    }
}
