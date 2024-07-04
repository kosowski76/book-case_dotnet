namespace BookLibrary.Infrastructure.Services;
using BookLibrary.Core.Domain;
using BookLibrary.Core.Repositories;
using BookLibrary.Infrastructure.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<IEnumerable<Order>> GetOrdersAsync(
        int pageSize, int pageNumber)
    {
        // Implementation of pagination logic
        var orders = await _orderRepository.GetAllAsync();
        return orders
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize);
    }
}
