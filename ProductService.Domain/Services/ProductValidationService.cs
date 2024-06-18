using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductService.Domain.Entities;

namespace ProductService.Domain.Services
{
    public class ProductValidationService
    {
        public bool IsValid(Product product)
        {
            // Implement validation logic here
            return !string.IsNullOrEmpty(product.Name) && product.Price > 0;
        }

    }
}

