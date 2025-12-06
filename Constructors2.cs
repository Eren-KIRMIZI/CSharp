using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int PageCount;

        // Parametresiz constructor
        public Book()
        {
            Title = "Bilinmeyen Kitap";
            Author = "Bilinmeyen Yazar";
            PageCount = 100;
        }

        // Parametreli constructor
        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Kitap: {Title}, Yazar: { Author}, Sayfa: { PageCount}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Parametresiz constructor ile nesne oluşturma
            Book defaultBook = new Book();
            defaultBook.ShowInfo();
            // Parametreli constructor ile nesne oluşturma
            Book novel = new Book("Sefiller", "Victor Hugo", 1456);
            novel.ShowInfo();
        }
    }
}
