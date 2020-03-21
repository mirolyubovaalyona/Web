using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FilterSortPagingApp.Models;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FilterSortPagingApp.Controllers
{
    public class HomeController : Controller
    {
        GenresContext db;
        public HomeController(GenresContext context)
        {
            this.db = context;
            if (db.Genres.Count() == 0)
            {
                Genre Horror = new Genre { Name = "Horror" };
                Genre Comedy = new Genre { Name = "Comedy" };
                Genre Action = new Genre { Name = "Action" };

                Film film1 = new Film { name = "Сонная Лощина", Genre = Horror, year = 1999, CreationDate = DateTime.Now};
                Film film2 = new Film { name = "1 + 1", Genre = Comedy, year = 2011, CreationDate = DateTime.Now };
                Film film3 = new Film { name = "Интервью с вампиром", Genre = Horror, year = 1994, CreationDate = DateTime.Now };
                Film film4 = new Film { name = "Константин", Genre = Horror, year = 2005, CreationDate = DateTime.Now };
                Film film5 = new Film { name = "Начало", Genre = Action, year = 2010, CreationDate = DateTime.Now };
                Film film6 = new Film { name = "Матрица", Genre = Action, year = 1999, CreationDate = DateTime.Now };
                Film film7 = new Film { name = "Оно", Genre = Horror, year = 2017, CreationDate = DateTime.Now };
                Film film8 = new Film { name = "1408", Genre = Horror, year = 2007, CreationDate = DateTime.Now };
                Film film9 = new Film { name = "Криминальное чтиво", Genre = Comedy, year = 1994, CreationDate = DateTime.Now };

                db.Genres.AddRange(Horror, Comedy, Action);
                db.Films.AddRange(film1, film2, film3, film4, film5, film6, film7, film8, film9);
                db.SaveChanges();
            }
        }
        [HttpPost]
        public ActionResult Add(Film film)
        {
            if (db.Films.Contains(film))
            {
                return BadRequest();
            }
            if (!db.Genres.Contains(film.Genre))
            {
                db.Genres.Add(film.Genre);
            }
            film.CreationDate = DateTime.Now;
            db.Films.Add(film);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Index(int? genre, string name, int page = 1,
            SortState sortOrder = SortState.NameAsc)
        {
            int pageSize = 5;

            //фильтрация
            IQueryable<Film> films = db.Films.Include(x => x.Genre);

            if (genre != null && genre != 0)
            {
                films = films.Where(p => p.GenreId == genre);
            }
            if (!String.IsNullOrEmpty(name))
            {
                films = films.Where(p => p.name.Contains(name));
            }

            // сортировка
            switch (sortOrder)
            {
                case SortState.NameDesc:
                    films = films.OrderByDescending(s => s.name);
                    break;
                case SortState.ExpAsc:
                    films = films.OrderBy(s => s.year);
                    break;
                case SortState.ExpDesc:
                    films = films.OrderByDescending(s => s.year);
                    break;
                case SortState.CompanyAsc:
                    films = films.OrderBy(s => s.Genre.Name);
                    break;
                case SortState.CompanyDesc:
                    films = films.OrderByDescending(s => s.Genre.Name);
                    break;
                default:
                    films = films.OrderBy(s => s.name);
                    break;
            }

            // пагинация
            var count = await films.CountAsync();
            var items = await films.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            // формируем модель представления
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(db.Genres.ToList(), genre, name),
                Films = items
            };
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
    }
}