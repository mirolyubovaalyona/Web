using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using task_4.Models;
using task_4.Models.Entities;

namespace task_4.Controllers
{
    public class ArticleController : Controller
    {
        private OrderContext _context;

        public ArticleController(OrderContext context)
        {
            _context = context;
        }

        // GET: Article
        public ActionResult Index()
        {
            return View(_context.Articles.ToList());
        }

        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            Article article = _context.Articles.Find(id);
            if (article == null)
                return NotFound();
            return View(article);
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Article article)
        {
            try
            {
                _context.Articles.Add(article);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            Article article = _context.Articles.Find(id);
            if (article == null)
                return NotFound();
            return View(article);
        }

        // POST: Article/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Article article)
        {
            try
            {
                _context.Articles.Update(article);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            Article article = _context.Articles.Find(id);
            if (article == null)
                return NotFound();
            return View(article);
        }

        // POST: Article/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Article article)
        {
            try
            {
                _context.Articles.Remove(article);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}