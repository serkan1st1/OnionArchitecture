using OnionArchitecture.Application.Features.Products.Commands.CreateProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Services
{
    public interface IProductService
    {
        Task AddAsync(CreateProductCommand request);
    }
}
