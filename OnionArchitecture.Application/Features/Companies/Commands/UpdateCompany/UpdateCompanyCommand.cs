using MediatR;

namespace OnionArchitecture.Application.Features.Companies.Commands.UpdateCompany
{
    public sealed record UpdateCompanyCommand(
        string CompanyId,
        int OrderStartTimeHour,
        int OrderStartTimeMinute
        ) : IRequest<UpdateCompanyCommandResponse>;

}
