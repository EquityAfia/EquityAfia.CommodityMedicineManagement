namespace OrderService.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string ShippingAddress { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public decimal TotalAmount => CalculateTotalAmount();

        private decimal CalculateTotalAmount()
        {
            decimal total = 0;
            foreach (var item in OrderItems)
            {
                total += item.Quantity * item.UnitPrice;
            }
            return total;
        }
    }

    public class OrderItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

