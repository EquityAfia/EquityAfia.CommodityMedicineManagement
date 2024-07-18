using ProductService.Application.Dtos;
using ProductService.Contracts.Dtos;
using ProductService.Domain.Entities;

namespace ProductService.Application.Interfaces.Commands
{
    public interface IProductCommandService
    {
        Product CreateProduct(CreateProductDto productDto);
    }
}

