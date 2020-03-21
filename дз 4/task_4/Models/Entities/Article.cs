using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace task_4.Models.Entities
{
    public class Article
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Date { get; set; }

        public int CompanyId { get; set; }

        public int NumberOfCopies { get; set; }
    }
}
