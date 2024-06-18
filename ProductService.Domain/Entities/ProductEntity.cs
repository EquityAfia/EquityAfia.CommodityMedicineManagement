/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } // Warning CS8618
        public string Description { get; set; } // Warning CS8618
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public Product(int id, string name, string description, decimal price, bool isAvailable)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Price = price;
            IsAvailable = isAvailable;
        }
    }
}
*/
namespace ProductService.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public Product(int id, string name, string description, decimal price, bool isAvailable)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            IsAvailable = isAvailable;
        }

        // Default constructor for EF Core or other usages
        public Product() { }
    }
}

