using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiMongo.Contracts;
using WebApiMongo.Models;
using WebApiMongo.Services;

namespace WebApiMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            var controller = typeof(WeatherForecastController);
            
            _bookService = bookService;
        }

        // GET
        // https://localhost:44376/api/books
        [HttpGet]
        public ActionResult<List<Book>> Get() => _bookService.Get();

        // GET
        // https://localhost:44376/api/books/5bfd996f7b8e48dc15ff215d
        [HttpGet("{id:length(24)}", Name = "GetName")]
        public ActionResult<Book> Get(string id)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // POST
        // https://localhost:44376/api/books
        //  {
        //      "id": "5bfd996f7b8e48dc15ff215d",
        //      "bookName": "Design Patterns222",
        //      "price": 54.93,
        //      "category": "Computers2",
        //      "author": "Ralph Johnson2"
        //  }
        [HttpPost]
        public ActionResult<Book> Create(Book book)
        {
            _bookService.Create(book);

            return CreatedAtRoute("GetBook", new { id = book.Id.ToString() }, book);
        }

        // PUT
        // https://localhost:44376/api/books/5bfd996f7b8e48dc15ff215d
        //  {
        //      "id": "5bfd996f7b8e48dc15ff215d",
        //      "bookName": "Design Patterns222",
        //      "price": 54.93,
        //      "category": "Computers2",
        //      "author": "Ralph Johnson2"
        //  }
        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Book bookIn)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _bookService.Update(id, bookIn);

            return NoContent();
        }

        // DELETE
        // https://localhost:44376/api/books/5bfd996f7b8e48dc15ff215d
        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var book = _bookService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _bookService.Remove(book.Id);

            return NoContent();
        }
    }
}
