namespace BookLibrary.UnitTests.Tests;
using BookLibrary.Core.Domain;
using BookLibrary.Infrastructure.Services;
using BookLibrary.Core.Repositories;

using Moq;
using Xunit;

public class BookServiceTests
{
    private readonly IBookService _bookService;
    private readonly Mock<IBookRepository> _bookRepositoryMock;

    public BookServiceTests()
    {
        _bookRepositoryMock = new Mock<IBookRepository>();
        _bookService = new BookService(_bookRepositoryMock.Object);
    }

    [Fact]
    public async Task GetBooksAsync_ShouldReturnBooks()
    {
        string guidString = "d72c25b0-6b3c-4f4a-03a4-32e64b12345a";
        Guid guid = Guid.Parse(guidString);

        // Arrange
        var books = new List<Book>
        {
            new Book { Id = guid, Title = "Book 1", Price = 10.99m }
        };
        
        _bookRepositoryMock.Setup(repo => repo.GetAllAsync()).ReturnsAsync(books);

        // Act
        var result = await _bookService.GetBooksAsync();

        // Assert
        Assert.Single(result);
        Assert.Equal("Book 1", result.First().Title);
    }

    [Fact]
    public async Task AddBookAsync_ShouldAddBook()
    {
        string guidString = "d72c25b0-6b3c-4f4a-03a4-32e64b12345a";
        Guid guid = Guid.Parse(guidString);

        // Arrange
        var book = new Book { Id = guid, Title = "New Book", Price = 15.99m };

        // Act
        await _bookService.AddBookAsync(book);

        // Assert
        _bookRepositoryMock.Verify(repo => repo.AddAsync(book), Times.Once);
    }
}
