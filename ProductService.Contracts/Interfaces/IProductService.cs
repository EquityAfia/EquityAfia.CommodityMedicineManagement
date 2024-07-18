using ProductService.Application.Dto.ProductService.Application.Dtos;
using ProductService.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Application.Contracts.Dtos;

public interface IProductService
{
    Task<IEnumerable<ProductDto>> GetAllAsync();
    Task<ProductDto> GetByIdAsync(int id);
    Task<ProductDto> AddAsync(CreateProductDto createProductDto);
    Task UpdateAsync(UpdateProductDto updateProductDto);
    Task DeleteAsync(int id);
}

