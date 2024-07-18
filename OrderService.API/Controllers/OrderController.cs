using Microsoft.AspNetCore.Mvc;
using OrderService.Application.Interfaces.Commands;
using OrderService.Contracts.DTOs;

namespace OrderService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderCommandService _orderCommandService;

        public OrderController(IOrderCommandService orderCommandService)
        {
            _orderCommandService = orderCommandService;
        }

        [HttpPost]
        public IActionResult CreateOrder([FromBody] CreateOrderDto orderDto)
        {
            if (orderDto == null || orderDto.OrderItems == null || orderDto.OrderItems.Count == 0)
            {
                return BadRequest("Order data is null or empty.");
            }

            var order = _orderCommandService.CreateOrder(orderDto);
            return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(int id)
        {
            // Logic to retrieve order by ID (implementation not provided)
            return Ok(); // Placeholder
        }
    }
}

