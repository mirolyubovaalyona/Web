using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web4.Models
{
    public class Manager
    {
        public class AuthorManager
        {
            public
               List<Author> data;

            public AuthorManager()
            {
                data = new List<Author>() { };
            }
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

        public class PublisherManager
        {
            public
              List<Publisher> data;

            public PublisherManager()
            {
                data = new List<Publisher>() { };
            }

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

            public GenreManager()
            {
                data = new List<Genre>() { };
            }
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
            public BookManager()
            {
                data = new List<Book>() { };
            }
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

            public CashManager()
            {
                Depot = new DepotManager();
            }
            public void AllAuthor()
            {
                Depot.DisplayAllAuthors();
            }

            public void AllPublisher()
            {
                Depot.DisplayAllPublishers();
            }

            public void AllGenre()
            {
                Depot.DisplayAllGenres();
            }

            public void AllBook()
            {
                Depot.DisplayAllBooks(); ;
            }


            public dynamic SellBookByID(int k)
            {
                if (Depot.CheckBookByID(k) == true)
                {
                    Depot.RemoveBookByID(k);
                    return true;
                }
                return false;
            }
        }
        public class DepotManager
        {
            public AuthorManager Authors;
            public PublisherManager Publishers;
            public GenreManager Genres;
            public BookManager Books;

            public DepotManager()
            {
                Authors = new AuthorManager();
                Publishers = new PublisherManager();
                Genres = new GenreManager();
                Books = new BookManager();
            }
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
    }
}
