using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web4.Models
{
    public class entities
    {
        public class Author
        {
            public
                int ID;
            string Name, Surname, DateOfBirth;

            public Author(int ID, string Name, string Surname, string DateOfBirth)
            {
                this.ID = ID;
                this.Name = Name;
                this.Surname = Surname;
                this.DateOfBirth = DateOfBirth;

            }

            void ChangeName(string k)
            {
                Name = k;
            }

            void ChangeSurname(string k)
            {
                Surname = k;
            }

            void ChangeDateOfBirth(string k)
            {
                DateOfBirth = k;
            }

            void ChangAll(string Name, string Surname, string DateOfBirth)
            {
                this.Name = Name;
                this.Surname = Surname;
                this.DateOfBirth = DateOfBirth;
            }

            public void Display()
            {
                Console.WriteLine($"ID: {ID} Имя: {Name}  Фамилия: {Surname}  DateOfBirth: {DateOfBirth}");
            }

        }

        public class Publisher
        {
            public
                int ID;
            string Name;

            public Publisher(int ID, string Name)
            {
                this.ID = ID;
                this.Name = Name;
            }

            public void ChangeName(string k)
            {
                Name = k;
            }
            public void Display()
            {
                Console.WriteLine($"ID: {ID} Имя: {Name}");
            }
        }

        public class Genre
        {
            public
                int ID;
            string Name;

            public Genre(int ID, string Name)
            {
                this.ID = ID;
                this.Name = Name;
            }

            public void ChangeName(string k)
            {
                Name = k;
            }
            public void Display()
            {
                Console.WriteLine($"ID: {ID} Имя: {Name}");
            }
        }

        public class Book
        {
            public
                int ID, AuthorID, PublisherID;
            public string Name, ReleaseDate;
            List<int> GenreIDs;
            public Book(int ID, int AuthorID, int PublisherID, string Name, string ReleaseDate, List<int> GenreIDs)
            {
                this.ID = ID;
                this.AuthorID = AuthorID;
                this.PublisherID = PublisherID;
                this.Name = Name;
                this.ReleaseDate = ReleaseDate;
                this.GenreIDs = GenreIDs;
            }

            public void ChangeName(string k)
            {
                Name = k;
            }

            public void ChangeReleaseDate(string k)
            {
                ReleaseDate = k;
            }

            public void ChangeAuthorID(int k)
            {
                AuthorID = k;
            }

            public void ChangePublisherID(int k)
            {
                PublisherID = k;
            }

            public void ChangeGenreIDs(List<int> k)
            {
                GenreIDs = k;
            }

            public void AddGenreID(int k)
            {
                GenreIDs.Add(k);
            }

            public bool RemoveGenreID(int k)
            {
                return GenreIDs.Remove(k);
            }

            public void Display()
            {
                Console.WriteLine($"ID: {ID} Название: {Name}  Дата выхода: {ReleaseDate}  ID автора: {AuthorID}  ID издания: {PublisherID}");
            }
        }
    }
}
