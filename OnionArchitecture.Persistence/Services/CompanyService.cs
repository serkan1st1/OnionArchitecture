using OnionArchitecture.Application.Features.Companies.Commands.CreateCompany;
using OnionArchitecture.Application.Features.Companies.Commands.UpdateCompany;
using OnionArchitecture.Application.Services;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Repositories.CompanyRepositories;
using OnionArchitecture.Domain.UnitOfWork;

namespace OnionArchitecture.Persistance.Services
{
    public sealed class CompanyService : ICompanyService
    {
        private readonly ICompanyCommandRepository _companyCommandRepositories;
        private readonly ICompanyQueryRepository _companyQueryRepositories;
        private readonly IUnitOfWork _unitOfWork;

        public CompanyService(ICompanyCommandRepository companyCommandRepositories, ICompanyQueryRepository companyQueryRepositories, IUnitOfWork unitOfWork)
        {
            _companyCommandRepositories = companyCommandRepositories;
            _companyQueryRepositories = companyQueryRepositories;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateCompanyAsync(CreateCompanyCommand request)
        {
            Company company = new()
            {
                Id = Guid.NewGuid().ToString(),
                Status = false,
                CompanyName = request.CompanyName,
                CreatedDate = DateTime.Now,
                OrderStartTimeHour = request.OrderStartTimeHour,
                OrderStartTimeMinute = request.OrderStartTimeMinute,
                OrderFinishTimeHour = request.OrderFinishTimeHour,
                OrderFinishTimeMinute = request.OrderFinishTimeMinute
            };

            await _companyCommandRepositories.AddAsync(company);
            await _unitOfWork.SaveChangesAsync();
        }

        public IQueryable<Company> GetAll()
        {
            return _companyQueryRepositories.GetAll();
        }

        public async Task<Company> GetCompanyById(string companyId)
        {
          return await _companyQueryRepositories.GetFirstById(companyId);
        }

        public async Task UpdateCompanyAsync(UpdateCompanyCommand request)
        {
            var company = await _companyQueryRepositories.GetFirstById(request.CompanyId);
            if (company == null) throw new Exception("Şirket kaydı bulunamadı");
            if (company.Status) throw new Exception("Şirket zaten onaylı.");

            company.Status = true;
            company.OrderStartTimeHour = request.OrderStartTimeHour;
            company.OrderStartTimeMinute = request.OrderStartTimeMinute;
            _companyCommandRepositories.Update(company);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
