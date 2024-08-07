﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductService.Application.Dto
{
    // File: ProductService.Application/Dtos/ProductDto.cs

    namespace ProductService.Application.Dtos
    {
        public class ProductDto
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public bool IsAvailable { get; set; }
        }
    }

}*/
namespace ProductService.Contracts.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}


