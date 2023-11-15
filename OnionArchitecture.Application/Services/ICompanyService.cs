using OnionArchitecture.Application.Features.Companies.Commands.CreateCompany;
using OnionArchitecture.Application.Features.Companies.Commands.UpdateCompany;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Services
{
    public interface ICompanyService
    {
        Task CreateCompanyAsync(CreateCompanyCommand request);
        Task UpdateCompanyAsync(UpdateCompanyCommand request);
        IQueryable<Company> GetAll();
        Task<Company> GetCompanyById(string companyId);

    }
}
