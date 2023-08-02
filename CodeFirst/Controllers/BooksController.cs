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

        [HttpPut]
        public Book UpdateBook(Book newBook)
        {
            _context.Book.Update(newBook);
            _context.SaveChanges();
            return newBook;
        }

        [HttpDelete("{id}")]
        public void DeleteBook(int id)
        {
            var deletedBook = _context.Book.Find(id);
            _context.Book.Remove(deletedBook);
            _context.SaveChanges();
        }

        [HttpGet("{id}")]
        public Book GetBookDetails(int id)
        {
            Book details = _context.Book.Find(id);
            return details;
        }
    }
}
