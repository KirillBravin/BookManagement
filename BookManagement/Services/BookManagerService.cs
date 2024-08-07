using BookManagement.Contracts;
using BookManagement.Models;

namespace BookManagement.Services
{
    public class BookManagerService : IBookManagerService
    {
        int uniqueId = 0;
        List<Book> allBooks = new List<Book>();
        public List<Book> ShowAllBooks()
        {
            return allBooks;
        }

        public Book GetBookById(int id)
        {
            foreach (Book book in allBooks)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }

        public void AddNewBook(string title, string author, int year)
        {
            Book newBook = new Book(uniqueId++, title, author, year);
            allBooks.Add(newBook);
        }

        public void UpdateBook(int id, string title, string author, int year)
        {
            foreach (Book book in allBooks)
            {
                if (id == book.Id)
                {
                    book.Title = title;
                    book.Author = author;
                    book.Year = year;
                }
            }
        }

        public void DeleteBook(int id)
        {
            foreach (Book book in allBooks)
            {
                if (id == book.Id)
                {
                    allBooks.Remove(book);
                }
            }
        }
    }
}
