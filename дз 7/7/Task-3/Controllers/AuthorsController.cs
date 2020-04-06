using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_3.Models;


namespace Task_3.Controllers
{
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        BookContext db;
        public AuthorsController(BookContext context)
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
        public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
        {
            return await db.Authors.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> GetAuthor(int id)
        {
            Author author = await db.Authors.FirstOrDefaultAsync(x => x.Id == id);
            if (author == null)
                return NotFound();
            return new ObjectResult(author);
        }

        [HttpPost]
        public async Task<ActionResult<Author>> PostAuthor(Author author)
        {
            if (author == null)
            {
                return BadRequest();
            }

            db.Authors.Add(author);
            await db.SaveChangesAsync();
            return Ok(author);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Author>> PutAuthor(Author author)
        {
            if (author == null)
            {
                return BadRequest();
            }
            if (!db.Authors.Any(x => x.Id == author.Id))
            {
                return NotFound();
            }

            db.Authors.Update(author);
            await db.SaveChangesAsync();
            return Ok(author);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Author>> DeleteAuthor(int id)
        {
            Author author = db.Authors.FirstOrDefault(x => x.Id == id);
            if (author == null)
            {
                return NotFound();
            }
            db.Authors.Remove(author);
            await db.SaveChangesAsync();
            return Ok(author);
        }
    }
}
