namespace BookLibrary.Core.Domain;
using BookLibrary.Core.Domain;

public class Order : Entity
{
    private ISet<OrderLine> _orderLines = new HashSet<OrderLine>();

    public Guid OrderId { get; set; }
    public DateTime CreatedAt { get; protected set; }
    public DateTime UpdatedAt { get; protected set; }
    public IEnumerable<OrderLine> OrderLines => _orderLines;

    protected Order() {}

    public Order(Guid id) {

        Id = id;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }
    public void AddOrderLines(Guid bookId, int amount, decimal price)
    {
        // a place for book
        var place = _orderLines.Count + 1;
        for(var i = 0; i < amount; i++)
        {
            _orderLines.Add(new OrderLine(this, place, price));
            place++;
        }
    }
}
