using OrderService.Domain.Entities;
using OrderService.Contracts.DTOs;


namespace OrderService.Application.Interfaces.Commands
{
    public interface IOrderCommandService
    {
        Order CreateOrder(CreateOrderDto orderDto);
    }
}
