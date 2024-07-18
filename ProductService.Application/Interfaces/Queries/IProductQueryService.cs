namespace ProductService.Application.Interfaces.Queries
{
    using ProductService.Contracts.DTOs;
    

    public interface IProductQueryService
    {
        ProductDto GetProductById(int id);
        IEnumerable<ProductDto> GetAllProducts();
    }
}

