using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.Companies.Commands;
using OnionArchitecture.Application.Features.Companies.Commands.CreateCompany;
using OnionArchitecture.Application.Features.Companies.Commands.UpdateCompany;
using OnionArchitecture.Application.Features.Companies.Queries.GetAllCompanyQuery;
using OnionArchitecture.Presentatiton.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Presentatiton.Controller
{
    public class CompanyController : ApiController
    {
        public CompanyController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCompany(CreateCompanyCommand request)
        {
            CreateCompanyCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> UpdateCompany(UpdateCompanyCommand request)
        {
            UpdateCompanyCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllCompany()
        {
            GetAllCompanyQuery request = new();
            GetAllCompanyQueryResponse response= await _mediator.Send(request);
            return Ok(response);
        }
    }
}
