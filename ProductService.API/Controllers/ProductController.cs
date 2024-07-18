/*using Microsoft.AspNetCore.Mvc;
using ProductService.Application.Interfaces;
using ProductService.Application.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using ProductService.Application.Dtos;
using ProductService.Application.Interfaces;
using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using ProductService.Application.Dtos;
using ProductService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductService.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAll()
        {
            try
            {
                var products = await _productService.GetAllAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetById(int id)
        {
            try
            {
                var product = await _productService.GetByIdAsync(id);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<ProductDto>> Create(CreateProductDto createProductDto)
        {
            try
            {
                var productDto = await _productService.AddAsync(createProductDto);
                return CreatedAtAction(nameof(GetById), new { id = productDto.Id }, productDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateProductDto updateProductDto)
        {
            try
            {
                if (id != updateProductDto.Id)
                {
                    return BadRequest("Id mismatch between route parameter and request body.");
                }

                await _productService.UpdateAsync(updateProductDto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _productService.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
*/
using Microsoft.AspNetCore.Mvc;
using ProductService.Application.Dtos;
using ProductService.Application.Interfaces.Commands;
using ProductService.Application.Interfaces.Queries;

using ProductService.Contracts.Dtos;

namespace ProductService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductCommandService _productCommandService;
        private readonly IProductQueryService _productQueryService;

        public ProductController(IProductCommandService productCommandService, IProductQueryService productQueryService)
        {
            _productCommandService = productCommandService;
            _productQueryService = productQueryService;
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] CreateProductDto productDto)
        {
            if (productDto == null)
            {
                return BadRequest("Product data is null.");
            }

            var product = _productCommandService.CreateProduct(productDto);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _productQueryService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productQueryService.GetAllProducts();
            return Ok(products);
        }
    }
}




