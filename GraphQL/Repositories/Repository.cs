using GraphQL.Models;

namespace GraphQL.Repositories
{
    public class Repository : IRepository
    {
        private readonly List<Author> _authors = new List<Author>
        {
            new Author { Id = 1, Name = "George Orwell", Bio = "Author of 1984 and Animal Farm" },
            new Author { Id = 2, Name = "J.R.R. Tolkien", Bio = "Author of The Hobbit and The Lord of the Rings" }
        };

        private readonly List<Book> _books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = new Author { Id = 1, Name = "George Orwell" } },
            new Book { Id = 2, Title = "The Hobbit", Author = new Author { Id = 2, Name = "J.R.R. Tolkien" } }
        };

        public IEnumerable<Author> GetAllAuthors() => _authors;
        public Author GetAuthorById(int id) => _authors.FirstOrDefault(a => a.Id == id);
        public Author AddAuthor(Author author)
        {
            author.Id = _authors.Max(a => a.Id) + 1;
            _authors.Add(author);
            return author;
        }

        public IEnumerable<Book> GetAllBooks() => _books;
        public Book GetBookById(int id) => _books.FirstOrDefault(b => b.Id == id);
        public Book AddBook(Book book)
        {
            book.Id = _books.Max(b => b.Id) + 1;
            _books.Add(book);
            return book;
        }
    }
}
