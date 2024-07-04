namespace BookLibrary.UnitTests.Tests;
using BookLibrary.Core.Domain;
using BookLibrary.Infrastructure.Services;
using BookLibrary.Core.Repositories;

using Moq;
using Xunit;

public class OrderServiceTests
{
    private readonly IOrderService _orderService;
    private readonly Mock<IOrderRepository> _orderRepositoryMock;

    public OrderServiceTests()
    {
        _orderRepositoryMock = new Mock<IOrderRepository>();
        _orderService = new OrderService(_orderRepositoryMock.Object);
    }

    [Fact]
    public async Task GetOrdersAsync_ShouldReturnPaginatedOrders()
    {

    string guidString = "d72c25b0-6b3c-4f4a-03a4-32e64b12345a";
    Guid guid = Guid.Parse(guidString);

    // Arrange
    var orders = new List<Order>
    {
        new Order(guid) {}
    };
    _orderRepositoryMock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(orders);

    // Act
    var result = await _orderService.GetOrdersAsync(1, 1);

    // Assert
    Assert.Single(result);
    }
}
