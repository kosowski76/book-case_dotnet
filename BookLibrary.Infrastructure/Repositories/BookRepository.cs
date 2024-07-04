namespace BookLibrary.Infrastructure.Repositories;
using BookLibrary.Core.Domain;
using BookLibrary.Core.Repositories;

public class BookRepository : IBookRepository
{
    private readonly ISet<Book> _books;

    public BookRepository()
    {
        _books = new HashSet<Book>();
    }

    public Task<IEnumerable<Book>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<Book>>(_books);
    }

    public Task<Book> GetByIdAsync(Guid id)
    // public Task<Book> GetByIdAsync(int id)
    {
        var book = _books.FirstOrDefault(b => b.Id == id);
        return Task.FromResult(book);
    }

    public Task AddAsync(Book book)
    {
        _books.Add(book);
        return Task.CompletedTask;
    }
}
