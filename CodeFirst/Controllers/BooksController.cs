using CodeFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BtkAkademiDbContext _context;
        public BooksController(BtkAkademiDbContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            books = _context.Book.ToList();
            return books;
        }

        [HttpPost]
        public Book AddBook(Book newBook)
        {
            _context.Book.Add(newBook);
            _context.SaveChanges();
            return newBook;
        }
    }
}
