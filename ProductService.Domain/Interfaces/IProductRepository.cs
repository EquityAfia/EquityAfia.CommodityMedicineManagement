/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductService.Domain.Entities;

namespace ProductService.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
*/
using ProductService.Domain.Entities;
using System.Collections.Generic;

namespace ProductService.Domain.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        Product GetById(int id);
        IEnumerable<Product> GetAll();
        void SaveChanges();
    }
}

