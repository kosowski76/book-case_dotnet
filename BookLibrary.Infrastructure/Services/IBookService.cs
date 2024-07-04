namespace BookLibrary.Infrastructure.Services;
using BookLibrary.Core.Domain;

public interface IBookService
{
    Task<IEnumerable<Book>> GetBooksAsync();
    Task AddBookAsync(Book book);
}