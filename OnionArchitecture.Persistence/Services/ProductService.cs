using OnionArchitecture.Application.Features.Products.Commands.CreateProduct;
using OnionArchitecture.Application.Services;
using OnionArchitecture.Domain.Entities;
using OnionArchitecture.Domain.Repositories.ProductRepositories;
using OnionArchitecture.Domain.UnitOfWork;

namespace OnionArchitecture.Persistance.Services
{
    public sealed class ProductService : IProductService
    {
        private readonly IProductCommandRepository _commandRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductCommandRepository commandRepository, IUnitOfWork unitOfWork) 
        {
            _commandRepository = commandRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(CreateProductCommand request)
        {
            Product product = new()
            {
                Id = Guid.NewGuid().ToString(),
                CompanyId = request.CompanyId,
                CreatedDate = DateTime.Now,
                ProductName = request.ProductName,
                Price = request.Price,
                Stock = request.Stock,
            }; 

            await _commandRepository.AddAsync(product);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
