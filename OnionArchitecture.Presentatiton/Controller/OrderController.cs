using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Features.Orders.Commands.CreateOrderCommand;
using OnionArchitecture.Presentatiton.Abstraction;

namespace OnionArchitecture.Presentatiton.Controller
{
    public sealed class OrderController : ApiController
    {
        public OrderController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateOrder(CreateOrderCommand request)
        {
            CreateOrderCommandResponse response = await _mediator.Send(request);
            return Ok(response);    
        }
    }
}
