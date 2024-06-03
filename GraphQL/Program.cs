using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using HotChocolate;
using System.Collections.Generic;
using GraphQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the BookService
builder.Services.AddSingleton<BookService>();

// Add GraphQL services
builder.Services.AddGraphQLServer()
        .AddQueryType<Query>()
        .AddMutationType<Mutation>()
        .AddApolloTracing();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Configure the GraphQL endpoint
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();

    // Set up a default route to redirect to /graphql
    endpoints.MapGet("/", async context =>
    {
        context.Response.Redirect("/graphql", permanent: false);
    });
});

app.Run();

// Define the Query type
public class Query
{
    private readonly BookService _bookService;

    public Query(BookService bookService)
    {
        _bookService = bookService;
    }

    public string Hello() => "Hello, world!";

    // Task 1
    public List<Book> GetBooks() => _bookService.GetBooks();

    // Task 3
    public Book GetBookById(int id) => _bookService.GetBookById(id);
}

// Task 1: Basic Query and Schema Definition
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
}

// Task 2: Mutation to Add a Book
public class Mutation
{
    private readonly BookService _bookService;

    public Mutation(BookService bookService)
    {
        _bookService = bookService;
    }

    public Book AddBook(int id, string title, string author)
    {
        return _bookService.AddBook(id, title, author);
    }
}
