using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library
{
    public class Library
    {
        public LinkedList<Book> Books { get; set; }

        public Library(IEnumerable<Book> books)
        {
            Books = new LinkedList<Book>(books);
        }

        public void PrintLibrary(List<Book> books)
        {
            foreach (Book book in Books)
            {

                Console.WriteLine(book);
            }
        }
        public void AddBook(string filePath)
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Book newBook = new Book()
            {
                Title = title,
                Author = author,
                Year = year
            };

            Books.AddLast(newBook);

            string newBookLine = $"{newBook.Title}, {newBook.Author}, {newBook.Year}";
            File.AppendAllText(filePath, Environment.NewLine + newBookLine);
        }

        public void RemoveBook(string filePath)
        {
            Console.Write("Input title of book for remove: ");
            string title = Console.ReadLine()?.Trim();
            var node = Books.First;

            while (node != null)
            {
                if(node.Value.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    Books.Remove(node);
                }
                node = node.Next;
            }

            List<string> updatedBookList = Books.Select(book => $"{book.Title},{book.Author},{book.Year}").ToList();

            File.WriteAllLines(filePath, updatedBookList);
        }

        public void SearchBook()
        {
            Console.Write("Input author for searh books: ");
            string author = Console.ReadLine()?.Trim();
            var node = Books.First;

            while (node != null)
            {
                if (node.Value.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(node.Value);
                }
                node = node.Next;
            }
        }

        public void SortedByYear()
        {
            var node = Books.First;

            while(node != null)
            {
                var nextNode = node.Next;
                while (nextNode != null)
                {
                    if (node.Value.Year > nextNode.Value.Year)
                    {
                        Book tmp = node.Value;
                        node.Value = nextNode.Value;
                        nextNode.Value = tmp;
                    }
                    nextNode = nextNode.Next;
                }
                node = node.Next;
            }

            foreach (Book book in Books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
