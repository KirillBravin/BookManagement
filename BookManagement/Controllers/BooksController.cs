using Microsoft.AspNetCore.Mvc;
using BookManagement.Models;
using BookManagement.Services;
using BookManagement.Contracts;

namespace BookManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : Controller
    {
        private readonly IBookManagerService _bookManagerService;

        public BooksController(IBookManagerService bookManagerService)
        {
            _bookManagerService = bookManagerService;
        }

        [HttpGet("ShowAllBooks")]
        public IActionResult ShowAllBooks()
        {
            try
            {
                List<Book> allBooks = _bookManagerService.ShowAllBooks();
                return Ok(allBooks);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Problem();
            }
        }

        [HttpGet("ShowBookById")]
        public IActionResult GetBookById(int id)
        {
            try
            {
                Book bookById = _bookManagerService.GetBookById(id);
                return Ok(bookById);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Problem();
            }
        }

        [HttpPost("AddNewBook")]
        public IActionResult AddNewBook(string title, string author, int year)
        {
            try
            {
                _bookManagerService.AddNewBook(title, author, year);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Problem();
            }
        }

        [HttpPatch("UpdateBook")]
        public IActionResult UpdateBook(int id, string title, string author, int year)
        {
            try
            {
                _bookManagerService.UpdateBook(id, title, author, year);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Problem();
            }
        }

        [HttpDelete("DeleteBook")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                _bookManagerService.DeleteBook(id);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Problem();
            }
        }
    }
}
