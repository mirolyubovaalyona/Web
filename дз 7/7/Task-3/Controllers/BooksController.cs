using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_3.Models;


namespace Task_3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        BookContext db;
        public BooksController(BookContext context)
        {
            db = context;
            if ((db.Books.Count() == 0) || (db.Authors.Count() == 0))
            {
                Author author1 = new Author { Name = "Джоан Роалинг", Birthday = 1965 };
                Author author2 = new Author { Name = "Рэй Брэдбери", Birthday = 1920 };
                db.Authors.AddRange(author1, author2);
                db.SaveChanges();
                Book book1 = new Book { Title = "Гарри Поттер и философский камень", Year = 1997, Author = author1 };
                Book book2 = new Book { Title = "Гарри Поттер и Тайная комната", Author = author1, Year = 1998 };
                Book book3 = new Book { Title = "Марсианские Хроники", Year = 1950, Author = author2 };
                db.Books.AddRange(book1, book2, book3);
                db.SaveChanges();
            }
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> Get()
        {
            return await db.Books.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> Get(int id)
        {
            Book book = await db.Books.FirstOrDefaultAsync(x => x.Id == id);
            if (book == null)
                return NotFound();
            return new ObjectResult(book);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> Post(Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }

            db.Books.Add(book);
            await db.SaveChangesAsync();
            return Ok(book);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Book>> Put(Book book)
        {
            if (book == null)
            {
                return BadRequest();
            }
            if (!db.Books.Any(x => x.Id == book.Id))
            {
                return NotFound();
            }

            db.Books.Update(book);
            await db.SaveChangesAsync();
            return Ok(book);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> Delete(int id)
        {
            Book book = db.Books.FirstOrDefault(x => x.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            db.Books.Remove(book);
            await db.SaveChangesAsync();
            return Ok(book);
        }
    }
}
