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
    public class CompanyController : Controller
    {
        private OrderContext _context;

        public CompanyController(OrderContext context)
        {
            _context = context;
        }

        // GET: Company
        public ActionResult Index()
        {
            return View(_context.Companies.ToList());
        }

        // GET: Company/Details/5
        public ActionResult Details(int id)
        {
            Company company = _context.Companies.Find(id);
            if (company == null)
                return NotFound();
            return View(company);
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Company company)
        {
            try
            {
                _context.Companies.Add(company);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Edit/5
        public ActionResult Edit(int id)
        {
            Company company = _context.Companies.Find(id);
            if (company == null)
                return NotFound();
            return View(company);
        }

        // POST: Company/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Company company)
        {
            try
            {
                _context.Companies.Update(company);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Company/Delete/5
        public ActionResult Delete(int id)
        {
            Company company = _context.Companies.Find(id);
            if (company == null)
                return NotFound();
            return View(company);
        }

        // POST: Company/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Company company)
        {
            try
            {
                _context.Companies.Remove(company);
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