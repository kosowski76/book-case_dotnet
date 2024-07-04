namespace BookLibrary.Core.Domain;

public class Book : Entity
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public int Bookstand { get; set; }
    public int Shelf { get; set; }
    public List<Author> Authors { get; set; } = new();
}

public class Author
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
