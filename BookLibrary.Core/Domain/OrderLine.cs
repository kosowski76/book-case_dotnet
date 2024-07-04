namespace BookLibrary.Core.Domain;

public class OrderLine : Entity
{
    public Guid OrderId { get; protected set; }
    public Guid BookId { get; protected set; }
    public int Quantity { get; protected set; }
    public decimal Price { get; protected set; }
    public Guid? UserId { get; protected set; }
    public string? Username { get; protected set; }
    public DateTime? BorrowedAt { get; protected set; }
    public bool Borrowed => UserId.HasValue;

    protected OrderLine() {
    }

    public OrderLine(Order order, int quantity, decimal price)
    {
        OrderId = order.Id;
        Quantity = quantity;
        Price = price;
    }
}
