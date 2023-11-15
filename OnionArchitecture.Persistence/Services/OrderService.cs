using OnionArchitecture.Application.Features.Orders.Commands.CreateOrderCommand;
using OnionArchitecture.Application.Services;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Repositories.OrderRepositories;
using OnionArchitecture.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistance.Services
{
    public sealed class OrderService : IOrderService
    {
        private readonly IOrderCommandRepository _commandRepository;
        private readonly IUnitOfWork _unitOuOfWork;
        public OrderService(IOrderCommandRepository commandRepository, IUnitOfWork unitOuOfWork)
        {
            _commandRepository = commandRepository;
            _unitOuOfWork = unitOuOfWork;
        }

        public async Task CreateOrder(CreateOrderCommand request)
        {
            Order order = new Order()
            {
                Id = Guid.NewGuid().ToString(),
                CreatedDate = DateTime.Now,
                CustomerName = request.CustomerName,
                CompId =request.CompanyId,
                OrderDate = DateTime.Now,
                ProductId = request.ProductId,
            };

            await _commandRepository.AddAsync(order);
            _unitOuOfWork.SaveChangesAsync();

        }
    }
}
