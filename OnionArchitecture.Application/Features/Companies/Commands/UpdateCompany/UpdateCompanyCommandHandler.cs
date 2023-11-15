using MediatR;
using OnionArchitecture.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Companies.Commands.UpdateCompany
{
    public sealed class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, UpdateCompanyCommandResponse>
    {
        private readonly ICompanyService _companyService;

        public UpdateCompanyCommandHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<UpdateCompanyCommandResponse> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
           await _companyService.UpdateCompanyAsync(request);
            return new();
        }
    }
}
