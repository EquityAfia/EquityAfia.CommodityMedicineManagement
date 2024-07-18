
using OrderService.Application.Interfaces.Commands;
using OrderService.Contracts.DTOs;
using OrderService.Domain.Entities;

namespace OrderService.Application.Services.Commands
{
    public class OrderCommandService : IOrderCommandService
    {
        private readonly List<Order> _orders = new();
        private readonly IProductQueryService _productQueryService;

        public OrderCommandService(IProductQueryService productQueryService)
        {
            _productQueryService = productQueryService;
        }

        public Order CreateOrder(CreateOrderDto orderDto)
        {
            var order = new Order
            {
                Id = GenerateOrderId(),
                OrderDate = DateTime.UtcNow,
                CustomerName = orderDto.CustomerName,
                ShippingAddress = orderDto.ShippingAddress,
                OrderItems = MapOrderItems(orderDto.OrderItems)
            };

            _orders.Add(order);
            return order;
        }

        private int GenerateOrderId()
        {
            // Logic to generate unique order ID (e.g., from a database sequence or GUID)
            return _orders.Count + 1; // Simplified for demonstration
        }

        private List<OrderItem> MapOrderItems(List<OrderItemDto> orderItemsDto)
        {
            var orderItems = new List<OrderItem>();

            foreach (var itemDto in orderItemsDto)
            {
                var product = _productQueryService.GetProductById(itemDto.ProductId);

                if (product != null)
                {
                    var orderItem = new OrderItem
                    {
                        ProductId = product.Id,
                        ProductName = product.Name,
                        Quantity = itemDto.Quantity,
                        UnitPrice = product.Price
                    };

                    orderItems.Add(orderItem);
                }
                else
                {
                    throw new ApplicationException($"Product with ID {itemDto.ProductId} not found.");
                }
            }

            return orderItems;
        }
    }
}
