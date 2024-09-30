using Repositories;
using Repositories.Entities;

namespace Services
{

    public class BookService
    {
        private BookRepository _repo = new BookRepository();

        public List<Book> GetBooks()
        {
            return _repo.GetBooks();
        }

        public void AddBook(Book book)
        {
            _repo.AddBook(book);
        }

        public void UpdateBook(Book book)
        {
            _repo.UpdateBook(book);
        }

        public void DeleteBook(Book book)
        {
            _repo.DeleteBook(book);
        }
    }
}
