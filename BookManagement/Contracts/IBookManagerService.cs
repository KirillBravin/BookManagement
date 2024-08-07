using BookManagement.Services;
using BookManagement.Models;

namespace BookManagement.Contracts
{
    public interface IBookManagerService
    {
        List<Book> ShowAllBooks();
        Book GetBookById(int id);
        void AddNewBook(string title, string author, int year);
        void UpdateBook(int id, string title, string author, int year);
        void DeleteBook(int id);
    }
}
