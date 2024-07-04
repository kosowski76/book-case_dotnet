namespace BookLibrary.Infrastructure.Services;
using BookLibrary.Core.Domain;

public interface IOrderService
{
    Task<IEnumerable<Order>> GetOrdersAsync(int pageSize, int pageNumber);
}
