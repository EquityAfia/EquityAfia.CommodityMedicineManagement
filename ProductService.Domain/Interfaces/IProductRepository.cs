using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

