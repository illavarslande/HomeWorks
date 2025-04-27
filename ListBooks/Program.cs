
namespace Library
{
    class Programm
    {
        static string filePath = "C:\\Users\\illav\\source\\repos\\HomeWorks\\ListBooks\\books.txt";
        static void Main(string[] args)
        {
            string[] listBook = File.ReadAllLines(filePath);

            List<Book> books = new List<Book>();

            foreach (string line in listBook)
            {
                string[] section = line.Split(',');

                Book book = new Book()
                {
                    Title = section[0].Trim(),
                    Author = section[1].Trim(),
                    Year = int.Parse(section[2].Trim())
                };

                books.Add(book);
            }

            Library library = new Library(books);

            while(true)
            {
                Console.WriteLine("1. Add new book.");
                Console.WriteLine("2. Print all books.");
                Console.WriteLine("3. Search by author.");
                Console.WriteLine("4. Remove book by title.");
                Console.WriteLine("5. Sorting books by year.");
                Console.WriteLine("6. Exit.");
                Console.WriteLine();

                Console.Write("Turn the key: ");
                string? key = Console.ReadLine();
                switch (key)
                {
                    case "1":
                        {
                            library.AddBook(filePath);
                            Console.WriteLine("Library is update!");
                            library.PrintLibrary(books);
                            Console.WriteLine();
                        }; break;
                    case "2": 
                        { 
                            library.PrintLibrary(books);
                            Console.WriteLine();
                        } break;
                    case "3":
                        {
                            library.SearchBook();
                        } break;
                    case "4":
                        {
                            library.RemoveBook(filePath);
                            Console.WriteLine("Library is update!");
                            library.PrintLibrary(books);
                            Console.WriteLine();
                        } break;
                    case "5":
                        {
                            library.SortedByYear();
                            Console.WriteLine();
                        }
                        break;
                    case "6":
                        {
                            return;
                        }
                    default: Console.WriteLine("Invalid key."); break;
                }
            }
        }
    }
}
