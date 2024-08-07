﻿

namespace OrderService.Contracts.DTOs
{
    public class CreateOrderDto
    {
        public string CustomerName { get; set; }
        public string ShippingAddress { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
    }

    public class OrderItemDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

