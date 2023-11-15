using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Repositories.CompanyRepositories;
using OnionArchitecture.Persistance.Context;

namespace OnionArchitecture.Persistance.Repositories.CompanyRepositories
{
    public sealed class CompanyCommandRepository : CommandRepository<Company>, ICompanyCommandRepository
    {
        public CompanyCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
