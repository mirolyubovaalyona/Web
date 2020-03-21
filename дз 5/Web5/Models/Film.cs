using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterSortPagingApp.Models
{
    public class Film
    {
        public int id { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public DateTime CreationDate { get; set; }
        public TimeSpan Lifetime
        {
            get
            {
                return DateTime.Now - CreationDate;
            }
        }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}
