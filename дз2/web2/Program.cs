using System;
using System.Collections.Generic;

namespace web2
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
            Console.WriteLine("??????????");
        }
    }

    public class AuthorManager
    {
        public
           List<Author> data;

        public void Add(Author k)
        {
            data.Add(k);
        }

        public bool Remove(Author k) // удаляет элемент item из списка, и если удаление прошло успешно, то возвращает true
        {
            return data.Remove(k);
        }

        List<Author> Data()
        {
            return data;
        }

        public dynamic GetByID(int k)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].ID == k)
                {
                    return data[i];
                }
            }
            return false;
        }


        public bool CheckID (int k)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].ID == k)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class PublisherManager
    {
        public
          List<Publisher> data;

        public void Add(Publisher k)
        {
            data.Add(k);
        }
        public bool Remove(Publisher k) 
        {
            return data.Remove(k);
        }
        public List<Publisher> Data()
        {
            return data;
        }

        public dynamic GetByID(int k)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].ID == k)
                {
                    return data[i];
                }
            }
            return false;
        }
        public bool CheckID(int k)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].ID == k)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class GenreManager
    {
        public
           List<Genre> data;

        public void Add(Genre k)
        {
            data.Add(k);
        }
        public bool Remove(Genre k)
        {
            return data.Remove(k);
        }
        public List<Genre> Data()
        {
            return data;
        }
        public dynamic GetByID(int k)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].ID == k)
                {
                    return data[i];
                }
            }
            return false;
        }

        public bool CheckID(int k)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].ID == k)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class BookManager
    {
        public
           List<Book> data;

        public void Add(Book k)
        {
            data.Add(k);
        }
        public bool Remove(Book k)
        {
            return data.Remove(k);
        }
        public List<Book> Data()
        {
            return data;
        }

        public dynamic GetByID(int k)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].ID == k)
                {
                    return data[i];
                }
            }
            return false;
        }

        public bool CheckID(int k)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].ID == k)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class CashManager
    {
        public DepotManager Depot;
        public void AllAuthor()
        {
            ;
        }

        public void AllPublisher()
        {
            ;
        }

        public void AllGenre()
        {
            ;
        }

        public void AllBook()
        {
            ;
        }


        public dynamic SellBookByID(int k) {
            if (Depot.CheckBookByID(k)==true)
            {
                Depot.RemoveBookByID(k);
                return true;
            }
            return false;
        }
    }

    public class DepotManager
    {
        public
           AuthorManager Authors;
           PublisherManager Publishers;
           GenreManager Genres;
           BookManager Books;

        public bool RemoveBookByID(int k) // удаляет элемент item из списка, и если удаление прошло успешно, то возвращает true
        {
            return Books.Remove(Books.GetByID(k));
        }
        public void AddPublisher(Publisher k)
        {
            Publishers.Add(k);

        }
        public void AddAuthor(Author k)
        {
            Authors.Add(k);

        }
        public void AddGenre(Genre k)
        {
            Genres.Add(k);

        }
        public void AddBook(Book k)
        {
            Books.Add(k);

        }

        public void DisplayAllBooks()
        {
            for (int i = 0; i < Books.data.Count; i++)
            {
                Books.data[i].Display();
            }
        }
        public void DisplayAllGenres()
        {
            for (int i = 0; i < Genres.data.Count; i++)
            {
                Genres.data[i].Display();
            }
        }
        public void DisplayAllAuthors()
        {
            for (int i = 0; i < Authors.data.Count; i++)
            {
                Authors.data[i].Display();
            }
        }
        public void DisplayAllPublishers()
        {
            for (int i = 0; i < Publishers.data.Count; i++)
            {
                Publishers.data[i].Display();
            }
        }

        public bool CheckBookByID(int k)
        {
            for (int i = 0; i < Books.data.Count; i++)
            {
                if (Books.data[i].ID == k)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Person tom = new Person();//конструктор по кмолчанию
        }
    }
}
