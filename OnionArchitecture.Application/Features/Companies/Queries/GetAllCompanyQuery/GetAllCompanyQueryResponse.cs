using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Features.Companies.Queries.GetAllCompanyQuery
{
    public sealed record GetAllCompanyQueryResponse(
        IQueryable<Company> Companies);
    
}
