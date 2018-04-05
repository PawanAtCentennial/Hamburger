using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hamburgerExample.model
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();
            books.Add(new Book { BookId = 1, Title = "title1" , Author = "Author1", CoverImage = "CoverImage1"});
            books.Add(new Book { BookId = 2, Title = "title2", Author = "Author2", CoverImage = "CoverImage2" });
            books.Add(new Book { BookId = 3, Title = "title3", Author = "Author3", CoverImage = "CoverImage3" });
            books.Add(new Book { BookId = 4, Title = "title4", Author = "Author4", CoverImage = "CoverImage4" });
            books.Add(new Book { BookId = 5, Title = "title5", Author = "Author5", CoverImage = "CoverImage5" });
            books.Add(new Book { BookId = 6, Title = "title6", Author = "Author6", CoverImage = "CoverImage6" });

            return books;

        }

    }
}
