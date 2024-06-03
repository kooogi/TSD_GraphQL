namespace GraphQL
{
    public class BookService
    {
        private readonly List<Book> _books = new List<Book>
    {
        new Book { Id = 1, Title = "1984", Author = "George Orwell" },
        new Book { Id = 2, Title = "The Hobbit", Author = "J.R.R. Tolkien" }
    };

        public List<Book> GetBooks() => _books;

        public Book AddBook(int id, string title, string author)
        {
            var book = new Book { Id = id, Title = title, Author = author };
            _books.Add(book);
            return book;
        }

        public Book GetBookById(int id) => _books.FirstOrDefault(b => b.Id == id);
    }

}
