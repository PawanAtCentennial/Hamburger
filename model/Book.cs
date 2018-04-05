using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburgerExample.model
{
    public class Book
    {

        public string Equities { get; set; }

        public double Amount { get; set; }

        public double Value { get; set; }

        public double Total { get; set; }
     
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { Equities = "FOO", Amount = 10, Value = 23.32, Total = 2332 } );
            books.Add(new Book { Equities = "BAR", Amount = 10, Value = 493.01, Total = 49301 });
            books.Add(new Book { Equities = "BAZ", Amount = 10, Value = 204.12, Total = 20412 });
           
            return books;

        }

    }
}
