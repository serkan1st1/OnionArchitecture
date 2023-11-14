using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Repositories.ProductRepositories;
using OnionArchitecture.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Persistance.Repositories.ProductRepositories
{
    public sealed class ProductCommandRepository : CommandRepository<Product>, IProductCommandRepository
    {
        public ProductCommandRepository(AppDbContext context) : base(context)
        {
        }
    }
}
