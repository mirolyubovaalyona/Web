using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using task_4.Models.Entities;

namespace task_4.Models
{
    public class OrderContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Company> Companies { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
