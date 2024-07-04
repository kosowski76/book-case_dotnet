namespace BookLibrary.Api.Controllers;
using BookLibrary.Core.Domain;
using BookLibrary.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public async Task<IActionResult> GetBooks()
    {
        var books = await _bookService.GetBooksAsync();
        return Ok(books);
    }

    [HttpPost]
    public async Task<IActionResult> AddBook([FromBody] Book book)
    {
        await _bookService.AddBookAsync(book);
        return CreatedAtAction(nameof(GetBooks), new { id = book.Id }, book);
    }
}
