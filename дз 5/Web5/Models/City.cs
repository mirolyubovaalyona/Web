using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterSortPagingApp.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Pilot> Pilots { get; set; }
        public City()
        {
            Pilots = new List<Pilot>();
        }
    }
}
