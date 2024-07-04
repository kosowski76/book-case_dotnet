namespace BookLibrary.Api.Controllers;
using BookLibrary.Core.Domain;
using BookLibrary.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public async Task<IActionResult> GetOrders(
        [FromQuery] int pageSize = 10,
        [FromQuery] int pageNumber = 1)
    {
        var orders = await _orderService.GetOrdersAsync(pageSize, pageNumber);
        
        return Ok(orders);
    }
}