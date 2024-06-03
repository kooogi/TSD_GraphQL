using GraphQL.Models;

namespace GraphQL.Repositories
{
    public interface IRepository
    {
        IEnumerable<Author> GetAllAuthors();
        Author GetAuthorById(int id);
        Author AddAuthor(Author author);

        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        Book AddBook(Book book);
    }
}
