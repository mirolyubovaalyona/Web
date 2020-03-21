using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterSortPagingApp.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Film> Films{ get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public SortViewModel SortViewModel { get; set; }
    }
}
