using MVCApp_Basic.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCApp_Basic.DataLayer
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public BookModel SearchBook(string title, string author)
        {
            return DataSource().Where(x => x.Title == title && x.Author == author).FirstOrDefault();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>() {
                new BookModel{ Id=1, Title="ABC", Author="ABC"},
                new BookModel{ Id=2, Title="XYZ", Author="XYZ"},
                new BookModel{ Id=3, Title="JKL", Author="XYZ"}
            };
        }
    }
}
