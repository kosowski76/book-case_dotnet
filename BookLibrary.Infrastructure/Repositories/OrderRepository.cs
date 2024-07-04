namespace BookLibrary.Infrastructure.Repositories;
using BookLibrary.Core.Domain;
using BookLibrary.Core.Repositories;

public class OrderRepository : IOrderRepository
{
    private readonly ISet<Order> _orders;

    public OrderRepository()
    {
        _orders = new HashSet<Order>();
    }

    public Task<IEnumerable<Order>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<Order>>(_orders);
    }

    public Task<Order> GetByIdAsync(Guid id)
    {
        // Since orders use GUID as ID, this method is redundant
        throw new NotImplementedException();
    }

    public Task AddAsync(Order order)
    {
        _orders.Add(order);
        return Task.CompletedTask;
    }
}
