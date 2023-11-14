using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Repositories.OrderRepositories;
using OnionArchitecture.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistance.Repositories.OrderRepositories
{
    public sealed class OrderCommandRepository : CommandRepository<Order>, IOrderCommandRepository
    {
        public OrderCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
