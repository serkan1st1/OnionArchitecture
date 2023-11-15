using MediatR;
using OnionArchitecture.Application.Services;
using OnionArchitecture.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Companies.Commands.CreateCompany
{
    public sealed class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, CreateCompanyCommandResponse>
    {
        private readonly ICompanyService _companyService;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCompanyCommandHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<CreateCompanyCommandResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            await _companyService.CreateCompanyAsync(request);
            return new();
        }
    }
}
