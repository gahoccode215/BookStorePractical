using Repositories.Entities;

namespace Services
{
    public class BookService
    {
        public List<Book> GetAllBooks()
        {
            List<Book> arr = new List<Book>();
            arr.Add(new Book() { BookId = 1, BookName = "Đời Ngắn Đừng Ngủ Dài", Author = "Robin Shama"});
            arr.Add(new Book() { BookId = 2, BookName = "Mình Là Nắng, Việc Của Mình Là Chói Chang", Author = "Son Tung MTP" });
            arr.Add(new Book() { BookId = 3, BookName = "Đừng Quên Tên Anh", Author = "Quân AP" });
            return arr;
        }
    }
}
