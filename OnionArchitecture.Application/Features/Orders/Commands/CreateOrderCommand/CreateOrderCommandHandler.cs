using MediatR;
using OnionArchitecture.Application.Services;
using OnionArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Orders.Commands.CreateOrderCommand
{
    public sealed class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, CreateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        private readonly ICompanyService _companyService;

        public CreateOrderCommandHandler(IOrderService orderService, ICompanyService companyService)
        {
            _orderService = orderService;
            _companyService = companyService;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            Company company = await _companyService.GetCompanyById(request.CompanyId);
            if (!company.Status) throw new Exception("Şirket aktif olmadığından sipariş alamıyor!");

            int orderStartHour = company.OrderStartTimeHour;
            int orderStartMin = company.OrderStartTimeMinute;

            int orderFinishHour = company.OrderFinishTimeHour;
            int orderFinishMin = company.OrderFinishTimeMinute;

            int nowHour = DateTime.Now.Hour;
            int nowMin= DateTime.Now.Minute;

            if(orderStartHour < nowHour && orderFinishHour >= nowHour)
            {
                if(orderStartMin<nowMin && orderFinishMin >= nowMin)
                {
                    await _orderService.CreateOrder(request);
                }
            }
            else
            {
                throw new Exception("Siparişiniz firmanın sipariş aldığı aralık dışında!");
            }
            return new();
        }
    }
}
