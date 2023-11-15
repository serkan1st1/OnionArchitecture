using MediatR;

namespace OnionArchitecture.Application.Features.Orders.Commands.CreateOrderCommand
{
    public sealed record CreateOrderCommand(
        string ProductId,
        string CustomerName,
        string CompanyId
        ) : IRequest<CreateOrderCommandResponse>;
    
}
