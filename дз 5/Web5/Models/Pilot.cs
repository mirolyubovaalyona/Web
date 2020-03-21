using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterSortPagingApp.Models
{
    public class Pilot
    {
        public int id { get; set; }
        public string name { get; set; }
        public int exp { get; set; }
        public DateTime CreationDate { get; set; }
        public TimeSpan Lifetime
        {
            get
            {
                return DateTime.Now - CreationDate;
            }
        }
        public int CityId { get; set; }
        public City City { get; set; }

    }
}
