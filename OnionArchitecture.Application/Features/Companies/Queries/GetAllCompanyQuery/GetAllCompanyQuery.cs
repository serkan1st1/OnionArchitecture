using MediatR;

namespace OnionArchitecture.Application.Features.Companies.Queries.GetAllCompanyQuery
{
    public sealed record GetAllCompanyQuery: IRequest<GetAllCompanyQueryResponse>;
    
}
