using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Application.Dtos
{
    public class UpdateProductDto
    {
        public int Id { get; set; }  // Required to identify the product to update

        public string Name { get; set; }  // Include properties that can be updated
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
