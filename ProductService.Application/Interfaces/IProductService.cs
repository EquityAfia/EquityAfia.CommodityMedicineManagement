using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductService.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductService.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<ProductDto> GetByIdAsync(int id);
        Task<int> AddAsync(CreateProductDto productDto);
        Task UpdateAsync(UpdateProductDto productDto);
        Task DeleteAsync(int id);
    }
}
/*namespace Application.Interfaces
{
    public interface IProductService
    {
        ProductDto GetProductDetails(Guid productId);
        IEnumerable<ProductDto> ListAllProducts();
        void CreateProduct(ProductDto productDto);
        void UpdateProduct(ProductDto productDto);
        void RemoveProduct(Guid productId);
    }
}*/
