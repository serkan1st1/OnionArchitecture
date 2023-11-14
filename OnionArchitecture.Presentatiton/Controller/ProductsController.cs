using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.Products.Commands.CreateProduct;
using OnionArchitecture.Presentatiton.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Presentatiton.Controller
{
    public sealed class ProductsController : ApiController
    {
        public ProductsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> CreateProduct(CreateProductCommand request)
        {
            CreateProductCommandResponse response= await _mediator.Send(request);
            return Ok(response);
        }

    }
}
