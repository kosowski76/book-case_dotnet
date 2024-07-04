// using BookLibrary.Api.Controllers;
// using BookLibrary.Api.Interfaces;
// using BookLibrary.Api.Exceptions;
using BookLibrary.Core.Domain;
using BookLibrary.Core.Repositories;
using BookLibrary.Infrastructure.Repositories;
// using BookLibrary.Infrastructure.Resources;
using BookLibrary.Infrastructure.Services;
// using BookLibrary.Infrastructure.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddSingleton<IBookRepository, BookRepository>();
builder.Services.AddSingleton<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddSingleton(AutoMapperConfig.Initialize());

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
