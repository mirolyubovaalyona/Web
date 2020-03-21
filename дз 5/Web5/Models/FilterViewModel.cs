using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FilterSortPagingApp.Models
{
    public class FilterViewModel
    {
        public FilterViewModel(List<Genre> genres, int? genre, string name)
        {
            genres.Insert(0, new Genre { Name = "Все", Id = 0 });
            Genres = new SelectList(genres, "Id", "Name", genre);
            SelectedGenre = genre;
            SelectedName = name;
        }
        public SelectList Genres { get; private set; } 
        public int? SelectedGenre { get; private set; }  
        public string SelectedName { get; private set; } 
    }

    public enum SortState
    {
        NameAsc,    
        NameDesc,  
        ExpAsc, 
        ExpDesc, 
        CompanyAsc, 
        CompanyDesc
    }
}