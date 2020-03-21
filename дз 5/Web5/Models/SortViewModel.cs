using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilterSortPagingApp.Models
{
    public class SortViewModel
    {
        public SortState NameSort { get; private set; }
        public SortState ExpSort { get; private set; }
        public SortState CompanySort { get; private set; }
        public SortState Current { get; private set; }

        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            ExpSort = sortOrder == SortState.ExpAsc ? SortState.ExpDesc : SortState.ExpAsc;
            CompanySort = sortOrder == SortState.CompanyAsc ? SortState.CompanyDesc : SortState.CompanyAsc;
            Current = sortOrder;
        }
    }
}
