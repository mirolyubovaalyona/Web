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
    }

    public class Book
    {
        public
            int ID, AuthorID, PublisherID;
            string Name, ReleaseDate;
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


        public bool CheckAuthorID (int k)
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


        //●	Изменить

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
    }
    public class CashManager
    {
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

        public void BuyBookByID()
        {
            ;
        }


        ///●	Продать книгу
    }

    public class DepotManager
    {
        public
           List<int> data;//id of books


        public void Add(int k)
        {
            data.Add(k);
        }

        public bool Remove(int k) 
        {
            return data.Remove(k);
        }
        public bool CheckBookByID(int k)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] == k)
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
