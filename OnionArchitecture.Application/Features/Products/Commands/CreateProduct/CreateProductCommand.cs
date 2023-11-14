using MediatR;

namespace OnionArchitecture.Application.Features.Products.Commands.CreateProduct
{
    public sealed record CreateProductCommand (
        string CompanyId,
        string ProductName,
        decimal Stock,
        decimal Price) : IRequest<CreateProductCommandResponse>;

}
