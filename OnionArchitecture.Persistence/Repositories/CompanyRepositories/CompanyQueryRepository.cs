using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Repositories.CompanyRepositories;
using OnionArchitecture.Persistance.Context;

namespace OnionArchitecture.Persistance.Repositories.CompanyRepositories
{
    public class CompanyQueryRepository : QueryRepository<Company>, ICompanyQueryRepository
    {
        public CompanyQueryRepository(AppDbContext context) : base(context)
        {
        }
    }
}
