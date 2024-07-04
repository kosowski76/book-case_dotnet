namespace BookLibrary.Infrastructure.Services;
using BookLibrary.Core.Domain;
using BookLibrary.Core.Repositories;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<IEnumerable<Book>> GetBooksAsync()
    {
        return await _bookRepository.GetAllAsync();
    }

    public async Task AddBookAsync(Book book)
    {
        await _bookRepository.AddAsync(book);
    }
}
