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
        }
    }

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
            data = new List<Book>() {};
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете что-то из этого");
            Console.WriteLine("1.1 Добавить книгу");
            Console.WriteLine("1.2 Добавить жанр");
            Console.WriteLine("1.3 Добавить автора");
            Console.WriteLine("1.4 Добавить Издателя");
            Console.WriteLine();

            Console.WriteLine("1.11 Вывести все книги");
            Console.WriteLine("1.21 Вывести все жанры");
            Console.WriteLine("1.31 Вывести всех авторов");
            Console.WriteLine("1.41 Вывести всех издателей");
            Console.WriteLine();

            Console.WriteLine("1.12 Вывести книгу  по ID");
            Console.WriteLine("1.22 Вывести жанр  по ID");
            Console.WriteLine("1.32 Вывести автора  по ID");
            Console.WriteLine("1.42 Вывести издателя  по ID");
            Console.WriteLine();

            Console.WriteLine("1.13 есть ли книга с таким ID");
            Console.WriteLine("1.23  есть ли жанр с таким ID");
            Console.WriteLine("1.33  есть ли автор с таким ID");
            Console.WriteLine("1.43  есть ли издатель с таким ID");
            Console.WriteLine();

            Console.WriteLine("2.1  добавить книгу на склад");
            Console.WriteLine("2.2  удалить книгу со склада по ID");
            Console.WriteLine();

            Console.WriteLine("3.1 продать книгу по ID");
            Console.WriteLine();

            CashManager Store = new CashManager();

            string str = "";
            while (str != "exit")
            {
                str = Console.ReadLine();
                if (str != "1.1" && str != "1.2" && str != "1.3" && str != "1.4" 
                    && str != "1.11" && str != "1.21" && str != "1.31" && str != "1.41" && str != "3.1" && str != "2.1" && str != "2.2" 
                    && str != "1.12" && str != "1.22" && str != "1.32" && str != "1.42"
                    && str != "1.13" && str != "1.23" && str != "1.33" && str != "1.43") 
                {
                    Console.WriteLine("Такого не бывает ");
                }
                else if (str == "1.1" || str == "2.1")
                {
                    Console.WriteLine("Введите id, название, дату выхода , id автора, id издателя, спиок из id жанров книги");
                    int k = int.Parse(Console.ReadLine());
                    string n = Console.ReadLine();
                    string d = Console.ReadLine();
                    int ka = int.Parse(Console.ReadLine());
                    int kp = int.Parse(Console.ReadLine());
                    string[] tmp = Console.ReadLine().Split();
                    List<int> g = new List<int>() { };
                    bool cg = true;
                    for (int i = 0; i < tmp.Length; i++)
                    {
                        g.Add(int.Parse(tmp[i]));
                        if (!(Store.Depot.Genres.CheckID(g[i])))
                        {
                            cg = false;
                        }
                    }



                    if (Store.Depot.Books.CheckID(k))
                    {
                        Console.WriteLine("книга с таким ID уже существует");
                    }
                    else if (!(Store.Depot.Authors.CheckID(ka)))
                    {
                        Console.WriteLine("нет автора с таким ID");
                    }
                    else if (!(Store.Depot.Publishers.CheckID(kp)))
                    {
                        Console.WriteLine("нет издателя с таким ID");
                    }
                    else if (!cg) {
                        Console.WriteLine("нет жанра с таким ID");
                    }
                    else {
                        Book p = new Book(k, ka, kp, n, d, g);
                        Store.Depot.AddBook(p);
                    }
                }
                else if (str == "1.2")
                {
                    Console.WriteLine("Введите id, название жанра");
                    int k = int.Parse(Console.ReadLine());
                    string s = Console.ReadLine();
                    Genre p = new Genre(k, s);
                    Store.Depot.AddGenre(p);

                }
                else if (str == "1.3")
                {
                    Console.WriteLine("Введите id, Имя, Фамилию и дату рождения автора");
                    int k = int.Parse(Console.ReadLine());
                    string n = Console.ReadLine();
                    string s = Console.ReadLine();
                    string d = Console.ReadLine();
                    Author p = new Author(k, n, s, d);
                    Store.Depot.AddAuthor(p);
                }
                else if (str == "1.4")
                {
                    Console.WriteLine("Введите id, название издателя");
                    int k = int.Parse(Console.ReadLine());
                    string s = Console.ReadLine();
                    Publisher p = new Publisher(k, s);
                    Store.Depot.AddPublisher(p);
                }
                else if (str == "1.11")
                {
                    Console.WriteLine("Книги:");
                    Store.AllBook();
                }
                else if (str == "1.21")
                {
                    Console.WriteLine("Жанры:");
                    Store.AllGenre();
                }
                else if (str == "1.31")
                {
                    Console.WriteLine("Авторы:");
                    Store.AllAuthor();
                }
                else if (str == "1.41")
                {
                    Console.WriteLine("Издатели:");
                    Store.AllPublisher();
                }
                else if (str == "3.1")
                {
                    Console.WriteLine("Введите ID покупаемой книги");
                    int k = int.Parse(Console.ReadLine());
                    if (Store.SellBookByID(k))
                    {
                        Console.WriteLine("Книга продана");
                    }
                    else
                    {
                        Console.WriteLine("На складе нет книги с таким ID");
                    }
                }
                else if (str == "2.2")
                {
                    Console.WriteLine("Введите ID удаляемой книги");
                    int k = int.Parse(Console.ReadLine());
                    if (Store.Depot.Books.Remove(Store.Depot.Books.GetByID(k)))
                    {
                        Console.WriteLine("Книга удалена");
                    }
                    else
                    {
                        Console.WriteLine("нет книги с  таким ID");
                    }
                }
                else if (str == "1.12")
                {
                    Console.WriteLine("Введите ID");
                    int k = int.Parse(Console.ReadLine());
                    if (Store.Depot.Books.CheckID(k))
                    {

                        Console.WriteLine("Книга:");
                        Book b = Store.Depot.Books.GetByID(k);
                        int i = 0;
                        while (b != Store.Depot.Books.data[i]) i++;
                        Store.Depot.Books.data[i].Display();

                    }
                    else
                    {
                        Console.WriteLine("нет книги с  таким ID");
                    }
                }
                else if (str == "1.22")
                {
                    Console.WriteLine("Введите ID");
                    int k = int.Parse(Console.ReadLine());
                    if (Store.Depot.Genres.CheckID(k))
                    {

                        Console.WriteLine("Жанр:");
                        Genre b = Store.Depot.Genres.GetByID(k);
                        int i = 0;
                        while (b != Store.Depot.Genres.data[i]) i++;
                        Store.Depot.Genres.data[i].Display();

                    }
                    else
                    {
                        Console.WriteLine("нет жанра с  таким ID");
                    }
                }
                else if (str == "1.32")
                {
                    Console.WriteLine("Введите ID");
                    int k = int.Parse(Console.ReadLine());
                    if (Store.Depot.Authors.CheckID(k))
                    {

                        Console.WriteLine("Автор:");
                        Author b = Store.Depot.Authors.GetByID(k);
                        int i = 0;
                        while (b != Store.Depot.Authors.data[i]) i++;
                        Store.Depot.Authors.data[i].Display();

                    }
                    else
                    {
                        Console.WriteLine("нет автора с  таким ID");
                    }
                }
                else if (str == "1.42")
                {
                    Console.WriteLine("Введите ID");
                    int k = int.Parse(Console.ReadLine());
                    if (Store.Depot.Publishers.CheckID(k))
                    {

                        Console.WriteLine("Автор:");
                        Publisher b = Store.Depot.Publishers.GetByID(k);
                        int i = 0;
                        while (b != Store.Depot.Publishers.data[i]) i++;
                        Store.Depot.Publishers.data[i].Display();

                    }
                    else
                    {
                        Console.WriteLine("нет автора с  таким ID");
                    }
                }
                else if (str == "1.13")
                {
                    Console.WriteLine("Введите ID");
                    int k = int.Parse(Console.ReadLine());
                    if (Store.Depot.Books.CheckID(k))
                    {
                        Console.WriteLine("есть книга с  таким ID");
                    }
                    else
                    {
                        Console.WriteLine("нет книги с  таким ID");
                    }
                }
                else if (str == "1.23")
                {
                    Console.WriteLine("Введите ID");
                    int k = int.Parse(Console.ReadLine());
                    if (Store.Depot.Genres.CheckID(k))
                    {
                        Console.WriteLine("есть жанр с  таким ID");
                    }
                    else
                    {
                        Console.WriteLine("нет жанра с  таким ID");
                    }
                }
                else if (str == "1.33")
                {
                    Console.WriteLine("Введите ID");
                    int k = int.Parse(Console.ReadLine());
                    if (Store.Depot.Authors.CheckID(k))
                    {
                        Console.WriteLine("есть автор с  таким ID");
                    }
                    else
                    {
                        Console.WriteLine("нет автора с  таким ID");
                    }
                }
                else if (str == "1.43")
                {
                    Console.WriteLine("Введите ID");
                    int k = int.Parse(Console.ReadLine());
                    if (Store.Depot.Publishers.CheckID(k))
                    {
                        Console.WriteLine("есть издатель с  таким ID");
                    }
                    else
                    {
                        Console.WriteLine("нет издателя с  таким ID");
                    }
                }
            

                Console.WriteLine("Ведите следующую команду");
            }

        }
    }
}
