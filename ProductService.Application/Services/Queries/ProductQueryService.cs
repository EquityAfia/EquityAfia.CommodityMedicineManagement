
using ProductService.Application.Interfaces.Queries;
using ProductService.Contracts.DTOs;
using ProductService.Domain.Entities;

namespace ProductService.Application.Services.Queries
{
    public class ProductQueryService : IProductQueryService
    {
        private readonly List<Product> _products = new();

        public ProductDto GetProductById(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null) return null;

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                IsAvailable = product.IsAvailable
            };
        }

        public IEnumerable<ProductDto> GetAllProducts()
        {
            return _products.Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                IsAvailable = p.IsAvailable
            }).ToList();
        }
    }
}

